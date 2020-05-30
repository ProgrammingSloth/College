Public Class ucInventory
    Public Items(5) As Item
    Public Pic(5) As PictureBox
    Private Count As Byte = 0

    Public Sub EmptyInventory()
        Dim i As Byte = 0
        For Each c As PictureBox In Me.Controls
            c.Image = Nothing
            Pic(i) = New PictureBox
            Pic(i) = c
            Items(i) = New Item
            Items(i).InVisible = False
            i += 1
        Next
        Count = 0
        displayInventory()
    End Sub

    Public Sub addToInventory(ByVal Img As Image, ByVal Tag As String)
        If Count < 5 Then
            SetItem(Count, Img, Tag)

            displayInventory()
            Count = Count + 1
        Else
            Dim ex As New Exception("Inventory Full")
            Throw ex
        End If
    End Sub

    Public Sub removeInventory(ByVal Tag As String)
        Dim found As Boolean = False
        If Count > 0 And found = False Then
            For i As Integer = Count To 0 Step -1
                If Items(i).InName = Tag Then
                    Pic(i).Image = Nothing
                    Items(i).InImg = Nothing
                    Items(i).InName = ""
                    Items(i).InVisible = False
                    found = True
                End If
            Next i
            Count = Count - 1
            displayInventory()
        ElseIf Count = 0 Then
            MessageBox.Show("Inventory Empty")

        ElseIf found = False Then
            MessageBox.Show("Item not found in inventory")
        End If
    End Sub

#Region "ucInventory private subs"
    Private Sub displayInventory()
        Dim i As Byte = 0

        For i = 0 To 4
            If i <= Count Then
                Items(i).InVisible = True
            Else
                Items(i).InVisible = False
                Pic(i).Image = Nothing
            End If
            Pic(i).Visible = Items(i).InVisible
        Next
    End Sub

    Private Sub SetItem(ByVal itemum As Byte, ByVal img As Image, ByVal tag As String)
        Pic(itemum).Image = img
        Pic(itemum).Visible = True
        Items(itemum).InImg = img
        Items(itemum).InName = tag
        Items(itemum).InVisible = True
    End Sub

    Private Sub ucInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmptyInventory()
    End Sub



#End Region
End Class