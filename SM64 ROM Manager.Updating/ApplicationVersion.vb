Public Class ApplicationVersion

    'P r o p e r t i e s

    Public Property Version As Version
    Public Property Build As Integer
    Public Property Channel As Channels

    'C o n s t r u c t o r s

    Public Sub New()
    End Sub

    Public Sub New(version As Version)
        Me.New(version, 0, Channels.Stable)
    End Sub

    Public Sub New(version As Version, build As Integer, channel As Channels)
        Me.Version = version
        Me.Build = build
        Me.Channel = channel
    End Sub

    'F e a t u r e s

    Public Overrides Function ToString() As String
        Return $"{Version.ToString} {Channel.ToString} {Build}"
    End Function

    'O p e r a t o r s

    Public Shared Operator >(a As ApplicationVersion, b As ApplicationVersion) As Boolean
        Return a.Version > b.Version OrElse (a.Version = b.Version AndAlso (a.Channel < b.Channel OrElse (a.Channel = b.Channel AndAlso a.Build > b.Build)))
    End Operator

    Public Shared Operator <(a As ApplicationVersion, b As ApplicationVersion) As Boolean
        Return a.Version < b.Version OrElse (a.Version = b.Version AndAlso (a.Channel > b.Channel OrElse (a.Channel = b.Channel AndAlso a.Build < b.Build)))
    End Operator

    Public Shared Operator =(a As ApplicationVersion, b As ApplicationVersion) As Boolean
        Return Not a <> b
    End Operator

    Public Shared Operator <>(a As ApplicationVersion, b As ApplicationVersion) As Boolean
        Return a.Version <> b.Version OrElse a.Channel <> b.Channel OrElse a.Build <> b.Build
    End Operator

    Public Shared Operator >=(a As ApplicationVersion, b As ApplicationVersion) As Boolean
        Return a = b OrElse a > b
    End Operator

    Public Shared Operator <=(a As ApplicationVersion, b As ApplicationVersion) As Boolean
        Return a = b OrElse a < b
    End Operator

End Class
