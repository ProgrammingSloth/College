<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnLevel = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Maroon
        Me.btnPlay.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(123, 84)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(298, 106)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "PLAY GAME"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnLevel
        '
        Me.btnLevel.BackColor = System.Drawing.Color.Maroon
        Me.btnLevel.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnLevel.Location = New System.Drawing.Point(123, 207)
        Me.btnLevel.Name = "btnLevel"
        Me.btnLevel.Size = New System.Drawing.Size(298, 106)
        Me.btnLevel.TabIndex = 1
        Me.btnLevel.Text = "LEVEL SELECT"
        Me.btnLevel.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Maroon
        Me.btnQuit.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnQuit.Location = New System.Drawing.Point(123, 337)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(298, 106)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "QUIT GAME"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MaizeMaze.My.Resources.Resources.RoombaMenu
        Me.PictureBox2.Location = New System.Drawing.Point(580, 173)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(517, 281)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle.Location = New System.Drawing.Point(512, 84)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(667, 115)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "ROOMBA RAID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1083, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 61)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "FAQ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MaizeMaze.My.Resources.Resources.frmMenuBG
        Me.ClientSize = New System.Drawing.Size(1276, 557)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLevel)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnLevel As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Button1 As Button
End Class
