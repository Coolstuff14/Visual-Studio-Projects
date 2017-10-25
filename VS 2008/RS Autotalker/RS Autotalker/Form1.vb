Public Class Form1


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendKeys.Send(TextBox1.Text)
        SendKeys.Send("~")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Threading.Thread.Sleep(5000)
        Timer1.Enabled = True
        ComboBox1.Enabled = False
        TextBox1.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        ComboBox1.Enabled = True
        TextBox1.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Timer1.Interval = ComboBox1.SelectedItem.ToString * 1000
        Button1.Enabled = True
    End Sub
End Class
