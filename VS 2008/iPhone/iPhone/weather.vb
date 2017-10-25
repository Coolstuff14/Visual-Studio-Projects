Public Class weather
    Dim zip
    Dim loadzip


  Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        zip = TextBox1.Text
        My.Settings.weather = zip
        My.Settings.Save()
        GroupBox1.Visible = False
        Dim sr As IO.StreamReader
        Dim wc As New System.Net.WebClient
        Dim strUrl As String
        Dim strOut As String = ""
        strUrl = String.Format("http://xml.weather.yahoo.com/forecastrss?p={0}", TextBox1.Text)

        Try
            sr = New IO.StreamReader(wc.OpenRead(strUrl))
            Dim strHtml As String = sr.ReadToEnd
            Dim x As Integer = strHtml.IndexOf("<img src")
            Dim y As Integer = strHtml.IndexOf(")<br/>")
            strOut = strHtml.Substring(x, y - x + 6)
            sr.Close()
        Catch
            strOut = "<h1>Error getting weather</h1>"
        Finally
            WebBrowser1.DocumentText = strOut
        End Try
    End Sub

    Private Sub weather_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If zip <> "" Then
            My.Settings.weather = zip.ToString
            My.Settings.Save()
        End If
      
    End Sub

    Private Sub weather_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.weather.ToString
        zip = TextBox1.Text
        loadzip = My.Settings.weather.ToString
        GroupBox1.Visible = False
        Dim sr As IO.StreamReader
        Dim wc As New System.Net.WebClient
        Dim strUrl As String
        Dim strOut As String = ""
        strUrl = String.Format("http://xml.weather.yahoo.com/forecastrss?p={0}", loadzip)

        Try
            sr = New IO.StreamReader(wc.OpenRead(strUrl))
            Dim strHtml As String = sr.ReadToEnd
            Dim x As Integer = strHtml.IndexOf("<img src")
            Dim y As Integer = strHtml.IndexOf(")<br/>")
            strOut = strHtml.Substring(x, y - x + 6)
            sr.Close()
        Catch
            strOut = "<h1>Error getting weather</h1>"
        Finally
            WebBrowser1.DocumentText = strOut
        End Try


    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class