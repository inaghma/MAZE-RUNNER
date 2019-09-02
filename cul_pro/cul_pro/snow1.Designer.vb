<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class snow1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.animationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.waitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mylabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'mylabel
        '
        Me.mylabel.AutoSize = True
        Me.mylabel.BackColor = System.Drawing.Color.Transparent
        Me.mylabel.Font = New System.Drawing.Font("Chiller", 108.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mylabel.ForeColor = System.Drawing.Color.Orange
        Me.mylabel.Location = New System.Drawing.Point(84, 29)
        Me.mylabel.Name = "mylabel"
        Me.mylabel.Size = New System.Drawing.Size(346, 166)
        Me.mylabel.TabIndex = 0
        Me.mylabel.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cul_pro.My.Resources.Resources.snow_character1
        Me.PictureBox1.Location = New System.Drawing.Point(332, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 439)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'snow1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1169, 608)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mylabel)
        Me.Name = "snow1"
        Me.Text = "Good Job !!!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents animationTimer As Timer
    Friend WithEvents waitTimer As Timer
    Friend WithEvents mylabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
