Public Class MyHealth
    Inherits MySuperClass

    Private _healthReward As Integer

    Public Property healthReward() As Integer
        Set(value As Integer)
            If value < 1 Or value >= 100 Then
                value = 50
            End If
            _healthReward = value
        End Set
        Get
            Return _healthReward

        End Get
    End Property
End Class
