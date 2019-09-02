Imports System.IO
Public Class level3
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Public a As Integer
    Dim newpos As Point
    Dim lvl1 = True
    Dim lvl2 = True
    Dim maze3 = True
    Dim bns1 = True
    Dim bns2 = True
    Private Sub check()
        Dim allButHeader = From lbl In Panel1.Controls.OfType(Of Label)()
                           Where lbl.Name <> "picmain"
        For Each lbl As Label In allButHeader
            If (lbl.Bounds.IntersectsWith(picmain.Bounds)) Or (picmain.Location.Y <= 0) Then
                lblscore.Text = Val(lblscore.Text) - 2
                write()
                'MessageBox.Show("SORRY")
                'Me.Hide()


                level3_1.Show()
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
        If bns2 = True Then
            check_bns2()
        End If
    End Sub
    Private Sub check_frs()

        ' frst game collision
        If (pclvl3_1.Bounds.IntersectsWith(picmain.Bounds)) Then
            write()
            lvl1 = False
            pclvl3_1.Visible = False
            pclvl3_2.Visible = True
            My.Forms.level3_1.pclvl31_1.Visible = False
            My.Forms.level3_1.pclvl31_2.Visible = True

            Me.Controls.Remove(pclvl3_1)
            pclvl3_1 = Nothing



            Dim word As New Wordoku.Form1
            word.Show()

        End If


    End Sub
    Private Sub check_sec()
        'second game collision
        If (pclvl3_2.Bounds.IntersectsWith(picmain.Bounds)) Then
            write()
            lvl2 = False
            PictureBox3.Visible = False
            pclvl3_2.Visible = False
            lblexit.Visible = True

            PictureBox1.BackColor = Color.Transparent

            My.Forms.level3_1.pclvl31_2.Visible = False




            Me.Controls.Remove(pclvl3_2)
            pclvl3_2 = Nothing

            Dim snake As New snake.Form1
            snake.Show()


        End If


    End Sub
    Private Sub check_thrd()
        'finish collision
        If (PictureBox3.Bounds.IntersectsWith(picmain.Bounds)) Then
            write()
            timermaze3.Stop()
            maze3 = False


            Me.Controls.Remove(PictureBox3)
            PictureBox3 = Nothing

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
    Private Sub check_bns2()
        If (bonus2.Bounds.IntersectsWith(picmain.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns2 = False
            bonus2.Visible = False
            Me.Controls.Remove(bonus2)
            bonus2 = Nothing

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        read()
        Timer1.Start()
        timermaze3.Start()

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '    'lbltemp.BackColor = Label22.BackColor
        '    'Label22.BackColor = lbltemp2.BackColor
        '    'lbltemp2.BackColor = lbltemp.BackColor
        If (Label22.Visible = True) Then
            Label22.Visible = False
        ElseIf (Label22.Visible = False) Then
            Label22.Visible = True
        End If

        If (Label24.Visible = True) Then
            Label24.Visible = False
        ElseIf (Label24.Visible = False) Then
            Label24.Visible = True
        End If
        If (Label35.Visible = True) Then
            Label35.Visible = False
        ElseIf (Label35.Visible = False) Then
            Label35.Visible = True
        End If

    End Sub

    Private Sub timermaze3_Tick(sender As Object, e As EventArgs) Handles timermaze3.Tick
        read()
        write()
        timermaze3.Enabled = True
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