Imports System.IO
Public Class level2

    Dim file As StreamWriter


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Dim newpos As Point '
    Dim lvl1 = True
    Dim lvl2 = True
    Dim bns1 = True
    Dim bns2 = True
    Dim bns3 = True

    Dim maze3 = True
    Private Sub level2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                newpos.Y = picblue.Location.Y - 5
                newpos.X = picblue.Location.X
                picblue.Image = My.Resources.mmmmmmm
            Case Keys.Left
                newpos.Y = picblue.Location.Y
                newpos.X = picblue.Location.X - 5
                picblue.Image = My.Resources.mmmmmmm

            Case Keys.Down
                newpos.Y = picblue.Location.Y + 5
                newpos.X = picblue.Location.X
                picblue.Image = My.Resources.mmmmmmm
            Case Keys.Right
                newpos.Y = picblue.Location.Y
                newpos.X = picblue.Location.X + 5
                picblue.Image = My.Resources.mmmmmmm


        End Select
        picblue.Location = newpos
        check()
        If lvl1 = True Then
            check_frs()
        End If
        If lvl2 = True Then
            check_sec()
        End If
        If maze3 = True Then
            check_thrd()
        End If
        If bns1 = True Then
            check_bns1()
        End If
        If bns2 = True Then
            check_bns2()
        End If
        If bns3 = True Then
            check_bns3()

        End If
    End Sub
    Private Sub check_frs()

        ' frst game collision
        If (PictureBox3.Bounds.IntersectsWith(picblue.Bounds)) Then
            write()
            lvl1 = False
            PictureBox3.Visible = False
            PictureBox2.Visible = True
            Me.Controls.Remove(PictureBox3)
            PictureBox3 = Nothing



            Dim reb As New Rebus_Game.rebus
            reb.ShowDialog()



        End If


    End Sub
    Private Sub check_sec()
        'second game collision
        If (PictureBox2.Bounds.IntersectsWith(picblue.Bounds)) Then
            write()
            lvl2 = False

            PictureBox2.Visible = False
            PictureBox1.BackColor = Color.Transparent
            Me.Controls.Remove(PictureBox2)
            PictureBox2 = Nothing

            lblexit.Visible = True
            Dim tet As New Tetris.tetrisgame
            tet.Show()



        End If


    End Sub
    Private Sub check_thrd()
        'finish collision
        If (PictureBox1.Bounds.IntersectsWith(picblue.Bounds)) Then
            write()
            timermaze2.Stop()
            maze3 = False


            Me.Controls.Remove(PictureBox3)
            PictureBox3 = Nothing
            Me.Hide()
            snow2.ShowDialog()
            write()


        End If


    End Sub

    Private Sub check()
        Dim allButHeader = From lbl In Panel1.Controls.OfType(Of Label)()
                           Where lbl.Name <> "picblue"
        For Each lbl As Label In allButHeader
            If (lbl.Bounds.IntersectsWith(picblue.Bounds)) Or (picblue.Location.X >= 559) Then

                picblue.Location = PictureBox4.Location()

            End If

        Next
    End Sub
    Private Sub check_bns1()
        If (bonus1.Bounds.IntersectsWith(picblue.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns1 = False
            bonus1.Visible = False
            Me.Controls.Remove(bonus1)
            bonus1 = Nothing

        End If
    End Sub
    Private Sub check_bns2()
        If (bonus2.Bounds.IntersectsWith(picblue.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns2 = False
            bonus2.Visible = False
            Me.Controls.Remove(bonus2)
            bonus2 = Nothing

        End If
    End Sub
    Private Sub check_bns3()
        If (bonus3.Bounds.IntersectsWith(picblue.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns3 = False
            bonus3.Visible = False
            Me.Controls.Remove(bonus3)
            bonus3 = Nothing

        End If
    End Sub

    'near the exit
    Private Sub topT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles topT.Tick
        lbltopmove.Top -= 3
        If lbltopmove.Top <= 45 Then
            topT.Enabled = False
            downT.Enabled = True
        End If
    End Sub

    Private Sub downT_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downT.Tick
        lbltopmove.Top += 3
        If lbltopmove.Top > 90 Then
            topT.Enabled = True
            downT.Enabled = False
        End If
    End Sub
    'near the game
    Private Sub leftT_Tick(sender As Object, e As EventArgs) Handles leftT.Tick
        lblsidemove.Left -= 3
        If lblsidemove.Left <= 50 Then
            rightT.Enabled = True
            leftT.Enabled = False
        End If
    End Sub

    Private Sub rightT_Tick(sender As Object, e As EventArgs) Handles rightT.Tick
        lblsidemove.Left += 3
        If lblsidemove.Left > 110 Then
            rightT.Enabled = False
            leftT.Enabled = True
        End If
    End Sub

    'simply to confuse
    Private Sub left2T_Tick(sender As Object, e As EventArgs) Handles left2T.Tick
        lblmoveside2.Left -= 3
        If lblmoveside2.Left <= 360 Then
            right2T.Enabled = True
            left2T.Enabled = False
        End If
    End Sub

    Private Sub right2T_Tick(sender As Object, e As EventArgs) Handles right2T.Tick
        lblmoveside2.Left += 3
        If lblmoveside2.Left > 435 Then
            right2T.Enabled = False
            left2T.Enabled = True
        End If
    End Sub

    Private Sub level2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        read()

        timermaze2.Start()
    End Sub
    Private Sub write()
        Dim file As StreamWriter
        file = New StreamWriter("C:\game\score.txt")
        file.WriteLine(lblscore.Text)
        file.Close()
        file = New StreamWriter("C:\game\sec.txt")
        file.WriteLine(lblsec.Text)
        file.Close()
        file = New StreamWriter("C:\game\min.txt")
        file.WriteLine(lblmin.Text)
        file.Close()
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

    Private Sub timermaze2_Tick(sender As Object, e As EventArgs) Handles timermaze2.Tick
        read()
        write()
        timermaze2.Enabled = True
        lblsec.Text += 1
        If (lblsec.Text = 59) Then

            lblsec.Text = 0
            lblmin.Text += 1


        End If
        write()
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
