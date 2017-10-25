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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bBrowse = New System.Windows.Forms.Button()
        Me.tCharacters = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bRename = New System.Windows.Forms.Button()
        Me.showDir = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'bBrowse
        '
        Me.bBrowse.Location = New System.Drawing.Point(12, 12)
        Me.bBrowse.Name = "bBrowse"
        Me.bBrowse.Size = New System.Drawing.Size(231, 32)
        Me.bBrowse.TabIndex = 0
        Me.bBrowse.Text = "Browse for files"
        Me.bBrowse.UseVisualStyleBackColor = True
        '
        'tCharacters
        '
        Me.tCharacters.Location = New System.Drawing.Point(12, 67)
        Me.tCharacters.Name = "tCharacters"
        Me.tCharacters.Size = New System.Drawing.Size(231, 22)
        Me.tCharacters.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Characters before number "
        '
        'bRename
        '
        Me.bRename.Enabled = False
        Me.bRename.Location = New System.Drawing.Point(12, 95)
        Me.bRename.Name = "bRename"
        Me.bRename.Size = New System.Drawing.Size(231, 40)
        Me.bRename.TabIndex = 3
        Me.bRename.Text = "Rename"
        Me.bRename.UseVisualStyleBackColor = True
        '
        'showDir
        '
        Me.showDir.AutoSize = True
        Me.showDir.Checked = True
        Me.showDir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showDir.Location = New System.Drawing.Point(12, 145)
        Me.showDir.Name = "showDir"
        Me.showDir.Size = New System.Drawing.Size(220, 21)
        Me.showDir.TabIndex = 4
        Me.showDir.Text = "Show directory after operation"
        Me.showDir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(256, 178)
        Me.Controls.Add(Me.showDir)
        Me.Controls.Add(Me.bRename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tCharacters)
        Me.Controls.Add(Me.bBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Renamer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bBrowse As System.Windows.Forms.Button
    Friend WithEvents tCharacters As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bRename As System.Windows.Forms.Button
    Friend WithEvents showDir As System.Windows.Forms.CheckBox

End Class
