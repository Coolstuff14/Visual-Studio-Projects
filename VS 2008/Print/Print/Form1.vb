Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String

        For Each pkInstalledPrinters In Printing.PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters
        ComboBox1.SelectedIndex = 0
        If My.Settings.record = 9001 Then
            pokabox.Visible = True
            MsgBox("You have printed OVER 9000! pages", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox2.CheckState = CheckState.Checked Then
            PBlack()
        ElseIf pokabox.CheckState = CheckState.Checked Then
            pokaprint()
        Else
            PrintDocument1.PrinterSettings.PrinterName = ComboBox1.SelectedValue
            PrintDocument1.PrinterSettings.Copies = NumericUpDown1.Value
            PrintDocument1.Print()
            My.Settings.record = My.Settings.record + NumericUpDown1.Value
            My.Settings.Save()
        End If
        
    End Sub
    Private Sub PBlack()
        Dim pd As New System.Drawing.Printing.PrintDocument
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        pd.PrinterSettings.PrinterName = ComboBox1.SelectedValue
        pd.PrinterSettings.Copies = NumericUpDown1.Value
        pd.Print()
        My.Settings.record = My.Settings.record + NumericUpDown1.Value
        My.Settings.Save()
    End Sub
    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawImage(My.Resources.black, 0, 0, 850, 1100)
    End Sub

    Private Sub pokaprint()
        Dim pd As New System.Drawing.Printing.PrintDocument
        AddHandler pd.PrintPage, AddressOf OnPrintPagePoka
        pd.PrinterSettings.PrinterName = ComboBox1.SelectedValue
        pd.PrinterSettings.Copies = NumericUpDown1.Value
        pd.Print()
        My.Settings.record = My.Settings.record + NumericUpDown1.Value
        My.Settings.Save()
    End Sub

    Private Sub OnPrintPagePoka(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        e.Graphics.DrawImage(My.Resources.PokaDots, 0, 0, 850, 1100)
    End Sub

End Class
