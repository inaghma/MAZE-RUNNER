Imports System.IO

Public Class find_stuff
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Dim i = 0
    Dim j = 0
    Dim k = 0
    Private this As Object

    Private Sub picradio_Click(sender As Object, e As EventArgs) Handles picradio.Click
        lblradio.Visible = False
        picradio.Visible = False
        Me.Controls.Remove(lblradio)
        lblradio = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        'j = 0
        'Label2.Text = j
        k += 1
        checkpanel()
    End Sub

    Private Sub picfish_Click(sender As Object, e As EventArgs) Handles picfish.Click
        lblfish.Visible = False
        picfish.Visible = False
        Me.Controls.Remove(lblfish)
        lblfish = Nothing

        lblscore.Text = Val(lblscore.Text) + 10
        'j = 0
        'Label2.Text = j
        k += 1
        checkpanel()
    End Sub

    Private Sub piceggs_Click(sender As Object, e As EventArgs) Handles piceggs.Click
        lbleggs.Visible = False
        piceggs.Visible = False
        Me.Controls.Remove(lbleggs)
        lbleggs = Nothing

        lblscore.Text = Val(lblscore.Text) + 10
        'j = 0
        ' Label2.Text = j
        k += 1
        checkpanel()
    End Sub

    Private Sub picgift_Click(sender As Object, e As EventArgs) Handles picgift.Click
        lblgift.Visible = False
        picgift.Visible = False
        Me.Controls.Remove(lblgift)
        lblgift = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picletterblcks_Click(sender As Object, e As EventArgs) Handles picletterblcks.Click
        lblletterblocks.Visible = False
        picletterblcks.Visible = False
        Me.Controls.Remove(lblletterblocks)
        lblletterblocks = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        'Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picmoney_Click(sender As Object, e As EventArgs) Handles picmoney.Click
        lblmoney.Visible = False
        picmoney.Visible = False
        Me.Controls.Remove(lblmoney)
        lblmoney = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picbrush_Click(sender As Object, e As EventArgs) Handles picbrush.Click
        lblclothbrush.Visible = False
        picbrush.Visible = False
        Me.Controls.Remove(lblclothbrush)
        lblclothbrush = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        '  j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picclock_Click(sender As Object, e As EventArgs) Handles picclock.Click
        lblclock.Visible = False
        picclock.Visible = False
        Me.Controls.Remove(lblclock)
        lblclock = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub pic25_Click(sender As Object, e As EventArgs) Handles pic25.Click
        lbl25.Visible = False
        pic25.Visible = False
        Me.Controls.Remove(lbl25)
        lbl25 = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        '  j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picheart_Click(sender As Object, e As EventArgs) Handles picheart.Click
        lblheart.Visible = False
        picheart.Visible = False
        Me.Controls.Remove(lblheart)
        lblheart = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picrat_Click(sender As Object, e As EventArgs) Handles picrat.Click
        lblrat.Visible = False
        picrat.Visible = False
        Me.Controls.Remove(lblrat)
        lblrat = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        '  j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub mainpic_Click(sender As Object, e As EventArgs) Handles mainpic.Click
        j += 1
        Label2.Text = j
        If Val(Label2.Text) = 5 Then
            lblscore.Text = Val(lblscore.Text) - 10
            j = 0
            Label2.Text = j
        End If
    End Sub

    Private Sub picskates_Click(sender As Object, e As EventArgs) Handles picskates.Click
        lblskates.Visible = False
        picskates.Visible = False
        Me.Controls.Remove(lblskates)
        lblskates = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        'j = 0
        'Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub picscent_Click(sender As Object, e As EventArgs) Handles picscent.Click
        lblscent.Visible = False
        picscent.Visible = False
        Me.Controls.Remove(lblscent)
        lblscent = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        ' Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub pishorseshoe_Click(sender As Object, e As EventArgs) Handles pishorseshoe.Click
        lblhorseshoe.Visible = False
        pishorseshoe.Visible = False
        Me.Controls.Remove(lblhorseshoe)
        lblhorseshoe = Nothing
        lblscore.Text = Val(lblscore.Text) + 10
        ' j = 0
        'Label2.Text = j

        k += 1
        checkpanel()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub find_stuff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        read()
        timerfindstuff.Start()
    End Sub

    Private Sub timerfindstuff_Tick(sender As Object, e As EventArgs) Handles timerfindstuff.Tick
        lblsec.Text += 1
        If (lblsec.Text = 59) Then

            lblsec.Text = 0
            lblmin.Text += 1


        End If
    End Sub
    Private Sub checkpanel()
        'Dim lbls = From ctrl In Panel2.Controls.OfType(Of Label)()


        If (k = 14) Then
            timerfindstuff.Stop()
            write()
            Me.Hide()
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