Imports System.IO

Public Class time
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private dragging As Boolean
    Private beginX, beginY As Integer
    Private Sub picdrive_MouseDown(sender As Object, e As MouseEventArgs) Handles picdrive.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picdrive_MouseMove(sender As Object, e As MouseEventArgs) Handles picdrive.MouseMove
        If dragging = True Then
            picdrive.Location = New Point(picdrive.Location.X + e.X - beginX, picdrive.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picdrive_MouseUp(sender As Object, e As MouseEventArgs) Handles picdrive.MouseUp
        dragging = False
        picdrive.BringToFront()
    End Sub
    Private Sub picskype_MouseDown(sender As Object, e As MouseEventArgs) Handles picskype.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picskype_MouseMove(sender As Object, e As MouseEventArgs) Handles picskype.MouseMove
        If dragging = True Then
            picskype.Location = New Point(picskype.Location.X + e.X - beginX, picskype.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picskype_MouseUp(sender As Object, e As MouseEventArgs) Handles picskype.MouseUp
        dragging = False
        picskype.BringToFront()
    End Sub
    Private Sub pichotmail_MouseDown(sender As Object, e As MouseEventArgs) Handles pichotmail.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub pichotmail_MouseMove(sender As Object, e As MouseEventArgs) Handles pichotmail.MouseMove
        If dragging = True Then
            pichotmail.Location = New Point(pichotmail.Location.X + e.X - beginX, pichotmail.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub pichotmail_MouseUp(sender As Object, e As MouseEventArgs) Handles pichotmail.MouseUp
        dragging = False
        pichotmail.BringToFront()
    End Sub
    Private Sub picppt_MouseDown(sender As Object, e As MouseEventArgs) Handles picppt.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picppt_MouseMove(sender As Object, e As MouseEventArgs) Handles picppt.MouseMove
        If dragging = True Then
            picppt.Location = New Point(picppt.Location.X + e.X - beginX, picppt.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picppt_MouseUp(sender As Object, e As MouseEventArgs) Handles picppt.MouseUp
        dragging = False
        picppt.BringToFront()
    End Sub
    Private Sub picsurface_MouseDown(sender As Object, e As MouseEventArgs) Handles picsurface.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picsurface_MouseMove(sender As Object, e As MouseEventArgs) Handles picsurface.MouseMove
        If dragging = True Then
            picsurface.Location = New Point(picsurface.Location.X + e.X - beginX, picsurface.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picsurface_MouseUp(sender As Object, e As MouseEventArgs) Handles picsurface.MouseUp
        dragging = False
        picsurface.BringToFront()
    End Sub
    Private Sub picmsword_MouseDown(sender As Object, e As MouseEventArgs) Handles picword.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picword_MouseMove(sender As Object, e As MouseEventArgs) Handles picword.MouseMove
        If dragging = True Then
            picword.Location = New Point(picword.Location.X + e.X - beginX, picword.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picword_MouseUp(sender As Object, e As MouseEventArgs) Handles picword.MouseUp
        dragging = False
        picword.BringToFront()
    End Sub
    Private Sub picxbox_MouseDown(sender As Object, e As MouseEventArgs) Handles picxbox.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picxbox_MouseMove(sender As Object, e As MouseEventArgs) Handles picxbox.MouseMove
        If dragging = True Then
            picxbox.Location = New Point(picxbox.Location.X + e.X - beginX, picxbox.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picxbox_MouseUp(sender As Object, e As MouseEventArgs) Handles picxbox.MouseUp
        dragging = False
        picxbox.BringToFront()
    End Sub
    Private Sub picmsn_MouseDown(sender As Object, e As MouseEventArgs) Handles picmsn.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picmsn_MouseMove(sender As Object, e As MouseEventArgs) Handles picmsn.MouseMove
        If dragging = True Then
            picmsn.Location = New Point(picmsn.Location.X + e.X - beginX, picmsn.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If ((pichotmail.Bounds.IntersectsWith(Panel2.Bounds)) And (picskype.Bounds.IntersectsWith(Panel3.Bounds)) And (picdrive.Bounds.IntersectsWith(Panel4.Bounds))) Then
            lblscore.Text = Val(lblscore.Text) + 30
            Panel1.Enabled = False
            Panel5.Visible = True



        End If
    End Sub

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        If txtans.Text = UCase("microsoft") Or txtans.Text = LCase("MICROSOFT") Then
            lblscore.Text = Val(lblscore.Text) + 10
            write()
            timermaze1.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub time_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        read()
        timermaze1.Start()
    End Sub

    Private Sub timermaze1_Tick(sender As Object, e As EventArgs) Handles timermaze1.Tick
        lblsec.Text += 1
        If (lblsec.Text = 59) Then

            lblsec.Text = 0
            lblmin.Text += 1


        End If
    End Sub
    Private Sub read()



        Dim file As StreamReader
        file = New StreamReader("C:\game\score.txt")
        lblscore.Text = Integer.Parse(file.ReadLine)
        file.Close()
        '  Dim file As StreamReader
        file = New StreamReader("C:\game\min.txt")
        lblmin.Text = Integer.Parse(file.ReadLine)
        file.Close()
        ' Dim file As StreamReader
        file = New StreamReader("C:\game\sec.txt")
        lblsec.Text = Integer.Parse(file.ReadLine)
        file.Close()
    End Sub
    Private Sub write()
        Dim file As StreamWriter
        file = New StreamWriter("C:\game\score.txt")
        file.WriteLine(Val(lblscore.Text))
        file.Close()
        file = New StreamWriter("C:\game\sec.txt")
        file.WriteLine(Val(lblsec.Text))
        file.Close()
        file = New StreamWriter("C:\game\min.txt")
        file.WriteLine(Val(lblmin.Text))
        file.Close()
    End Sub

    Private Sub picmsn_MouseUp(sender As Object, e As MouseEventArgs) Handles picmsn.MouseUp
        dragging = False
        picmsn.BringToFront()
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