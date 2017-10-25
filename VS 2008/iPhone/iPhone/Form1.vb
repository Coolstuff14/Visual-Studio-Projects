Imports System.Net
Imports System.Net.WebClient
Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = (My.Settings.pass.ToString) Then
            Label1.Text = "Password Correct"
            Form2.Show()
            Me.Close()

        Else
            Label1.Text = "Password Incorect"
        End If
    End Sub
    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = (My.Settings.pass.ToString) Then
                Label1.Text = "Password Correct"
                Form2.Show()
                Me.Close()

            Else
                Label1.Text = "Password Incorect"
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Password:"
        Dim url As String = "http://www.site2.feeddom.com/version.html"
        Dim pageRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        Dim pageResponse As WebResponse = pageRequest.GetResponse()
        Dim page As String = ""
        Using r As New StreamReader(pageResponse.GetResponseStream())
            page = r.ReadToEnd()
        End Using
        If Not page = Convert.ToString(My.Settings.version) Then
            System.Diagnostics.Process.Start(Application.StartupPath & "\UpdateChecker.exe")
            Me.Close()
        End If
    End Sub

End Class
