Imports System
Imports System.IO.Ports
Public Class GlobalVars
    'Global variables shared by all forms
    'General
    Public Shared displaySerial As New SerialPort
    Public Shared currentCounter As String

    'Port info
    Public Shared spAddress As String
    Public Shared spCom As String
    Public Shared spBaud As String
    Public Shared spDataBit As String
    Public Shared spParity As String

    'Main display flags
    Public Shared clockEn As Boolean
    Public Shared dateEn As Boolean
    Public Shared cpuEn As Boolean
    Public Shared memUseEn As Boolean
    Public Shared memFreeEn As Boolean
    Public Shared processEn As Boolean
    Public Shared netUseUpEn As Boolean
    Public Shared netUseDownEn As Boolean

End Class
