Public Class Item
    Private _inVisible As Boolean
    Property InVisible As Boolean
        Get
            Return _inVisible
        End Get
        Set(ByVal value As Boolean)
            _inVisible = value
        End Set
    End Property

    Private _inName As String
    Property InName As String
        Get
            Return _inName
        End Get
        Set(ByVal value As String)
            _inName = value
        End Set
    End Property

    Private _inImg As Image
    Property InImg As Image
        Get
            Return _inImg
        End Get
        Set(ByVal value As Image)
            If _inVisible Then
                _inImg = value
            Else
                _inImg = Nothing
            End If

        End Set
    End Property
End Class
