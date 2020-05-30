Public Class frmLevels
    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click
        Me.Hide()
        frmGameScreen.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class