Imports System.IO
Imports System.Runtime.InteropServices
Imports SM64Lib.Configuration
Imports SM64Lib.Data
Imports SM64Lib.Geolayout
Imports SM64Lib.Levels.Script
Imports SM64Lib.Levels.Script.Commands
Imports SM64Lib.SegmentedBanking

Namespace Global.SM64Lib.ObjectBanks

    Public Class CustomObjectBank

        Public ReadOnly Property Config As New ObjectBankConfig
        Public ReadOnly Property Objects As New List(Of CustomObject)
        Public ReadOnly Property CurSeg As SegmentedBank = Nothing
        Public Property NeedToSave As Boolean = False
        Public ReadOnly Property Levelscript As New Levelscript

        Public Function WriteToSeg(bankID As Byte) As SegmentedBank
            Dim segStream As New MemoryStream
            Dim seg As New SegmentedBank(bankID, segStream)
            Dim lastPos As Integer = WriteToSeg(seg, 0)
            seg.Length = lastPos
            Return seg
        End Function

        Public Function WriteToSeg(seg As SegmentedBank, offset As Integer) As Integer
            Dim data As New BinaryStreamData(seg.Data)
            Dim lastPos As Integer = WriteToSeg(data, offset, seg.BankID)
            _CurSeg = seg
            Return lastPos
        End Function

        Public Function WriteToSeg(data As BinaryData, offset As Integer, bankID As Byte) As Integer
            Dim lvlScriptLength As UInteger
            Dim bankAddr As Integer = CUInt(bankID) << 24

            'Clear the old levelscript
            Levelscript.Clear()

            'Clear Configuration
            Config.CustomObjectConfigs.Clear()

            'Calculate space of Levelscript
            lvlScriptLength = HexRoundUp1(Objects.Count * 8 + 4)

            'Start Custom Objects
            data.Position = offset + lvlScriptLength

            For i As Integer = 0 To Objects.Count - 1
                Dim obj As CustomObject = Objects(i)

                'Write Object Model
                obj.ModelBankOffset = data.Position
                Dim sr As Model.ObjectModel.SaveResult =
                    obj.Model.ToBinaryData(data, data.Position, 0, bankAddr)
                HexRoundUp2(data.Position)

                'Write Model Offset & Length & Collision Offset
                data.Write(obj.ModelBankOffset)
                data.Write(CInt(obj.Model.Fast3DBuffer.Length))
                data.Write(If(sr.CollisionPointer = -1, -1, sr.CollisionPointer And &HFFFFFF))
                obj.CollisionPointer = sr.CollisionPointer
                HexRoundUp2(data.Position)

                'Copy new Geopointer(s)
                obj.Geolayout.Geopointers.Clear()
                obj.Geolayout.Geopointers.AddRange(sr.GeoPointers.ToArray)

                'Write Geolayout
                obj.GeolayoutBankOffset = data.Position
                obj.Geolayout.Write(data.BaseStream, data.Position)
                data.Position = HexRoundUp1(data.Position + &H30)

                'Add object config to object bank config
                Config.CustomObjectConfigs.Add(i, obj.Config)
            Next

            'Set length of segmented
            HexRoundUp2(data.Position)
            Dim lastPosition As Integer = data.Position

            'Create Levelscript
            For Each obj As CustomObject In Objects
                Levelscript.Add(New LevelscriptCommand($"22 08 00 {obj.ModelID.ToString("X")} {bankID.ToString("X")} {Hex((obj.GeolayoutBankOffset >> 16) And &HFF)} {Hex((obj.GeolayoutBankOffset >> 8) And &HFF)} {Hex(obj.GeolayoutBankOffset And &HFF)}"))
            Next
            Levelscript.Add(New LevelscriptCommand("07 04 00 00"))
            Levelscript.Write(data, offset)

            _NeedToSave = False

            Return lastPosition
        End Function

        Public Sub WriteCollisionPointers(rommgr As RomManager)
            Dim data As BinaryData = rommgr.GetBinaryRom(FileAccess.ReadWrite)

            'Write collision pointer
            For Each obj As CustomObject In Objects
                For Each dest As Integer In obj.Config.CollisionPointerDestinations
                    data.Position = dest
                    data.Write(obj.CollisionPointer)
                Next
            Next

            data.Close()
        End Sub

        Public Sub ReadFromSeg(rommgr As RomManager, bankID As Byte, config As ObjectBankConfig)
            ReadFromSeg(rommgr, rommgr.GetSegBank(bankID), config)
        End Sub

        Public Sub ReadFromSeg(rommgr As RomManager, seg As SegmentedBank, config As ObjectBankConfig)
            Dim s As Stream
            Dim data As BinaryData

            Levelscript.Clear()
            _CurSeg = seg
            s = seg.ReadDataIfNull(rommgr)
            data = New BinaryStreamData(s)

            'Get configuration
            _Config = config

            'Read Levelscript
            Levelscript.Read(rommgr, seg.BankAddress, LevelscriptCommandTypes.JumpBack, New Dictionary(Of Byte, SegmentedBank) From {{seg.BankID, seg}})

            'Parse Levelscript & Load Models
            For i As Integer = 0 To Levelscript.Count - 1
                Dim cmd As LevelscriptCommand = Levelscript(i)

                Select Case cmd.CommandType
                    Case LevelscriptCommandTypes.LoadPolygonWithGeo
                        Dim obj As New CustomObject With {
                            .Config = config.GetCustomObjectConfig(i)
                        }

                        'Load Model ID & Geolayout Offset
                        obj.ModelID = clLoadPolygonWithGeo.GetModelID(cmd)
                        Dim geoAddr As Integer = clLoadPolygonWithGeo.GetSegAddress(cmd)
                        obj.GeolayoutBankOffset = geoAddr And &HFFFFFF

                        If (geoAddr >> 24) = seg.BankID Then
                            'Load Model Offset & Length
                            data.Position = obj.GeolayoutBankOffset - &H10
                            obj.ModelBankOffset = data.ReadInt32
                            Dim f3d_length As Integer = data.ReadInt32
                            Dim colOffset As Integer = data.ReadInt32
                            Dim colPointer As Integer = colOffset Or seg.BankAddress
                            obj.CollisionPointer = colPointer

                            'Load Geolayout
                            obj.Geolayout = New Geolayout.Geolayout(Geolayout.Geolayout.NewScriptCreationMode.None)
                            obj.Geolayout.Read(rommgr, geoAddr)

                            'Load Model
                            obj.Model = New Model.ObjectModel
                            obj.Model.FromBinaryData(data, 0, seg.BankAddress, obj.ModelBankOffset, f3d_length, obj.Geolayout.Geopointers.ToArray, colPointer)

                            'Add Object to list
                            Objects.Add(obj)
                        End If

                End Select
            Next
        End Sub

    End Class

End Namespace
