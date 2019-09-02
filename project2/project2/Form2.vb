Imports System.IO

Public Class Form2
    Dim file As StreamWriter
    Dim file1 As StreamWriter
    Dim file2 As StreamWriter
    Dim score = 25
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        file = New StreamWriter("E:\project1\TextFile1.txt")
        file.WriteLine(Val(min.Text))
        file.Close()
        file1 = New StreamWriter("E:\project1\TextFile2.txt")
        file1.WriteLine(Val(sec.Text))
        file1.Close()
        file2 = New StreamWriter("E:\project1\TextFile3.txt")
        file2.WriteLine(Val(Label1.Text))
        file2.Close()


        sec.Text += 1
        If (sec.Text = 59) Then

            sec.Text = 0
            min.Text += 1
            score = score + 10
            Label1.Text = score
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        min.Text = "10"
        sec.Text = "10"
        Label1.Text = score
        file = New StreamWriter("E:\project1\TextFile1.txt")
        file.WriteLine(min.Text)
        file.Close()

        file1 = New StreamWriter("E:\project1\TextFile2.txt")
        file1.WriteLine(sec.Text)
        file1.Close()

        file2 = New StreamWriter("E:\project1\TextFile3.txt")
        file2.WriteLine(Label1.Text)
        file2.Close()
    End Sub
End Class