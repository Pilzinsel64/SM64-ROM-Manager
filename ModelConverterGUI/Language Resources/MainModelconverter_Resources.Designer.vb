﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:4.0.30319.42000
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class MainModelconverter_Resources
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ModelConverterGUI.MainModelconverter_Resources", GetType(MainModelconverter_Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Your collision map is not triangulated. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ColMapIsnotTriangled() As String
            Get
                Return ResourceManager.GetString("MsgBox_ColMapIsnotTriangled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Collision Map ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ColMapIsnotTriangled_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_ColMapIsnotTriangled_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Error at loading Materials:&lt;br/&gt;{0} ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ErrorLoadingMaterial() As String
            Get
                Return ResourceManager.GetString("MsgBox_ErrorLoadingMaterial", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Material Error ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_ErrorLoadingMaterial_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_ErrorLoadingMaterial_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die To use different formats then Waverfront OBJ, you need &lt;b&gt;Microsoft Visual C++ Redistributable 2017&lt;/b&gt; installed on your PC.&lt;br/&gt;&lt;br/&gt;&lt;b&gt;Download links:&lt;/b&gt;&lt;br/&gt;&lt;a href=&quot;&quot;https://aka.ms/vs/15/release/vc_redist.x64.exe&quot;&quot;&gt;vc_redist.x64.exe&lt;/a&gt; (for &lt;b&gt;64-bit&lt;/b&gt; systems)&lt;br/&gt;&lt;a href=&quot;&quot;https://aka.ms/vs/15/release/vc_redist.x86.exe&quot;&quot;&gt;vc_redist.x32.exe&lt;/a&gt; (for &lt;b&gt;32-bit&lt;/b&gt; systems) ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_MVCppMissing() As String
            Get
                Return ResourceManager.GetString("MsgBox_MVCppMissing", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Microsoft Visual C++ Redistributable 2017 is missing ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_MVCppMissing_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_MVCppMissing_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Your visual map is not triangulated. ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_VMapIsnotTriangled() As String
            Get
                Return ResourceManager.GetString("MsgBox_VMapIsnotTriangled", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Sucht eine lokalisierte Zeichenfolge, die Visual Map ähnelt.
        '''</summary>
        Friend Shared ReadOnly Property MsgBox_VMapIsnotTriangled_Title() As String
            Get
                Return ResourceManager.GetString("MsgBox_VMapIsnotTriangled_Title", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
