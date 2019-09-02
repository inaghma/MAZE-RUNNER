Imports System.IO

Public Class rebus

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btncar.Click

        car()



    End Sub
    Private Sub car()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtcarans1, txtcarans2, txtcarans3}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("CAR") Or cccccc.Text = UCase("car") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel1.Visible = False
            Panel1.Enabled = False
            Panel2.Visible = True

        End If
    End Sub

    Private Sub btncrssbrd_Click(sender As Object, e As EventArgs) Handles btncrssbrd.Click
        crssbrd()

    End Sub
    Private Sub crssbrd()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtcrssbrdans1, txtcrssbrdans2, txtcrssbrdans3, txtcrssbrdans4, txtcrssbrdans5, txtcrssbrdans6, txtcrssbrdans7, txtcrssbrdans8, txtcrssbrdans9, txtcrssbrdans10}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("CROSSBREED") Or cccccc.Text = UCase("crossbreed") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel2.Visible = False
            Panel2.Enabled = False
            Panel3.Visible = True

        End If
    End Sub

    Private Sub btn4give4get_Click(sender As Object, e As EventArgs) Handles btn4give4get.Click

        FgetFgive()

    End Sub

    Private Sub FgetFgive()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txt4give4getans1, txt4give4getans2, txt4give4getans3, txt4give4getans4, txt4give4getans5, txt4give4getans6, txt4give4getans7, txt4give4getans8, txt4give4getans9, txt4give4getans10, txt4give4getans11, txt4give4getans12, txt4give4getans13, txt4give4getans14, txt4give4getans15, txt4give4getans16}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("FORGIVEANDFORGET") Or cccccc.Text = UCase("forgiveandforget") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel3.Visible = False
            Panel3.Enabled = False
            Panel4.Visible = True

        End If
    End Sub

    Private Sub btnsk8_Click(sender As Object, e As EventArgs) Handles btnsk8.Click
        sk8()

    End Sub
    Private Sub sk8()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtsk81, txtsk82, txtsk83, txtsk84, txtsk85, txtsk86, txtsk87, txtsk88, txtsk89, txtsk810, txtsk811, txtsk812}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("SKATEOVERICE") Or cccccc.Text = UCase("skateoverice") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel4.Visible = False
            Panel4.Enabled = False
            Panel5.Visible = True

        End If
    End Sub

    Private Sub btnbrkfst_Click(sender As Object, e As EventArgs) Handles btnbrkfst.Click
        brkfst()

    End Sub
    Private Sub brkfst()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtbrkfst1, txtbrkfst2, txtbrkfst3, txtbrkfst4, txtbrkfst5, txtbrkfst6, txtbrkfst7, txtbrkfst8, txtbrkfst9}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("BREAKFAST") Or cccccc.Text = UCase("breakfast") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel5.Visible = False
            Panel5.Enabled = False
            Panel7.Visible = True
        End If
    End Sub

    Private Sub btnstyovr_Click(sender As Object, e As EventArgs) Handles btnstyovr.Click
        styovr()

    End Sub
    Private Sub styovr()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtstyovr1, txtstyovr2, txtstyovr3, txtstyovr4, txtstyovr5, txtstyovr6, txtstyovr7, txtstyovr8, txtstyovr9, txtstyovr10, txtstyovr11, txtstyovr12, txtstyovr13}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("STAYOVERNIGHT") Or cccccc.Text = UCase("stayovernight") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel6.Visible = False
            Panel6.Enabled = False
            Panel7.Visible = True

        End If
    End Sub

    Private Sub btntrprnd_Click(sender As Object, e As EventArgs) Handles btntrprnd.Click
        trparnd()

    End Sub
    Private Sub trparnd()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtrpwrld1, txtrpwrld2, txtrpwrld3, txtrpwrld4, txtrpwrld5, txtrpwrld6, txtrpwrld7, txtrpwrld8, txtrpwrld9, txtrpwrld10, txtrpwrld11, txtrpwrld12, txtrpwrld13, txtrpwrld14, txtrpwrld15, txtrpwrld16, txtrpwrld17, txtrpwrld18}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("TRIPAROUNDTHEWORLD") Or cccccc.Text = UCase("triparoundtheworld") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel7.Visible = False
            Panel7.Enabled = False
            Panel9.Visible = True
        End If
    End Sub

    Private Sub btntrvlovr_Click(sender As Object, e As EventArgs) Handles btntrvlovr.Click
        trvlovr()

    End Sub
    Private Sub trvlovr()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txttrvlovr1, txttrvlovr2, txttrvlovr3, txttrvlovr4, txttrvlovr5, txttrvlovr6, txttrvlovr7, txttrvlovr8, txttrvlovr9, txttrvlovr10, txttrvlovr11, txttrvlovr12, txttrvlovr13, txttrvlovr14}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("TRAVELOVERSEAS") Or cccccc.Text = UCase("traveloverseas") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel8.Visible = False
            Panel8.Enabled = False
            Panel9.Visible = True
        End If
    End Sub

    Private Sub btnrbnhd_Click(sender As Object, e As EventArgs) Handles btnrbnhd.Click
        rbnhd()

    End Sub
    Private Sub rbnhd()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtrbnhd1, txtrbnhd2, txtrbnhd3, txtrbnhd4, txtrbnhd5, txtrbnhd6, txtrbnhd7, txtrbnhd8, txtrbnhd9}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("ROBINHOOD") Or cccccc.Text = UCase("robinhood") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel9.Visible = False
            Panel9.Enabled = False
            Panel10.Visible = True

        End If
    End Sub



    Private Sub btnwater_Click(sender As Object, e As EventArgs) Handles btnwater.Click
        water()

    End Sub
    Private Sub water()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtwater1, txtwater2, txtwater3, txtwater4, txtwater5}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("WATER") Or cccccc.Text = UCase("water") Then
            lblscore.Text = Val(lblscore.Text) + 10
            Panel10.Visible = False
            Panel10.Enabled = False
            Panel11.Visible = True

        End If
    End Sub

    Private Sub btnspace_Click(sender As Object, e As EventArgs) Handles btnspace.Click
        space()
        Me.Hide()
    End Sub
    Private Sub space()
        cccccc.Text = ""
        Dim MyListOfTextBoxes() As TextBox = {txtspace1, txtspace2, txtspace3, txtspace4, txtspace5}
        Dim i As Integer

        For i = 0 To MyListOfTextBoxes.Length - 1

            cccccc.Text = cccccc.Text + MyListOfTextBoxes(i).Text
        Next
        If cccccc.Text = LCase("SPACE") Or cccccc.Text = UCase("space") Or cccccc.Text = LCase("BLANK") Or cccccc.Text = UCase("blank") Or cccccc.Text = LCase("WHITE") Or cccccc.Text = UCase("white") Then
            lblscore.Text = Val(lblscore.Text) + 10


            write()
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub
    Private Sub rebus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        read()

        panel()
        textbox()
        Timer1.Start()
    End Sub
    Private Sub panel()
        Dim all = From pnl In Me.Controls.OfType(Of Panel)()


        For Each pnl As Panel In all
            pnl.Location = Panel1.Location

        Next
    End Sub
    Private Sub textbox()
        Dim text = From txt In Me.Controls.OfType(Of TextBox)()
        For Each txt As TextBox In text
            txt.TextAlign = HorizontalAlignment.Center
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblsec.Text += 1
        If (lblsec.Text = 59) Then

            lblsec.Text = 0
            lblmin.Text += 1


        End If
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
