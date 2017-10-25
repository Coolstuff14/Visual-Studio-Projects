Public Class notes

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Save As New SaveFileDialog
        Save.Filter = "Text Files (*.txt)|*.txt|ALL FILES (*.*)|*.*"
        Save.Title = "Save File"
        Save.CheckPathExists = True
        Save.ShowDialog(Me)
        Try
            My.Computer.FileSystem.WriteAllText(Save.FileName, TextBox1.Text, False)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Text Files (*.txt)|*.txt|ALL FILES (*.*)|*.*"
        Open.Title = "Open File"
        Open.CheckPathExists = True
        Open.ShowDialog(Me)
        On Error Resume Next
        Dim RT As New System.IO.StreamReader(Open.FileName)
        On Error Resume Next
        TextBox1.Text = RT.ReadToEnd
    End Sub

    Private Sub notes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Close()
       
    End Sub

    Private Sub notes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "Virtual iPhone Notes"
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class