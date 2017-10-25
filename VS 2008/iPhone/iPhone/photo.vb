Public Class photo
    Dim path
    Dim picpath
    Dim picpath2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.ImageLocation = ComboBox1.SelectedItem
    End Sub

    Private Sub photo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Close()
       
    End Sub
    Private Sub photo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picpath = My.Computer.FileSystem.SpecialDirectories.MyPictures
        picpath2 = picpath & "\Virtual iphone Photos"
        If Not My.Computer.FileSystem.DirectoryExists(picpath2) Then
            My.Computer.FileSystem.CreateDirectory(picpath2)
        End If
        My.Computer.FileSystem.CurrentDirectory = picpath2
        ComboBox1.DataSource = My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.CurrentDirectory, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
        GroupBox1.Visible = False
        If ComboBox1.Text = "" Then
            ComboBox1.Text = "NO Images"
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        GroupBox1.Visible = True
        GroupBox1.Height = (143)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        path = ComboBox1.SelectedValue.ToString
        My.Settings.bgpic = path.ToString
        My.Settings.Save()
        GroupBox1.Height = (161)
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class