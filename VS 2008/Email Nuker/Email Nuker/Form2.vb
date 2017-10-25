Public Class Form2

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Visible = True
        My.Computer.Audio.Play(My.Resources.bomb, AudioPlayMode.Background)
        Threading.Thread.Sleep(5000)
        Me.Close()
    End Sub



End Class