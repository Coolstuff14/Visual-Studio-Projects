
Public Class Form1
    Dim Santa
    Dim bio
    Dim banana
    Dim pacman
    Public passused


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        'This is what happens when the timer runs out
        Me.Visible = True
        Timer2.Enabled = False
        'This is how long the timer runs - set at 8 seconds
        Timer2.Interval = (My.Settings.time + "000")
    End Sub

    Private Sub PictureBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick

        'When you click the ghost the form goes away and the timer restarts
        Dim generator As New Random
        Dim randomValue As Integer
        Me.Visible = False

        'This is X & Y of screen location
        randomValue = generator.Next(10, 800)
        Me.SetDesktopLocation(randomValue, randomValue)
        Timer2.Enabled = True
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If My.Settings.upass = 1 Then
                LoginForm1.Show()
            Else
                Form2.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Santa = (My.Resources.santa)
        bio = (My.Resources.biohazard)
        banana = (My.Resources.banana)
        pacman = (My.Resources.blue_blog)

        If My.Settings.pic = "santa" Then
            PictureBox1.Image = Santa
            Me.BackColor = Color.Lime
            Me.TransparencyKey = Color.Lime
        End If
        If My.Settings.pic = "pacman" Then
            PictureBox1.Image = pacman
            Me.BackColor = Color.White
            Me.TransparencyKey = Color.White
        End If
        If My.Settings.pic = "bio" Then
            PictureBox1.Image = bio
            Me.BackColor = Color.White
            Me.TransparencyKey = Color.White
        End If
        If My.Settings.pic = "banana" Then
            PictureBox1.Image = banana
            Me.BackColor = Color.Red
            Me.TransparencyKey = Color.Red
        End If
    End Sub
End Class