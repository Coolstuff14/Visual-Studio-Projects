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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ssidTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passTb = New System.Windows.Forms.MaskedTextBox()
        Me.GOBITCH = New System.Windows.Forms.Button()
        Me.startupChk = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SSID:"
        '
        'ssidTb
        '
        Me.ssidTb.Location = New System.Drawing.Point(12, 29)
        Me.ssidTb.Name = "ssidTb"
        Me.ssidTb.Size = New System.Drawing.Size(256, 22)
        Me.ssidTb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'passTb
        '
        Me.passTb.Location = New System.Drawing.Point(12, 74)
        Me.passTb.Name = "passTb"
        Me.passTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.passTb.Size = New System.Drawing.Size(256, 22)
        Me.passTb.TabIndex = 3
        '
        'GOBITCH
        '
        Me.GOBITCH.Location = New System.Drawing.Point(12, 102)
        Me.GOBITCH.Name = "GOBITCH"
        Me.GOBITCH.Size = New System.Drawing.Size(399, 40)
        Me.GOBITCH.TabIndex = 4
        Me.GOBITCH.Text = "DO IT!! JUST DO IT!!!"
        Me.GOBITCH.UseVisualStyleBackColor = True
        '
        'startupChk
        '
        Me.startupChk.AutoSize = True
        Me.startupChk.Location = New System.Drawing.Point(161, 5)
        Me.startupChk.Name = "startupChk"
        Me.startupChk.Size = New System.Drawing.Size(107, 21)
        Me.startupChk.TabIndex = 6
        Me.startupChk.Text = "On Startup?"
        Me.startupChk.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Da_Wifi.My.Resources.Resources.off
        Me.PictureBox1.Location = New System.Drawing.Point(274, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "DA WIFI"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "DA WIFI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(423, 154)
        Me.Controls.Add(Me.startupChk)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GOBITCH)
        Me.Controls.Add(Me.passTb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ssidTb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GIVE ME DA WIFI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ssidTb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents passTb As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GOBITCH As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents startupChk As System.Windows.Forms.CheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
