Imports System.IO

Public Class Form1
    Dim ssid As String
    Dim pass As String
    Dim procStartInfo As New ProcessStartInfo
    Dim procExecuting As New Process

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ssidTb.Text = My.Settings.ssid
        passTb.Text = My.Settings.pass
        PictureBox1.Image = My.Resources.off
        If My.Settings.chkstate = True Then
            startupChk.CheckState = CheckState.Checked
            GOBITCH.PerformClick()
        Else
            startupChk.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub GOBITCH_Click(sender As Object, e As EventArgs) Handles GOBITCH.Click
        If passTb.Text.Trim.Length < 8 Then
            MessageBox.Show("MAKE YA PASS LONGER!")
        Else
            ssid = ssidTb.Text
            pass = passTb.Text
            My.Settings.ssid = ssid
            My.Settings.pass = pass
            My.Settings.Save()
            createNet()
        End If
    End Sub
    Private Sub createNet()
        If ssidTb.Text = "" Or passTb.Text = "" Then
            MsgBox("YA NEED SOME DAMN WORDS IN DA BOXES! Geeezz noob")
        End If

        Try
            With procStartInfo
                .UseShellExecute = True
                .FileName = "cmd"
                .Arguments = "/k netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + pass + " && timeout /t 1 && netsh wlan start hostednetwork"
                .WindowStyle = ProcessWindowStyle.Hidden
                '.Verb = "runas" 'add this to prompt for elevation
            End With
            procExecuting = Process.Start(procStartInfo)
            PictureBox1.Image = My.Resources._on
        Catch ex As Exception
            MsgBox("AWWWW SHIT THAT FAILED!")
        End Try
    End Sub

    Private Sub startupChk_CheckStateChanged(sender As Object, e As EventArgs) Handles startupChk.CheckStateChanged
        Try
            If startupChk.CheckState = CheckState.Checked Then
                My.Settings.chkstate = True
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            End If
            If startupChk.CheckState = CheckState.Unchecked Then
                My.Settings.chkstate = False
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            End If
            My.Settings.Save()
        Catch ex As Exception
            MsgBox("OHH NOOOOOS SOMETHING WENT WRONG!")
        End Try
       
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            With procStartInfo
                .UseShellExecute = True
                .FileName = "cmd"
                .Arguments = "/k netsh wlan stop hostednetwork"
                .WindowStyle = ProcessWindowStyle.Hidden
                '.Verb = "runas" 'add this to prompt for elevation
            End With

            procExecuting = Process.Start(procStartInfo)
        Catch ex As Exception
            MsgBox("AWWWW SHIT THAT FAILED!")
        End Try
        My.Settings.Save()
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
End Class
