Public Class MyPlayer
    Inherits MySuperClass

    Private _health As Integer

    Public Property health() As Integer
        Set(value As Integer)
            If value < 0 Then
                value = 0
            End If
            _health = value
        End Set
        Get
            Return _health
        End Get
    End Property

    Public Function IncrementHealth(increment As Integer) As Integer
        _health += increment
        Return _health
    End Function
End Class
