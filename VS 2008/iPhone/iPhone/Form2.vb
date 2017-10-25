Public Class Form2
    Dim path

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If path <> "" Then
            My.Settings.bgpic = path.ToString
            My.Settings.Save()
           
        End If
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists(My.Settings.bgpic) Then
            PictureBox1.Image = Image.FromFile(My.Settings.bgpic.ToString)
        End If
        On Error Resume Next
        Label1.ForeColor = My.Settings.tmtxtcolor
        On Error Resume Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        settings.Show()
        settings.WindowState = FormWindowState.Normal
        Me.Close()
  End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click

        Form1.Show()
        Form1.WindowState = FormWindowState.Normal
        Form1.BringToFront()
        Form1.TextBox1.Text = ""
        Form1.Label1.Text = "Password:"
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        safari.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        cam.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        notes.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        media.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        photo.Show()
        Me.Close()
        My.Computer.FileSystem.CurrentDirectory = "C:\"
        photo.GroupBox1.Visible = False
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        calender.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        weather.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        calc.Show()
        Me.Close()
    End Sub
End Class