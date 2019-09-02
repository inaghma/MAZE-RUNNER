
Imports System.IO
Public Class level1
    Dim score = 0


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
    Dim bns1 = True
    Dim bns2 = True
    Dim maze2 = True


    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label35.Click, Label34.Click

    End Sub
    'moving the green box
    Private Sub level1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        Select Case e.KeyCode
            Case Keys.Up
                newpos.Y = picgreen.Location.Y - 5
                newpos.X = picgreen.Location.X
                picgreen.Image = My.Resources.Fred1right
            Case Keys.Left
                newpos.Y = picgreen.Location.Y
                newpos.X = picgreen.Location.X - 5
                picgreen.Image = My.Resources.fred11
            Case Keys.Down
                newpos.Y = picgreen.Location.Y + 5
                newpos.X = picgreen.Location.X
                picgreen.Image = My.Resources.Fred1right
            Case Keys.Right
                newpos.Y = picgreen.Location.Y
                newpos.X = picgreen.Location.X + 5
                picgreen.Image = My.Resources.Fred1right


        End Select
        picgreen.Location = newpos
        ' read()
        '  write()
        check()
        If lvl1 = True Then
            check_frs()
        End If
        If lvl2 = True Then
            check_sec()
        End If
        If maze2 = True Then
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
        If (PictureBox2.Bounds.IntersectsWith(picgreen.Bounds)) Then
            write()
            lvl1 = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            Me.Controls.Remove(PictureBox2)
            PictureBox2 = Nothing

            ' Me.Hide()
            Dim timelin As New timeline.time
            timelin.ShowDialog()
            'write()




        End If


    End Sub
    Private Sub check_sec()
        'second game collision
        If (PictureBox3.Bounds.IntersectsWith(picgreen.Bounds)) Then
            write()
            lvl2 = False
            ' PictureBox4.Enabled = True

            PictureBox3.Visible = False
            PictureBox4.BackColor = Color.Transparent
            Me.Controls.Remove(PictureBox3)
            PictureBox3 = Nothing
            lblexit.Visible = True
            Dim obj As New object_find.find_stuff
            obj.Show()

        End If


    End Sub
    Private Sub check_thrd()
        'third game collision
        If (PictureBox4.Bounds.IntersectsWith(picgreen.Bounds)) Then
            write()
            timermaze1.Stop()

            maze2 = False


            Me.Controls.Remove(PictureBox3)
            PictureBox3 = Nothing
            Me.Hide()
            snow1.ShowDialog()


        End If


    End Sub

    'collision with walls and the wall of the panel
    Private Sub check()
        Dim allButHeader = From lbl In Panel1.Controls.OfType(Of Label)()
                           Where lbl.Name <> "picgreen"
        For Each lbl As Label In allButHeader
            If (lbl.Bounds.IntersectsWith(picgreen.Bounds)) Or (picgreen.Location.Y <= 0) Then
                'MessageBox.Show("SORRY")
                picgreen.Location = PictureBox1.Location()

            End If

        Next
        'For Each lbl As Label In {La55, Label50, Label36}
        '    With lbl
        '        If (lbl.Bounds.IntersectsWith(picgreen.Bounds)) Then
        '            MessageBox.Show("SORRY")
        '        End If
        '    End With
        'Next
    End Sub
    Private Sub check_bns1()
        If (bonus1.Bounds.IntersectsWith(picgreen.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns1 = False
            bonus1.Visible = False
            Me.Controls.Remove(bonus1)
            bonus1 = Nothing

        End If
    End Sub
    Private Sub check_bns2()
        If (bonus2.Bounds.IntersectsWith(picgreen.Bounds)) Then

            lblscore.Text = Val(lblscore.Text) + 10
            write()
            bns2 = False
            bonus2.Visible = False
            Me.Controls.Remove(bonus2)
            bonus2 = Nothing

        End If
    End Sub

    Private Sub level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblmin.Text = 0
        lblscore.Text = 00
        lblsec.Text = 0
        write()
        timermaze1.Start()
    End Sub

    Private Sub timermaze1_Tick(sender As Object, e As EventArgs) Handles timermaze1.Tick
        read()
        write()
        timermaze1.Enabled = True
        lblsec.Text += 1
        If (lblsec.Text = 59) Then

            lblsec.Text = 0
            lblmin.Text += 1


        End If
        write()
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

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
