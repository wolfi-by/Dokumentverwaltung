Public Class MainControl
    Inherits TextBox

    Private _ok As Boolean
    Public Property OK() As Boolean
        Get
            Return _ok
        End Get
        Set(ByVal value As Boolean)
            _ok = value
        End Set
    End Property

End Class
