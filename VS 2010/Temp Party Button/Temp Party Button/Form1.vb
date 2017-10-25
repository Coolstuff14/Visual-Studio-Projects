Imports System.Collections.Specialized
Imports ActiveHomeScriptLib
Imports System.IO

Public Class Form1
    Dim onCode As String
    Dim partyOn As Integer = 0
    Dim WithEvents ActiveHomeObj As ActiveHomeScriptLib.ActiveHome
    Dim AHEvents As String
    Dim closeMe As Boolean

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If closeMe = True Then
            saveActions()
            saveModules()
        Else
            e.Cancel = True
            Me.Hide()
            NotifyIcon1.Visible = True
        End If
        
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = False
        ActiveHomeObj = New ActiveHome
        If My.Settings.modules IsNot Nothing Then
            For Each item In My.Settings.modules
                modulesClb.Items.Add(item)
            Next
        End If
        If My.Settings.actions IsNot Nothing Then
            For Each item In My.Settings.actions
                actionClb.Items.Add(item)
            Next
        End If
        If My.Settings.modulesChecked IsNot Nothing Then
            For Each item In My.Settings.modulesChecked
                modulesClb.SetItemCheckState(item, CheckState.Checked)
            Next
        End If
        If My.Settings.actionsChecked IsNot Nothing Then
            For Each item In My.Settings.actionsChecked
                actionClb.SetItemCheckState(item, CheckState.Checked)
            Next
        End If

        codeTxt.Text = My.Settings.code
        onCode = My.Settings.code
        saveModules()
        saveActions()


    End Sub
    Sub ActiveHomeTrafficAction(ByVal bszRecv As Object _
                            , ByVal vParm1 As Object _
                            , ByVal vParm2 As Object _
                            , ByVal vParm3 As Object _
                            , ByVal vParm4 As Object _
                            , ByVal vParm5 As Object _
                            , ByVal vReserved As Object) Handles ActiveHomeObj.RecvAction

        Dim convertedTime = Format(Now, "h:mm tt")
        Dim formatedDate = Format(Now, "dd/MM")
        AHEvents = formatedDate & " - " & convertedTime & " - " & bszRecv & " - " & vParm1 & " - " & vParm2
        AHEvents = AHEvents & vbCrLf
        trafficTxt.AppendText(AHEvents)

        If vParm1 = onCode And vParm2 = "On" Then
            partyOn += 1
            partyStart()
        ElseIf vParm1 = onCode And vParm2 = "Off" Then
            partyEnd()
        End If

        If trafficTxt.TextLength >= 15000 Then
            trafficTxt.Clear()
        End If


    End Sub

    Private Sub partyStart()
        If partyOn = 1 Then
            trafficTxt.AppendText("Party Started" & vbCrLf)
            For Each itm In modulesClb.CheckedItems
                Dim str As String = itm.ToString + " on"
                ActiveHomeObj.SendAction("sendrf", str)
                ActiveHomeObj.SendAction("sendrf", str)
            Next
            Try
                For Each act In actionClb.CheckedItems
                    System.Diagnostics.Process.Start(act)
                Next

            Catch ex As Exception
                MsgBox("Could not start file")
            End Try

            NotifyIcon1.BalloonTipText = "The party has started!"
            NotifyIcon1.ShowBalloonTip(2000)

            checkTimer.Enabled = True
        End If

        partyOn = 0
    End Sub
    Private Sub checkTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTimer.Tick
        For Each itm In modulesClb.CheckedItems
            Dim str As String = itm.ToString + " on"
            If ActiveHomeObj.SendAction("queryplc", str) = 0 Then
                ActiveHomeObj.SendAction("sendrf", str)
            End If
        Next
        checkTimer.Enabled = False
    End Sub
    Private Sub partyEnd()
        checkTimer.Enabled = False
        partyOn = 0
        trafficTxt.AppendText("Party Ended" & vbCrLf)

        NotifyIcon1.BalloonTipText = "The party is over"
        NotifyIcon1.ShowBalloonTip(2000)

        For Each itm In modulesClb.CheckedItems
            Dim str As String = itm.ToString + " off"
            ActiveHomeObj.SendAction("sendrf", str)
        Next

        Try
            For Each itm In actionClb.CheckedItems
                Dim flnm As String = Path.GetFileNameWithoutExtension(itm)
                If Path.GetExtension(itm) = ".scr" Then
                    Process.GetProcessesByName(flnm + ".scr")(0).Kill()
                Else
                    Process.GetProcessesByName(flnm)(0).Kill()
                End If
            Next
        Catch ex As Exception
            Dim p = Process.GetProcessesByName("wmplayer")
            If p.Count > 0 Then
                Process.GetProcessesByName("wmplayer")(0).Kill()
            End If
        End Try
    End Sub

    Private Sub setCodeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCodeBtn.Click
        My.Settings.code = codeTxt.Text
        onCode = codeTxt.Text
    End Sub

    Private Sub saveModules()
        If My.Settings.modules Is Nothing Then
            My.Settings.modules = New StringCollection
        End If
        If My.Settings.modulesChecked Is Nothing Then
            My.Settings.modulesChecked = New StringCollection
        End If

        My.Settings.modules.Clear()
        For Each item In modulesClb.Items
            My.Settings.modules.Add(item)
        Next
        My.Settings.modulesChecked.Clear()
        For Each item In modulesClb.CheckedIndices
            My.Settings.modulesChecked.Add(item)
        Next
        My.Settings.Save()
    End Sub

    Private Sub saveActions()
        If My.Settings.actions Is Nothing Then
            My.Settings.actions = New StringCollection
        End If
        If My.Settings.actionsChecked Is Nothing Then
            My.Settings.actionsChecked = New StringCollection
        End If

        My.Settings.actions.Clear()
        For Each item In actionClb.Items
            My.Settings.actions.Add(item)
        Next
        My.Settings.actionsChecked.Clear()
        For Each item In actionClb.CheckedIndices
            My.Settings.actionsChecked.Add(item)
        Next
        My.Settings.Save()
    End Sub

    Private Sub addModuleBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addModuleBtn.Click
        Dim value As String
        value = InputBox("Please enter module code", "Add module")
        If value IsNot Nothing Then
            modulesClb.Items.Add(value)
            saveModules()
        End If

    End Sub

    Private Sub deleteModuleBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteModuleBtn.Click
        Do While (modulesClb.SelectedItems.Count > 0)
            modulesClb.Items.Remove(modulesClb.SelectedItem)
        Loop
        saveModules()
    End Sub

    Private Sub startParty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startParty.Click
        partyOn = 1
        partyStart()
    End Sub

    Private Sub endParty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endParty.Click
        partyEnd()
    End Sub

    Private Sub addActionbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addActionbtn.Click
        OpenFileDialog1.Title = "Please Select a program"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim value As String = OpenFileDialog1.FileName
            If value IsNot Nothing Then
                actionClb.Items.Add(value)
                saveActions()
            End If

        End If
    End Sub

    Private Sub deleteActionBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteActionBtn.Click
        Do While (actionClb.SelectedItems.Count > 0)
            actionClb.Items.Remove(actionClb.SelectedItem)
        Loop
        saveActions()
    End Sub

    Private Sub StartPartyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartPartyToolStripMenuItem.Click
        partyOn = 1
        partyStart()

    End Sub

    Private Sub EndPartyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndPartyToolStripMenuItem.Click
        partyEnd()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        closeMe = True
        Me.Close()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub


    Private Sub ClearAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem1.Click
        trafficTxt.Clear()
        codeTxt.Clear()
        actionClb.Items.Clear()
        modulesClb.Items.Clear()
        My.Settings.actions.Clear()
        My.Settings.modules.Clear()
        My.Settings.code = ""
        My.Settings.Save()

    End Sub

   
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        closeMe = True
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        trafficTxt.Clear()
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Keyboard.SendKeys("play", True)
    End Sub
End Class
