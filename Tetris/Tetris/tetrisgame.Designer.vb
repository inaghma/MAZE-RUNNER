<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tetrisgame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tetrisgame))
        Me.HelpLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinesLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.timermaze1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.PreviewBox = New System.Windows.Forms.PictureBox()
        Me.GameBox = New System.Windows.Forms.PictureBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviewBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpLabel
        '
        Me.HelpLabel.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLabel.Location = New System.Drawing.Point(953, 356)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(278, 161)
        Me.HelpLabel.TabIndex = 42
        Me.HelpLabel.Text = " Up Arrow : Rotate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Down Arrow:Shift Down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Left Arrow: Shift Left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Right" &
    " Arrow: Shift Right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(986, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 31)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Keys:"
        '
        'LinesLabel
        '
        Me.LinesLabel.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinesLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.LinesLabel.Location = New System.Drawing.Point(634, 180)
        Me.LinesLabel.Name = "LinesLabel"
        Me.LinesLabel.Size = New System.Drawing.Size(66, 56)
        Me.LinesLabel.TabIndex = 40
        Me.LinesLabel.Text = "0"
        Me.LinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(623, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 41)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Rows"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(976, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 31)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Next"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MessageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MessageLabel.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Black
        Me.MessageLabel.Location = New System.Drawing.Point(755, 262)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(167, 211)
        Me.MessageLabel.TabIndex = 44
        Me.MessageLabel.Text = "CLICK HERE TO START!!!"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timermaze1
        '
        Me.timermaze1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 21.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(26, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(588, 450)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.header.Image = Global.Tetris.My.Resources.Resources.Screen_Shot_01_18_16_at_11_48_PM
        Me.header.Location = New System.Drawing.Point(83, 32)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(397, 160)
        Me.header.TabIndex = 53
        Me.header.TabStop = False
        '
        'PreviewBox
        '
        Me.PreviewBox.BackColor = System.Drawing.Color.Transparent
        Me.PreviewBox.Location = New System.Drawing.Point(974, 190)
        Me.PreviewBox.Name = "PreviewBox"
        Me.PreviewBox.Size = New System.Drawing.Size(80, 80)
        Me.PreviewBox.TabIndex = 45
        Me.PreviewBox.TabStop = False
        '
        'GameBox
        '
        Me.GameBox.BackColor = System.Drawing.Color.SeaShell
        Me.GameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GameBox.Location = New System.Drawing.Point(741, 133)
        Me.GameBox.Name = "GameBox"
        Me.GameBox.Size = New System.Drawing.Size(200, 400)
        Me.GameBox.TabIndex = 43
        Me.GameBox.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(1039, 35)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(101, 37)
        Me.Label38.TabIndex = 59
        Me.Label38.Text = "Time "
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.BackColor = System.Drawing.Color.Transparent
        Me.lblscore.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(1176, 97)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(36, 37)
        Me.lblscore.TabIndex = 58
        Me.lblscore.Text = "0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(1038, 97)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(135, 37)
        Me.Label40.TabIndex = 57
        Me.Label40.Text = "Score : "
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.BackColor = System.Drawing.Color.Transparent
        Me.lblsec.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(1239, 35)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(36, 37)
        Me.lblsec.TabIndex = 56
        Me.lblsec.Text = "0"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(1197, 35)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(27, 37)
        Me.Label42.TabIndex = 55
        Me.Label42.Text = ":"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.BackColor = System.Drawing.Color.Transparent
        Me.lblmin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.Location = New System.Drawing.Point(1155, 35)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(36, 37)
        Me.lblmin.TabIndex = 54
        Me.lblmin.Text = "0"
        '
        'tetrisgame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 660)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.lblsec)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinesLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PreviewBox)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.GameBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tetrisgame"
        Me.Text = "BLock it up!!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviewBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinesLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents PreviewBox As PictureBox
    Friend WithEvents MessageLabel As Label
    Friend WithEvents GameBox As PictureBox
    Friend WithEvents timermaze1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents header As PictureBox
    Friend WithEvents Label38 As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lblsec As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents lblmin As Label
End Class
