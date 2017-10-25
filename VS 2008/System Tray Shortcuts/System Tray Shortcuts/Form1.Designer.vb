<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.trayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.bBrowse = New System.Windows.Forms.Button
        Me.tPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.bExit = New System.Windows.Forms.Button
        Me.FolderDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SuspendLayout()
        '
        'trayMenu
        '
        Me.trayMenu.Name = "ContextMenuStrip1"
        Me.trayMenu.Size = New System.Drawing.Size(61, 4)
        '
        'trayIcon
        '
        Me.trayIcon.ContextMenuStrip = Me.trayMenu
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "trayIcon"
        Me.trayIcon.Visible = True
        '
        'bBrowse
        '
        Me.bBrowse.Location = New System.Drawing.Point(12, 57)
        Me.bBrowse.Name = "bBrowse"
        Me.bBrowse.Size = New System.Drawing.Size(328, 23)
        Me.bBrowse.TabIndex = 1
        Me.bBrowse.Text = "Browse"
        Me.bBrowse.UseVisualStyleBackColor = True
        '
        'tPath
        '
        Me.tPath.Location = New System.Drawing.Point(12, 29)
        Me.tPath.Name = "tPath"
        Me.tPath.Size = New System.Drawing.Size(328, 22)
        Me.tPath.TabIndex = 2
        Me.tPath.Text = "No Path Set"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Shortcut folder location"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "About"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(183, 86)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(157, 23)
        Me.bExit.TabIndex = 5
        Me.bExit.Text = "Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 120)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tPath)
        Me.Controls.Add(Me.bBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "System Tray Shortcuts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents trayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents bBrowse As System.Windows.Forms.Button
    Friend WithEvents tPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents FolderDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
