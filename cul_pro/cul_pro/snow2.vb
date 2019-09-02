Public Class snow2
    Dim num, x(), y(), v(), s() As Integer
    Dim random As Random = New Random
    Dim graphics As System.Drawing.Graphics
    Dim rectangle As Rectangle
    Dim waitTime As Integer = 500 'ms
    Dim speed As Integer = 150 'ms
    Dim var = 0

    Dim printText As String = " U teched it up!!!! "
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        animationTimer.Enabled = True
        animationTimer.Interval = speed
        waitTimer.Interval = waitTime
        waitTimer.Enabled = True
        mylabel.Text = ""
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
        snow()
        Timer1.Start()
    End Sub
    Private Sub snow()
        num = 2000
        ReDim x(num - 1)
        ReDim y(num - 1)
        ReDim v(num - 1)
        ReDim s(num - 1)
        Dim i As Integer
        For i = 0 To num - 1
            Insnow(i)
        Next
    End Sub
    Private Sub Insnow(ByVal i As Integer)
        x(i) = random.Next(0, Me.Width - 1)
        y(i) = random.Next(0, Me.Height * 5 / 7)
        v(i) = random.Next(5, 20)
        s(i) = (random.Next(1, 3) * 100 + random.Next(50, 200)) / 100
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static i As Integer
        For i = 0 To num - 1
            y(i) = y(i) + v(i)
            If y(i) = Me.Height Then
                Insnow(i)
            End If
        Next
        Invalidate()
        If Not var > 100 Then
            var = var + 1
        Else Timer1.Stop()
            Me.Hide()
            level3.ShowDialog()
        End If
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        graphics = e.Graphics
        Dim i As Integer
        Dim j As Integer
        For i = 0 To num - 1
            For j = 1 To 5



                Dim newColor As Color = Color.FromArgb(random.Next(0, 256), random.Next(0.256), random.Next(0, 256))
                Dim myBrush As New SolidBrush(newColor)
                graphics.FillEllipse(myBrush, x(i), y(i), s(i), s(i))
            Next
        Next
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
    End Sub



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub waitTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waitTimer.Tick
        waitTimer.Enabled = False
        animationTimer.Enabled = True
    End Sub
    Private Sub animationTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles animationTimer.Tick
        mylabel.Text += printText.Substring(mylabel.Text.Length, 1)
        If mylabel.Text = printText Then animationTimer.Enabled = False
        '  MyPictureBox.Location = New Point(MyPictureBox.Location.X, MyPictureBox.Location.Y + 1)
        '  If MyPictureBox.Location.Y = 205 Then animationTimer.Enabled = False
    End Sub
End Class