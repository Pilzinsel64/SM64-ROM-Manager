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



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")>  _
Partial Public NotInheritable Class FileParserSettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As FileParserSettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New FileParserSettings()),FileParserSettings)
    
    Public Shared ReadOnly Property [Default]() As FileParserSettings
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Assimp")>  _
    Public Property LoaderModule() As Global.S3DFileParser.LoaderModule
        Get
            Return CType(Me("LoaderModule"),Global.S3DFileParser.LoaderModule)
        End Get
        Set
            Me("LoaderModule") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Y")>  _
    Public Property UpAxis() As Global.S3DFileParser.UpAxis
        Get
            Return CType(Me("UpAxis"),Global.S3DFileParser.UpAxis)
        End Get
        Set
            Me("UpAxis") = value
        End Set
    End Property
End Class
