Public Class MySuperClass
    Inherits PictureBox

    Public Function collisionFound(rect As Rectangle) As Boolean
        If Me.Bounds.IntersectsWith(rect) Then
            Return True

        Else
            Return False
        End If
    End Function
End Class
