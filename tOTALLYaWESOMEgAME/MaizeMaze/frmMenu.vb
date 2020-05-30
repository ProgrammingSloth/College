Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Me.Hide()
        frmGameScreen.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnLevel_Click(sender As Object, e As EventArgs) Handles btnLevel.Click
        Me.Hide()
        frmLevels.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmFAQ.Show()
    End Sub
End Class