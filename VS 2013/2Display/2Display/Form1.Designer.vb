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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.numTB = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.scaleBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.scaleTb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.setpointBtn = New System.Windows.Forms.Button()
        Me.setpointTB = New System.Windows.Forms.TextBox()
        Me.countBChk = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.countAChk = New System.Windows.Forms.CheckBox()
        Me.portStatusTB = New System.Windows.Forms.TextBox()
        Me.closePortBtn = New System.Windows.Forms.Button()
        Me.clockTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.parityBitList = New System.Windows.Forms.ComboBox()
        Me.comList = New System.Windows.Forms.ComboBox()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.baudList = New System.Windows.Forms.ComboBox()
        Me.dataBitTB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.mainTab = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mainTAdj = New System.Windows.Forms.NumericUpDown()
        Me.mainChkls = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.timerBtn = New System.Windows.Forms.Button()
        Me.settingsTab = New System.Windows.Forms.TabPage()
        Me.mainDTmr = New System.Windows.Forms.Timer(Me.components)
        Me.cpuTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cpulbl = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.mainTab.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.mainTAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.settingsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.sendBtn)
        Me.GroupBox2.Controls.Add(Me.numTB)
        Me.GroupBox2.Location = New System.Drawing.Point(220, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(181, 104)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Write"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Numbers"
        '
        'sendBtn
        '
        Me.sendBtn.Location = New System.Drawing.Point(6, 66)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(169, 29)
        Me.sendBtn.TabIndex = 1
        Me.sendBtn.Text = "Send"
        Me.sendBtn.UseVisualStyleBackColor = True
        '
        'numTB
        '
        Me.numTB.Location = New System.Drawing.Point(6, 38)
        Me.numTB.MaxLength = 999999
        Me.numTB.Name = "numTB"
        Me.numTB.Size = New System.Drawing.Size(169, 22)
        Me.numTB.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.scaleBtn)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.scaleTb)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.setpointBtn)
        Me.GroupBox3.Controls.Add(Me.setpointTB)
        Me.GroupBox3.Controls.Add(Me.countBChk)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.countAChk)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 126)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(199, 226)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Advanced"
        '
        'scaleBtn
        '
        Me.scaleBtn.Location = New System.Drawing.Point(6, 188)
        Me.scaleBtn.Name = "scaleBtn"
        Me.scaleBtn.Size = New System.Drawing.Size(187, 27)
        Me.scaleBtn.TabIndex = 8
        Me.scaleBtn.Text = "Set"
        Me.scaleBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Scale Factor"
        '
        'scaleTb
        '
        Me.scaleTb.Location = New System.Drawing.Point(6, 160)
        Me.scaleTb.MaxLength = 999999
        Me.scaleTb.Name = "scaleTb"
        Me.scaleTb.Size = New System.Drawing.Size(187, 22)
        Me.scaleTb.TabIndex = 6
        Me.scaleTb.Text = "000000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "SetPoint"
        '
        'setpointBtn
        '
        Me.setpointBtn.Location = New System.Drawing.Point(6, 110)
        Me.setpointBtn.Name = "setpointBtn"
        Me.setpointBtn.Size = New System.Drawing.Size(187, 27)
        Me.setpointBtn.TabIndex = 4
        Me.setpointBtn.Text = "Set"
        Me.setpointBtn.UseVisualStyleBackColor = True
        '
        'setpointTB
        '
        Me.setpointTB.Location = New System.Drawing.Point(6, 82)
        Me.setpointTB.Name = "setpointTB"
        Me.setpointTB.Size = New System.Drawing.Size(187, 22)
        Me.setpointTB.TabIndex = 3
        Me.setpointTB.Text = "999999"
        '
        'countBChk
        '
        Me.countBChk.AutoSize = True
        Me.countBChk.Location = New System.Drawing.Point(105, 38)
        Me.countBChk.Name = "countBChk"
        Me.countBChk.Size = New System.Drawing.Size(93, 21)
        Me.countBChk.TabIndex = 2
        Me.countBChk.Text = "Counter B"
        Me.countBChk.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Counter"
        '
        'countAChk
        '
        Me.countAChk.AutoSize = True
        Me.countAChk.Checked = True
        Me.countAChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.countAChk.Location = New System.Drawing.Point(6, 38)
        Me.countAChk.Name = "countAChk"
        Me.countAChk.Size = New System.Drawing.Size(93, 21)
        Me.countAChk.TabIndex = 0
        Me.countAChk.Text = "Counter A"
        Me.countAChk.UseVisualStyleBackColor = True
        '
        'portStatusTB
        '
        Me.portStatusTB.BackColor = System.Drawing.Color.Red
        Me.portStatusTB.Location = New System.Drawing.Point(313, 330)
        Me.portStatusTB.Name = "portStatusTB"
        Me.portStatusTB.ReadOnly = True
        Me.portStatusTB.Size = New System.Drawing.Size(100, 22)
        Me.portStatusTB.TabIndex = 15
        Me.portStatusTB.Text = "PORT CLOSED"
        '
        'closePortBtn
        '
        Me.closePortBtn.Location = New System.Drawing.Point(220, 326)
        Me.closePortBtn.Name = "closePortBtn"
        Me.closePortBtn.Size = New System.Drawing.Size(87, 26)
        Me.closePortBtn.TabIndex = 16
        Me.closePortBtn.Text = "Close Port"
        Me.closePortBtn.UseVisualStyleBackColor = True
        '
        'clockTmr
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data Bit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Parity Bit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Com Port"
        '
        'parityBitList
        '
        Me.parityBitList.FormattingEnabled = True
        Me.parityBitList.Items.AddRange(New Object() {"odd", "even"})
        Me.parityBitList.Location = New System.Drawing.Point(282, 42)
        Me.parityBitList.Name = "parityBitList"
        Me.parityBitList.Size = New System.Drawing.Size(75, 24)
        Me.parityBitList.TabIndex = 7
        '
        'comList
        '
        Me.comList.FormattingEnabled = True
        Me.comList.Location = New System.Drawing.Point(10, 42)
        Me.comList.Name = "comList"
        Me.comList.Size = New System.Drawing.Size(94, 24)
        Me.comList.TabIndex = 2
        '
        'addressTB
        '
        Me.addressTB.Location = New System.Drawing.Point(363, 42)
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(57, 22)
        Me.addressTB.TabIndex = 10
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(12, 72)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(410, 29)
        Me.saveBtn.TabIndex = 11
        Me.saveBtn.Text = "Save and Open"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(107, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Baud"
        '
        'baudList
        '
        Me.baudList.FormattingEnabled = True
        Me.baudList.Items.AddRange(New Object() {"300", "600", "1200", "2400", "4800", "9600", "19200", "38400"})
        Me.baudList.Location = New System.Drawing.Point(110, 42)
        Me.baudList.Name = "baudList"
        Me.baudList.Size = New System.Drawing.Size(98, 24)
        Me.baudList.TabIndex = 13
        '
        'dataBitTB
        '
        Me.dataBitTB.Location = New System.Drawing.Point(214, 42)
        Me.dataBitTB.Name = "dataBitTB"
        Me.dataBitTB.Size = New System.Drawing.Size(62, 22)
        Me.dataBitTB.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dataBitTB)
        Me.GroupBox1.Controls.Add(Me.baudList)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.saveBtn)
        Me.GroupBox1.Controls.Add(Me.addressTB)
        Me.GroupBox1.Controls.Add(Me.comList)
        Me.GroupBox1.Controls.Add(Me.parityBitList)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 114)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setup"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.mainTab)
        Me.TabControl1.Controls.Add(Me.settingsTab)
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 393)
        Me.TabControl1.TabIndex = 19
        '
        'mainTab
        '
        Me.mainTab.BackColor = System.Drawing.SystemColors.Control
        Me.mainTab.Controls.Add(Me.GroupBox5)
        Me.mainTab.Controls.Add(Me.GroupBox4)
        Me.mainTab.Location = New System.Drawing.Point(4, 25)
        Me.mainTab.Name = "mainTab"
        Me.mainTab.Padding = New System.Windows.Forms.Padding(3)
        Me.mainTab.Size = New System.Drawing.Size(452, 364)
        Me.mainTab.TabIndex = 0
        Me.mainTab.Text = "Main"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.mainTAdj)
        Me.GroupBox5.Controls.Add(Me.mainChkls)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(215, 349)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Main Display"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Switch Delay (Sec)"
        '
        'mainTAdj
        '
        Me.mainTAdj.Location = New System.Drawing.Point(6, 228)
        Me.mainTAdj.Maximum = New Decimal(New Integer() {900, 0, 0, 0})
        Me.mainTAdj.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.mainTAdj.Name = "mainTAdj"
        Me.mainTAdj.Size = New System.Drawing.Size(136, 22)
        Me.mainTAdj.TabIndex = 21
        Me.mainTAdj.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'mainChkls
        '
        Me.mainChkls.FormattingEnabled = True
        Me.mainChkls.Items.AddRange(New Object() {"Clock", "Date", "Cpu Usage", "Memory Usage", "Memory Free", "Number Of Processes", "Network Usage Up", "Network Usage Down"})
        Me.mainChkls.Location = New System.Drawing.Point(6, 31)
        Me.mainChkls.Name = "mainChkls"
        Me.mainChkls.Size = New System.Drawing.Size(203, 174)
        Me.mainChkls.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cpulbl)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.timerBtn)
        Me.GroupBox4.Location = New System.Drawing.Point(229, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(213, 349)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Programs"
        '
        'timerBtn
        '
        Me.timerBtn.Location = New System.Drawing.Point(6, 21)
        Me.timerBtn.Name = "timerBtn"
        Me.timerBtn.Size = New System.Drawing.Size(201, 27)
        Me.timerBtn.TabIndex = 18
        Me.timerBtn.Text = "TIMER"
        Me.timerBtn.UseVisualStyleBackColor = True
        '
        'settingsTab
        '
        Me.settingsTab.BackColor = System.Drawing.SystemColors.Control
        Me.settingsTab.Controls.Add(Me.GroupBox1)
        Me.settingsTab.Controls.Add(Me.GroupBox2)
        Me.settingsTab.Controls.Add(Me.GroupBox3)
        Me.settingsTab.Controls.Add(Me.closePortBtn)
        Me.settingsTab.Controls.Add(Me.portStatusTB)
        Me.settingsTab.Location = New System.Drawing.Point(4, 25)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.settingsTab.Size = New System.Drawing.Size(452, 364)
        Me.settingsTab.TabIndex = 1
        Me.settingsTab.Text = "Settings"
        '
        'mainDTmr
        '
        '
        'cpuTmr
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cpulbl
        '
        Me.cpulbl.AutoSize = True
        Me.cpulbl.Location = New System.Drawing.Point(125, 205)
        Me.cpulbl.Name = "cpulbl"
        Me.cpulbl.Size = New System.Drawing.Size(59, 17)
        Me.cpulbl.TabIndex = 20
        Me.cpulbl.Text = "Label11"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(458, 393)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "2Display"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.mainTab.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.mainTAdj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.settingsTab.ResumeLayout(False)
        Me.settingsTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sendBtn As System.Windows.Forms.Button
    Friend WithEvents numTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents scaleBtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents scaleTb As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents setpointBtn As System.Windows.Forms.Button
    Friend WithEvents setpointTB As System.Windows.Forms.TextBox
    Friend WithEvents countBChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents countAChk As System.Windows.Forms.CheckBox
    Friend WithEvents portStatusTB As System.Windows.Forms.TextBox
    Friend WithEvents closePortBtn As System.Windows.Forms.Button
    Friend WithEvents clockTmr As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents parityBitList As System.Windows.Forms.ComboBox
    Friend WithEvents comList As System.Windows.Forms.ComboBox
    Friend WithEvents addressTB As System.Windows.Forms.TextBox
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents baudList As System.Windows.Forms.ComboBox
    Friend WithEvents dataBitTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents mainTab As System.Windows.Forms.TabPage
    Friend WithEvents settingsTab As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents timerBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents mainDTmr As System.Windows.Forms.Timer
    Friend WithEvents mainChkls As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mainTAdj As System.Windows.Forms.NumericUpDown
    Friend WithEvents cpuTmr As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cpulbl As System.Windows.Forms.Label

End Class
