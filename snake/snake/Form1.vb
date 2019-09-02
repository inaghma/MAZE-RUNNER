Imports System.IO

Public Class Form1
    Dim score As Integer = 0
    Dim sec As Integer = 59
    Dim min As Integer = 4
    Dim applex As Integer
    Dim appley As Integer
    Dim snakeup As Boolean = False
    Dim snakedown As Boolean = False
    Dim snakeleft As Boolean = False
    Dim snakeright As Boolean = True
    Dim extrabody As Integer = 5
    Dim x As Integer
    Dim snakebody(200) As PictureBox
    Dim pause As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim file As StreamReader
        file = New StreamReader("C:\game\score.txt")
        score = Integer.Parse(file.ReadLine)
        file.Close()
        'lblsec.Text = Integer.Parse(file.ReadLine)
        file = New StreamReader("C:\game\lives.txt")
        labellives.Text = Integer.Parse(file.ReadLine)
        '   LabelLabellives.text.Text = Labellives.text
        file.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        begin()
        TimerTime.Enabled = True
        TimerMoveSnake.Enabled = True

    End Sub
    Private Sub begin()
        apple.Visible = True
        snakehead.Visible = True
        Label1.Visible = False
        labellives.Visible = False
        picinstructn.Visible = False
        Button1.Visible = False
        header.Visible = False
        Me.Focus()
        Newapple()
        For Me.x = 1 To extrabody
            snakebody(x) = New PictureBox()
            snakebody(x).Image = My.Resources.snake__15x15_


            snakebody(x).Width = 15
            snakebody(x).Height = 15
            snakebody(x).BackColor = Color.Transparent
            snakebody(x).Left = 120 - (15 * x)
            snakebody(x).Top = 180
            snakebody(x).SizeMode = PictureBoxSizeMode.StretchImage
            Controls.Add(snakebody(x))
        Next


    End Sub
    Private Sub Newapple()
        Randomize()

        appley = Rnd() * 24
        applex = Rnd() * 24

        apple.Location = New Point(applex * 15, appley * 15)

    End Sub

    Private Sub TimerTime_Tick(sender As Object, e As EventArgs) Handles TimerTime.Tick
        sec -= 1
        If (sec = -1) Then
            sec = 59
            min -= 1

        End If
        If (min = 0 And sec = 0) Then
            TimerMoveSnake.Enabled = False
            TimerTime.Enabled = False


            MessageBox.Show(" You Did it!!")
            Dim file As StreamWriter
            file = New StreamWriter("C:\game\score.txt")
            file.WriteLine(score)
            file.Close()
            file = New StreamWriter("C:\game\lives.txt")
            file.WriteLine(labellives.Text)
            file.Close()
            Me.Hide()

        End If

    End Sub

    Private Sub TimerMoveSnake_Tick(sender As Object, e As EventArgs) Handles TimerMoveSnake.Tick
        Movesnake()
        Me.Text = "Score: " & score & ", Time: " & min & ":" & sec & ", "

    End Sub
    Private Sub Movesnake()
        snakebody(1).Location = snakehead.Location

        If snakeup = True Then
            snakehead.Top += -15
        End If
        If snakedown = True Then
            snakehead.Top += 15
        End If
        If snakeright = True Then
            snakehead.Left += 15
        End If
        If snakeleft = True Then
            snakehead.Left += -15
        End If
        x = extrabody
        Do Until snakebody(2).Location = snakebody(1).Location
            snakebody(x).Location = snakebody(x - 1).Location
            x -= 1
        Loop

        checkapple()
        snakebody(extrabody).Visible = True
        checkcollision()
    End Sub
    Private Sub checkcollision()
        For Me.x = 1 To extrabody
            If snakebody(x).Location = snakehead.Location Then
                Hitbody()
            End If
        Next
        If snakehead.Left = Me.ClientRectangle.Left Or snakehead.Top = Me.ClientRectangle.Top Or snakehead.Top + snakehead.Height = Me.ClientRectangle.Top + Me.ClientRectangle.Height Or snakehead.Left + snakehead.Width = Me.ClientRectangle.Left + Me.ClientRectangle.Width Or snakehead.Left + snakehead.Width = Me.ClientRectangle.Left + Me.ClientRectangle.Width Then
            hitwall()
        End If

    End Sub

    Private Sub hitwall()
        If (labellives.Text = 0) Then
            MessageBox.Show(" You collided with the wall ...")
            MessageBox.Show("GAME OVER")
            Dim file As StreamWriter
            file = New StreamWriter("C:\game\score.txt")
            file.WriteLine(score)
            file.Close()
            file = New StreamWriter("C:\game\lives.txt")
            file.WriteLine(labellives.Text)
            file.Close()
            '  LabelLabellives.text.Text = Labellives.Text
            TimerMoveSnake.Stop()
            TimerTime.Stop()
            Me.Hide()
            ' Application.Restart()
        Else
            labellives.Text -= 1
            Dim file As StreamWriter

            file = New StreamWriter("C:\game\lives.txt")
            file.WriteLine(labellives.Text)
            file.Close()
            ' LabelLabellives.text.Text = Labellives.Text
            Me.Hide()
            Dim snake As New Form1
            snake.ShowDialog()
            'Application.Restart()
        End If



    End Sub

    Private Sub Hitbody()
        TimerTime.Enabled = False
        TimerMoveSnake.Enabled = False



        If (labellives.Text = 0) Then
            Dim file As StreamWriter
            file = New StreamWriter("C:\game\score.txt")
            file.WriteLine(score)
            file.Close()
            file = New StreamWriter("C:\game\lives.txt")
            file.WriteLine(labellives.Text)
            file.Close()
            ' LabelLabellives.text.Text = Labellives.Text
            ' Application.Restart()
            MessageBox.Show("You Collided With The Yourself")
            MessageBox.Show("GAME OVER")
            TimerMoveSnake.Stop()
            TimerTime.Stop()
            Me.Hide()
        Else
            labellives.Text -= 1
            Dim file As StreamWriter
            file = New StreamWriter("C:\game\lives.txt")
            file.WriteLine(labellives.Text)
            file.Close()
            Me.Hide()
            'LabelLabellives.text.Text = Labellives.Text
            Dim snake As New Form1
            snake.ShowDialog()
        End If


    End Sub


    Private Sub checkapple()
        If snakehead.Location = apple.Location Then
            appleeaten()
        End If

    End Sub
    Private Sub appleeaten()
        Newapple()
        score += 10
        extrabody += 1
        snakebody(extrabody) = New PictureBox()
        snakebody(extrabody).Image = My.Resources.snake__15x15_

        snakebody(extrabody).Width = 15
        snakebody(extrabody).Height = 15
        snakebody(extrabody).BackColor = Color.Transparent
        snakebody(extrabody).SizeMode = PictureBoxSizeMode.StretchImage
        snakebody(extrabody).Visible = False
        Controls.Add(snakebody(extrabody))

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Right And snakeleft = False Then
            snakeright = True
            snakeup = False
            snakedown = False
            snakehead.Image = My.Resources.snakeright
        End If
        If e.KeyValue = Keys.Left And snakeright = False Then
            snakeleft = True
            snakeup = False
            snakedown = False
            snakehead.Image = My.Resources.snakeleft
        End If
        If e.KeyValue = Keys.Up And snakedown = False Then
            snakeup = True
            snakeleft = False
            snakeright = False
            snakehead.Image = My.Resources.snakeup
        End If
        If e.KeyValue = Keys.Down And snakeup = False Then
            snakedown = True
            snakeleft = False
            snakeright = False
            snakehead.Image = My.Resources.snakedown
        End If

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
            Return
        End If
        If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub
End Class
