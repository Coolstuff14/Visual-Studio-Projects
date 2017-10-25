Public Class mediafull
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AxWindowsMediaPlayer1.URL = TextBox1.Text.ToString
        GroupBox1.Visible = False

    End Sub

    Private Sub home_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles home.Click
        Form2.Show()
        Me.Hide()

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "All Files (*.*)|*.*|Mp3 (*.mp3)|*.mp3|Wav (*.wav)|*.wav|Avi (*.avi)|*.avi"
        Open.Title = "Open Media File"
        Open.CheckPathExists = True
        Open.ShowDialog(Me)
        On Error Resume Next
        TextBox1.Text = Open.FileName
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub mediafull_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub mediafull_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.ply_url.ToString
        GroupBox1.Visible = True
        AxWindowsMediaPlayer1.uiMode = "full"
        PictureBox1.Image = My.Resources.navigate_down_icon
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If AxWindowsMediaPlayer1.uiMode = "full" Then
            AxWindowsMediaPlayer1.uiMode = "none"
            PictureBox1.Image = My.Resources.navigate_up_icon
        Else
            AxWindowsMediaPlayer1.uiMode = "full"
            PictureBox1.Image = My.Resources.navigate_down_icon
        End If
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        media.Show()
        Me.Close()
    End Sub
End Class