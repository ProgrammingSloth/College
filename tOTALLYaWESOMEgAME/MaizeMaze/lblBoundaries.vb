Public Class lblBoundaries
    Inherits Label
    Public Sub New()
        'set default baclcolor to BLACK
        MyBase.BackColor = Color.Transparent
        MyBase.ForeColor = Color.Transparent
    End Sub
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
            MyBase.BackColor = value
        End Set
    End Property
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = False
        End Set
    End Property
    Public Function IsCollision(obj As Control) As Boolean
        'if collides with passed in parameter return true
        If Me.Bounds.IntersectsWith(obj.Bounds) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
