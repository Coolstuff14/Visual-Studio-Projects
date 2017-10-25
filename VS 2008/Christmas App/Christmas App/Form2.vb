Public Class Form2
    Dim image
    Dim File_path As String
    Dim drag As Boolean
    Dim clickedat As Point
    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            clickedat = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag = True Then
            Dim point As Point
            point = Me.PointToScreen(New Point(e.X, e.Y))
            point.Offset(-clickedat.X, -clickedat.Y)
            Me.Location = point
        End If
    End Sub
    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Form1.PictureBox1.Image = My.Resources.Tree1
                My.Settings.img = "1"
                My.Settings.Save()
            Case 1
                Form1.PictureBox1.Image = My.Resources.Tree2
                My.Settings.img = "2"
                My.Settings.Save()
            Case 2
                Form1.PictureBox1.Image = My.Resources.Tree3
                My.Settings.img = "3"
                My.Settings.Save()
            Case 3
                Form1.PictureBox1.Image = My.Resources.Snowglobe1
                My.Settings.img = "4"
                My.Settings.Save()
            Case 4
                Form1.PictureBox1.Image = My.Resources.Snowglobe2
                My.Settings.img = "5"
                My.Settings.Save()
            Case 5
                Form1.PictureBox1.Image = My.Resources.Snowglobe3
                My.Settings.img = "6"
                My.Settings.Save()
            Case 6
                Form1.PictureBox1.Image = My.Resources.Snowglobe4
                My.Settings.img = "7"
                My.Settings.Save()
            Case 7
                Form1.PictureBox1.Image = My.Resources.Gift1
                My.Settings.img = "8"
                My.Settings.Save()
            Case 8
                Form1.PictureBox1.Image = My.Resources.Gift2
                My.Settings.img = "9"
                My.Settings.Save()
            Case 9
                Form1.PictureBox1.Image = My.Resources.Gift3
                My.Settings.img = "10"
                My.Settings.Save()
            Case 10
                Form1.PictureBox1.Image = My.Resources.House1
                My.Settings.img = "11"
                My.Settings.Save()
            Case 11
                Form1.PictureBox1.Image = My.Resources.House2
                My.Settings.img = "12"
                My.Settings.Save()
            Case 12
                Form1.PictureBox1.Image = My.Resources.Wreath
                My.Settings.img = "13"
                My.Settings.Save()
        End Select

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
    
End Class