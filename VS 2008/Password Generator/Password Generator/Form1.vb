Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = generateCode()
    End Sub
    Public Function generateCode() As Object
        Dim intRnd As Object
        Dim intstep As Object
        Dim strName As Object
        Dim intNamelength As Object
        Dim intlength As Object
        Dim strInputstring As Object
        Dim customlength As Integer

        strInputstring = "1234567890abcdefghigjlmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWZYZ"

        intlength = Len(strInputstring)

        customlength = TextBox2.Text

        intNamelength = customlength

        Randomize()

        strName = ""

        For intstep = 1 To intNamelength
            intRnd = Int((intlength * Rnd()) + 1)

            strName = strName & Mid(strInputstring, intRnd, 1)
        Next
        generateCode = strName
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AboutBox1.Show()
    End Sub
End Class
