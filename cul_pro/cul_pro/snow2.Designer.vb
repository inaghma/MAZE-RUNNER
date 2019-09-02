<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class snow2
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
        Me.mylabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.waitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'mylabel
        '
        Me.mylabel.AutoSize = True
        Me.mylabel.BackColor = System.Drawing.Color.Transparent
        Me.mylabel.Font = New System.Drawing.Font("Tempus Sans ITC", 108.0!, System.Drawing.FontStyle.Bold)
        Me.mylabel.ForeColor = System.Drawing.Color.PapayaWhip
        Me.mylabel.Location = New System.Drawing.Point(70, 355)
        Me.mylabel.Name = "mylabel"
        Me.mylabel.Size = New System.Drawing.Size(453, 188)
        Me.mylabel.TabIndex = 1
        Me.mylabel.Text = "Label1"
        '
        'Timer1
        '
        '
        'animationTimer
        '
        '
        'waitTimer
        '
        '
        'snow2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.cul_pro.My.Resources.Resources._3839665_medieval_knight_by_lijinbo781
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1335, 741)
        Me.Controls.Add(Me.mylabel)
        Me.Name = "snow2"
        Me.Text = "Good Job!!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mylabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents animationTimer As Timer
    Friend WithEvents waitTimer As Timer
End Class
