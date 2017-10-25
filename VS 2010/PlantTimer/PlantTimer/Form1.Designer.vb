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
        Me.trafficTxt = New System.Windows.Forms.RichTextBox()
        Me.modulesClb = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.deleteModuleBtn = New System.Windows.Forms.Button()
        Me.addModuleBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.timeSel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.mainTmr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X10 Traffic"
        '
        'trafficTxt
        '
        Me.trafficTxt.Location = New System.Drawing.Point(12, 29)
        Me.trafficTxt.Name = "trafficTxt"
        Me.trafficTxt.Size = New System.Drawing.Size(256, 97)
        Me.trafficTxt.TabIndex = 1
        Me.trafficTxt.Text = ""
        '
        'modulesClb
        '
        Me.modulesClb.FormattingEnabled = True
        Me.modulesClb.Location = New System.Drawing.Point(12, 149)
        Me.modulesClb.Name = "modulesClb"
        Me.modulesClb.Size = New System.Drawing.Size(126, 89)
        Me.modulesClb.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modules"
        '
        'deleteModuleBtn
        '
        Me.deleteModuleBtn.Location = New System.Drawing.Point(144, 186)
        Me.deleteModuleBtn.Name = "deleteModuleBtn"
        Me.deleteModuleBtn.Size = New System.Drawing.Size(124, 30)
        Me.deleteModuleBtn.TabIndex = 4
        Me.deleteModuleBtn.Text = "Delete Module"
        Me.deleteModuleBtn.UseVisualStyleBackColor = True
        '
        'addModuleBtn
        '
        Me.addModuleBtn.Location = New System.Drawing.Point(144, 149)
        Me.addModuleBtn.Name = "addModuleBtn"
        Me.addModuleBtn.Size = New System.Drawing.Size(124, 31)
        Me.addModuleBtn.TabIndex = 5
        Me.addModuleBtn.Text = "Add Module"
        Me.addModuleBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(274, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 41)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Run"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'timeSel
        '
        Me.timeSel.FormattingEnabled = True
        Me.timeSel.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30"})
        Me.timeSel.Location = New System.Drawing.Point(274, 52)
        Me.timeSel.Name = "timeSel"
        Me.timeSel.Size = New System.Drawing.Size(121, 24)
        Me.timeSel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Time On / Off"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(274, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 41)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Stop"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'mainTmr
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(413, 250)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.timeSel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.addModuleBtn)
        Me.Controls.Add(Me.deleteModuleBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.modulesClb)
        Me.Controls.Add(Me.trafficTxt)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Plant Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trafficTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents modulesClb As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents deleteModuleBtn As System.Windows.Forms.Button
    Friend WithEvents addModuleBtn As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents timeSel As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents mainTmr As System.Windows.Forms.Timer

End Class
