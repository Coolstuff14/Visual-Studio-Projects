Public Class Form1
    Dim drag As Boolean
    Dim clickedat As Point
    Dim hidden
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            clickedat = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If drag = True Then
            Dim point As Point
            point = Me.PointToScreen(New Point(e.X, e.Y))
            point.Offset(-clickedat.X, -clickedat.Y)
            Me.Location = point
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        drag = False
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
            hidden = False
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Try
            Me.Hide()
            NotifyIcon1.Visible = True
            hidden = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        If Me.hidden = True Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
            hidden = False
        Else
            Me.Hide()
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.windowLocation = Me.DesktopLocation
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.DesktopLocation = My.Settings.windowLocation

            Select Case My.Settings.autoplay
                Case True
                    MediaPlayer1.settings.autoStart = True
                    OnToolStripMenuItem.Checked = True
                    OffToolStripMenuItem.Checked = False
                Case False
                    MediaPlayer1.settings.autoStart = False
                    OffToolStripMenuItem.Checked = True
                    OnToolStripMenuItem.Checked = False
            End Select

            Select Case My.Settings.img
                Case "1"
                    PictureBox1.Image = My.Resources.Tree1
                Case "2"
                    PictureBox1.Image = My.Resources.Tree2
                Case "3"
                    PictureBox1.Image = My.Resources.Tree3
                Case "4"
                    PictureBox1.Image = My.Resources.Snowglobe1
                Case "5"
                    PictureBox1.Image = My.Resources.Snowglobe2
                Case "6"
                    PictureBox1.Image = My.Resources.Snowglobe3
                Case "7"
                    PictureBox1.Image = My.Resources.Snowglobe4
                Case "8"
                    PictureBox1.Image = My.Resources.Gift1
                Case "9"
                    PictureBox1.Image = My.Resources.Gift2
                Case "10"
                    PictureBox1.Image = My.Resources.Gift3
                Case "11"
                    PictureBox1.Image = My.Resources.House1
                Case "12"
                    PictureBox1.Image = My.Resources.House2
                Case "13"
                    PictureBox1.Image = My.Resources.Wreath
                Case Else
                    PictureBox1.ImageLocation = My.Settings.img
            End Select
            Try
                Select Case My.Settings.station
                    Case 1
                        FmToolStripMenuItem.PerformClick()
                    Case 2
                        ClassicHolidayRadioToolStripMenuItem.PerformClick()
                    Case 3
                        ChristmasChannelToolStripMenuItem.PerformClick()
                    Case 4
                        NorthPoleRadioToolStripMenuItem.PerformClick()
                    Case Else
                        MediaPlayer1.URL = My.Settings.station
                        CustomToolStripMenuItem.Checked = True
                End Select
            Catch ex As Exception
                MsgBox("Please select radio station", MsgBoxStyle.Information, "Station")
            End Try

            checkState()

        Catch ex As Exception
            MsgBox("An error has occurred trying to start aplication!", MsgBoxStyle.Critical, "Error")
        End Try
       

    End Sub

    Private Sub FmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FmToolStripMenuItem.Click
        Try
            MediaPlayer1.URL = "1fm.asx"
            FmToolStripMenuItem.Checked = True
            ClassicHolidayRadioToolStripMenuItem.Checked = False
            ChristmasChannelToolStripMenuItem.Checked = False
            NorthPoleRadioToolStripMenuItem.Checked = False
            CustomToolStripMenuItem.Checked = False
            My.Settings.station = 1
            My.Settings.Save()
            checkState()
        Catch ex As Exception
            MsgBox("Could not connect to station!", MsgBoxStyle.Critical, "Error")
        End Try
        
    End Sub

    Private Sub ClassicHolidayRadioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassicHolidayRadioToolStripMenuItem.Click
        Try
            MediaPlayer1.URL = "Classic Holiday Radio.asx"
            FmToolStripMenuItem.Checked = False
            ClassicHolidayRadioToolStripMenuItem.Checked = True
            ChristmasChannelToolStripMenuItem.Checked = False
            NorthPoleRadioToolStripMenuItem.Checked = False
            CustomToolStripMenuItem.Checked = False
            My.Settings.station = 2
            My.Settings.Save()
            checkState()
        Catch ex As Exception
            MsgBox("Could not connect to station!", MsgBoxStyle.Critical, "Error")
        End Try
        

    End Sub

    Private Sub ChristmasChannelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChristmasChannelToolStripMenuItem.Click
        Try
            MediaPlayer1.URL = "Christmas channel.asx"
            FmToolStripMenuItem.Checked = False
            ClassicHolidayRadioToolStripMenuItem.Checked = False
            ChristmasChannelToolStripMenuItem.Checked = True
            NorthPoleRadioToolStripMenuItem.Checked = False
            CustomToolStripMenuItem.Checked = False
            My.Settings.station = 3
            My.Settings.Save()
            checkState()
        Catch ex As Exception
            MsgBox("Could not connect to station!", MsgBoxStyle.Critical, "Error")
        End Try
        
    End Sub

    Private Sub NorthPoleRadioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NorthPoleRadioToolStripMenuItem.Click
        Try
            MediaPlayer1.URL = "North Pole Radio.asx"
            FmToolStripMenuItem.Checked = False
            ClassicHolidayRadioToolStripMenuItem.Checked = False
            ChristmasChannelToolStripMenuItem.Checked = False
            NorthPoleRadioToolStripMenuItem.Checked = True
            CustomToolStripMenuItem.Checked = False
            My.Settings.station = 4
            My.Settings.Save()
            checkState()
        Catch ex As Exception
            MsgBox("Could not connect to station!", MsgBoxStyle.Critical, "Error")
        End Try
        
    End Sub

    Private Sub CustomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub OnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnToolStripMenuItem.Click
        Try
            MediaPlayer1.settings.autoStart = True
            My.Settings.autoplay = True
            My.Settings.Save()
            OnToolStripMenuItem.Checked = True
            OffToolStripMenuItem.Checked = False
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical, "Error")
        End Try
        
    End Sub

    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
        Try
            MediaPlayer1.settings.autoStart = False
            My.Settings.autoplay = False
            My.Settings.Save()
            OnToolStripMenuItem.Checked = False
            OffToolStripMenuItem.Checked = True
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical, "Error")
        End Try
       
    End Sub

    Private Sub PauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        Try
            Select Case MediaPlayer1.playState

                Case WMPLib.WMPPlayState.wmppsReady, WMPLib.WMPPlayState.wmppsPaused
                    MediaPlayer1.Ctlcontrols.play()
                    MediaPlayer1.settings.volume = 100
                    checkState()

                Case WMPLib.WMPPlayState.wmppsPlaying
                    MediaPlayer1.Ctlcontrols.pause()
                    checkState()

            End Select

        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub checkState()
        Try
            Select Case MediaPlayer1.playState

                Case WMPLib.WMPPlayState.wmppsReady, WMPLib.WMPPlayState.wmppsPaused
                    PauseToolStripMenuItem.Text = "Play"

                Case WMPLib.WMPPlayState.wmppsPlaying, WMPLib.WMPPlayState.wmppsTransitioning
                    PauseToolStripMenuItem.Text = "Pause"

            End Select
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ChangePictureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePictureToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub MediaPlayer1_MediaChange(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles MediaPlayer1.MediaChange
        Try
            ' Get an interface to the changed media item that is returned in the event data.
            Dim changedItem As WMPLib.IWMPMedia3 = e.item

            ' Display the name of the changed media item.
            NotifyIcon1.BalloonTipText = changedItem.name
            NotifyIcon1.ShowBalloonTip(3000)
        Catch ex As Exception

        End Try
       

    End Sub
End Class
