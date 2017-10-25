Imports System.IO
Public Class Form1
    Dim filesDirectory As String
    Dim fileNames As Array

    Private Sub bBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBrowse.Click

        'Setup open file dialog
        OpenFileDialog1.Title = "Choose files to rename"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Enable rename button
            bRename.Enabled = True

            'Get directory of selected files
            filesDirectory = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\"

            'Save files selected to array
            fileNames = OpenFileDialog1.FileNames

            'Release all resources used by open file dialog
            OpenFileDialog1.Dispose()

        End If

    End Sub

    Private Sub bRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRename.Click

        'Define variables
        Dim count As Double = 0
        Dim newName As String
        Me.Enabled = False

        'Loop through all selected files and rename them
        For Each foundFile As String In fileNames

            'Add one to counter
            count += 1

            Dim fileExt As String = Path.GetExtension(foundFile)

            Select Case count

                'Add zero in front of number until it reaches 9
                Case 1 To 9
                    newName = tCharacters.Text & "0" & count.ToString & fileExt

                    'Add characters from text box to sequential number
                Case Else
                    newName = tCharacters.Text & count.ToString & fileExt

            End Select


            Try
                'Rename file
                My.Computer.FileSystem.RenameFile(foundFile, newName)
            Catch ex As Exception
                MsgBox("Error can not overwrite file!", MsgBoxStyle.Critical, "Error")
                End
            End Try
            

        Next

        'Confirm files renamed
        MsgBox("Operation compleated successfully!", MsgBoxStyle.Information, "Done")

        'reset
        tCharacters.Text = ""
        Me.Enabled = True

        'Open directory if check box is checked
        If showDir.Checked = True Then
            Process.Start("explorer.exe", filesDirectory)
        End If


    End Sub
End Class
