Public Class LoginForm1
    Dim pass

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = pass Then
            Form1.Close()
            Form2.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    
    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pass = My.Settings.pass.ToString
    End Sub
End Class
