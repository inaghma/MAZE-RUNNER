

Imports System.IO

Public Class Forma
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()



    End Sub

    Private Sub Forma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As StreamReader
        file = New StreamReader("E:\project1\TextFile1.txt")
        Label1.Text = Integer.Parse(file.ReadLine)
        file.Close()
    End Sub
End Class
