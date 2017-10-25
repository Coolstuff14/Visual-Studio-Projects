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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Body_Box1 = New System.Windows.Forms.RichTextBox
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExtraAdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SlowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MediumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FastlaggyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NINJAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Data_Box1 = New System.Windows.Forms.RichTextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.bcc_box = New System.Windows.Forms.TextBox
        Me.bcc_list = New System.Windows.Forms.ListBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cc_box = New System.Windows.Forms.TextBox
        Me.Cc_list = New System.Windows.Forms.ListBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Email Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 77)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(230, 22)
        Me.TextBox3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Their Email Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amout to send:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(248, 78)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Subject:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(417, 22)
        Me.TextBox4.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Body:"
        '
        'Body_Box1
        '
        Me.Body_Box1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Body_Box1.Location = New System.Drawing.Point(12, 167)
        Me.Body_Box1.Name = "Body_Box1"
        Me.Body_Box1.Size = New System.Drawing.Size(417, 158)
        Me.Body_Box1.TabIndex = 11
        Me.Body_Box1.Text = ""
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.CenterToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(122, 76)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.CenterToolStripMenuItem.Text = "Center"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 382)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(417, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "0% Complete"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(251, 29)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MaskedTextBox1.Size = New System.Drawing.Size(178, 22)
        Me.MaskedTextBox1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 6000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "0 of 0 Sent"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Double click to open "
        Me.NotifyIcon1.BalloonTipTitle = "Look"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Email Sender"
        Me.NotifyIcon1.Visible = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(354, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Pause"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(248, 331)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.ExtraAdvancedToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 76)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.HelpToolStripMenuItem.Text = "Info"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'ExtraAdvancedToolStripMenuItem
        '
        Me.ExtraAdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlowToolStripMenuItem, Me.MediumToolStripMenuItem, Me.FastlaggyToolStripMenuItem, Me.NINJAToolStripMenuItem})
        Me.ExtraAdvancedToolStripMenuItem.Name = "ExtraAdvancedToolStripMenuItem"
        Me.ExtraAdvancedToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.ExtraAdvancedToolStripMenuItem.Text = "Send Speed"
        '
        'SlowToolStripMenuItem
        '
        Me.SlowToolStripMenuItem.Name = "SlowToolStripMenuItem"
        Me.SlowToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.SlowToolStripMenuItem.Text = "Slow"
        '
        'MediumToolStripMenuItem
        '
        Me.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem"
        Me.MediumToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.MediumToolStripMenuItem.Text = "Medium"
        '
        'FastlaggyToolStripMenuItem
        '
        Me.FastlaggyToolStripMenuItem.Name = "FastlaggyToolStripMenuItem"
        Me.FastlaggyToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.FastlaggyToolStripMenuItem.Text = "Fast"
        '
        'NINJAToolStripMenuItem
        '
        Me.NINJAToolStripMenuItem.Name = "NINJAToolStripMenuItem"
        Me.NINJAToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.NINJAToolStripMenuItem.Text = "NINJA SPEED!"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(336, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 21)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Use Blog"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(9, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(321, 22)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "Blog Address Here"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'Data_Box1
        '
        Me.Data_Box1.Location = New System.Drawing.Point(20, 442)
        Me.Data_Box1.Name = "Data_Box1"
        Me.Data_Box1.Size = New System.Drawing.Size(51, 42)
        Me.Data_Box1.TabIndex = 21
        Me.Data_Box1.Text = ""
        Me.Data_Box1.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(120, 484)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(28, 22)
        Me.TextBox5.TabIndex = 22
        Me.TextBox5.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.bcc_box)
        Me.GroupBox1.Controls.Add(Me.bcc_list)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Cc_box)
        Me.GroupBox1.Controls.Add(Me.Cc_list)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(444, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 396)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Advanced"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(9, 359)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(411, 30)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Insert Picture From URL (Html)"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(282, 323)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(138, 30)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Reset"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(9, 323)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(267, 30)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Convert Body To HTML"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(335, 204)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Bcc"
        '
        'bcc_box
        '
        Me.bcc_box.Location = New System.Drawing.Point(9, 204)
        Me.bcc_box.Name = "bcc_box"
        Me.bcc_box.Size = New System.Drawing.Size(320, 22)
        Me.bcc_box.TabIndex = 26
        '
        'bcc_list
        '
        Me.bcc_list.FormattingEnabled = True
        Me.bcc_list.ItemHeight = 16
        Me.bcc_list.Location = New System.Drawing.Point(9, 233)
        Me.bcc_list.Name = "bcc_list"
        Me.bcc_list.ScrollAlwaysVisible = True
        Me.bcc_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.bcc_list.Size = New System.Drawing.Size(411, 84)
        Me.bcc_list.TabIndex = 25
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(335, 68)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Cc"
        '
        'Cc_box
        '
        Me.Cc_box.Location = New System.Drawing.Point(9, 68)
        Me.Cc_box.Name = "Cc_box"
        Me.Cc_box.Size = New System.Drawing.Size(320, 22)
        Me.Cc_box.TabIndex = 22
        '
        'Cc_list
        '
        Me.Cc_list.FormattingEnabled = True
        Me.Cc_list.ItemHeight = 16
        Me.Cc_list.Location = New System.Drawing.Point(9, 97)
        Me.Cc_list.Name = "Cc_list"
        Me.Cc_list.ScrollAlwaysVisible = True
        Me.Cc_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.Cc_list.Size = New System.Drawing.Size(411, 84)
        Me.Cc_list.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 416)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Data_Box1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Body_Box1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Email Spammer"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Body_Box1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Data_Box1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cc_list As System.Windows.Forms.ListBox
    Friend WithEvents Cc_box As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bcc_box As System.Windows.Forms.TextBox
    Friend WithEvents bcc_list As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CenterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtraAdvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FastlaggyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NINJAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
