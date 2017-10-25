Public Class Password
    Dim pass

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pass = TextBox1.Text.ToString
        My.Settings.pass = pass.ToString
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            pass = TextBox1.Text.ToString
            My.Settings.pass = pass.ToString
            Me.Close()
        End If
    End Sub
End Class