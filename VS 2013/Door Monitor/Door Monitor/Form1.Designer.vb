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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.vlcFeed = New AxAXVLC.AxVLCPlugin2()
        Me.viewBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordTb = New System.Windows.Forms.MaskedTextBox()
        Me.usernmTb = New System.Windows.Forms.TextBox()
        Me.urlTb = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OverlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hideTmr = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnStartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.vlcFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'vlcFeed
        '
        Me.vlcFeed.Enabled = True
        Me.vlcFeed.Location = New System.Drawing.Point(12, 12)
        Me.vlcFeed.Name = "vlcFeed"
        Me.vlcFeed.OcxState = CType(resources.GetObject("vlcFeed.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlcFeed.Size = New System.Drawing.Size(400, 300)
        Me.vlcFeed.TabIndex = 0
        '
        'viewBtn
        '
        Me.viewBtn.Location = New System.Drawing.Point(268, 366)
        Me.viewBtn.Name = "viewBtn"
        Me.viewBtn.Size = New System.Drawing.Size(145, 47)
        Me.viewBtn.TabIndex = 1
        Me.viewBtn.Text = "Save and View"
        Me.viewBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Url (NO HTTP://)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'passwordTb
        '
        Me.passwordTb.Location = New System.Drawing.Point(91, 394)
        Me.passwordTb.Name = "passwordTb"
        Me.passwordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTb.Size = New System.Drawing.Size(158, 22)
        Me.passwordTb.TabIndex = 7
        '
        'usernmTb
        '
        Me.usernmTb.Location = New System.Drawing.Point(91, 363)
        Me.usernmTb.Name = "usernmTb"
        Me.usernmTb.Size = New System.Drawing.Size(158, 22)
        Me.usernmTb.TabIndex = 3
        '
        'urlTb
        '
        Me.urlTb.Location = New System.Drawing.Point(15, 335)
        Me.urlTb.Name = "urlTb"
        Me.urlTb.Size = New System.Drawing.Size(397, 22)
        Me.urlTb.TabIndex = 2
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "Door Monitor"
        Me.NotifyIcon1.ContextMenuStrip = Me.mainMenu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Door Monitor"
        '
        'mainMenu
        '
        Me.mainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverlayToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(176, 104)
        '
        'OverlayToolStripMenuItem
        '
        Me.OverlayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem, Me.MediumToolStripMenuItem, Me.LargeToolStripMenuItem})
        Me.OverlayToolStripMenuItem.Name = "OverlayToolStripMenuItem"
        Me.OverlayToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.OverlayToolStripMenuItem.Text = "Overlay"
        '
        'SmallToolStripMenuItem
        '
        Me.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem"
        Me.SmallToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.SmallToolStripMenuItem.Text = "Small"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'LargeToolStripMenuItem
        '
        Me.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem"
        Me.LargeToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.LargeToolStripMenuItem.Text = "Large"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'hideTmr
        '
        Me.hideTmr.Enabled = True
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnStartupToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'OnStartupToolStripMenuItem
        '
        Me.OnStartupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YesToolStripMenuItem, Me.NoToolStripMenuItem})
        Me.OnStartupToolStripMenuItem.Name = "OnStartupToolStripMenuItem"
        Me.OnStartupToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.OnStartupToolStripMenuItem.Text = "On Startup"
        '
        'YesToolStripMenuItem
        '
        Me.YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        Me.YesToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.YesToolStripMenuItem.Text = "Yes"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.NoToolStripMenuItem.Text = "No"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 428)
        Me.Controls.Add(Me.passwordTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usernmTb)
        Me.Controls.Add(Me.urlTb)
        Me.Controls.Add(Me.viewBtn)
        Me.Controls.Add(Me.vlcFeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Door Monitor"
        CType(Me.vlcFeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vlcFeed As AxAXVLC.AxVLCPlugin2
    Friend WithEvents viewBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents passwordTb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents usernmTb As System.Windows.Forms.TextBox
    Friend WithEvents urlTb As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents hideTmr As System.Windows.Forms.Timer
    Friend WithEvents mainMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OverlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnStartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
