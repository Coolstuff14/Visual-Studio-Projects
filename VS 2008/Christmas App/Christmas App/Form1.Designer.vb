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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notify_contex = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangeSationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NorthPoleRadioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassicHolidayRadioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChristmasChannelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlayMusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePictureToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.notify_contex.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Error fetching song info"
        Me.NotifyIcon1.BalloonTipTitle = "Your listening to:"
        Me.NotifyIcon1.ContextMenuStrip = Me.notify_contex
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Christmas App"
        '
        'notify_contex
        '
        Me.notify_contex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ChangeSationToolStripMenuItem, Me.PlayMusicToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.notify_contex.Name = "notify_contex"
        Me.notify_contex.Size = New System.Drawing.Size(180, 124)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.ShowToolStripMenuItem.Text = "Show/Hide"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ChangeSationToolStripMenuItem
        '
        Me.ChangeSationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NorthPoleRadioToolStripMenuItem, Me.FmToolStripMenuItem, Me.ClassicHolidayRadioToolStripMenuItem, Me.ChristmasChannelToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.ChangeSationToolStripMenuItem.Name = "ChangeSationToolStripMenuItem"
        Me.ChangeSationToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.ChangeSationToolStripMenuItem.Text = "Change Station"
        '
        'NorthPoleRadioToolStripMenuItem
        '
        Me.NorthPoleRadioToolStripMenuItem.Name = "NorthPoleRadioToolStripMenuItem"
        Me.NorthPoleRadioToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.NorthPoleRadioToolStripMenuItem.Text = "North Pole Radio"
        '
        'FmToolStripMenuItem
        '
        Me.FmToolStripMenuItem.Name = "FmToolStripMenuItem"
        Me.FmToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.FmToolStripMenuItem.Text = "1Fm"
        '
        'ClassicHolidayRadioToolStripMenuItem
        '
        Me.ClassicHolidayRadioToolStripMenuItem.Name = "ClassicHolidayRadioToolStripMenuItem"
        Me.ClassicHolidayRadioToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ClassicHolidayRadioToolStripMenuItem.Text = "Classic Holiday Radio"
        '
        'ChristmasChannelToolStripMenuItem
        '
        Me.ChristmasChannelToolStripMenuItem.Name = "ChristmasChannelToolStripMenuItem"
        Me.ChristmasChannelToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ChristmasChannelToolStripMenuItem.Text = "Christmas channel"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'PlayMusicToolStripMenuItem
        '
        Me.PlayMusicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePictureToolStripMenuItem1, Me.AutoplayToolStripMenuItem})
        Me.PlayMusicToolStripMenuItem.Name = "PlayMusicToolStripMenuItem"
        Me.PlayMusicToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.PlayMusicToolStripMenuItem.Text = "Settings"
        '
        'ChangePictureToolStripMenuItem1
        '
        Me.ChangePictureToolStripMenuItem1.Name = "ChangePictureToolStripMenuItem1"
        Me.ChangePictureToolStripMenuItem1.Size = New System.Drawing.Size(177, 24)
        Me.ChangePictureToolStripMenuItem1.Text = "Change Picture"
        '
        'AutoplayToolStripMenuItem
        '
        Me.AutoplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
        Me.AutoplayToolStripMenuItem.Name = "AutoplayToolStripMenuItem"
        Me.AutoplayToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.AutoplayToolStripMenuItem.Text = "Autoplay"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.OnToolStripMenuItem.Text = "On "
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Christmas_App.My.Resources.Resources.Tree1
        Me.PictureBox1.Location = New System.Drawing.Point(13, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MediaPlayer1
        '
        Me.MediaPlayer1.Enabled = True
        Me.MediaPlayer1.Location = New System.Drawing.Point(275, 267)
        Me.MediaPlayer1.Name = "MediaPlayer1"
        Me.MediaPlayer1.OcxState = CType(resources.GetObject("MediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer1.Size = New System.Drawing.Size(10, 12)
        Me.MediaPlayer1.TabIndex = 2
        Me.MediaPlayer1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(299, 339)
        Me.ContextMenuStrip = Me.notify_contex
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MediaPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.notify_contex.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents notify_contex As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ChangeSationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NorthPoleRadioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassicHolidayRadioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChristmasChannelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayMusicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePictureToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
