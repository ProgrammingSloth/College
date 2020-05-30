<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevels
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLevelLocked2 = New System.Windows.Forms.Button()
        Me.btnLevelLocked = New System.Windows.Forms.Button()
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(360, 104)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(383, 77)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Level Select"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MaizeMaze.My.Resources.Resources.RoombaMenu
        Me.PictureBox1.Location = New System.Drawing.Point(694, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnLevelLocked2
        '
        Me.btnLevelLocked2.BackColor = System.Drawing.Color.Maroon
        Me.btnLevelLocked2.Enabled = False
        Me.btnLevelLocked2.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelLocked2.ForeColor = System.Drawing.Color.White
        Me.btnLevelLocked2.Location = New System.Drawing.Point(824, 287)
        Me.btnLevelLocked2.Name = "btnLevelLocked2"
        Me.btnLevelLocked2.Size = New System.Drawing.Size(298, 106)
        Me.btnLevelLocked2.TabIndex = 2
        Me.btnLevelLocked2.Text = "LOCKED"
        Me.btnLevelLocked2.UseVisualStyleBackColor = False
        '
        'btnLevelLocked
        '
        Me.btnLevelLocked.BackColor = System.Drawing.Color.Maroon
        Me.btnLevelLocked.Enabled = False
        Me.btnLevelLocked.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelLocked.ForeColor = System.Drawing.Color.White
        Me.btnLevelLocked.Location = New System.Drawing.Point(470, 287)
        Me.btnLevelLocked.Name = "btnLevelLocked"
        Me.btnLevelLocked.Size = New System.Drawing.Size(298, 106)
        Me.btnLevelLocked.TabIndex = 3
        Me.btnLevelLocked.Text = "LOCKED"
        Me.btnLevelLocked.UseVisualStyleBackColor = False
        '
        'btnLevel1
        '
        Me.btnLevel1.BackColor = System.Drawing.Color.Maroon
        Me.btnLevel1.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel1.ForeColor = System.Drawing.Color.White
        Me.btnLevel1.Location = New System.Drawing.Point(116, 287)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(298, 106)
        Me.btnLevel1.TabIndex = 4
        Me.btnLevel1.Text = "LEVEL 1"
        Me.btnLevel1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Maroon
        Me.btnBack.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1061, 473)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(203, 72)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmLevels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MaizeMaze.My.Resources.Resources.frmMenuBG
        Me.ClientSize = New System.Drawing.Size(1276, 557)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLevel1)
        Me.Controls.Add(Me.btnLevelLocked)
        Me.Controls.Add(Me.btnLevelLocked2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmLevels"
        Me.Text = "frmLevels"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLevelLocked2 As Button
    Friend WithEvents btnLevelLocked As Button
    Friend WithEvents btnLevel1 As Button
    Friend WithEvents btnBack As Button
End Class
