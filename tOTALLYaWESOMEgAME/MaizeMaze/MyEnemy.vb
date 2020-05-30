Public Class MyEnemy
    Inherits MySuperClass

    Private _damageInflicted As Integer

    Public Property DamageInflicted As Integer
        Set(value As Integer)
            If value > 0 Then
                value = value * -1
            End If
            _damageInflicted = value
        End Set
        Get
            Return _damageInflicted
        End Get
    End Property
End Class
