Imports System
Imports System.IO
Imports System.Text
Public Class Form1
    Dim dirPath As String = Directory.GetCurrentDirectory()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Settings
        urlTb.Text = My.Settings.url
        usernmTb.Text = My.Settings.username
        passwordTb.Text = My.Settings.password

        'Play feed
        playFeed()

    End Sub

    Private Sub viewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click
        'Play Feed
        playFeed()

        'Save settings
        My.Settings.url = urlTb.Text
        My.Settings.username = usernmTb.Text
        My.Settings.password = passwordTb.Text
        My.Settings.Save()
    End Sub

    Public Sub playFeed()
        'Create ASF video feed file
        Dim path As String = "feed.m3u"
        Dim fs As FileStream = File.Create(path)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("http://" + usernmTb.Text + ":" + passwordTb.Text + "@" + urlTb.Text)
        fs.Write(info, 0, info.Length)
        fs.Close()

        'PLay file in vlc component
        vlcFeed.playlist.items.clear()
        vlcFeed.playlist.add("file:///" + dirPath + "/feed.m3u")
        vlcFeed.playlist.play()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Computer.FileSystem.DeleteFile("feed.m3u")
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
        End If
    End Sub

    Private Sub hideTmr_Tick(sender As Object, e As EventArgs) Handles hideTmr.Tick
        'Hide form on load
        Me.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.BalloonTipText = "Camera Running"
        NotifyIcon1.ShowBalloonTip(2000)
        hideTmr.Stop()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SmallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmallToolStripMenuItem.Click
        '216x162 
        overlay.Size = New Size(216, 162 + 48)
        overlay.overlayFeed.Size = New Size(216, 162)
        overlay.Show()
    End Sub

    Private Sub LargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeToolStripMenuItem.Click
        '640x480
        overlay.Size = New Size(640, 480 + 48)
        overlay.overlayFeed.Size = New Size(640, 480)
        overlay.Show()
    End Sub

    Private Sub MediumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumToolStripMenuItem.Click
        '428x321 default
        overlay.Size = New Size(428, 321 + 48)
        overlay.overlayFeed.Size = New Size(428, 321)
        overlay.Show()
    End Sub

    Private Sub YesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YesToolStripMenuItem.Click
        Try
            My.Settings.startup = True
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Catch ex As Exception
            MsgBox("Something went wrong :(")
        End Try
        
    End Sub

    Private Sub NoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoToolStripMenuItem.Click
        Try
            My.Settings.startup = False
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        Catch ex As Exception
            MsgBox("Something went wrong :(")
        End Try
    End Sub
End Class
