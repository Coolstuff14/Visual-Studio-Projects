<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timer
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
        Me.downChk = New System.Windows.Forms.CheckBox()
        Me.upChk = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.startNumTB = New System.Windows.Forms.TextBox()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.stopBtn = New System.Windows.Forms.Button()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.tTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'downChk
        '
        Me.downChk.AutoSize = True
        Me.downChk.Location = New System.Drawing.Point(246, 6)
        Me.downChk.Name = "downChk"
        Me.downChk.Size = New System.Drawing.Size(65, 21)
        Me.downChk.TabIndex = 14
        Me.downChk.Text = "Down"
        Me.downChk.UseVisualStyleBackColor = True
        '
        'upChk
        '
        Me.upChk.AutoSize = True
        Me.upChk.Location = New System.Drawing.Point(192, 5)
        Me.upChk.Name = "upChk"
        Me.upChk.Size = New System.Drawing.Size(48, 21)
        Me.upChk.TabIndex = 13
        Me.upChk.Text = "Up"
        Me.upChk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Start Point"
        '
        'startNumTB
        '
        Me.startNumTB.Location = New System.Drawing.Point(86, 5)
        Me.startNumTB.Name = "startNumTB"
        Me.startNumTB.Size = New System.Drawing.Size(100, 22)
        Me.startNumTB.TabIndex = 11
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(224, 33)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(75, 32)
        Me.resetBtn.TabIndex = 10
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'stopBtn
        '
        Me.stopBtn.Location = New System.Drawing.Point(143, 33)
        Me.stopBtn.Name = "stopBtn"
        Me.stopBtn.Size = New System.Drawing.Size(75, 32)
        Me.stopBtn.TabIndex = 9
        Me.stopBtn.Text = "Stop"
        Me.stopBtn.UseVisualStyleBackColor = True
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(62, 33)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(75, 32)
        Me.startBtn.TabIndex = 8
        Me.startBtn.Text = "Start"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'tTimer
        '
        Me.tTimer.Interval = 10
        '
        'timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(347, 78)
        Me.Controls.Add(Me.downChk)
        Me.Controls.Add(Me.upChk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.startNumTB)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.stopBtn)
        Me.Controls.Add(Me.startBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "timer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents downChk As System.Windows.Forms.CheckBox
    Friend WithEvents upChk As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents startNumTB As System.Windows.Forms.TextBox
    Friend WithEvents resetBtn As System.Windows.Forms.Button
    Friend WithEvents stopBtn As System.Windows.Forms.Button
    Friend WithEvents startBtn As System.Windows.Forms.Button
    Friend WithEvents tTimer As System.Windows.Forms.Timer
End Class
