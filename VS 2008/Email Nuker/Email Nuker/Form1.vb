Imports System.Net.Mail
Public Class Form1
    Dim Drag As Boolean
    Dim Clicked_at As Point
    Dim Btn_state As Boolean 'Used to determin whether the button is send or cancel
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Drag = True
            Clicked_at = New Point(e.X, e.Y)
        Else
            drag = False
        End If
    End Sub
    Private Sub me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag = True Then
            Dim point As Point
            point = Me.PointToScreen(New Point(e.X, e.Y))
            point.Offset(-Clicked_at.X, -Clicked_at.Y)
            Me.Location = point
        End If
    End Sub
    Private Sub me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Btn_state = True 'Button set to send
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub Disable()
        For Each ctl As Control In Controls
            ctl.Enabled = False
        Next
        PictureBox1.Enabled = True
        ProgressBar1.Enabled = True
        Send_btn.Enabled = True
        Send_btn.Text = "Abort"
        Btn_state = False 'Button set to cancel
    End Sub
    Private Sub Enable()
        For Each ctl As Control In Controls
            ctl.Enabled = True
        Next
        Send_btn.Text = "Send"
        ProgressBar1.Value = 0
        Btn_state = True 'Button set to send
    End Sub
    Private Sub Send_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send_btn.Click
        Select Case Btn_state
            Case True
                BackgroundWorker1.RunWorkerAsync()
                ProgressBar1.Maximum = Num_Emails.Value
                Disable()
            Case False
                BackgroundWorker1.CancelAsync()
                BackgroundWorker1.Dispose()
        End Select
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim EMessage As New MailMessage
        With EMessage
            .Body = (Body_box.Text)
            .Subject = (subject_box.Text)
            .To.Add(to_box.Text)
            .From = New MailAddress(from_box.Text)
            .Priority = MailPriority.Normal
        End With
        Dim SimpleSMTP As New SmtpClient("smtp.gmail.com")
        SimpleSMTP.Port = 587
        SimpleSMTP.EnableSsl = True
        SimpleSMTP.Credentials = New System.Net.NetworkCredential(from_box.Text, pass_box.Text)

        For i = 1 To Num_Emails.Value
            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                SimpleSMTP.Send(EMessage)
                BackgroundWorker1.ReportProgress(i)
            End If
        Next

    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Operation Canceled!", MsgBoxStyle.Critical, "Report")
            Enable()
        Else
            MsgBox("Operation was a success!", MsgBoxStyle.Exclamation, "Report")
            Enable()
        End If
    End Sub
    Private Sub from_box_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles from_box.GotFocus
        from_box.SelectAll()
    End Sub
    Private Sub pass_box_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles pass_box.GotFocus
        pass_box.SelectAll()
    End Sub
    Private Sub to_box_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles to_box.GotFocus
        to_box.SelectAll()
    End Sub
    Private Sub subject_box_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles subject_box.GotFocus
        subject_box.SelectAll()
    End Sub
    Private Sub Body_box_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Body_box.GotFocus
        Body_box.SelectAll()
    End Sub


End Class
