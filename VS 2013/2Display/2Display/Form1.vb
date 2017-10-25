Imports System
Imports System.IO.Ports
Imports _2Display.GlobalVars
Imports System.Diagnostics
Public Class Form1
    Dim oldTm = 0 'Old time for clock comparison
    Dim checkedNum = 0 'Number of cheked items in mainChkls
    Dim mainCount = 0 'Counter for main timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Show all available COM ports. 
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comList.Items.Add(sp)
        Next

        'Load settings if already saved 
        If My.Settings.savedSettings = True Then
            loadSettings()
        End If

        'Run main display
        mainDisplayRun()

    End Sub
    Private Sub mainDisplayRun()
        'This function starts the main display timer and sets values for whats being used
        'Check if any items checked 
        If mainChkls.CheckedItems.Count > 0 Then
            checkedNum = mainChkls.CheckedItems.Count
            For Each li In mainChkls.CheckedItems
                'Set values for whats being used
                Select Case li.ToString
                    Case "Clock"
                        clockEn = True
                    Case "Date"
                        dateEn = True
                    Case "Cpu Usage"
                        cpuEn = True
                    Case "Memory Usage"
                        memUseEn = True
                    Case "Memory Free"
                        memFreeEn = True
                    Case "Number Of Processes"
                        processEn = True
                    Case "Network Usage Up"
                        netUseUpEn = True
                    Case "Network Usage Down"
                        netUseDownEn = True
                End Select
            Next
        Else
            'No items checked default to only clock
            mainChkls.SetItemChecked(0, True)
            MsgBox("No items checked defaulting to clock only!", MsgBoxStyle.Information, "2Display")
            'Call self to enable clock after checked
            mainDisplayRun()
        End If

        'Set timer interval from selector box in seconds
        mainDTmr.Interval = mainTAdj.Value * 1000
        mainDTmr.Start()
    End Sub
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        'Save setting setup group box 
        My.Settings.com = comList.Text
        My.Settings.baud = baudList.Text
        My.Settings.dataBit = dataBitTB.Text
        My.Settings.address = addressTB.Text
        My.Settings.parityBit = parityBitList.Text

        'Check current counter and save to settings
        If countAChk.CheckState = CheckState.Checked Then
            My.Settings.currentCounter = "A"
        ElseIf countBChk.CheckState = CheckState.Checked Then
            My.Settings.currentCounter = "B"
        End If

        'Save settings
        My.Settings.savedSettings = True 'Flag for first time setup and autoloading port setup
        My.Settings.Save()
        loadSettings() 'Function setup port and open it
    End Sub

    Private Sub loadSettings()
        'Check if port open and close if so
        If displaySerial.IsOpen = True Then
            displaySerial.Close()
        End If

        'Load settings for COM port 
        'Set Global Variables
        spCom = My.Settings.com
        spBaud = My.Settings.baud
        spDataBit = My.Settings.dataBit
        spParity = My.Settings.parityBit
        spAddress = My.Settings.address

        'Fill in entries for setup group box
        comList.Text = spCom
        baudList.Text = spBaud
        dataBitTB.Text = spDataBit
        parityBitList.Text = spParity
        addressTB.Text = spAddress

        'Setup port with settings
        displaySerial.PortName = spCom
        displaySerial.BaudRate = spBaud
        displaySerial.DataBits = spDataBit

        'Set parity bit
        If spParity = "odd" Then
            displaySerial.Parity = Parity.Odd
        Else
            displaySerial.Parity = Parity.Even
        End If

        'Try and open port with settings
        Try
            displaySerial.Open()
            portStatusTB.Text = "PORT OPEN"
            portStatusTB.BackColor = Color.Lime
        Catch ex As Exception
            'If error try closing and re-opening port 
            Try
                displaySerial.Close()
                displaySerial.Open()
            Catch exx As Exception
                'Didn't work error to the max!
                MsgBox(comList.Text + " In Use! Unable to open port!", MsgBoxStyle.Exclamation, "PORT ERROR")
            End Try
        End Try

        'Check whats the current counter saved from settings and set variable and checkboxes 
        If My.Settings.currentCounter = "A" Then
            countAChk.CheckState = CheckState.Checked
            currentCounter = "A"
        End If
        If My.Settings.currentCounter = "B" Then
            countBChk.CheckState = CheckState.Checked
            currentCounter = "B"
        End If
    End Sub

    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        write2Display(numTB.Text)
    End Sub

    Private Sub write2Display(ByRef data As String)
        'Writing to LD2006P0 or LD4006P0
        'Format is a follows:
        'N = node address
        'V = write value change
        'A or B = counter to write to 
        '$ or * to mark end of string
        displaySerial.Write("N" + spAddress + "V" + currentCounter + data + "$")
    End Sub

    Private Sub setpointBtn_Click(sender As Object, e As EventArgs) Handles setpointBtn.Click
        'SetPoint is the point at which the counter resets to use in manner of sending number to it
        'its recommended to set it to 999999 allowing full possiblitiy of numbers to be sent
        'Set point is writen to by "F" 
        displaySerial.Write("N" + spAddress + "V" + "F" + setpointTB.Text + "$")
    End Sub

    Private Sub scaleBtn_Click(sender As Object, e As EventArgs) Handles scaleBtn.Click
        'Scale factor allows you to scale or round numbers sent to the display
        'scale factor can be any number 6 digits long
        'it is set with "D" for scale factor A and "E" for scale factor B
        displaySerial.Write("N" + spAddress + "V" + currentCounter + "D" + scaleTb.Text + "$")
    End Sub

    Private Sub numTB_KeyDown(sender As Object, e As KeyEventArgs) Handles numTB.KeyDown
        'Enter key submits text box entry for numbers 
        If e.KeyCode = Keys.Enter Then
            sendBtn.PerformClick()
        End If
    End Sub

    Private Sub closePortBtn_Click(sender As Object, e As EventArgs) Handles closePortBtn.Click
        'Close port 
        displaySerial.Close()
        If displaySerial.IsOpen = False Then
            portStatusTB.Text = "PORT CLOSED"
            portStatusTB.BackColor = Color.Red
        End If
    End Sub

    Private Sub clockTmr_Tick(sender As Object, e As EventArgs) Handles clockTmr.Tick
        'Write current time to clock
        Dim cTime = Format(Now, "hhmm")
        If oldTm <> cTime Then
            oldTm = cTime
            write2Display(cTime)
        End If
    End Sub

    Private Sub timerBtn_Click(sender As Object, e As EventArgs) Handles timerBtn.Click
        timer.Show()
    End Sub

    Private Sub mainChkls_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mainChkls.SelectedIndexChanged
        If checkedNum <> mainChkls.CheckedItems.Count Then
            mainDTmr.Stop()
            mainDisplayRun()
        End If
    End Sub

    Private Sub mainTAdj_ValueChanged(sender As Object, e As EventArgs) Handles mainTAdj.ValueChanged
        'Change value of main timer in seconds
        mainDTmr.Interval = mainTAdj.Value * 1000
    End Sub

    Private Sub mainDTmr_Tick(sender As Object, e As EventArgs) Handles mainDTmr.Tick
        'Main Display Timer
        mainCount += 1

        'Clock
        If mainCount = 1 And clockEn Then
            Dim cTime = Format(Now, "hhmm")
            write2Display(cTime)
            clockTmr.Start()
        Else
            clockTmr.Stop()
        End If

        'Date
        If mainCount = 2 And dateEn Then
            Dim cD = Format(Now, "MMddyy")
            write2Display(cD)
        End If

        'Cpu Usage
        If mainCount = 3 And cpuEn Then
            writeCpu()
        End If

        'Reset Counter
        If mainCount = checkedNum Then
            mainCount = 0
        End If
    End Sub

    Private Sub cpuTmr_Tick(sender As Object, e As EventArgs) Handles cpuTmr.Tick
        writeCpu()
    End Sub
    Private Sub writeCpu()
        Dim myCounter As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter()

        myCounter.CategoryName = "Processor"
        myCounter.CounterName = "% Processor Time"
        myCounter.InstanceName = "_Total"
        MessageBox.Show(myCounter.NextValue().ToString()) 'cpu usage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        writeCpu()
    End Sub
End Class
