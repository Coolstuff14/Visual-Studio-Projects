<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label13 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.pw2 = New System.Windows.Forms.MaskedTextBox
        Me.pw3 = New System.Windows.Forms.MaskedTextBox
        Me.pw5 = New System.Windows.Forms.MaskedTextBox
        Me.pw4 = New System.Windows.Forms.MaskedTextBox
        Me.pw1 = New System.Windows.Forms.MaskedTextBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.ea5 = New System.Windows.Forms.TextBox
        Me.ea4 = New System.Windows.Forms.TextBox
        Me.ea3 = New System.Windows.Forms.TextBox
        Me.ea2 = New System.Windows.Forms.TextBox
        Me.ea1 = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(222, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Time before change (miliseconds)"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(15, 195)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown2.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(323, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "From Address"
        '
        'pw2
        '
        Me.pw2.Location = New System.Drawing.Point(326, 63)
        Me.pw2.Name = "pw2"
        Me.pw2.Size = New System.Drawing.Size(137, 22)
        Me.pw2.TabIndex = 25
        '
        'pw3
        '
        Me.pw3.Location = New System.Drawing.Point(326, 91)
        Me.pw3.Name = "pw3"
        Me.pw3.Size = New System.Drawing.Size(137, 22)
        Me.pw3.TabIndex = 24
        '
        'pw5
        '
        Me.pw5.Location = New System.Drawing.Point(326, 147)
        Me.pw5.Name = "pw5"
        Me.pw5.Size = New System.Drawing.Size(137, 22)
        Me.pw5.TabIndex = 23
        '
        'pw4
        '
        Me.pw4.Location = New System.Drawing.Point(326, 119)
        Me.pw4.Name = "pw4"
        Me.pw4.Size = New System.Drawing.Size(137, 22)
        Me.pw4.TabIndex = 22
        '
        'pw1
        '
        Me.pw1.Location = New System.Drawing.Point(326, 35)
        Me.pw1.Name = "pw1"
        Me.pw1.Size = New System.Drawing.Size(137, 22)
        Me.pw1.TabIndex = 21
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(220, 8)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Use Emails"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ea5
        '
        Me.ea5.Location = New System.Drawing.Point(15, 147)
        Me.ea5.Name = "ea5"
        Me.ea5.Size = New System.Drawing.Size(305, 22)
        Me.ea5.TabIndex = 19
        '
        'ea4
        '
        Me.ea4.Location = New System.Drawing.Point(15, 119)
        Me.ea4.Name = "ea4"
        Me.ea4.Size = New System.Drawing.Size(305, 22)
        Me.ea4.TabIndex = 18
        '
        'ea3
        '
        Me.ea3.Location = New System.Drawing.Point(15, 91)
        Me.ea3.Name = "ea3"
        Me.ea3.Size = New System.Drawing.Size(305, 22)
        Me.ea3.TabIndex = 17
        '
        'ea2
        '
        Me.ea2.Location = New System.Drawing.Point(15, 63)
        Me.ea2.Name = "ea2"
        Me.ea2.Size = New System.Drawing.Size(305, 22)
        Me.ea2.TabIndex = 16
        '
        'ea1
        '
        Me.ea1.Location = New System.Drawing.Point(15, 35)
        Me.ea1.Name = "ea1"
        Me.ea1.Size = New System.Drawing.Size(305, 22)
        Me.ea1.TabIndex = 15
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 479)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pw2)
        Me.Controls.Add(Me.pw3)
        Me.Controls.Add(Me.pw5)
        Me.Controls.Add(Me.pw4)
        Me.Controls.Add(Me.pw1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ea5)
        Me.Controls.Add(Me.ea4)
        Me.Controls.Add(Me.ea3)
        Me.Controls.Add(Me.ea2)
        Me.Controls.Add(Me.ea1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Extra Advanced"
        Me.TopMost = True
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pw2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pw3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pw5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pw4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pw1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ea5 As System.Windows.Forms.TextBox
    Friend WithEvents ea4 As System.Windows.Forms.TextBox
    Friend WithEvents ea3 As System.Windows.Forms.TextBox
    Friend WithEvents ea2 As System.Windows.Forms.TextBox
    Friend WithEvents ea1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
