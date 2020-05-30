<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameScreen))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCheat4 = New System.Windows.Forms.Button()
        Me.btnCheat3 = New System.Windows.Forms.Button()
        Me.btnCheat2 = New System.Windows.Forms.Button()
        Me.btnCheat1 = New System.Windows.Forms.Button()
        Me.prgHealth = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblCollected = New System.Windows.Forms.Label()
        Me.lblFriCount = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.picRoomba = New MaizeMaze.MyPlayer()
        Me.picDog = New MaizeMaze.MyEnemy()
        Me.LblBoundaries16 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries15 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries14 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries13 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries12 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries11 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries10 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries9 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries8 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries7 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries4 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries3 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries2 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries1 = New MaizeMaze.lblBoundaries()
        Me.picJunk5 = New MaizeMaze.MyHealth()
        Me.picJunk4 = New MaizeMaze.MyHealth()
        Me.picJunk3 = New MaizeMaze.MyHealth()
        Me.picJunk2 = New MaizeMaze.MyHealth()
        Me.picJunk1 = New MaizeMaze.MyHealth()
        Me.UcInventory1 = New MaizeMaze.ucInventory()
        Me.LblBoundaries5 = New MaizeMaze.lblBoundaries()
        Me.LblBoundaries6 = New MaizeMaze.lblBoundaries()
        Me.Inventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.Enemy = New System.Windows.Forms.ToolTip(Me.components)
        Me.Roomba = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoomba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJunk5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJunk4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJunk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJunk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJunk1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "JunkFood - 1.png")
        Me.ImageList1.Images.SetKeyName(1, "JunkFood - 2.png")
        Me.ImageList1.Images.SetKeyName(2, "JunkFood - 3.png")
        Me.ImageList1.Images.SetKeyName(3, "JunkFood - 4.png")
        Me.ImageList1.Images.SetKeyName(4, "JunkFood - 5.png")
        '
        'btnCheat4
        '
        Me.btnCheat4.BackColor = System.Drawing.Color.Maroon
        Me.btnCheat4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCheat4.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheat4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheat4.Location = New System.Drawing.Point(73, 535)
        Me.btnCheat4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCheat4.Name = "btnCheat4"
        Me.btnCheat4.Size = New System.Drawing.Size(25, 23)
        Me.btnCheat4.TabIndex = 11
        Me.btnCheat4.Text = "4"
        Me.btnCheat4.UseVisualStyleBackColor = False
        '
        'btnCheat3
        '
        Me.btnCheat3.BackColor = System.Drawing.Color.Maroon
        Me.btnCheat3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCheat3.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheat3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheat3.Location = New System.Drawing.Point(48, 535)
        Me.btnCheat3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCheat3.Name = "btnCheat3"
        Me.btnCheat3.Size = New System.Drawing.Size(25, 23)
        Me.btnCheat3.TabIndex = 10
        Me.btnCheat3.Text = "3"
        Me.btnCheat3.UseVisualStyleBackColor = False
        '
        'btnCheat2
        '
        Me.btnCheat2.BackColor = System.Drawing.Color.Maroon
        Me.btnCheat2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCheat2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheat2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheat2.Location = New System.Drawing.Point(23, 535)
        Me.btnCheat2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCheat2.Name = "btnCheat2"
        Me.btnCheat2.Size = New System.Drawing.Size(25, 23)
        Me.btnCheat2.TabIndex = 9
        Me.btnCheat2.Text = "2"
        Me.btnCheat2.UseVisualStyleBackColor = False
        '
        'btnCheat1
        '
        Me.btnCheat1.BackColor = System.Drawing.Color.Maroon
        Me.btnCheat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCheat1.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCheat1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheat1.Location = New System.Drawing.Point(-2, 535)
        Me.btnCheat1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCheat1.Name = "btnCheat1"
        Me.btnCheat1.Size = New System.Drawing.Size(25, 23)
        Me.btnCheat1.TabIndex = 8
        Me.btnCheat1.Text = "1"
        Me.btnCheat1.UseVisualStyleBackColor = False
        '
        'prgHealth
        '
        Me.prgHealth.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.prgHealth.Location = New System.Drawing.Point(358, 9)
        Me.prgHealth.Name = "prgHealth"
        Me.prgHealth.Size = New System.Drawing.Size(221, 33)
        Me.prgHealth.TabIndex = 21
        Me.prgHealth.Value = 100
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MaizeMaze.My.Resources.Resources.DogBowl
        Me.PictureBox1.Location = New System.Drawing.Point(403, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'picBox
        '
        Me.picBox.BackColor = System.Drawing.Color.Transparent
        Me.picBox.Image = Global.MaizeMaze.My.Resources.Resources.BoxV2
        Me.picBox.Location = New System.Drawing.Point(452, 413)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(179, 132)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 23
        Me.picBox.TabStop = False
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblHealth.Font = New System.Drawing.Font("Bahnschrift", 20.0!)
        Me.lblHealth.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHealth.Location = New System.Drawing.Point(234, 9)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(118, 33)
        Me.lblHealth.TabIndex = 41
        Me.lblHealth.Text = "HEALTH:"
        '
        'lblCollected
        '
        Me.lblCollected.AutoSize = True
        Me.lblCollected.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblCollected.Font = New System.Drawing.Font("Bahnschrift", 16.0!)
        Me.lblCollected.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCollected.Location = New System.Drawing.Point(1154, 36)
        Me.lblCollected.Name = "lblCollected"
        Me.lblCollected.Size = New System.Drawing.Size(104, 27)
        Me.lblCollected.TabIndex = 42
        Me.lblCollected.Text = "Collected"
        '
        'lblFriCount
        '
        Me.lblFriCount.AutoSize = True
        Me.lblFriCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.lblFriCount.Font = New System.Drawing.Font("Bahnschrift", 16.0!)
        Me.lblFriCount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFriCount.Location = New System.Drawing.Point(1184, 66)
        Me.lblFriCount.Name = "lblFriCount"
        Me.lblFriCount.Size = New System.Drawing.Size(44, 27)
        Me.lblFriCount.TabIndex = 43
        Me.lblFriCount.Text = "0/5"
        '
        'picRoomba
        '
        Me.picRoomba.BackColor = System.Drawing.Color.Transparent
        Me.picRoomba.BackgroundImage = Global.MaizeMaze.My.Resources.Resources.Blank
        Me.picRoomba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRoomba.health = 0
        Me.picRoomba.Location = New System.Drawing.Point(100, 379)
        Me.picRoomba.Name = "picRoomba"
        Me.picRoomba.Size = New System.Drawing.Size(148, 77)
        Me.picRoomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoomba.TabIndex = 13
        Me.picRoomba.TabStop = False
        Me.Roomba.SetToolTip(Me.picRoomba, "This is your main character," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User W,A,S,D to move your character," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collect t" &
        "he junk food while avoiding the dog!")
        '
        'picDog
        '
        Me.picDog.BackColor = System.Drawing.Color.Transparent
        Me.picDog.DamageInflicted = 0
        Me.picDog.Image = CType(resources.GetObject("picDog.Image"), System.Drawing.Image)
        Me.picDog.Location = New System.Drawing.Point(283, 133)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(114, 162)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDog.TabIndex = 24
        Me.picDog.TabStop = False
        Me.Enemy.SetToolTip(Me.picDog, "This is the enemy of this level," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you hit this animal you will be replled an" &
        "d you will lose health." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "So hint: Don't hit touch him... He BITES!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'LblBoundaries16
        '
        Me.LblBoundaries16.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries16.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries16.Location = New System.Drawing.Point(303, 146)
        Me.LblBoundaries16.Name = "LblBoundaries16"
        Me.LblBoundaries16.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries16.TabIndex = 40
        '
        'LblBoundaries15
        '
        Me.LblBoundaries15.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries15.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries15.Location = New System.Drawing.Point(256, 156)
        Me.LblBoundaries15.Name = "LblBoundaries15"
        Me.LblBoundaries15.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries15.TabIndex = 39
        '
        'LblBoundaries14
        '
        Me.LblBoundaries14.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries14.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries14.Location = New System.Drawing.Point(212, 179)
        Me.LblBoundaries14.Name = "LblBoundaries14"
        Me.LblBoundaries14.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries14.TabIndex = 38
        '
        'LblBoundaries13
        '
        Me.LblBoundaries13.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries13.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries13.Location = New System.Drawing.Point(171, 201)
        Me.LblBoundaries13.Name = "LblBoundaries13"
        Me.LblBoundaries13.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries13.TabIndex = 37
        '
        'LblBoundaries12
        '
        Me.LblBoundaries12.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries12.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries12.Location = New System.Drawing.Point(128, 223)
        Me.LblBoundaries12.Name = "LblBoundaries12"
        Me.LblBoundaries12.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries12.TabIndex = 36
        '
        'LblBoundaries11
        '
        Me.LblBoundaries11.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries11.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries11.Location = New System.Drawing.Point(87, 248)
        Me.LblBoundaries11.Name = "LblBoundaries11"
        Me.LblBoundaries11.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries11.TabIndex = 35
        '
        'LblBoundaries10
        '
        Me.LblBoundaries10.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries10.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries10.Location = New System.Drawing.Point(56, 271)
        Me.LblBoundaries10.Name = "LblBoundaries10"
        Me.LblBoundaries10.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries10.TabIndex = 34
        '
        'LblBoundaries9
        '
        Me.LblBoundaries9.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries9.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries9.Location = New System.Drawing.Point(25, 294)
        Me.LblBoundaries9.Name = "LblBoundaries9"
        Me.LblBoundaries9.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries9.TabIndex = 33
        '
        'LblBoundaries8
        '
        Me.LblBoundaries8.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries8.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries8.Location = New System.Drawing.Point(-2, 318)
        Me.LblBoundaries8.Name = "LblBoundaries8"
        Me.LblBoundaries8.Size = New System.Drawing.Size(25, 24)
        Me.LblBoundaries8.TabIndex = 32
        '
        'LblBoundaries7
        '
        Me.LblBoundaries7.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries7.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries7.Location = New System.Drawing.Point(944, 109)
        Me.LblBoundaries7.Name = "LblBoundaries7"
        Me.LblBoundaries7.Size = New System.Drawing.Size(10, 104)
        Me.LblBoundaries7.TabIndex = 31
        '
        'LblBoundaries4
        '
        Me.LblBoundaries4.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries4.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries4.Location = New System.Drawing.Point(752, 0)
        Me.LblBoundaries4.Name = "LblBoundaries4"
        Me.LblBoundaries4.Size = New System.Drawing.Size(389, 10)
        Me.LblBoundaries4.TabIndex = 28
        '
        'LblBoundaries3
        '
        Me.LblBoundaries3.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries3.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries3.Location = New System.Drawing.Point(944, 109)
        Me.LblBoundaries3.Name = "LblBoundaries3"
        Me.LblBoundaries3.Size = New System.Drawing.Size(197, 24)
        Me.LblBoundaries3.TabIndex = 27
        '
        'LblBoundaries2
        '
        Me.LblBoundaries2.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries2.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries2.Location = New System.Drawing.Point(1138, -1)
        Me.LblBoundaries2.Name = "LblBoundaries2"
        Me.LblBoundaries2.Size = New System.Drawing.Size(10, 565)
        Me.LblBoundaries2.TabIndex = 26
        '
        'LblBoundaries1
        '
        Me.LblBoundaries1.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries1.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries1.Location = New System.Drawing.Point(729, 0)
        Me.LblBoundaries1.Name = "LblBoundaries1"
        Me.LblBoundaries1.Size = New System.Drawing.Size(17, 215)
        Me.LblBoundaries1.TabIndex = 25
        '
        'picJunk5
        '
        Me.picJunk5.BackColor = System.Drawing.Color.Transparent
        Me.picJunk5.healthReward = 50
        Me.picJunk5.Image = Global.MaizeMaze.My.Resources.Resources.JunkFood___1
        Me.picJunk5.Location = New System.Drawing.Point(978, 179)
        Me.picJunk5.Name = "picJunk5"
        Me.picJunk5.Size = New System.Drawing.Size(53, 57)
        Me.picJunk5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJunk5.TabIndex = 20
        Me.picJunk5.TabStop = False
        '
        'picJunk4
        '
        Me.picJunk4.BackColor = System.Drawing.Color.Transparent
        Me.picJunk4.healthReward = 50
        Me.picJunk4.Image = Global.MaizeMaze.My.Resources.Resources.JunkFood___1
        Me.picJunk4.Location = New System.Drawing.Point(1032, 36)
        Me.picJunk4.Name = "picJunk4"
        Me.picJunk4.Size = New System.Drawing.Size(53, 57)
        Me.picJunk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJunk4.TabIndex = 19
        Me.picJunk4.TabStop = False
        '
        'picJunk3
        '
        Me.picJunk3.BackColor = System.Drawing.Color.Transparent
        Me.picJunk3.healthReward = 50
        Me.picJunk3.Image = Global.MaizeMaze.My.Resources.Resources.JunkFood___1
        Me.picJunk3.Location = New System.Drawing.Point(442, 123)
        Me.picJunk3.Name = "picJunk3"
        Me.picJunk3.Size = New System.Drawing.Size(53, 57)
        Me.picJunk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJunk3.TabIndex = 18
        Me.picJunk3.TabStop = False
        '
        'picJunk2
        '
        Me.picJunk2.BackColor = System.Drawing.Color.Transparent
        Me.picJunk2.healthReward = 50
        Me.picJunk2.Image = Global.MaizeMaze.My.Resources.Resources.JunkFood___1
        Me.picJunk2.Location = New System.Drawing.Point(732, 449)
        Me.picJunk2.Name = "picJunk2"
        Me.picJunk2.Size = New System.Drawing.Size(53, 57)
        Me.picJunk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJunk2.TabIndex = 17
        Me.picJunk2.TabStop = False
        '
        'picJunk1
        '
        Me.picJunk1.BackColor = System.Drawing.Color.Transparent
        Me.picJunk1.healthReward = 50
        Me.picJunk1.Image = Global.MaizeMaze.My.Resources.Resources.JunkFood___1
        Me.picJunk1.Location = New System.Drawing.Point(320, 429)
        Me.picJunk1.Name = "picJunk1"
        Me.picJunk1.Size = New System.Drawing.Size(53, 57)
        Me.picJunk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJunk1.TabIndex = 14
        Me.picJunk1.TabStop = False
        '
        'UcInventory1
        '
        Me.UcInventory1.BackgroundImage = CType(resources.GetObject("UcInventory1.BackgroundImage"), System.Drawing.Image)
        Me.UcInventory1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UcInventory1.Location = New System.Drawing.Point(1141, 27)
        Me.UcInventory1.Name = "UcInventory1"
        Me.UcInventory1.Size = New System.Drawing.Size(123, 515)
        Me.UcInventory1.TabIndex = 7
        Me.Inventory.SetToolTip(Me.UcInventory1, "This is your Inventory:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "When you collect an item of food it will appear in thi" &
        "s menu to help you keep track of what is left to collect!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'LblBoundaries5
        '
        Me.LblBoundaries5.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries5.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries5.Location = New System.Drawing.Point(-5, 540)
        Me.LblBoundaries5.Name = "LblBoundaries5"
        Me.LblBoundaries5.Size = New System.Drawing.Size(1289, 23)
        Me.LblBoundaries5.TabIndex = 29
        '
        'LblBoundaries6
        '
        Me.LblBoundaries6.BackColor = System.Drawing.Color.Transparent
        Me.LblBoundaries6.ForeColor = System.Drawing.Color.Transparent
        Me.LblBoundaries6.Location = New System.Drawing.Point(501, 97)
        Me.LblBoundaries6.Name = "LblBoundaries6"
        Me.LblBoundaries6.Size = New System.Drawing.Size(253, 23)
        Me.LblBoundaries6.TabIndex = 30
        '
        'Inventory
        '
        Me.Inventory.ToolTipTitle = "Inventory"
        '
        'Enemy
        '
        Me.Enemy.ToolTipTitle = "Enemy"
        '
        'Roomba
        '
        Me.Roomba.ToolTipTitle = "Main Character"
        '
        'frmGameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MaizeMaze.My.Resources.Resources.BackgroundV3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1276, 557)
        Me.Controls.Add(Me.lblFriCount)
        Me.Controls.Add(Me.lblCollected)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.picDog)
        Me.Controls.Add(Me.LblBoundaries16)
        Me.Controls.Add(Me.LblBoundaries15)
        Me.Controls.Add(Me.LblBoundaries14)
        Me.Controls.Add(Me.LblBoundaries13)
        Me.Controls.Add(Me.LblBoundaries12)
        Me.Controls.Add(Me.LblBoundaries11)
        Me.Controls.Add(Me.LblBoundaries10)
        Me.Controls.Add(Me.LblBoundaries9)
        Me.Controls.Add(Me.LblBoundaries8)
        Me.Controls.Add(Me.LblBoundaries7)
        Me.Controls.Add(Me.LblBoundaries4)
        Me.Controls.Add(Me.LblBoundaries3)
        Me.Controls.Add(Me.LblBoundaries2)
        Me.Controls.Add(Me.LblBoundaries1)
        Me.Controls.Add(Me.picRoomba)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.prgHealth)
        Me.Controls.Add(Me.picJunk5)
        Me.Controls.Add(Me.picJunk4)
        Me.Controls.Add(Me.picJunk3)
        Me.Controls.Add(Me.picJunk2)
        Me.Controls.Add(Me.picJunk1)
        Me.Controls.Add(Me.btnCheat4)
        Me.Controls.Add(Me.btnCheat3)
        Me.Controls.Add(Me.btnCheat2)
        Me.Controls.Add(Me.btnCheat1)
        Me.Controls.Add(Me.UcInventory1)
        Me.Controls.Add(Me.LblBoundaries5)
        Me.Controls.Add(Me.LblBoundaries6)
        Me.DoubleBuffered = True
        Me.Name = "frmGameScreen"
        Me.Text = "frmGame"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoomba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJunk5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJunk4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJunk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJunk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJunk1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents picRoomba As MyPlayer
    Friend WithEvents picJunk1 As MyHealth
    Friend WithEvents UcInventory1 As ucInventory
    Friend WithEvents btnCheat4 As Button
    Friend WithEvents btnCheat3 As Button
    Friend WithEvents btnCheat2 As Button
    Friend WithEvents btnCheat1 As Button
    Friend WithEvents picJunk2 As MyHealth
    Friend WithEvents picJunk3 As MyHealth
    Friend WithEvents picJunk4 As MyHealth
    Friend WithEvents picJunk5 As MyHealth
    Friend WithEvents prgHealth As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Tmr1 As Timer
    Friend WithEvents picBox As PictureBox
    Friend WithEvents picDog As MyEnemy
    Friend WithEvents LblBoundaries1 As lblBoundaries
    Friend WithEvents LblBoundaries2 As lblBoundaries
    Friend WithEvents LblBoundaries3 As lblBoundaries
    Friend WithEvents LblBoundaries4 As lblBoundaries
    Friend WithEvents LblBoundaries5 As lblBoundaries
    Friend WithEvents LblBoundaries6 As lblBoundaries
    Friend WithEvents LblBoundaries7 As lblBoundaries
    Friend WithEvents LblBoundaries8 As lblBoundaries
    Friend WithEvents LblBoundaries9 As lblBoundaries
    Friend WithEvents LblBoundaries10 As lblBoundaries
    Friend WithEvents LblBoundaries11 As lblBoundaries
    Friend WithEvents LblBoundaries12 As lblBoundaries
    Friend WithEvents LblBoundaries13 As lblBoundaries
    Friend WithEvents LblBoundaries14 As lblBoundaries
    Friend WithEvents LblBoundaries15 As lblBoundaries
    Friend WithEvents LblBoundaries16 As lblBoundaries
    Friend WithEvents lblHealth As Label
    Friend WithEvents lblCollected As Label
    Friend WithEvents lblFriCount As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Inventory As ToolTip
    Friend WithEvents Enemy As ToolTip
    Friend WithEvents Roomba As ToolTip
End Class
