Imports System.IO
Imports System.Collections.Specialized
Public Class Form1
    'Declare global variables
    Dim filePaths As New StringDictionary()
    Dim closeMe As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'check if a folder path is saved in setting if not instruct user to choose one
            If My.Settings.folderPath = Nothing Then
                MsgBox("Please select a folder containing your shortcuts. For help click the about button.", MsgBoxStyle.Information, "Welcome")
            Else
                tPath.Text = (My.Settings.folderPath)
                Me.Hide()
                loadMenu()
            End If
        Catch ex As Exception
            exceptError("formload")
        End Try
    End Sub
    Private Sub ContextMenuHandler_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            'start selected program from tray menu using tag to find value in the dictionary
            Process.Start(filePaths.Item(sender.tag))
        Catch ex As Exception
            exceptError("ContextMenuHandler")
        End Try
    End Sub
    Private Sub bExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bExit.Click
        Try
            'Exit the program
            closeMe = True
            Me.Close()
        Catch ex As Exception
            exceptError("bExit")
        End Try
    End Sub
    Private Sub bBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBrowse.Click
        Try
            'Show file dialog and save result of Ok or Cancel click
            Dim result As DialogResult = FolderDialog1.ShowDialog()

            If result = DialogResult.OK Then
                'save folder path to settings and place path text in text box
                My.Settings.folderPath = FolderDialog1.SelectedPath
                My.Settings.Save()
                tPath.Text = (FolderDialog1.SelectedPath.ToString)
                loadMenu()
            End If
        Catch ex As Exception
            exceptError("bBrowse")
        End Try
    End Sub
    Private Sub loadMenu()
        Try
            'Declare and initilize variables 
            Dim folderPath = My.Settings.folderPath
            Dim tagCounter As Double = 0
            Dim filename As String

            'clear items from tray menu
            trayMenu.Items.Clear()

            'Loop through files in chosen directory 
            For Each filePath As String In My.Computer.FileSystem.GetFiles(folderPath)

                'Add one to the tag counter
                tagCounter += 1

                'Get file name from file path
                filename = Path.GetFileName(filePath)

                'Remove extention from file name
                filename = filename.Remove(filename.Length - 4)

                Dim NewToolStripItem As New ToolStripMenuItem

                NewToolStripItem.Text = filename

                NewToolStripItem.Tag = tagCounter

                'Add file path to dictionary with tag as the key
                filePaths.Add(tagCounter.ToString, filePath)

                'assign handler to menu items in case of click
                AddHandler NewToolStripItem.Click, AddressOf ContextMenuHandler_Click

                'Add item to tray menu
                trayMenu.Items.Add(NewToolStripItem)

            Next
        Catch ex As Exception
            exceptError("loadMenu")
        End Try
    End Sub
    Private Sub trayIcon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles trayIcon.DoubleClick
        Try
            Me.Show()
        Catch ex As Exception
            exceptError("trayIcon-DoubleClick")
        End Try
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Select Case closeMe
                Case False
                    Me.Hide()
                    e.Cancel = True

                Case True
                    Me.Show()
                    e.Cancel = False
            End Select
            
        Catch ex As Exception
            exceptError("formclosing")
        End Try
    End Sub
    'Private Sub trayIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trayIcon.MouseClick
    '    Try
    '        'opens tray menu on left click at mouse cooridinate position
    '        Dim x As Integer
    '        Dim y As Integer
    '        x = Control.MousePosition().X - Me.Location.X - 0  'Adjust Here If Needed
    '        y = Control.MousePosition().Y - Me.Location.Y - 120 'Adjust Here If Needed
    '        Dim xy As New Point(x, y)
    '        trayMenu.Show(Me, xy)
    '    Catch ex As Exception
    '        exceptError("trayIcon-Click")
    '    End Try
    'End Sub
    Public Sub exceptError(ByVal errorCode)
        MsgBox("An error has occurred! Code: " & errorCode, MsgBoxStyle.Critical, "Error!")
        closeMe = True
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
