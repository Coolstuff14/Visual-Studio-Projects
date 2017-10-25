Public Class settings
    Dim npass
    Dim path

    Private Sub settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
       
    End Sub


    Private Sub settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists(My.Settings.bgpic) Then
            Form2.PictureBox1.Image = Image.FromFile(My.Settings.bgpic.ToString)
        End If
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG Image (*.jpg)|*.jpg|All Files (*.*)|*.*"
        OpenFileDialog1.Title = "Choose Background Image"
        TextBox1.Text = (My.Settings.bgpic.ToString)
        GroupBox3.Enabled = False

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.Cancel) Then
            Return
        Else
            Form2.PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            path = OpenFileDialog1.FileName.ToString
        End If
        My.Settings.bgpic = path.ToString
        My.Settings.Save()
        Label1.Text = "Background Changed"
        TextBox1.Text = path
    End Sub
    Private Sub Home_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Home.Click
        Form2.Show()
        Me.Close()
        Form2.WindowState = FormWindowState.Normal
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox2.Text = (My.Settings.pass.ToString) Then
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.SelectAll()
    End Sub
    Private Sub TextBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        TextBox2.SelectAll()
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox2.Text = (My.Settings.pass.ToString) Then
                GroupBox3.Visible = True
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        npass = TextBox3.Text
        My.Settings.pass = npass.ToString
        Label5.Text = "Password Changed"
        My.Settings.Save()
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            npass = TextBox3.Text
            My.Settings.pass = npass.ToString
            Label5.Text = "Password Changed"
            My.Settings.Save()
        End If
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox3.PasswordChar = "*"
    End Sub
    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Button4.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GroupBox3.Enabled = False
        Label5.Text = ""
        Timer1.Enabled = False
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Label1.ForeColor = ColorDialog1.Color
        My.Settings.tmtxtcolor = ColorDialog1.Color
    End Sub
End Class