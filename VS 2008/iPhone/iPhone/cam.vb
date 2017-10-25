Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class cam
    Inherits System.Windows.Forms.Form

    Const WM_CAP_START = &H400S
    Const WS_CHILD = &H40000000
    Const WS_VISIBLE = &H10000000
    Const WM_CAP_DRIVER_CONNECT = WM_CAP_START + 10
    Const WM_CAP_DRIVER_DISCONNECT = WM_CAP_START + 11
    Const WM_CAP_EDIT_COPY = WM_CAP_START + 30
    Const WM_CAP_SEQUENCE = WM_CAP_START + 62
    Const WM_CAP_FILE_SAVEAS = WM_CAP_START + 23
    Const WM_CAP_SET_SCALE = WM_CAP_START + 53
    Const WM_CAP_SET_PREVIEWRATE = WM_CAP_START + 52
    Const WM_CAP_SET_PREVIEW = WM_CAP_START + 50
    Const SWP_NOMOVE = &H2S
    Const SWP_NOSIZE = 1
    Const SWP_NOZORDER = &H4S
    Const HWND_BOTTOM = 1
    '--The capGetDriverDescription function retrieves the version
    ' description of the capture driver--
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" _
    (ByVal wDriverIndex As Short, _
    ByVal lpszName As String, ByVal cbName As Integer, _
    ByVal lpszVer As String, _
    ByVal cbVer As Integer) As Boolean

    '--The capCreateCaptureWindow function creates a capture window--
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
    (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
    ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
    ByVal nHeight As Short, ByVal hWnd As Integer, _
    ByVal nID As Integer) As Integer

    '--This function sends the specified message to a window or windows--
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
    (ByVal hwnd As Integer, ByVal Msg As Integer, _
    ByVal wParam As Integer, _
    <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    '--Sets the position of the window relative to the screen buffer--
    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" _
    (ByVal hwnd As Integer, _
    ByVal hWndInsertAfter As Integer, ByVal x As Integer, _
    ByVal y As Integer, _
    ByVal cx As Integer, ByVal cy As Integer, _
    ByVal wFlags As Integer) As Integer

    '--This function destroys the specified window--
    Declare Function DestroyWindow Lib "user32" _
    (ByVal hndw As Integer) As Boolean

    '---used to identify the video source---
    Dim CamSource As Integer

    '---used as a window handle---
    Dim hWnd As Integer
    Private Sub previewCamera(ByVal pbCtrl As PictureBox)
        hWnd = capCreateCaptureWindowA(CamSource, _
        WS_VISIBLE Or WS_CHILD, 0, 0, 0, _
        0, pbCtrl.Handle.ToInt32, 0)
        If SendMessage( _
        hWnd, WM_CAP_DRIVER_CONNECT, _
        CamSource, 0) Then
            '---set the preview scale---
            SendMessage(hWnd, WM_CAP_SET_SCALE, True, 0)
            '---set the preview rate (ms)---
            SendMessage(hWnd, WM_CAP_SET_PREVIEWRATE, 30, 0)
            '---start previewing the image---
            SendMessage(hWnd, WM_CAP_SET_PREVIEW, True, 0)
            '---resize window to fit in PictureBox control---
            SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, _
            pbCtrl.Width, pbCtrl.Height, _
            SWP_NOMOVE Or SWP_NOZORDER)
            Panel2.BackColor = Color.Lime
        Else
            '--error connecting to video source---
            DestroyWindow(hWnd)

        End If
    End Sub

    Private Sub cam_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
       
    End Sub
    Private Sub cam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        previewCamera(PictureBox1)

    End Sub
    Private Sub stopPreviewCamera()
        SendMessage(hWnd, WM_CAP_DRIVER_DISCONNECT, CamSource, 0)
        DestroyWindow(hWnd)
    End Sub
 Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        previewCamera(PictureBox1)
        Me.Refresh()

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        stopPreviewCamera()
        MsgBox("Safe to Remove Webcam")
        Panel2.BackColor = Color.Red
    End Sub

  
End Class
