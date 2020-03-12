Imports System.Collections.Specialized

Public Class PatchProfile

    ''' <summary>
    ''' The Name of the Profile.
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String = ""
    ''' <summary>
    ''' A list with scripts.
    ''' </summary>
    ''' <returns></returns>
    Public Property Scripts As New List(Of PatchScript)
    ''' <summary>
    ''' The version of this profile.
    ''' </summary>
    ''' <returns></returns>
    Public Property Version As New Version("1.0.0.0")
    ''' <summary>
    ''' The description of this profile
    ''' </summary>
    ''' <returns></returns>
    Public Property Description As String = ""
    ''' <summary>
    ''' The Xml file for this profile.
    ''' </summary>
    ''' <returns></returns>
    Public Property FileName As String = ""

End Class

''' <summary>
''' A Profile containing a script and some descriptions.
''' </summary>
Public Class PatchScript

    ''' <summary>
    ''' The Name of this Script.
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String = ""
    ''' <summary>
    ''' The Script.
    ''' </summary>
    ''' <returns></returns>
    Public Property Script As String = ""
    ''' <summary>
    ''' Defines the syntax of the script.
    ''' </summary>
    ''' <returns></returns>
    Public Property Type As ScriptType = ScriptType.TweakScript
    ''' <summary>
    ''' The description of this Script.
    ''' </summary>
    ''' <returns></returns>
    Public Property Description As String = ""
    ''' <summary>
    ''' A collection of Reference Assemblies to bind at compiling script.
    ''' </summary>
    ''' <returns></returns>
    Public Property References As New StringCollection

End Class

''' <summary>
''' Defines the script type, so the behavior on write it.
''' </summary>
Public Enum ScriptType
    ''' <summary>
    ''' A tweak syntax known from the SM64 Editor.
    ''' </summary>
    TweakScript
    ''' <summary>
    ''' A Visual Basic code.
    ''' </summary>
    VisualBasic
    ''' <summary>
    ''' A C# Code.
    ''' </summary>
    CSharp
    ''' <summary>
    ''' A DLL file containing the Code.
    ''' </summary>
    DynamicLinkLibrary
    ''' <summary>
    ''' Code that can be applied using Armips.
    ''' </summary>
    Armips
End Enum
