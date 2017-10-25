Public Class calender

 
    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub calender_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
   
    End Sub
End Class