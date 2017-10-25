Public Class Form2
    Dim emailcount As Integer
    Dim maxcount As Integer

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        Timer1.Interval = NumericUpDown2.Value
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Select Case CheckBox2.CheckState
            Case CheckState.Checked
                Timer1.Start()
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea2.Text = "" Then

                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If
                If ea1.Text = "" Then
                    MsgBox("No Email Entered")
                End If

            Case CheckState.Indeterminate
            Case CheckState.Unchecked
        End Select

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Select Case Form1.started
            Case True

                If Form1.sending = False Then
                    emailcount = emailcount + 1
                    select_email()
                End If

            Case False

        End Select
    End Sub

    Private Sub select_email()
        Select Case emailcount
            Case 1
                Form1.cred = New System.Net.NetworkCredential(ea1.Text, pw1.Text)
            Case 2
                Form1.cred = New System.Net.NetworkCredential(ea2.Text, pw2.Text)
            Case 3
                Form1.cred = New System.Net.NetworkCredential(ea3.Text, pw3.Text)
            Case 4
                Form1.cred = New System.Net.NetworkCredential(ea4.Text, pw4.Text)
            Case 5
                Form1.cred = New System.Net.NetworkCredential(ea5.Text, pw5.Text)

        End Select
    End Sub
End Class