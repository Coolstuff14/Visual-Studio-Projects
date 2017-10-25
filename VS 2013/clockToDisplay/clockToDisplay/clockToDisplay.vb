Imports System.IO.Ports
Imports System
Imports System.Runtime.InteropServices
Imports System.Timers
Public Class clockToDisplay
    Public Shared displaySerial As New SerialPort
    Dim oldTm = 0 'Old time for clock comparison
    Private Shared cTimer As Timer

    Protected Overrides Sub OnStart(ByVal args() As String)
        Dim serviceStatus As ServiceStatus = New ServiceStatus()
        ' Update the service state to Start Pending.
        serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING
        serviceStatus.dwWaitHint = 100000
        SetServiceStatus(Me.ServiceHandle, serviceStatus)

        'Open Port
        openPort()

        ' Create a timer with a two second interval.
        cTimer = New System.Timers.Timer(1000)
        ' Hook up the Elapsed event for the timer.  
        AddHandler cTimer.Elapsed, AddressOf OnTimedEvent
        cTimer.Enabled = True

        ' Update the service state to Running.
        serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING
        SetServiceStatus(Me.ServiceHandle, serviceStatus)

    End Sub
    Public Sub openPort()
        'Try and open port
        'Setup port with settings
        displaySerial.PortName = "COM3"
        displaySerial.BaudRate = "9600"
        displaySerial.DataBits = "7"
        displaySerial.Parity = Parity.Odd

        'Try and open port with settings
        Try
            displaySerial.Open()
        Catch ex As Exception
            'If error try closing and re-opening port 
            Try
                displaySerial.Close()
                displaySerial.Open()
            Catch exx As Exception
                'Didn't work error to the max!
                MsgBox("COM3 In Use! Unable to open port!", MsgBoxStyle.Exclamation, "PORT ERROR")
            End Try
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        cTimer.Enabled = False
        displaySerial.Close()
        Dim serviceStatus As ServiceStatus = New ServiceStatus()
        ' Update the service state to Stoped.
        serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED
        SetServiceStatus(Me.ServiceHandle, serviceStatus)
    End Sub

    Private Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)
        'Write current time to clock
        Dim cT = Format(Now, "hhmm")
        If oldTm <> cT Then
            oldTm = cT
            'Writing to LD2006P0 or LD4006P0
            'Format is a follows:
            'N = node address
            'V = write value change
            'A or B = counter to write to 
            '$ or * to mark end of string
            displaySerial.Write("N0VA" + cT + "$")
        End If
    End Sub

    Declare Auto Function SetServiceStatus Lib "advapi32.dll" (ByVal handle As IntPtr, ByRef serviceStatus As ServiceStatus) As Boolean
    Public Enum ServiceState
        SERVICE_STOPPED = 1
        SERVICE_START_PENDING = 2
        SERVICE_STOP_PENDING = 3
        SERVICE_RUNNING = 4
        SERVICE_CONTINUE_PENDING = 5
        SERVICE_PAUSE_PENDING = 6
        SERVICE_PAUSED = 7
    End Enum

    <StructLayout(LayoutKind.Sequential)>
    Public Structure ServiceStatus
        Public dwServiceType As Long
        Public dwCurrentState As ServiceState
        Public dwControlsAccepted As Long
        Public dwWin32ExitCode As Long
        Public dwServiceSpecificExitCode As Long
        Public dwCheckPoint As Long
        Public dwWaitHint As Long
    End Structure
End Class
