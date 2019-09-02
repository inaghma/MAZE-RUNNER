<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMoveSnake = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labellives = New System.Windows.Forms.Label()
        Me.picinstructn = New System.Windows.Forms.PictureBox()
        Me.apple = New System.Windows.Forms.PictureBox()
        Me.snakehead = New System.Windows.Forms.PictureBox()
        Me.header = New System.Windows.Forms.Label()
        CType(Me.picinstructn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.snakehead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(698, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Begin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimerTime
        '
        Me.TimerTime.Interval = 1000
        '
        'TimerMoveSnake
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 34.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(656, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Lives Left : "
        '
        'labellives
        '
        Me.labellives.AutoSize = True
        Me.labellives.BackColor = System.Drawing.Color.Transparent
        Me.labellives.Font = New System.Drawing.Font("Goudy Old Style", 34.25!, System.Drawing.FontStyle.Bold)
        Me.labellives.Location = New System.Drawing.Point(939, 199)
        Me.labellives.Name = "labellives"
        Me.labellives.Size = New System.Drawing.Size(0, 54)
        Me.labellives.TabIndex = 4
        '
        'picinstructn
        '
        Me.picinstructn.Image = Global.snake.My.Resources.Resources.Screen_Shot_01_19_16_at_12_39_AM
        Me.picinstructn.Location = New System.Drawing.Point(38, 159)
        Me.picinstructn.Name = "picinstructn"
        Me.picinstructn.Size = New System.Drawing.Size(509, 501)
        Me.picinstructn.TabIndex = 5
        Me.picinstructn.TabStop = False
        '
        'apple
        '
        Me.apple.BackColor = System.Drawing.Color.Transparent
        Me.apple.Image = Global.snake.My.Resources.Resources.apple__15x15_
        Me.apple.Location = New System.Drawing.Point(461, 252)
        Me.apple.Name = "apple"
        Me.apple.Size = New System.Drawing.Size(15, 15)
        Me.apple.TabIndex = 2
        Me.apple.TabStop = False
        Me.apple.Visible = False
        '
        'snakehead
        '
        Me.snakehead.BackColor = System.Drawing.Color.Transparent
        Me.snakehead.Image = Global.snake.My.Resources.Resources.snakeright
        Me.snakehead.Location = New System.Drawing.Point(120, 180)
        Me.snakehead.Name = "snakehead"
        Me.snakehead.Size = New System.Drawing.Size(15, 15)
        Me.snakehead.TabIndex = 1
        Me.snakehead.TabStop = False
        Me.snakehead.Visible = False
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Font = New System.Drawing.Font("Book Antiqua", 51.75!, System.Drawing.FontStyle.Bold)
        Me.header.ForeColor = System.Drawing.Color.Black
        Me.header.Location = New System.Drawing.Point(238, 35)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(464, 82)
        Me.header.TabIndex = 6
        Me.header.Text = "Snake Xenzia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.snake.My.Resources.Resources.Reticular_Tissue_White_Seamless_Texture
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 594)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.picinstructn)
        Me.Controls.Add(Me.labellives)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.apple)
        Me.Controls.Add(Me.snakehead)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Handle me!!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picinstructn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.snakehead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TimerTime As Timer
    Friend WithEvents TimerMoveSnake As Timer
    Friend WithEvents snakehead As PictureBox
    Friend WithEvents apple As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents labellives As Label
    Friend WithEvents picinstructn As PictureBox
    Friend WithEvents header As Label
End Class
