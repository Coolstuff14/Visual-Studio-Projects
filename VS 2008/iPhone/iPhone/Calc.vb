Option Explicit On
Public Class calc
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        txtDisplay.Text = txtDisplay.Text & 1
    End Sub
    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
        txtDisplay.Text = txtDisplay.Text & 2
    End Sub
    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel3.Click
        txtDisplay.Text = txtDisplay.Text & 3
    End Sub
    Private Sub Panel4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel4.Click
        txtDisplay.Text = txtDisplay.Text & 4
    End Sub

    Private Sub Panel5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.Click
        txtDisplay.Text = txtDisplay.Text & 5
    End Sub

    Private Sub Panel6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel6.Click
        txtDisplay.Text = txtDisplay.Text & 6
    End Sub

    Private Sub Panel7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel7.Click
        txtDisplay.Text = txtDisplay.Text & 7
    End Sub

    Private Sub Panel8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel8.Click
        txtDisplay.Text = txtDisplay.Text & 8
    End Sub

    Private Sub Panel9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel9.Click
        txtDisplay.Text = txtDisplay.Text & 9
    End Sub

    Private Sub Panel10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel10.Click
        txtDisplay.Text = txtDisplay.Text & 0
    End Sub

    Private Sub Panel11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel11.Click
        txtDisplay.Text = txtDisplay.Text & "."
    End Sub

    Private Sub Panel12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel12.Click
        txtDisplay.Text = ""
    End Sub

    Private Sub add_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles add.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        ArithmeticProcess = "+"
    End Sub

    Private Sub subtract_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles subtract.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        ArithmeticProcess = "-"
    End Sub

    Private Sub div_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles div.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        ArithmeticProcess = "/"
    End Sub

    Private Sub mult_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mult.Click
        FirstNumber = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        ArithmeticProcess = "X"
    End Sub

    Private Sub equals_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles equals.Click
        SecondNumber = Val(txtDisplay.Text)
        If ArithmeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        If ArithmeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        If ArithmeticProcess = "X" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        If ArithmeticProcess = "/" Then
            AnswerNumber = FirstNumber / SecondNumber
        End If
        txtDisplay.Text = AnswerNumber
    End Sub

    Private Sub home_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles home.Click
        Form2.Show()
        Me.Close()

    End Sub


    Private Sub pwrlove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pwrlove.Click
        My.Computer.Audio.Play(My.Resources.Huey_Lewis_and_the_News___The_Power_of_Love, AudioPlayMode.Background)
        MsgBox("Please Enjoy The Power Of Love!!")
    End Sub

  
    Private Sub calc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        
    End Sub
End Class