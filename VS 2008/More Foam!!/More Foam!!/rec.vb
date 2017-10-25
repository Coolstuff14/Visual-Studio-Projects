Public Class rec
    Dim msg
    Private Sub rec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        print()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        msg = MsgBox("Are You sure you want to clear all records?", MsgBoxStyle.YesNo, "Clear All Records")
        If msg = 6 Then
            clear()
        End If
       End Sub
    Private Sub print()
        easyL.Text = My.Settings.easyL
        easyW.Text = My.Settings.easyW
        easyP.Text = (Val(easyL.Text) + Val(easyW.Text))

        medL.Text = My.Settings.medL
        medW.Text = My.Settings.medW
        medP.Text = (Val(medL.Text) + Val(medW.Text))

        hardL.Text = My.Settings.hardL
        hardW.Text = My.Settings.hardW
        hardP.Text = (Val(hardL.Text) + Val(hardW.Text))

        shardL.Text = My.Settings.shardL
        shardW.Text = My.Settings.shardW
        shardP.Text = (Val(shardL.Text) + Val(shardW.Text))
    End Sub
    Private Sub clear()
        My.Settings.Reset()
        My.Settings.Reload()
        print()
    End Sub
End Class