Imports System.Net.Mail
Public Class Form3

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim EMessage As New MailMessage
        With EMessage
            .Body = ("Sup")
            .Subject = ("Sup")
            .To.Add("georgeholton1234@gmail.com")
            .From = New MailAddress("Kevinlampton123@gmail.com")
            .Priority = MailPriority.Normal
        End With
        Dim SimpleSMTP As New SmtpClient("smtp.gmail.com")
        SimpleSMTP.Port = 587
        SimpleSMTP.EnableSsl = True
        SimpleSMTP.Credentials = New System.Net.NetworkCredential("Kevinlampton123@gmail.com", "basicpassword")

        For i = 0 To 20
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("canceled")
        Else
            MsgBox("Done")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BackgroundWorker1.CancelAsync()
        BackgroundWorker1.Dispose()
    End Sub
End Class