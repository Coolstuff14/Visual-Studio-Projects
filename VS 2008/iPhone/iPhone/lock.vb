Public Class lock

    Dim var_int1 = 0
    Dim var_int2 = 0



    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        TextBox1.Text = Val(TextBox1.Text + "1")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        TextBox1.Text = Val(TextBox1.Text + "2")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.Click
        TextBox1.Text = Val(TextBox1.Text + "3")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel7.Click
        TextBox1.Text = Val(TextBox1.Text + "4")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "1234" Then
                Form1.Visible = True



            Else
                If var_int1 = 4 Then
                    Label1.Text = "No More Trys"
                    Label1.TextAlign = ContentAlignment.MiddleCenter
                    TextBox1.Enabled = False
                End If
                TextBox1.Text = ""
                Label1.Visible = True
                var_int1 = var_int1 + 1


            End If
        End If
    End Sub

    Private Sub lock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        Form1.Visible = False


    End Sub

    Private Sub Panel13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel13.Click
        TextBox1.Text = Val(TextBox1.Text + "5")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel17.Click
        TextBox1.Text = Val(TextBox1.Text + "6")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel21.Click
        TextBox1.Text = Val(TextBox1.Text + "7")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel25.Click
        TextBox1.Text = Val(TextBox1.Text + "8")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub

    Private Sub Panel27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel27.Click
        TextBox1.Text = Val(TextBox1.Text + "9")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub
    Private Sub Panel31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel31.Click
        TextBox1.Text = Val(TextBox1.Text + "0")
        var_int2 = var_int2 + 1
        If var_int2 > 4 Then
            TextBox1.Text = ""
            var_int2 = 0
        End If
    End Sub


    Private Sub Panel33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel33.Click
        TextBox1.Text = ""
    End Sub

End Class


