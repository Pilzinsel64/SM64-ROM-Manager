Imports System.CodeDom.Compiler
Imports System.IO
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Xml
Imports Microsoft.CSharp
Imports Pilz.S3DFileParser
Imports SM64Lib

Public Class PatchingManager

    Public Sub Save(patch As PatchProfile, dir As String)
        Dim xml As XElement =
                <m64tweak name=<%= patch.Name %> description=<%= patch.Description %> version=<%= patch.Version.ToString %>></m64tweak>

        For Each script As PatchScript In patch.Scripts
            xml.Add(ScriptToXElement(script))
        Next

        If patch.FileName = "" Then
            patch.FileName = Path.Combine(dir, patch.Name & ".xml")
        End If

        xml.Save(patch.FileName)
    End Sub

    Public Function ScriptToXElement(script As PatchScript) As XElement
        Dim references As String = ""

        For Each ref As String In script.References
            If references <> "" Then
                references &= ";"
            End If
            references &= ref
        Next

        Return <patch name=<%= script.Name %> description=<%= script.Description %> type=<%= CInt(script.Type) %> references=<%= references %>>
                   <%= script.Script %>
               </patch>
    End Function

    Public Function Read(fileName As String) As PatchProfile
        Dim patch As New PatchProfile
        Dim xml As XDocument = XDocument.Load(fileName)

        patch.FileName = fileName

        Dim mainNode As XElement = xml.Elements.FirstOrDefault(Function(n) n.Name = "m64tweak")

        For Each attr As XAttribute In mainNode.Attributes
            Select Case attr.Name
                Case "name"
                    patch.Name = attr.Value
                Case "description"
                    patch.Description = attr.Value
                Case "version"
                    patch.Version = New Version(attr.Value)
            End Select
        Next

        For Each element As XElement In mainNode.Elements
            Select Case element.Name
                Case "name"
                    patch.Name = element.Value
                Case "description"
                    patch.Description = element.Value
                Case "patch"
                    patch.Scripts.Add(XElementToScript(element))
            End Select
        Next

        If String.IsNullOrEmpty(patch.Name) Then
            patch.Name = Path.GetFileNameWithoutExtension(fileName)
        End If

        Return patch
    End Function

    Public Function XElementToScript(element As XElement) As PatchScript
        Dim script As New PatchScript
        script.Script = element.Value

        For Each attr As XAttribute In element.Attributes
            Select Case attr.Name
                Case "name"
                    script.Name = attr.Value
                Case "description"
                    script.Description = attr.Value
                Case "type"
                    script.Type = attr.Value
                Case "references"
                    If Not String.IsNullOrEmpty(attr.Value) Then
                        script.References.AddRange(attr.Value.Split(";"))
                    End If
            End Select
        Next

        Return script
    End Function

    Public Sub Patch(script As PatchScript, owner As IWin32Window, params As IReadOnlyDictionary(Of String, Object))
        Patch(script, Nothing, owner, params)
    End Sub

    Public Sub Patch(script As PatchScript, rommgr As RomManager, owner As IWin32Window, params As IReadOnlyDictionary(Of String, Object))
        If script Is Nothing Then
            Throw New ArgumentNullException(NameOf(script))
        End If

        Dim romfile As String = ""
        If params Is Nothing OrElse Not params.TryGetValue("romfile", romfile) Then
            romfile = rommgr.RomFile
        End If

        Select Case script.Type
            Case ScriptType.TweakScript
                Dim stream As New FileStream(romfile, FileMode.Open, FileAccess.ReadWrite)
                Dim bw As New BinaryWriter(stream)
                Dim br As New BinaryReader(stream)

                Dim reader As New StringReader(script.Script)

                Do While reader.Peek > -1
                    Dim line As String = reader.ReadLine.Trim.ToLower

                    Dim commentStart As Integer = line.IndexOf("//")
                    If commentStart > -1 Then
                        line = line.Substring(0, commentStart)
                    End If

                    If line.Trim = "" Then
                        Continue Do
                    End If

                    Dim nextDP As Integer = line.IndexOf(":")
                    Dim body As String = line.Substring(nextDP + 1).Trim

                    If nextDP > -1 Then
                        Dim addr As String
                        addr = line.Substring(0, nextDP)
                        stream.Position = Convert.ToInt32(addr, 16)
                    End If

                    Dim nextKlammer As Integer = body.IndexOf("["c)
                    Do While nextKlammer > -1
                        Dim endKl As Integer = body.IndexOf("]"c, nextKlammer + 1)
                        Dim str As String = body.Substring(nextKlammer, endKl - nextKlammer + 1)
                        Dim newVal As String = ""

                        Select Case True
                            Case str.StartsWith("[")

                                Dim parts As String() = str.Substring(1, str.Length - 2).Split(",") 'body.Substring(1, body.Length - 1).Split(",")
                                If parts.Count > 0 Then
                                    Select Case parts(0).Trim
                                        Case "copy"
                                            If parts.Count > 1 Then
                                                Dim startAddr As Integer = Convert.ToInt32(parts(1).Trim, 16)
                                                Dim endAddr As Integer = If(parts.Length > 2, Convert.ToInt32(parts(2).Trim, 16), startAddr + 1)
                                                Dim length As Integer = endAddr - startAddr
                                                Dim lastPos As Integer = stream.Position

                                                body = ""
                                                stream.Position = startAddr
                                                For i As Integer = 1 To length
                                                    body &= " " & br.ReadByte.ToString("X2")
                                                Next

                                                stream.Position = lastPos
                                            End If

                                        Case "fill"
                                            If parts.Count > 2 Then
                                                Dim value As Byte = Convert.ToByte(parts(1).Trim, 16)
                                                Dim valueString As String = value.ToString("X2")
                                                Dim length As Integer = Convert.ToInt32(parts(2).Trim, 16)

                                                body = ""
                                                For i As Integer = 1 To length
                                                    body &= " " & valueString
                                                Next
                                            End If

                                        Case Else
                                            Dim infoText As String = ""
                                            Dim inputType As InputDialog.InputValueType = InputDialog.InputValueType.Byte

                                            Select Case parts(0).Trim
                                                Case "8"
                                                    infoText = "Input a 8 Bit value (Byte)"
                                                    inputType = InputDialog.InputValueType.Byte
                                                Case "16"
                                                    infoText = "Input a 16 Bit value (2 Bytes)"
                                                    inputType = InputDialog.InputValueType.UInt16
                                                Case "32"
                                                    infoText = "Input a 32 Bit value (4 Bytes)"
                                                    inputType = InputDialog.InputValueType.UInt32
                                                Case "half"
                                                    infoText = "Input a float value"
                                                    inputType = InputDialog.InputValueType.Single
                                                Case "string"
                                                    infoText = "Input a string"
                                                    inputType = InputDialog.InputValueType.String
                                                Case "sequence"
                                                    infoText = "Input a Sequence ID"
                                                    inputType = InputDialog.InputValueType.Sequence
                                                Case "level"
                                                    infoText = "Input a Level ID"
                                                    inputType = InputDialog.InputValueType.LevelID
                                            End Select

                                            Dim input As New InputDialog(inputType, rommgr)
                                            input.Text = parts.ElementAtOrDefault(1)?.Trim?.Trim(""""c, "["c, "]"c)
                                            If input.ShowDialog(owner) = DialogResult.OK Then
                                                If inputType = InputDialog.InputValueType.String Then
                                                    Dim barr As Byte() = System.Text.Encoding.ASCII.GetBytes(input.ReturnValue)
                                                    For Each b As Byte In barr
                                                        newVal &= b.ToString("X2")
                                                    Next
                                                Else
                                                    Dim barr As String = ""

                                                    Select Case inputType
                                                        Case InputDialog.InputValueType.Byte, InputDialog.InputValueType.Sequence
                                                            barr = CByte(input.ReturnValue).ToString("X2")
                                                        Case InputDialog.InputValueType.UInt16, InputDialog.InputValueType.LevelID
                                                            barr = CUShort(input.ReturnValue).ToString("X4")
                                                        Case InputDialog.InputValueType.Single
                                                            barr = CSng(input.ReturnValue).ToString("X4")
                                                        Case InputDialog.InputValueType.UInt32
                                                            barr = CUInt(input.ReturnValue).ToString("X8")
                                                    End Select

                                                    For i As Integer = 0 To barr.Length - 1 Step 2
                                                        newVal &= " " & barr.Substring(i, 2)
                                                    Next

                                                End If
                                            End If

                                            body = body.Replace(str, newVal)

                                    End Select
                                End If

                            Case Else
                                Continue Do

                        End Select

                        nextKlammer = body.IndexOf("["c, nextKlammer + 1)
                    Loop

                    If body <> "" Then
                        For Each str As String In body.Split(" ")
                            If Not String.IsNullOrWhiteSpace(str) Then

                                Dim value As Byte = Convert.ToByte(str, 16)
                                bw.Write(value)

                            End If
                        Next
                    End If

                Loop

                reader.Close()
                stream.Close()

            Case ScriptType.VisualBasic, ScriptType.CSharp
                Dim assembly As Assembly = GetAssembly(script)
                If assembly IsNot Nothing Then
                    ExecuteScript(assembly, params)
                End If

            Case ScriptType.Armips
                Dim createText As String =
$".Open ""{romfile}"", 0
{script.Script}
.Close"

                Dim tmpAsmFile As String = Path.GetTempFileName
                File.WriteAllText(tmpAsmFile, createText)

                Dim p As New Process
                p.StartInfo.FileName = Path.Combine(Publics.MyToolsPath, "armips.exe")
                p.StartInfo.Arguments = $"""{tmpAsmFile}"" -root ""{Path.GetDirectoryName(params("profilepath"))}"""
                p.StartInfo.UseShellExecute = False
                p.Start()

                Do Until p.HasExited
                Loop

                File.Delete(tmpAsmFile)

        End Select

        PatchClass.UpdateChecksum(romfile)
    End Sub

    Public Function CompileScript(script As PatchScript) As CompilerResults
        Dim cp As CodeDomProvider

        Select Case script.Type
            Case ScriptType.VisualBasic
                cp = New VBCodeProvider
            Case ScriptType.CSharp
                cp = New CSharpCodeProvider
            Case Else
                Return Nothing
        End Select

        Dim options As New CompilerParameters
        options.GenerateExecutable = False
        options.GenerateInMemory = True

        Select Case script.Type
            Case ScriptType.VisualBasic
                options.ReferencedAssemblies.Add("Microsoft.CSharp.dll")
            Case ScriptType.CSharp
                options.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        End Select

        options.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        options.ReferencedAssemblies.Add("System.dll")
        options.ReferencedAssemblies.Add("System.Core.dll")
        options.ReferencedAssemblies.Add("System.Data.dll")
        options.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll")
        options.ReferencedAssemblies.Add("System.Deployment.dll")
        options.ReferencedAssemblies.Add("System.Net.Http.dll")
        options.ReferencedAssemblies.Add("System.Xml.dll")
        options.ReferencedAssemblies.Add("System.Xml.Linq.dll")
        options.ReferencedAssemblies.Add("System.IO.dll")
        options.ReferencedAssemblies.Add("System.Drawing.dll")

        options.ReferencedAssemblies.Add(GetType(Object3D).Assembly.Location)
        options.ReferencedAssemblies.Add(GetType(DevComponents.DotNetBar.OfficeForm).Assembly.Location)
        options.ReferencedAssemblies.Add(GetType(RomManager).Assembly.Location)

        'Alternative???
        'For Each asm As Assembly In AppDomain.CurrentDomain.GetAssemblies
        '    options.ReferencedAssemblies.Add(asm.Location)
        'Next

        For Each ref As String In script.References
            If Not options.ReferencedAssemblies.Contains(ref) Then
                options.ReferencedAssemblies.Add(ref)
            End If
        Next

        Return cp.CompileAssemblyFromSource(options, script.Script)
    End Function

    Public Function GetAssembly(script As PatchScript) As Assembly
        Dim res As CompilerResults = CompileScript(script)
        If res.Errors.Count = 0 Then
            Return res.CompiledAssembly
        Else
            Throw New SyntaxErrorException("Error hat compiling Script. Either there are syntax errors or there are missing some references.")
        End If
    End Function

    Public Sub ExecuteScript(assembly As Assembly, params As IReadOnlyDictionary(Of String, Object))
        Dim main As MethodInfo = assembly.GetType("Script")?.GetMethod("Main", BindingFlags.Static Or BindingFlags.Public Or BindingFlags.NonPublic)
        Dim fs As FileStream = Nothing
        Dim param As Object() = {Nothing}
        Dim paraminfo As ParameterInfo() = main.GetParameters
        Dim romfile As String = ""

        params.TryGetValue("romfile", romfile)

        If paraminfo.Length = 1 AndAlso paraminfo(0).ParameterType = GetType(Stream) AndAlso Not String.IsNullOrEmpty(romfile) Then
            fs = New FileStream(romfile, FileMode.Open, FileAccess.ReadWrite)
            param = {fs}
        ElseIf paraminfo.Length = 1 AndAlso paraminfo(0).ParameterType = GetType(String) Then
            param = {romfile}
        ElseIf paraminfo.Length = 1 AndAlso paraminfo(0).ParameterType = GetType(IReadOnlyDictionary(Of String, Object)) Then
            param = {params}
        End If

        If main IsNot Nothing Then
            main.Invoke(Nothing, param)
        End If

        If fs IsNot Nothing Then
            fs.Close()
        End If
    End Sub

End Class
