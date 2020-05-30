<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFAQ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Roomba = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.Enemy = New System.Windows.Forms.ToolTip(Me.components)
        Me.JunkFood = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Maroon
        Me.btnBack.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1061, 473)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(203, 72)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MaizeMaze.My.Resources.Resources.RoombaFront
        Me.PictureBox1.Location = New System.Drawing.Point(97, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.Roomba.SetToolTip(Me.PictureBox1, "This is your main character,")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MaizeMaze.My.Resources.Resources.Dog
        Me.PictureBox2.Location = New System.Drawing.Point(96, 208)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.Enemy.SetToolTip(Me.PictureBox2, "This is the enemy of this level,")
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.MaizeMaze.My.Resources.Resources.JunkFood___1
        Me.PictureBox3.Location = New System.Drawing.Point(118, 410)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(122, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        Me.JunkFood.SetToolTip(Me.PictureBox3, "Your goal is to collect these junk food items to complete your levels," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you " &
        "collect all of these items within a level you win :)")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.MaizeMaze.My.Resources.Resources.Capture
        Me.PictureBox4.Location = New System.Drawing.Point(615, 255)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(122, 290)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        Me.Inventory.SetToolTip(Me.PictureBox4, "This is your Inventory:")
        '
        'Roomba
        '
        Me.Roomba.ToolTipTitle = "Main Character"
        '
        'Inventory
        '
        Me.Inventory.ToolTipTitle = "Inventory"
        '
        'Enemy
        '
        Me.Enemy.ToolTipTitle = "Enemy"
        '
        'JunkFood
        '
        Me.JunkFood.ToolTipTitle = "JunkFood"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(743, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "This is your inventory for each level, "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(743, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "when you collect an item it will"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(743, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "appear in this menu."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(280, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "This is the main character"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(280, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(289, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "You control this character with W,A,S,D"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(280, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Your job is to collect to the junk food"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(281, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "by running over the item"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(280, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "This is the main enemy of the game"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(280, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(303, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Your job is to avoid this god with your life"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(280, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "All he wants is to ruin your day"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(281, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(305, 19)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "So don't run into this guy or lose your hp!"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(281, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 19)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "This is the junk food item"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(281, 467)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(276, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Your job as a roomba is to collect all "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(281, 486)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(248, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "of the junk food items in the level"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift", 16.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(511, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(227, 27)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "The Goal of the Game:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift", 14.0!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(237, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(765, 23)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Your goal for each level is to collect every junk food item without losing all of" &
    " your health"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift", 14.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(782, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(319, 23)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Question: How do you win the game?"
        '
        'Label18
        '
        Me.Label18.AllowDrop = True
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(825, 113)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(291, 19)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Answer: You complete all of the levels?"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Bahnschrift", 14.0!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(782, 158)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(371, 23)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Question: How do you complete the levels?"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(825, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(422, 19)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Answer: You collect all of the junk food items in the level?"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Bahnschrift", 14.0!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(782, 232)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(368, 23)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Question: How do you unlock more levels?"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(825, 255)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(310, 19)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Answer: You complete the previous levels"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Bahnschrift", 14.0!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(782, 302)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(304, 23)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Question: Are more levels coming?"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(825, 325)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(367, 19)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Answer: No, at this time it is just a one level demo"
        '
        'frmFAQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MaizeMaze.My.Resources.Resources.frmMenuBG
        Me.ClientSize = New System.Drawing.Size(1301, 557)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmFAQ"
        Me.Text = "FAQ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Roomba As ToolTip
    Friend WithEvents Inventory As ToolTip
    Friend WithEvents Enemy As ToolTip
    Friend WithEvents JunkFood As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
End Class
