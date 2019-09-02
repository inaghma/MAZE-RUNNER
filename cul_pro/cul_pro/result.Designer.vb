<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class result
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
        Me.lblscore = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.BackColor = System.Drawing.Color.Transparent
        Me.lblscore.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(757, 436)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(0, 57)
        Me.lblscore.TabIndex = 20
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(392, 436)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(315, 57)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Final Score :"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.BackColor = System.Drawing.Color.Transparent
        Me.lblsec.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(838, 351)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(0, 57)
        Me.lblsec.TabIndex = 18
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(786, 353)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 57)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = ":"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.BackColor = System.Drawing.Color.Transparent
        Me.lblmin.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.Location = New System.Drawing.Point(723, 351)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(0, 57)
        Me.lblmin.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 86.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1290, 150)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Thank you for playing : )"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 57)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Finish Time :"
        '
        'result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.cul_pro.My.Resources.Resources.AW9YjSS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1193, 596)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.lblsec)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.lblmin)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "result"
        Me.Text = "SCOREBOARD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblscore As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblsec As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lblmin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
