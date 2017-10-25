Public Class Form3
    Dim drag As Boolean
    Dim clickedat As Point
    Private Sub Form3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            clickedat = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub
    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag = True Then
            Dim point As Point
            point = Me.PointToScreen(New Point(e.X, e.Y))
            point.Offset(-clickedat.X, -clickedat.Y)
            Me.Location = point
        End If
    End Sub
    Private Sub Form3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text.Contains(".asx") Then
                Form1.MediaPlayer1.URL = TextBox1.Text
                Form1.MediaPlayer1.Ctlcontrols.play()
                My.Settings.station = TextBox1.Text
                My.Settings.Save()
                Form1.CustomToolStripMenuItem.Checked = True
                Form1.FmToolStripMenuItem.Checked = False
                Form1.ClassicHolidayRadioToolStripMenuItem.Checked = False
                Form1.ChristmasChannelToolStripMenuItem.Checked = False
                Form1.NorthPoleRadioToolStripMenuItem.Checked = False
            Else
                TextBox1.Text = ""
            End If
            
        Catch ex As Exception
            MsgBox("Cound not connect!", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Please Select a .asx file"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "ASX File (.asx)|*.asx"
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            Form1.MediaPlayer1.URL = OpenFileDialog1.FileName
            Form1.MediaPlayer1.Ctlcontrols.play()
            Form1.CustomToolStripMenuItem.Checked = True
            Form1.FmToolStripMenuItem.Checked = False
            Form1.ClassicHolidayRadioToolStripMenuItem.Checked = False
            Form1.ChristmasChannelToolStripMenuItem.Checked = False
            Form1.NorthPoleRadioToolStripMenuItem.Checked = False
        Catch ex As Exception
            MsgBox("Could not run!", MsgBoxStyle.Critical, "Error")
        End Try
        My.Settings.station = OpenFileDialog1.FileName
        My.Settings.Save()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub


End Class