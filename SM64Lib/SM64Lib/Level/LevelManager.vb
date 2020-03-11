Imports System.IO
Imports SM64Lib.Model
Imports SM64Lib.Levels.Script, SM64Lib.Levels.Script.Commands
Imports SM64Lib.Geolayout.Script
Imports SM64Lib.Geolayout.Script.Commands
Imports SM64Lib.Levels.ScrolTex
Imports SM64Lib.Data
Imports SM64Lib.ObjectBanks
Imports SM64Lib.Data.System
Imports SM64Lib.SegmentedBanking

Namespace Levels

    Public Class LevelManager
        Implements ILevelManager

        ''' <summary>
        ''' Loads a ROM Manager Level from ROM.
        ''' </summary>
        ''' <param name="lvl"></param>
        ''' <param name="rommgr"></param>
        ''' <param name="LevelID"></param>
        ''' <param name="segAddress"></param>
        Public Overridable Sub LoadRomManagerLevel(lvl As Level, rommgr As RomManager, LevelID As UShort, segAddress As UInteger) Implements ILevelManager.LoadLevel
            Dim customBGStart As Integer = 0
            Dim customBGEnd As Integer = 0

            lvl.LevelID = LevelID

            'Load Bank 0x19
            lvl.Bank0x19 = rommgr.GetSegBank(&H19)
            lvl.Bank0x19.ReadDataIfNull(rommgr.RomFile)

            'Close if not closed & re-open
            If Not lvl.Closed Then lvl.Close()
            lvl.Closed = False

            'Lade Levelscript
            lvl.Levelscript = New Levelscript
            lvl.Levelscript.Read(rommgr, segAddress)

            'Erstelle Areas / Lade Einstellungen
            Dim AreaOnFly As Boolean = False
            Dim tArea As LevelArea = Nothing
            Dim CurrentLevelScriptCommands = lvl.Levelscript.ToArray
            Dim cmdsToRemove As New List(Of LevelscriptCommand)

            For Each c As LevelscriptCommand In CurrentLevelScriptCommands
                Select Case c.CommandType
                    Case LevelscriptCommandTypes.StartArea
                        AreaOnFly = True
                        tArea = New RMLevelArea
                        tArea.AreaID = clStartArea.GetAreaID(c)
                        tArea.GeolayoutOffset = clStartArea.GetSegGeolayoutAddr(c) '- bank0x19.BankAddress + bank0x19.RomStart
                        tArea.Geolayout.Read(rommgr, tArea.GeolayoutOffset)

                    Case LevelscriptCommandTypes.EndOfArea
                        tArea.Levelscript.Add(c)
                        lvl.Levelscript.Remove(c)
                        lvl.Areas.Add(tArea)
                        AreaOnFly = False

                    Case LevelscriptCommandTypes.AreaMusic
                        tArea.BGMusic = clAreaMusic.GetMusicID(c)

                    Case LevelscriptCommandTypes.AreaMusicSimple
                        tArea.BGMusic = clAreaMusicSimple.GetMusicID(c)

                    Case LevelscriptCommandTypes.Tarrain
                        tArea.TerrainType = clTerrian.GetTerrainType(c)

                    Case LevelscriptCommandTypes.Normal3DObject
                        If {&H400000, &H401700}.Contains(clNormal3DObject.GetSegBehaviorAddr(c)) Then
                            tArea.ScrollingTextures.Add(New ManagedScrollingTexture(c))
                        Else
                            tArea.Objects.Add(c)
                        End If

                    Case LevelscriptCommandTypes.ConnectedWarp
                        If ({&HF0, &HF1}).Contains(clWarp.GetWarpID(c)) Then
                            tArea.WarpsForGame.Add(c)
                        Else
                            tArea.Warps.Add(c)
                        End If

                    Case LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.InstantWarp
                        tArea.Warps.Add(c)

                    Case LevelscriptCommandTypes.LoadRomToRam
                        Dim bankID As Byte = clLoadRomToRam.GetSegmentedID(c)
                        Dim startAddr As Integer = clLoadRomToRam.GetRomStart(c)
                        Dim endAddr As Integer = clLoadRomToRam.GetRomEnd(c)

                        Select Case bankID
                            Case &HA 'Background-Image
                                customBGStart = startAddr
                                customBGEnd = endAddr - &H140
                            Case &H7 'Global Object Bank
                                If rommgr.GlobalObjectBank IsNot Nothing AndAlso
                                    startAddr = rommgr.GlobalObjectBank.CurSeg.RomStart AndAlso
                                    endAddr = rommgr.GlobalObjectBank.CurSeg.RomEnd Then
                                    lvl.EnableGlobalObjectBank = True
                                    lvl.LastGobCmdSegLoad = c
                                End If
                        End Select

                    Case LevelscriptCommandTypes.ShowDialog
                        If AreaOnFly Then
                            tArea.ShowMessage.Enabled = True
                            tArea.ShowMessage.DialogID = clShowDialog.GetDialogID(c)
                        End If

                    Case LevelscriptCommandTypes.JumpBack, LevelscriptCommandTypes.JumpToSegAddr
                        If tArea IsNot Nothing Then cmdsToRemove.Add(c)

                End Select

                If AreaOnFly AndAlso Not cmdsToRemove.Contains(c) Then
                    lvl.Levelscript.Remove(c)
                    tArea.Levelscript.Add(c)
                End If
            Next

            'Lösche alle Jump-Commands aus dem Levelscript
            For Each cmd As LevelscriptCommand In cmdsToRemove
                lvl.Levelscript.Remove(cmd)
                cmd.Close()
            Next

            'Lösche alle Objekte und Warps aus dem Levelscript
            Dim lvlscrptidstoremove = {LevelscriptCommandTypes.Normal3DObject, LevelscriptCommandTypes.ConnectedWarp, LevelscriptCommandTypes.PaintingWarp, LevelscriptCommandTypes.InstantWarp}
            For Each a In lvl.Areas
                For Each c In a.Levelscript.Where(Function(n) lvlscrptidstoremove.Contains(n.CommandType)).ToArray
                    a.Levelscript.Remove(c)
                Next
            Next

            'Lese Custom Background Image
            Dim fs As New FileStream(rommgr.RomFile, FileMode.Open, FileAccess.Read)
            Dim br2 As New BinaryReader(fs)
            lvl.Background.Enabled = False
            For Each a As LevelArea In lvl.Areas
                Dim bgglcmd As GeolayoutCommand = a.Geolayout.Geolayoutscript.GetFirst(GeolayoutCommandTypes.Background)
                If cgBackground.GetBackgroundPointer(bgglcmd) = 0 Then
                    a.Background.Type = AreaBGs.Color
                    a.Background.Color = cgBackground.GetRrgbaColor(bgglcmd)
                Else
                    a.Background.Type = AreaBGs.Levelbackground
                    lvl.Background.ID = cgBackground.GetBackgroundID(bgglcmd)
                    lvl.Background.Enabled = True
                End If
            Next
            If customBGStart <> 0 Then
                lvl.Background.IsCustom = True
            End If
            For Each val As Integer In [Enum].GetValues(GetType(Geolayout.BackgroundPointers))
                If val <> 0 AndAlso customBGStart = val Then
                    lvl.Background.IsCustom = False
                End If
            Next
            If lvl.Background.Enabled AndAlso lvl.Background.IsCustom Then '.ID = Geolayout.BackgroundIDs.Custom Then
                fs.Position = customBGStart
                lvl.Background.ReadImage(fs, customBGStart)
            End If

            Dim bank0x19RomStart As Integer
            Dim bank0x19RomEnd As Integer
            Dim brToUse As BinaryReader
            bank0x19RomStart = 0
            bank0x19RomEnd = lvl.Bank0x19.Length
            brToUse = New BinaryReader(lvl.Bank0x19.Data)

            'Lese Area-Table
            For Each a As LevelArea In lvl.Areas
                'Fast3D-Daten
                brToUse.BaseStream.Position = bank0x19RomStart + &H5F00 + (a.AreaID * &H10)
                a.Bank0x0EOffset = SwapInts.SwapInt32(brToUse.ReadInt32)
                Dim romEnd0xE As Integer = SwapInts.SwapInt32(brToUse.ReadInt32)
                rommgr.SetSegBank(&HE, a.Bank0x0EOffset, romEnd0xE, a.AreaID)

                '2D-Kamera
                brToUse.BaseStream.Position = bank0x19RomStart + &H5F0F + (a.AreaID * &H10)
                a.Enable2DCamera = Bits.GetBoolOfByte(brToUse.ReadByte, 7)
            Next

            'Lese Area-Modelle
            For Each a As LevelArea In lvl.Areas
                a.AreaModel.FromStream(fs, a.Bank0x0EOffset, &HE000000, a.Fast3DBankRomStart, a.Fast3DLength, a.Geolayout.Geopointers.ToArray, a.CollisionPointer)
            Next

            'Lese alle Box-Daten
            Dim CurrentBoxOffset As Integer = bank0x19RomStart + &H6A00
            For Each a As LevelArea In lvl.Areas
                'Clear special boxes
                a.SpecialBoxes.Clear()

                'Load special boxes
                a.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.Water, bank0x19RomStart, bank0x19RomStart + &H6000 + (&H50 * a.AreaID)))
                a.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.ToxicHaze, bank0x19RomStart, bank0x19RomStart + &H6280 + (&H50 * a.AreaID)))
                a.SpecialBoxes.AddRange(SpecialBoxList.ReadTable(brToUse.BaseStream, SpecialBoxType.Mist, bank0x19RomStart, bank0x19RomStart + &H6500 + (&H50 * a.AreaID)))

                'Load boxdata from collision
                For i As Integer = 0 To a.SpecialBoxes.Count - 1
                    Dim boxdata As Collision.BoxData = a.AreaModel.Collision.SpecialBoxes.ElementAtOrDefault(i)
                    If boxdata IsNot Nothing Then
                        a.SpecialBoxes(i).Y = boxdata.Y
                    End If
                Next
            Next

            'One-Bank-0xE-System
            lvl.OneBank0xESystemEnabled = True

            'Act Selector
            PatchClass.Open(fs)
            lvl.ActSelector = PatchClass.ActSelector_Enabled(LevelID)

            'Hardcoded Camera
            lvl.HardcodedCameraSettings = PatchClass.HardcodedCamera_Enabled(LevelID)

            fs.Close()
        End Sub

        ''' <summary>
        ''' Saves a ROM Manager Level to ROM.
        ''' </summary>
        ''' <param name="lvl"></param>
        ''' <param name="rommgr"></param>
        ''' <param name="output"></param>
        ''' <param name="curOff"></param>
        ''' <returns></returns>
        Public Overridable Function SaveRomManagerLevel(lvl As Level, rommgr As RomManager, output As BinaryData, ByRef curOff As UInteger) As LevelSaveResult Implements ILevelManager.SaveLevel
            Dim saveres As New LevelSaveResult
            Dim data0x19 As BinaryData
            Dim lid = rommgr.LevelInfoData.GetByLevelID(lvl.LevelID)

            'Write Area Model & Update Scrolling Texture Vertex Pointers & Write Custom Object Bank
            For Each a As LevelArea In lvl.Areas
                a.Bank0x0EOffset = curOff

                Dim oldModelStart As Integer = a.AreaModel.Fast3DBuffer.Fast3DBankStart
                Dim newModelStart As Integer
                Dim modelOffset As Integer

                'Add the new water boxes
                a.AreaModel.Collision.SpecialBoxes.Clear()
                Dim TableIndex() As Integer = {0, &H32, &H33}
                For Each sp As SpecialBox In a.SpecialBoxes
                    Dim boxdata As New Collision.BoxData

                    boxdata.X1 = sp.X1
                    boxdata.X2 = sp.X2
                    boxdata.Z1 = sp.Z1
                    boxdata.Z2 = sp.Z2
                    boxdata.Y = sp.Y
                    boxdata.Index = TableIndex(sp.Type)

                    Select Case sp.Type
                        Case SpecialBoxType.Water
                            boxdata.Type = Collision.BoxDataType.Water
                        Case SpecialBoxType.Mist
                            boxdata.Type = Collision.BoxDataType.Mist
                        Case SpecialBoxType.ToxicHaze
                            boxdata.Type = Collision.BoxDataType.ToxicHaze
                    End Select

                    a.AreaModel.Collision.SpecialBoxes.Add(boxdata)
                    TableIndex(sp.Type) += 1
                Next

                'Write Area Model
                Dim res As ObjectModel.SaveResult
                res = a.AreaModel.ToBinaryData(output, curOff, curOff, &HE000000)

                'Calculate Model Offset & Update Scrolling Texture Vertex Pointers
                newModelStart = a.AreaModel.Fast3DBuffer.Fast3DBankStart
                modelOffset = newModelStart - oldModelStart
                If modelOffset <> 0 Then
                    a.UpdateScrollingTextureVertexPointer(modelOffset)
                End If

                a.CollisionPointer = res.CollisionPointer
                a.Geolayout.Geopointers.Clear() : a.Geolayout.Geopointers.AddRange(res.GeoPointers.ToArray)

                curOff += res.Length + &H20
                HexRoundUp2(curOff)

                'Write Object Bank
                a.CustomObjectsStartOffset = curOff - a.Bank0x0EOffset
                'a.CustomObjects.WriteToSeg(output, a.CustomObjectsStartOffset, &HE)

                a.Bank0xELength = curOff - a.Bank0x0EOffset
            Next

            'Write Background Image
            HexRoundUp2(output.Position)
            Dim customBGStart As Integer = curOff
            Dim customBGEnd As Integer = 0
            If lvl.Background.IsCustom Then '.ID = Geolayout.BackgroundIDs.Custom Then
                'Write Custom Background
                lvl.Background.WriteImage(output.BaseStream, customBGStart)

                'Write Pointer Table
                Dim bgPtrTable As Byte() = LevelBG.GetBackgroundPointerTable()
                output.Write(bgPtrTable, 0, bgPtrTable.Length)

                customBGEnd = customBGStart + lvl.Background.ImageLength + bgPtrTable.Length
                curOff += lvl.Background.ImageLength + bgPtrTable.Length
                HexRoundUp2(curOff)
            End If

            'Get Bank 0x19
            If lvl.Bank0x19 Is Nothing Then
                lvl.Bank0x19 = rommgr.SetSegBank(&H19, curOff, RomManagerSettings.DefaultLevelscriptSize)
                lvl.Bank0x19.Data = New MemoryStream
                lvl.Bank0x19.Length = RomManagerSettings.DefaultLevelscriptSize
            Else
                Dim oldData As MemoryStream = lvl.Bank0x19.Data
                lvl.Bank0x19 = rommgr.SetSegBank(&H19, curOff, curOff + lvl.Bank0x19.Length)
                lvl.Bank0x19.Data = oldData
            End If
            data0x19 = New BinaryStreamData(lvl.Bank0x19.Data)
            saveres.Bank0x19 = lvl.Bank0x19
            curOff += lvl.Bank0x19.Data.Length
            HexRoundUp2(curOff)

            'Update Geolayouts
            For Each a As LevelArea In lvl.Areas
                'Update Backcolor Command
                Dim cmd As GeolayoutCommand = a.Geolayout.Geolayoutscript.GetFirst(GeolayoutCommandTypes.Background)
                If a.Background.Type = AreaBGs.Levelbackground AndAlso lvl.Background.Enabled Then
                    cgBackground.SetBackgroundPointer(cmd, &H802763D4)
                    cgBackground.SetBackgroundID(cmd, lvl.Background.ID)
                Else
                    cgBackground.SetBackgroundPointer(cmd, 0)
                    cgBackground.SetRgbaColor(cmd, a.Background.Color)
                End If
            Next

            'Write Geolayouts
            Dim geoOffset As Integer = &H5F00
            For Each a As LevelArea In lvl.Areas
                geoOffset -= HexRoundUp1(a.Geolayout.Length) + &H50
                a.GeolayoutOffset = lvl.Bank0x19.BankAddress + geoOffset
                a.Geolayout.Write(lvl.Bank0x19.Data, geoOffset)
                a.Geolayout.NewGeoOffset = lvl.Bank0x19.RomStart + geoOffset
            Next

            'Füge Show-Dialog-Command & 2D-Camera-Object ein
            For Each a As LevelArea In lvl.Areas
                'Show-Dialog-Command
                If a.ShowMessage.Enabled Then
                    Dim cmdShowMsg As New LevelscriptCommand($"30 04 00 {a.ShowMessage.DialogID.ToString("X2")}")
                    Dim indexOf1E As Integer = a.Levelscript.IndexOfFirst(LevelscriptCommandTypes.EndOfArea)
                    a.Levelscript.Insert(indexOf1E, cmdShowMsg)
                End If

                '2D-Camera-Object
                Dim cmds2d As New List(Of LevelscriptCommand)
                For Each obj As LevelscriptCommand In a.Objects
                    If obj.CommandType = LevelscriptCommandTypes.Normal3DObject Then
                        If clNormal3DObject.GetSegBehaviorAddr(obj) = &H130053C4 Then 'Behav-ID: '0x130053C4
                            cmds2d.Add(obj)
                        End If
                    End If
                Next
                If a.Enable2DCamera Then
                    If cmds2d.Count = 0 Then
                        Dim cmd As New LevelscriptCommand("24 18 1F 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 13 00 53 C4")
                        a.Objects.Add(cmd)
                    End If
                ElseIf cmds2d.Count > 0 Then
                    For Each cmd As LevelscriptCommand In cmds2d
                        a.Objects.Remove(cmd)
                    Next
                End If
            Next

            Dim lvlScript0E As Levelscript = Nothing
            Dim areaobjwarpoffsetdic As Dictionary(Of Byte, UInteger) = Nothing
            Dim firstBank0xE As SegmentedBank = Nothing
            Dim curFirstBank0xEOffset As UInteger = 0

            'Add Objects and Warps to new Levelscript
            lvlScript0E = New Levelscript
            firstBank0xE = rommgr.SetSegBank(&HE, curOff, 0)
            areaobjwarpoffsetdic = New Dictionary(Of Byte, UInteger)

            For Each a As LevelArea In lvl.Areas
                areaobjwarpoffsetdic.Add(a.AreaID, firstBank0xE.BankAddress + curFirstBank0xEOffset)
                For Each c As LevelscriptCommand In a.Objects
                    lvlScript0E.Add(c)
                    curFirstBank0xEOffset += c.Length
                Next
                For Each c As ManagedScrollingTexture In a.ScrollingTextures
                    c.SaveProperties()
                    lvlScript0E.Add(c.Command)
                    curFirstBank0xEOffset += c.Command.Length
                Next
                For Each c As LevelscriptCommand In a.Warps
                    lvlScript0E.Add(c)
                    curFirstBank0xEOffset += c.Length
                Next
                For Each c As LevelscriptCommand In a.WarpsForGame
                    lvlScript0E.Add(c)
                    curFirstBank0xEOffset += c.Length
                Next
                lvlScript0E.Add(New LevelscriptCommand("07 04 00 00"))
                curFirstBank0xEOffset += 4
            Next

            firstBank0xE.Length = HexRoundUp1(curFirstBank0xEOffset)
            lvlScript0E.Write(output, firstBank0xE.RomStart)
            curOff += firstBank0xE.Length

            'Füge Area dem Levelscript hinzu
            Dim cIndex2 = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1E)
            For Each a In lvl.Areas
                For Each c In a.Levelscript
                    lvl.Levelscript.Insert(cIndex2, c)
                    cIndex2 += 1
                Next
            Next

            'Übernehme Level- und Areaeinstellungen
            Dim CurrentAreaIndex As Integer = 0
            Dim areaobjwarpindextoinsertdic As New Dictionary(Of Byte, Integer)
            Dim areaidindex As New Dictionary(Of Byte, Byte)
            Dim tArea As LevelArea = Nothing
            Dim foundCmdShowMsg As Boolean = False
            Dim cmdBgSegLoad As LevelscriptCommand = Nothing
            Dim cmdGobSegLoad As LevelscriptCommand = Nothing
            Dim cmdGobJump As LevelscriptCommand = Nothing
            Dim cmdsToInsertAt As New Dictionary(Of LevelscriptCommand, LevelscriptCommand)
            Dim cmdsToRemove As New List(Of LevelscriptCommand)

            For Each c In lvl.Levelscript
                Select Case c.CommandType
                    Case LevelscriptCommandTypes.StartArea
                        tArea = lvl.Areas(CurrentAreaIndex)
                        Dim areaid As Byte = tArea.AreaID
                        areaidindex.Add(areaid, areaidindex.Count)
                        clStartArea.SetSegGeolayoutAddr(c, lvl.Areas(CurrentAreaIndex).Geolayout.NewGeoOffset - lvl.Bank0x19.RomStart + lvl.Bank0x19.BankAddress)
                        areaobjwarpindextoinsertdic.Add(areaid, lvl.Levelscript.IndexOf(c) + 1)

                    Case LevelscriptCommandTypes.EndOfArea

                        If Not foundCmdShowMsg AndAlso tArea.ShowMessage.Enabled Then
                            Dim cmdShowMsg As New LevelscriptCommand($"30 04 00 {tArea.ShowMessage.DialogID.ToString("X2")}")
                            cmdsToInsertAt.Add(c, cmdShowMsg)
                        End If

                        foundCmdShowMsg = False
                        CurrentAreaIndex += 1
                        tArea = Nothing

                    Case LevelscriptCommandTypes.AreaMusic
                        clAreaMusic.SetMusicID(c, lvl.Areas(CurrentAreaIndex).BGMusic)

                    Case LevelscriptCommandTypes.AreaMusicSimple
                        clAreaMusicSimple.SetMusicID(c, lvl.Areas(CurrentAreaIndex).BGMusic)

                    Case LevelscriptCommandTypes.Tarrain
                        clTerrian.SetTerrainType(c, lvl.Areas(CurrentAreaIndex).TerrainType)

                    Case LevelscriptCommandTypes.LoadRomToRam
                        Select Case clLoadRomToRam.GetSegmentedID(c)
                            Case &HE 'Bank 0xE
                                clLoadRomToRam.SetRomStart(c, firstBank0xE.RomStart)
                                clLoadRomToRam.SetRomEnd(c, firstBank0xE.RomEnd)
                            Case &HA
                                cmdBgSegLoad = c
                            Case &H7
                                If lvl.LastGobCmdSegLoad Is c Then
                                    cmdGobSegLoad = c
                                End If
                        End Select

                    Case LevelscriptCommandTypes.ShowDialog
                        If tArea?.ShowMessage.Enabled AndAlso Not foundCmdShowMsg Then
                            clShowDialog.SetDialogID(c, tArea.ShowMessage.DialogID)
                            foundCmdShowMsg = True
                        Else
                            cmdsToRemove.Add(c)
                        End If

                    Case LevelscriptCommandTypes.JumpToSegAddr
                        If (clJumpToSegAddr.GetSegJumpAddr(c) >> 24) = &H7 Then
                            cmdGobJump = c
                        End If

                End Select
            Next

            'Füge Jump Commands zur ersten 0xE-Bank hinzu
            For Each e In areaobjwarpindextoinsertdic.OrderByDescending(Function(n) n.Value)
                Dim segStartAddr As UInteger = areaobjwarpoffsetdic(e.Key)
                lvl.Levelscript.Insert(e.Value, New LevelscriptCommand({&H6, 8, 0, 0, (segStartAddr >> 24) And &HFF, (segStartAddr >> 16) And &HFF, (segStartAddr >> 8) And &HFF, segStartAddr And &HFF}))
            Next

            'Lösche Commands
            For Each cmd As LevelscriptCommand In cmdsToRemove
                lvl.Levelscript.Remove(cmd)
            Next

            'Füge neue Commands ein
            For Each kvp As KeyValuePair(Of LevelscriptCommand, LevelscriptCommand) In cmdsToInsertAt
                Dim index As Integer = lvl.Levelscript.IndexOf(kvp.Key)
                lvl.Levelscript.Insert(index, kvp.Value)
            Next

            'Füge Background-Command ein
            If lvl.Background.Enabled Then
                Dim newbgcmd As LevelscriptCommand = If(cmdBgSegLoad, New LevelscriptCommand({&H17, &HC, 0, &HA, 0, 0, 0, 0, 0, 0, 0, 0}))

                If lvl.Background.IsCustom AndAlso lvl.Background.HasImage Then '.ID = Geolayout.BackgroundIDs.Custom Then
                    clLoadRomToRam.SetRomStart(newbgcmd, customBGStart)
                    clLoadRomToRam.SetRomEnd(newbgcmd, customBGEnd)
                Else
                    clLoadRomToRam.SetRomStart(newbgcmd, GetBackgroundAddressOfID(lvl.Background.ID, False))
                    clLoadRomToRam.SetRomEnd(newbgcmd, GetBackgroundAddressOfID(lvl.Background.ID, True))
                End If

                If Not lvl.Levelscript.Contains(newbgcmd) Then
                    Dim indexoffirstx1e As Integer = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D)
                    lvl.Levelscript.Insert(indexoffirstx1e, newbgcmd)
                End If
            ElseIf cmdBgSegLoad IsNot Nothing Then
                lvl.Levelscript.Remove(cmdBgSegLoad)
            End If

            'Füge Global Object Bank Command ein
            If lvl.EnableGlobalObjectBank Then
                Dim newgobjumpcmd As LevelscriptCommand = If(cmdGobJump, New LevelscriptCommand("06 08 00 00 07 00 00 00"))
                Dim newgobcmd As LevelscriptCommand = If(cmdGobSegLoad, New LevelscriptCommand("17 0C 00 07 00 00 00 00 00 00 00 00"))

                clLoadRomToRam.SetRomStart(newgobcmd, rommgr.GlobalObjectBank.CurSeg.RomStart)
                clLoadRomToRam.SetRomEnd(newgobcmd, rommgr.GlobalObjectBank.CurSeg.RomEnd)

                If Not lvl.Levelscript.Contains(newgobcmd) Then
                    Dim indexoffirstx1d As Integer = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1D)
                    lvl.Levelscript.Insert(indexoffirstx1d, newgobcmd)
                    lvl.LastGobCmdSegLoad = newgobcmd
                End If

                If Not lvl.Levelscript.Contains(newgobjumpcmd) Then
                    Dim indexoffirstx1e As Integer = lvl.Levelscript.IndexOfFirst(LevelscriptCommandTypes.x1E)
                    lvl.Levelscript.Insert(indexoffirstx1e, newgobjumpcmd)
                End If
            Else
                If cmdGobJump IsNot Nothing Then
                    lvl.Levelscript.Remove(cmdGobJump)
                End If
                If cmdGobSegLoad IsNot Nothing Then
                    lvl.Levelscript.Remove(cmdGobSegLoad)
                End If
            End If

            'Write Level Start (Start of Bank 0x19)
            lvl.Bank0x19.Data.Position = 0
            For Each b As Byte In Level.LevelscriptStart
                data0x19.Write(b)
            Next

            'Write Levelscript
            lvl.Levelscript.Write(lvl.Bank0x19.Data, data0x19.Position)

            'Parse Levelscript again!
            Dim AreaOnFly As Boolean = False
            For Each c In lvl.Levelscript.ToArray
                Select Case c.CommandType
                    Case LevelscriptCommandTypes.StartArea
                        AreaOnFly = True
                    Case LevelscriptCommandTypes.EndOfArea
                        AreaOnFly = False
                        lvl.Levelscript.Remove(c)
                End Select
                If AreaOnFly Then lvl.Levelscript.Remove(c)
            Next

            Dim bwToUse As BinaryData = If(data0x19, output)

            'Write 4 checkbytes for the One-0xE-Bank-Per-Area-Code
            lvl.Bank0x19.Data.Position = &H5FFC
            bwToUse.Write(CInt(&H4BC9189A))

            'Write Area Table
            For Each a As LevelArea In lvl.Areas
                Dim off As UInteger = &H5F00 + (a.AreaID * &H10)
                lvl.Bank0x19.Data.Position = off
                bwToUse.Write(CUInt(a.Bank0x0EOffset))
                bwToUse.Write(CUInt(a.Bank0x0EOffset + a.Bank0xELength))
                bwToUse.Write(CUInt(0))
                bwToUse.Write(CByte(&H0))
                bwToUse.Write(CByte(&H0))
                bwToUse.Write(CByte(&H0))
                bwToUse.Write(Bits.ArrayToByte({False, False, False, False, False, False, False, a.Enable2DCamera}))
            Next

            'Write SpecialBoxes
            Dim CurrentBoxOffset As Integer = &H6A00
            For Each a As LevelArea In lvl.Areas
                Dim TableIndex() As Integer = {0, &H32, &H33}
                Dim TableOffset() As Integer = {
                    &H6000 + (&H50 * a.AreaID),
                    &H6280 + (&H50 * a.AreaID),
                    &H6500 + (&H50 * a.AreaID)}

                a.SpecialBoxes.SortByHeight()

                For Each w As SpecialBox In a.SpecialBoxes
                    'Write Table Entry
                    bwToUse.Position = TableOffset(w.Type)
                    bwToUse.Write(CShort(TableIndex(w.Type)))
                    bwToUse.Write(CShort(&H0))
                    bwToUse.Write(CInt(CurrentBoxOffset + lvl.Bank0x19.BankAddress))
                    TableOffset(w.Type) = bwToUse.Position

                    'Write Box Data
                    bwToUse.Position = CurrentBoxOffset
                    For Each b As Byte In w.ToArrayBoxData()
                        bwToUse.Write(b)
                    Next

                    TableIndex(w.Type) += 1
                    CurrentBoxOffset += &H20
                Next

                For Each i As Integer In TableOffset
                    bwToUse.Position = i
                    bwToUse.Write(CUShort(&HFFFF))
                Next
            Next

            'Write Bank0x19
            lvl.Bank0x19.WriteData(output)

            'Hardcoded Camera Settings & Act Selector
            PatchClass.Open(output)
            PatchClass.HardcodedCamera_Enabled(lvl.LevelID) = lvl.HardcodedCameraSettings
            PatchClass.ActSelector_Enabled(lvl.LevelID) = lvl.ActSelector

            'Write Pointer to Levelscript
            output.Position = lid.Pointer
            output.Write(CInt(&H100019))
            output.Write(CUInt(lvl.Bank0x19.RomStart))
            output.Write(CUInt(lvl.Bank0x19.RomEnd))
            output.Write(CUInt(&H1900001C))
            output.Write(CUInt(&H7040000))

            Return saveres
        End Function

    End Class

End Namespace
