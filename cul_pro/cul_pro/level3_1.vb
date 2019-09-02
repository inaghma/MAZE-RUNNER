Imports System.IO

Public Class level3_1

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Dim newpos As Point
    Dim lvl1 = True
    Dim lvl2 = True
    Dim maze3 = True
    Dim bns1 = True
    Dim i As Integer
    Private Sub check()
        Dim allButHeader = From lbl In Panel1.Controls.OfType(Of Label)()
                           Where lbl.Name <> "picmain"
        For Each lbl As Label In allButHeader
            If (lbl.Bounds.IntersectsWith(picmain.Bounds)) Or (picmain.Location.Y <= 0) Then
                lblscore.Text = Val(lblscore.Text) - 2
                write()
                'MessageBox.Show("SORRY")

                Me.Hide()

                level3.Show()

                picmain.Location = PictureBox1.Location()

            End If

        Next
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                newpos.Y = picmain.Location.Y - 5
                newpos.X = picmain.Location.X
                picmain.Image = My.Resources.marioface
            Case Keys.Left
                newpos.Y = picmain.Location.Y
                newpos.X = picmain.Location.X - 5
                picmain.Image = My.Resources.marioface
            Case Keys.Down
                newpos.Y = picmain.Location.Y + 5
                newpos.X = picmain.Location.X
                picmain.Image = My.Resources.marioface
            Case Keys.Right
                newpos.Y = picmain.Location.Y
                newpos.X = picmain.Location.X + 5
                picmain.Image = My.Resources.marioface


        End Select
        picmain.Location = newpos
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
    End Sub
    Private Sub check_frs()

        ' frst game collision
        If (pclvl31_1.Bounds.IntersectsWith(picmain.Bounds)) Then
            write()
            lvl1 = False
            pclvl31_1.Visible = False
            pclvl31_2.Visible = True
            My.Forms.level3.pclvl3_1.Visible = False
            My.Forms.level3.pclvl3_2.Visible = True

            Me.Controls.Remove(pclvl31_1)
            pclvl31_1 = Nothing



            Dim word As New Wordoku.Form1
            word.ShowDialog()

        End If


    End Sub
    Private Sub check_sec()
        'second game collision
        If (pclvl31_2.Bounds.IntersectsWith(picmain.Bounds)) Then
            write()


            lvl2 = False

            pclvl31_2.Visible = False
            My.Forms.level3.pclvl3_2.Visible = False
            My.Forms.level3.PictureBox3.Visible = False
            lblexit.Visible = True
            My.Forms.level3.lblexit.Visible = True
            Me.Controls.Remove(pclvl31_2)
            pclvl31_2 = Nothing
            'Me.Hide()
            Dim snake As New snake.Form1
            snake.ShowDialog()


        End If


    End Sub
    Private Sub check_thrd()
        'finish collision
        If (PictureBox4.Bounds.IntersectsWith(picmain.Bounds)) Then
            write()
            timermaze3_1.Stop()

            maze3 = False


            Me.Controls.Remove(PictureBox4)
            PictureBox4 = Nothing
            Me.Hide()
            result.Show()



        End If
    End Sub
    Private Sub check_bns1()
        If (bonus1.Bounds.IntersectsWith(picmain.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns1 = False
            bonus1.Visible = False
            Me.Controls.Remove(bonus1)
            bonus1 = Nothing

        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        picmain.Location = PictureBox1.Location

        read()
        timermaze3_1.Start()

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

    Private Sub timermaze3_1_Tick(sender As Object, e As EventArgs) Handles timermaze3_1.Tick

        timermaze3_1.Enabled = True
        lblsec.Text += 1
        If (lblsec.Text = 59) Then

            lblsec.Text = 0
            lblmin.Text += 1


        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picinstruct.Click

    End Sub

    Private Sub picmain_Click(sender As Object, e As EventArgs) Handles picmain.Click

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