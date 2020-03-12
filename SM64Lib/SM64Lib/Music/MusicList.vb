Imports System.IO
Imports SM64Lib.Data

Namespace Music

    Public Class MusicList
        Inherits List(Of MusicSequence)

        'C o n s t s

        Public Const addrMusicStart As Integer = &H1210000

        'A u t o   P r o p e r t i e s

        Public Property EnableMusicHack As Boolean = False
        Public Property NeedToSaveNInsts As Boolean = False
        Public Property NeedToSaveSequenceNames As Boolean = False
        Public Property NeedToSaveSequences As Boolean = False
        Public Property NeedToSaveMusicHackSettings As Boolean = False

        'O t h e r   P r o p e r t i e s

        Public ReadOnly Property NeedToSave As Boolean
            Get
                Return NeedToSaveNInsts OrElse
                    NeedToSaveMusicHackSettings OrElse
                    NeedToSaveSequenceNames OrElse
                    NeedToSaveSequences
            End Get
        End Property

        'M e t h o d s

        Public Sub Read(rommgr As RomManager)
            Dim s As BinaryData = rommgr.GetBinaryRom(FileAccess.Read)

            s.Position = &H1210002
            Dim musicCount As Int16 = s.ReadInt16

            'Read NInsts
            Dim tNInstList() As InstrumentSetList = ReadNInsts(s, &H7F0000, musicCount)

            'Read Sequence Names
            Dim tNames() As String = ReadSequenceNames(rommgr)
            If Not tNames.Any Then
                tNames = ReadSequenceNames(s, &H7F1000, musicCount)
            End If

            'Read Sequences
            Me.Clear()
            Me.AddRange(ReadSequences(s, addrMusicStart, musicCount, tNInstList, tNames))

            'Check for Music Hack
            Dim needUpdateChecksum As Boolean = False
            s.Position = &HD213A
            Dim t001 = s.ReadUInt16
            s.Position = &HD213E
            Dim t002 = s.ReadUInt16
            EnableMusicHack = t001 = &H807C And t002 = &H0

            s.Close()
        End Sub

        Public Sub Write(rommgr As RomManager, ByRef lastPosition As Integer)
            Dim s As BinaryData = rommgr.GetBinaryRom(FileAccess.ReadWrite)

            'Enable/Disable Music Hack
            If NeedToSaveMusicHackSettings Then
                s.Position = &HD213A
                s.Write(CUShort(If(EnableMusicHack, &H807C, &H801D)))
                s.Position = &HD213E
                s.Write(CUShort(If(EnableMusicHack, &H0, &HE000)))
                s.Position = &HD215A
                s.Write(CUShort(If(EnableMusicHack, &H807C, &H801D)))
                s.Position = &HD215E
                s.Write(CUShort(If(EnableMusicHack, &H0, &HE000)))
                s.Position = &HD459A
                s.Write(CUShort(If(EnableMusicHack, &H807C, &H801D)))
                s.Position = &HD459E
                s.Write(CUShort(If(EnableMusicHack, &H0, &HE000)))
                s.Position = &HEE2B0
                s.Write(CUInt(If(EnableMusicHack, &HBD00, &H6D00)))
                s.Position = &HD48B4
                s.Write(CUInt(If(EnableMusicHack, &H3C02803D, &H3C02807C))) '&H3C02807C
                s.Position = &HD48B8
                s.Write(CUInt(If(EnableMusicHack, &H34420000, &H34420000)))
            End If

            Dim arrMe() As MusicSequence = Me.ToArray

            'Write Music Names
            If NeedToSaveSequenceNames Then
                WriteSequenceNames(rommgr, arrMe)
            End If

            'Write NInsts
            If NeedToSaveNInsts Then
                WriteNInst(s, &H7F0000, arrMe)
            End If

            'Write Music Sequences
            lastPosition = WriteSequences(s, addrMusicStart, arrMe, NeedToSaveSequences)

            'Reset NeedToSave Properties
            NeedToSaveSequences = False
            NeedToSaveNInsts = False
            NeedToSaveSequenceNames = False
            NeedToSaveMusicHackSettings = False

            s.Close()
        End Sub

        'S h a r e d   M e t h o d s

        Private Shared Function ReadNInsts(s As BinaryData, TableStart As Integer, Count As Int16) As InstrumentSetList()
            Dim tNInstList As New List(Of InstrumentSetList)
            s.Position = TableStart
            For i As Integer = 0 To Count - 1
                Dim startoff As UShort = s.ReadUInt16()

                Dim n As New InstrumentSetList
                tNInstList.Add(n)

                Dim offBefore As Integer = s.Position
                n.ReadNInst(s, TableStart + startoff)
                s.Position = offBefore
            Next

            Return tNInstList.ToArray
        End Function

        Private Shared Function ReadSequenceNames(s As BinaryData, RomAddress As Integer, Count As Integer) As String()
            s.Position = RomAddress
            Dim tNames As New List(Of String)

            For i As Integer = 0 To Count - 1
                If s.ReadByte = &HFF Then
                    s.Position -= 1
                Else
                    s.Position -= 1
                    tNames.Add(s.ReadString)
                End If
            Next

            Return tNames.ToArray
        End Function

        Private Shared Function ReadSequenceNames(rommgr As RomManager) As String()
            Return rommgr.RomConfig.MusicConfig.SqeuenceNames.ToArray
        End Function

        Private Shared Function ReadSequences(s As BinaryData, TableStart As Integer, Count As Integer, tNInstList As InstrumentSetList(), tNames As String()) As MusicSequence()
            s.Position = TableStart + 4
            Dim tSequences As New List(Of MusicSequence)
            For i As Integer = 0 To Count - 1
                Dim startoff As UInteger = s.ReadUInt32
                Dim len As UInteger = s.ReadUInt32

                Dim ms As New MusicSequence
                tSequences.Add(ms)

                If tNames.Length > i Then ms.Name = tNames(i)
                If tNInstList.Length > i Then ms.InstrumentSets = tNInstList(i)

                Dim offBefore As Integer = s.Position
                ms.ReadData(s, TableStart + startoff, len)
                s.Position = offBefore
            Next

            Return tSequences.ToArray
        End Function

        Public Shared Sub Prepaire(rommgr As RomManager)
            Dim s As BinaryData = rommgr.GetBinaryRom(FileAccess.ReadWrite)

            s.Position = &H7B0863
            Dim musicCount As Byte = s.ReadByte

            'Set original Names
            Dim tNames As String() = {
            "No Music",
            "High Score",
            "Title Screen",
            "Bob-Omb Battlefield",
            "Inside Castle",
            "Dire, Dire Docks",
            "Lethal Lava Land",
            "Bowser Battle",
            "Snow",
            "Slide",
            "Haunted House",
            "Piranha Plant Lullaby",
            "Hazy Maze Cave",
            "Star Select",
            "Wing Cap",
            "Metal Cap",
            "Bowser Message",
            "Bowser Course",
            "Star Catch",
            "Merry-Go-Round",
            "Start and End Race with Koopa the Quick",
            "Star Appears",
            "Boss Fight",
            "Take a Key",
            "Endless Stairs",
            "Final Boss",
            "Staff Credits",
            "Puzzle Solved",
            "Toad Message",
            "Peach Message",
            "Introduction Scene",
            "Last Star Fanfare",
            "Ending Scene",
            "File Select",
            "Lakitu Appears"}

            'Read original sequences
            Dim tSequences As MusicSequence() = ReadSequences(s, &H7B0860, musicCount, {}, tNames)

            s.Position = &HDC0B8
            s.Write(0)

            'Write sequences to the new Position
            WriteSequences(s, addrMusicStart, tSequences, True)

            'Write new sequence names
            WriteSequenceNames(rommgr, tSequences)

            'Write NInsts
            WriteNInst(s, &H7F0000, tSequences)

            'Edit ASM-Code to load from the new location
            s.Position = &H7B085F
            s.Write(17)
            s.Position = &HD4714
            s.Write(&H3C040121)
            s.Position = &HD471C
            s.Write(&H24840000)
            s.Position = &HD4768
            s.Write(&H3C040121)
            s.Position = &HD4770
            s.Write(&H24840000)
            s.Position = &HD4784
            s.Write(&H3C050121)
            s.Position = &HD4788
            s.Write(&H24A50000)
            s.Position = &HD48B4
            s.Write(&H3C02807C)
            s.Position = &HD48B8
            s.Write(&H34420000)

            'Edit ASM-Code to load from new location
            s.Position = &HD48C6
            s.Write(CShort(&H7F))
            s.Position = &HD48CC
            s.Write(&H34840000)
            s.Position = &HD48DA
            s.Write(CShort(&H200))

            'Check for Music Hack
            s.Position = &HD213A
            Dim t001 = s.ReadUInt16
            s.Position = &HD213E
            Dim t002 = s.ReadUInt16

            If t001 = &H805D And t002 = &HC000 Then
                s.Position = &HD213A
                s.Write(CUShort(&H807C))
                s.Position = &HD213E
                s.Write(CUShort(&H0))
                s.Position = &HD215A
                s.Write(CUShort(&H807C))
                s.Position = &HD215E
                s.Write(CUShort(&H0))
                s.Position = &HD459A
                s.Write(CUShort(&H807C))
                s.Position = &HD459E
                s.Write(CUShort(&H0))
                s.Position = &HEE2B0
                s.Write(CUInt(&HBD00))
            End If

            s.Close()
        End Sub

        Private Shared Sub WriteSequenceNames(rommgr As RomManager, sequences As MusicSequence())
            rommgr.RomConfig.MusicConfig.SqeuenceNames.Clear()
            rommgr.RomConfig.MusicConfig.SqeuenceNames.AddRange(sequences.Select(Function(n) n.Name))
        End Sub

        Private Shared Sub WriteNInst(s As BinaryData, TableStart As Integer, sequences As MusicSequence())
            s.Position = TableStart
            Dim lastNInstDataOffset As Integer = TableStart + sequences.Length * 2

            For Each ms As MusicSequence In sequences
                s.Write(CUShort(lastNInstDataOffset - TableStart))

                Dim lastOff As Integer = s.Position
                ms.InstrumentSets.WriteNInst(s, lastNInstDataOffset)
                lastNInstDataOffset += ms.InstrumentSets.NInstLength
                s.Position = lastOff
            Next
        End Sub

        Private Shared Function WriteSequences(s As BinaryData, TableStart As Integer, sequences As MusicSequence(), WriteData As Boolean) As Integer
            s.Position = TableStart
            s.Write(CShort(3))
            s.Write(CShort(sequences.Length))

            'Write sequences to the new Position
            Dim curMsDataOff As Integer = HexRoundUp1(TableStart + 4 + sequences.Length * &H8)
            For Each ms As MusicSequence In sequences
                If WriteData Then
                    s.Write(CUInt(curMsDataOff - TableStart))
                    s.Write(CUInt(ms.Lenght))

                    Dim lastOff As Integer = s.Position
                    ms.WriteData(s, curMsDataOff)
                    s.Position = lastOff
                End If

                curMsDataOff += HexRoundUp1(ms.Lenght)
            Next

            Return curMsDataOff
        End Function

    End Class

End Namespace
