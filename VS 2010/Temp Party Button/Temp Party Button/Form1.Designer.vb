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
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.codeTxt = New System.Windows.Forms.TextBox()
        Me.addModuleBtn = New System.Windows.Forms.Button()
        Me.deleteModuleBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startParty = New System.Windows.Forms.Button()
        Me.endParty = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.setCodeBtn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartPartyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndPartyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addActionbtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.deleteActionBtn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.checkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.actionClb = New System.Windows.Forms.CheckedListBox()
        Me.modulesClb = New System.Windows.Forms.CheckedListBox()
        Me.trafficTxt = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(113, 28)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'codeTxt
        '
        Me.codeTxt.Location = New System.Drawing.Point(12, 280)
        Me.codeTxt.Name = "codeTxt"
        Me.codeTxt.Size = New System.Drawing.Size(143, 22)
        Me.codeTxt.TabIndex = 1
        '
        'addModuleBtn
        '
        Me.addModuleBtn.Location = New System.Drawing.Point(15, 341)
        Me.addModuleBtn.Name = "addModuleBtn"
        Me.addModuleBtn.Size = New System.Drawing.Size(140, 24)
        Me.addModuleBtn.TabIndex = 2
        Me.addModuleBtn.Text = "Add Module"
        Me.addModuleBtn.UseVisualStyleBackColor = True
        '
        'deleteModuleBtn
        '
        Me.deleteModuleBtn.Location = New System.Drawing.Point(15, 371)
        Me.deleteModuleBtn.Name = "deleteModuleBtn"
        Me.deleteModuleBtn.Size = New System.Drawing.Size(140, 25)
        Me.deleteModuleBtn.TabIndex = 3
        Me.deleteModuleBtn.Text = "Delete Module"
        Me.deleteModuleBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Activate Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Modules"
        '
        'startParty
        '
        Me.startParty.BackColor = System.Drawing.Color.Lime
        Me.startParty.Location = New System.Drawing.Point(312, 312)
        Me.startParty.Name = "startParty"
        Me.startParty.Size = New System.Drawing.Size(291, 39)
        Me.startParty.TabIndex = 7
        Me.startParty.Text = "Start Party!"
        Me.startParty.UseVisualStyleBackColor = False
        '
        'endParty
        '
        Me.endParty.BackColor = System.Drawing.Color.Red
        Me.endParty.Location = New System.Drawing.Point(312, 357)
        Me.endParty.Name = "endParty"
        Me.endParty.Size = New System.Drawing.Size(291, 39)
        Me.endParty.TabIndex = 8
        Me.endParty.Text = "End Party"
        Me.endParty.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "X10 Traffic"
        '
        'setCodeBtn
        '
        Me.setCodeBtn.Location = New System.Drawing.Point(15, 311)
        Me.setCodeBtn.Name = "setCodeBtn"
        Me.setCodeBtn.Size = New System.Drawing.Size(140, 24)
        Me.setCodeBtn.TabIndex = 10
        Me.setCodeBtn.Text = "Set Code"
        Me.setCodeBtn.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "The party has started"
        Me.NotifyIcon1.BalloonTipTitle = "Party Button Monitor"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Party Button Monitor"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.StartPartyToolStripMenuItem, Me.EndPartyToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 100)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'StartPartyToolStripMenuItem
        '
        Me.StartPartyToolStripMenuItem.Name = "StartPartyToolStripMenuItem"
        Me.StartPartyToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.StartPartyToolStripMenuItem.Text = "Start Party"
        '
        'EndPartyToolStripMenuItem
        '
        Me.EndPartyToolStripMenuItem.Name = "EndPartyToolStripMenuItem"
        Me.EndPartyToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.EndPartyToolStripMenuItem.Text = "End Party"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Actions"
        '
        'addActionbtn
        '
        Me.addActionbtn.Location = New System.Drawing.Point(313, 267)
        Me.addActionbtn.Name = "addActionbtn"
        Me.addActionbtn.Size = New System.Drawing.Size(147, 39)
        Me.addActionbtn.TabIndex = 13
        Me.addActionbtn.Text = "Add Action"
        Me.addActionbtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'deleteActionBtn
        '
        Me.deleteActionBtn.Location = New System.Drawing.Point(466, 267)
        Me.deleteActionBtn.Name = "deleteActionBtn"
        Me.deleteActionBtn.Size = New System.Drawing.Size(138, 39)
        Me.deleteActionBtn.TabIndex = 14
        Me.deleteActionBtn.Text = "Delete Action"
        Me.deleteActionBtn.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearAllToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(135, 52)
        '
        'ClearAllToolStripMenuItem1
        '
        Me.ClearAllToolStripMenuItem1.Name = "ClearAllToolStripMenuItem1"
        Me.ClearAllToolStripMenuItem1.Size = New System.Drawing.Size(134, 24)
        Me.ClearAllToolStripMenuItem1.Text = "Clear All"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(134, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'checkTimer
        '
        Me.checkTimer.Interval = 15000
        '
        'actionClb
        '
        Me.actionClb.FormattingEnabled = True
        Me.actionClb.Location = New System.Drawing.Point(313, 29)
        Me.actionClb.Name = "actionClb"
        Me.actionClb.Size = New System.Drawing.Size(291, 225)
        Me.actionClb.TabIndex = 15
        '
        'modulesClb
        '
        Me.modulesClb.FormattingEnabled = True
        Me.modulesClb.Location = New System.Drawing.Point(161, 280)
        Me.modulesClb.Name = "modulesClb"
        Me.modulesClb.Size = New System.Drawing.Size(142, 123)
        Me.modulesClb.TabIndex = 16
        '
        'trafficTxt
        '
        Me.trafficTxt.BackColor = System.Drawing.Color.White
        Me.trafficTxt.ContextMenuStrip = Me.ContextMenuStrip3
        Me.trafficTxt.Location = New System.Drawing.Point(12, 28)
        Me.trafficTxt.Multiline = True
        Me.trafficTxt.Name = "trafficTxt"
        Me.trafficTxt.ReadOnly = True
        Me.trafficTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.trafficTxt.Size = New System.Drawing.Size(295, 226)
        Me.trafficTxt.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(616, 410)
        Me.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Controls.Add(Me.trafficTxt)
        Me.Controls.Add(Me.modulesClb)
        Me.Controls.Add(Me.actionClb)
        Me.Controls.Add(Me.deleteActionBtn)
        Me.Controls.Add(Me.addActionbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.setCodeBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.endParty)
        Me.Controls.Add(Me.startParty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.deleteModuleBtn)
        Me.Controls.Add(Me.addModuleBtn)
        Me.Controls.Add(Me.codeTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Party Button Monitor"
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents codeTxt As System.Windows.Forms.TextBox
    Friend WithEvents addModuleBtn As System.Windows.Forms.Button
    Friend WithEvents deleteModuleBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents startParty As System.Windows.Forms.Button
    Friend WithEvents endParty As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents setCodeBtn As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartPartyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndPartyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents addActionbtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents deleteActionBtn As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents checkTimer As System.Windows.Forms.Timer
    Friend WithEvents actionClb As System.Windows.Forms.CheckedListBox
    Friend WithEvents modulesClb As System.Windows.Forms.CheckedListBox
    Friend WithEvents trafficTxt As System.Windows.Forms.TextBox

End Class
