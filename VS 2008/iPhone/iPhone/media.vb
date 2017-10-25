Public Class media
    


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "All Files (*.*)|*.*|Mp3 (*.mp3)|*.mp3|Wav (*.wav)|*.wav|Avi (*.avi)|*.avi"
        Open.Title = "Open Media File"
        Open.CheckPathExists = True
        Open.ShowDialog(Me)
        On Error Resume Next
        TextBox1.Text = Open.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.AxWindowsMediaPlayer1.URL = TextBox1.Text.ToString

    End Sub

    Private Sub home_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles home.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        mediafull.Show()
        Me.Close()
    End Sub
    Private Sub media_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

 Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        My.Settings.ply_url = TextBox1.Text
        My.Settings.Save()
    End Sub

    
    Private Sub media_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class