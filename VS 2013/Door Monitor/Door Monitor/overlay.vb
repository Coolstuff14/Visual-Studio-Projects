Imports System
Imports System.IO
Public Class overlay
    Dim drag As Boolean
    Dim clickedat As Point
    Dim dirPath As String = Directory.GetCurrentDirectory()

    Private Sub overlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PLay file in vlc component
        overlayFeed.playlist.items.clear()
        overlayFeed.playlist.add("file:///" + dirPath + "/feed.m3u")
        overlayFeed.playlist.play()

        'Set Location
        Me.Location = My.Settings.overlayLocation
    End Sub

    Private Sub overlay_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            clickedat = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub

    Private Sub overlay_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag = True Then
            Dim point As Point
            point = Me.PointToScreen(New Point(e.X, e.Y))
            point.Offset(-clickedat.X, -clickedat.Y)
            Me.Location = point
        End If
    End Sub

    Private Sub overlay_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        My.Settings.overlayLocation = Me.Location
        My.Settings.Save()
        Me.Hide()
    End Sub

   
End Class