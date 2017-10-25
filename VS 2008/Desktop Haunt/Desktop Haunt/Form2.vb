Public Class Form2
    Dim Santa
    Dim bio
    Dim banana
    Dim pacman
    Dim start
    Dim time


    Private Sub Button4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseDown
        Button4.Image = My.Resources.Play_1_Pressed_icon
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Image = My.Resources.Play_1_Normal_icon
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseHover
        Button4.Image = My.Resources.Play_1_Hot_icon
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Image = My.Resources.Play_1_Normal_icon
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "Santa" Then
            PictureBox2.Image = Santa
            Label1.Visible = False
        End If
        If ComboBox1.SelectedItem = "Bio Hazard" Then
            PictureBox2.Image = bio
            Label1.Visible = False
        End If
        If ComboBox1.SelectedItem = "Banana" Then
            PictureBox2.Image = banana
            Label1.Visible = True
        End If
        If ComboBox1.SelectedItem = "Blue Blob Thing From Packman" Then
            PictureBox2.Image = pacman
            Label1.Visible = False
        End If

    End Sub

    Private Sub Form2_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        AboutBox1.Show()
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Visible = False
       Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        start = 0
        Santa = (My.Resources.santa)
        bio = (My.Resources.biohazard)
        banana = (My.Resources.banana)
        pacman = (My.Resources.blue_blog)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       
        Label2.Text = "Picture: Set!"
        If ComboBox1.SelectedItem = "Santa" Then
            My.Settings.pic = "santa"
            My.Settings.Save()
        End If
        If ComboBox1.SelectedItem = "Bio Hazard" Then
            My.Settings.pic = "bio"
            My.Settings.Save()
        End If
        If ComboBox1.SelectedItem = "Banana" Then
            My.Settings.pic = "banana"
            My.Settings.Save()
        End If
        If ComboBox1.SelectedItem = "Blue Blob Thing From Packman" Then
            My.Settings.pic = "pacman"
            My.Settings.Save()
        End If
    End Sub
    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        Button2.Enabled = True
    End Sub
    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged
        Button3.Enabled = True
    End Sub
    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        start = start + 1
        If start = 2 Then
            Button4.Enabled = True
        End If
    End Sub
    Private Sub Label3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        start = start + 1
        If start = 2 Then
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label3.Text = "Time: Set!"
        time = ComboBox2.SelectedItem.ToString
        My.Settings.time = time.ToString
    End Sub

   
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.Show()
            My.Settings.upass = 1
        End If
        If CheckBox1.Checked = False Then
            My.Settings.upass = 0
        End If
    End Sub
End Class