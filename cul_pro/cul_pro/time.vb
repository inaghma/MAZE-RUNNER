﻿Public Class time
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
    Private Sub picmsword_MouseDown(sender As Object, e As MouseEventArgs) Handles picmsword.MouseDown
        dragging = True
        beginX = e.X
        beginY = e.Y
    End Sub
    Private Sub picmsword_MouseMove(sender As Object, e As MouseEventArgs) Handles picmsword.MouseMove
        If dragging = True Then
            picmsword.Location = New Point(picmsword.Location.X + e.X - beginX, picmsword.Location.Y + e.Y - beginY)
            Me.Refresh()
        End If
    End Sub
    Private Sub picmsword_MouseUp(sender As Object, e As MouseEventArgs) Handles picmsword.MouseUp
        dragging = False
        picmsword.BringToFront()
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
    Private Sub picmsn_MouseUp(sender As Object, e As MouseEventArgs) Handles picmsn.MouseUp
        dragging = False
        picmsn.BringToFront()
    End Sub
    Private Sub btnok_Click(sender As System.Object, e As System.EventArgs) Handles btnok.Click
        If ((pichotmail.Bounds.IntersectsWith(Panel1.Bounds)) And (picskype.Bounds.IntersectsWith(Panel2.Bounds)) And (picdrive.Bounds.IntersectsWith(Panel3.Bounds))) Then
            Panel4.Visible = True

        End If
    End Sub

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        If txtans.Text = UCase("MICROSOFT") Then

    End Sub
End Class