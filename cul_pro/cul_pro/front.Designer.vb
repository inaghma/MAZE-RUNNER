<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class front
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sitka Small", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(523, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(263, 106)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 62.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(90, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1101, 94)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department of Computer Science"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poor Richard", 62.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(475, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 94)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "presents"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poor Richard", 62.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(344, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(592, 94)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MAZE  RUNNER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poor Richard", 62.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(285, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 94)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "||"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poor Richard", 62.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(923, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 94)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "||"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'front
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.BackgroundImage = Global.cul_pro.My.Resources.Resources.resembling_the_surface_of_a_wooden_wall_paneling_foc1gs459wrmvo9d1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 589)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "front"
        Me.Text = "Welcome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
