Public Class frmGameScreen
    Dim WinCouner As Int16
    Dim items2Collect(8) As String
    Private Sub InventoryList()
        items2Collect(0) = "Junk1"
        items2Collect(1) = "Junk2"
        items2Collect(2) = "Junk3"
        items2Collect(3) = "Junk4"
        items2Collect(4) = "Junk5"

    End Sub
    Private Sub btnCheat1_Click(sender As Object, e As EventArgs) Handles btnCheat1.Click
        Me.Close()
        frmWin.Show()
    End Sub

    Private Sub btnCheat2_Click(sender As Object, e As EventArgs) Handles btnCheat2.Click
        Me.Close()
        frmFailed.Show()
    End Sub

    Private Sub btnCheat3_Click(sender As Object, e As EventArgs) Handles btnCheat3.Click
        UcInventory1.addToInventory(ImageList1.Images(0), items2Collect(0))
    End Sub

    Private Sub btnCheat4_Click(sender As Object, e As EventArgs) Handles btnCheat4.Click
        UcInventory1.EmptyInventory()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        KeyPreview = True
        prgHealth.Value = 100
        picDog.DamageInflicted = -10
        Tmr1.Enabled = True
        picRoomba.Image = My.Resources.RoombaBack
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim PlayerPositionB4moved As Point = picRoomba.Location
        Select Case e.KeyCode
            Case Keys.A
                picRoomba.Left -= 5
                picRoomba.Image = My.Resources.RoombaLeft
            Case Keys.D
                picRoomba.Left += 5
                picRoomba.Image = My.Resources.RoombaRight
            Case Keys.W
                picRoomba.Top -= 5
                picRoomba.Image = My.Resources.BackRoombaV2
            Case Keys.S
                picRoomba.Top += 5

                picRoomba.Image = My.Resources.RoombaFront

        End Select

        For Each l As Control In Me.Controls
            If TypeOf l Is lblBoundaries Then 'if it's a wall type label
                Dim lbl As lblBoundaries = l 'then declare it as a wall to make it easier to access
                If lbl.IsCollision(picRoomba) Then
                    picRoomba.Location = PlayerPositionB4moved
                End If
            End If
        Next

        If picRoomba.collisionFound(picDog.Bounds) Then
            picRoomba.IncrementHealth(picDog.DamageInflicted)
            If prgHealth.Value = 0 Then
                Me.Close()
                frmFailed.Show()
            Else
                prgHealth.Value = prgHealth.Value - 10
                My.Computer.Audio.Play(My.Resources.bugger2, AudioPlayMode.Background)

                Select Case e.KeyCode
                    Case Keys.A
                        picRoomba.Left += 35
                        picRoomba.Image = My.Resources.RoombaLeft_Hurt
                    Case Keys.D
                        picRoomba.Left -= 35
                        picRoomba.Image = My.Resources.RoombaRight_Hurt
                    Case Keys.W
                        picRoomba.Top += 35
                        picRoomba.Image = My.Resources.BackRoomba_Hurt
                    Case Keys.S
                        picRoomba.Top -= 35
                        picRoomba.Image = My.Resources.FrontRoomba_Hurt

                End Select
            End If


        End If

        If picRoomba.collisionFound(picBox.Bounds) Then
            picRoomba.Location = PlayerPositionB4moved
        End If

        If picRoomba.collisionFound(picJunk1.Bounds) And picJunk1.Visible Then
            picJunk1.Visible = False
            picRoomba.IncrementHealth(picJunk1.healthReward)
            UcInventory1.addToInventory(ImageList1.Images(0), items2Collect(0))
            If prgHealth.Maximum = prgHealth.Value Then
                prgHealth.Maximum += 10
                prgHealth.Width = prgHealth.Width * (prgHealth.Maximum / (prgHealth.Maximum - 10))
                prgHealth.Value = prgHealth.Value + 10

            End If
            WinCouner = WinCouner + 1
            lblFriCount.Text = "1/5"

        ElseIf picRoomba.collisionFound(picJunk2.Bounds) And picJunk2.Visible Then
            picJunk2.Visible = False
            picRoomba.IncrementHealth(picJunk1.healthReward)
            UcInventory1.addToInventory(ImageList1.Images(0), items2Collect(0))
            If prgHealth.Maximum = prgHealth.Value Then
                prgHealth.Maximum += 10
                prgHealth.Width = prgHealth.Width * (prgHealth.Maximum / (prgHealth.Maximum - 10))
                prgHealth.Value = prgHealth.Value + 10

            End If
            WinCouner = WinCouner + 1
            lblFriCount.Text = "3/5"

        ElseIf picRoomba.collisionFound(picJunk3.Bounds) And picJunk3.Visible Then
            picJunk3.Visible = False
            picRoomba.IncrementHealth(picJunk1.healthReward)
            UcInventory1.addToInventory(ImageList1.Images(0), items2Collect(0))
            If prgHealth.Maximum = prgHealth.Value Then
                prgHealth.Maximum += 10
                prgHealth.Width = prgHealth.Width * (prgHealth.Maximum / (prgHealth.Maximum - 10))
                prgHealth.Value = prgHealth.Value + 10

            End If
            WinCouner = WinCouner + 1
            lblFriCount.Text = "2/5"

        ElseIf picRoomba.collisionFound(picJunk4.Bounds) And picJunk4.Visible Then
            picJunk4.Visible = False
            picRoomba.IncrementHealth(picJunk1.healthReward)
            UcInventory1.addToInventory(ImageList1.Images(0), items2Collect(0))
            If prgHealth.Maximum = prgHealth.Value Then
                prgHealth.Maximum += 10
                prgHealth.Width = prgHealth.Width * (prgHealth.Maximum / (prgHealth.Maximum - 10))
                prgHealth.Value = prgHealth.Value + 10

            End If
            WinCouner = WinCouner + 1
            lblFriCount.Text = "5/5"

        ElseIf picRoomba.collisionFound(picJunk5.Bounds) And picJunk5.Visible Then
            picJunk5.Visible = False
            picRoomba.IncrementHealth(picJunk1.healthReward)
            UcInventory1.addToInventory(ImageList1.Images(0), items2Collect(0))
            If prgHealth.Maximum = prgHealth.Value Then
                prgHealth.Maximum += 10
                prgHealth.Width = prgHealth.Width * (prgHealth.Maximum / (prgHealth.Maximum - 10))
                prgHealth.Value = prgHealth.Value + 10

            End If
            WinCouner = WinCouner + 1
            lblFriCount.Text = "4/5"
        End If

        If WinCouner = 5 Then
            Me.Close()
            frmWin.Show()
        End If

    End Sub

End Class

