Imports System.Collections.Specialized
Imports ActiveHomeScriptLib
Imports System.IO

Public Class Form1
    Dim WithEvents ActiveHomeObj As ActiveHomeScriptLib.ActiveHome
    Dim AHEvents As String
    Dim closeMe As Boolean
    Dim tmrState As Boolean


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ActiveHomeObj = New ActiveHome

        If My.Settings.modules IsNot Nothing Then
            For Each item In My.Settings.modules
                modulesClb.Items.Add(item)
            Next
        End If

        If My.Settings.modulesChecked IsNot Nothing Then
            For Each item In My.Settings.modulesChecked
                modulesClb.SetItemCheckState(item, CheckState.Checked)
            Next
        End If

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
        
        If trafficTxt.TextLength >= 15000 Then
            trafficTxt.Clear()
        End If


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



    Private Sub allOff()
        For Each itm In modulesClb.CheckedItems
            Dim str As String = itm.ToString + " off"
            ActiveHomeObj.SendAction("sendrf", str)
        Next
    End Sub

    Private Sub allOn()
        For Each itm In modulesClb.CheckedItems
            Dim str As String = itm.ToString + " on"
            ActiveHomeObj.SendAction("sendrf", str)
        Next
    End Sub

    Private Sub addModuleBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles addModuleBtn.Click
        Dim value As String
        value = InputBox("Please enter module code", "Add module")
        If value IsNot Nothing Then
            modulesClb.Items.Add(value)
            saveModules()
        End If
    End Sub

    Private Sub deleteModuleBtn_Click(sender As System.Object, e As System.EventArgs) Handles deleteModuleBtn.Click
        Do While (modulesClb.SelectedItems.Count > 0)
            modulesClb.Items.Remove(modulesClb.SelectedItem)
        Loop
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        mainTmr.Interval = timeSel.SelectedItem * 60000
        Console.WriteLine(mainTmr.Interval)
        allOff()
        tmrState = False
        allOn()
        mainTmr.Start()
    End Sub

    Private Sub mainTmr_Tick(sender As System.Object, e As System.EventArgs) Handles mainTmr.Tick
        Select Case tmrState
            Case False
                allOff()
                tmrState = True
            Case True
                allOn()
                tmrState = False
        End Select
    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        mainTmr.Stop()
        allOff()
        tmrState = False
    End Sub
End Class
