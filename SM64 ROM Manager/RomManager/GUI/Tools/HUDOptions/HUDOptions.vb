Imports System.IO
Imports Newtonsoft.Json.Linq
Imports SM64Lib
Imports SM64Lib.Data

Public Class HUDOptions

    Private binaryData As BinaryData

    Public ReadOnly Property Block As HUDOptionsBlock = Nothing
    Public ReadOnly Property RomManager As RomManager

    Public Sub New(rommgr As RomManager)
        RomManager = rommgr
    End Sub

    Public Sub LoadBlock(p As String)
        _Block = JObject.Parse(File.ReadAllText(p)).ToObject(Of HUDOptionsBlock)
    End Sub

    Public Function GetPosition(b As HUDOptionsBlock) As Point
        GetPosition = Point.Empty

        If b?.Cords IsNot Nothing AndAlso binaryData?.CanRead Then
            binaryData.Position = b.Cords.RomPosX
            GetPosition.X = binaryData.ReadInt16

            binaryData.Position = b.Cords.RomPosY
            GetPosition.Y = binaryData.ReadInt16
        End If
    End Function

    Public Sub SetPosition(b As HUDOptionsBlock, p As Point)
        If b?.Cords IsNot Nothing AndAlso binaryData?.CanWrite Then
            If b.Cords.RomPosX IsNot Nothing Then
                binaryData.Position = b.Cords.RomPosX
                binaryData.Write(CShort(p.X))
            End If

            If b.Cords.RomPosY IsNot Nothing Then
                binaryData.Position = b.Cords.RomPosY
                binaryData.Write(CShort(p.Y))
            End If
        End If
    End Sub

    Public Sub OpenRomRead()
        If binaryData Is Nothing OrElse Not binaryData.CanRead Then
            CloseRom()
            binaryData = RomManager.GetBinaryRom(FileAccess.Read)
        End If
    End Sub

    Public Sub OpenRomWrite()
        If binaryData Is Nothing OrElse Not binaryData.CanWrite Then
            CloseRom()
            binaryData = RomManager.GetBinaryRom(FileAccess.ReadWrite)
        End If
    End Sub

    Public Sub CloseRom()
        If binaryData IsNot Nothing Then
            binaryData.Close()
            binaryData = Nothing
        End If
    End Sub

End Class
