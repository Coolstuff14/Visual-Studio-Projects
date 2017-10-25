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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripProgressBar3 = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cal = New System.Windows.Forms.Panel
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.plug = New System.Windows.Forms.Panel
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.toaster = New System.Windows.Forms.PictureBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ArmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toastxt = New System.Windows.Forms.Label
        Me.cat = New System.Windows.Forms.Panel
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.ToolStrip1.SuspendLayout()
        Me.cal.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripProgressBar2, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripProgressBar3, Me.ToolStripSeparator1, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1177, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(44, 25)
        Me.ToolStripLabel2.Text = "C.A.L."
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Maximum = 50
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar2.ToolTipText = "C.A.L. Energy Level"
        Me.ToolStripProgressBar2.Value = 50
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(84, 25)
        Me.ToolStripLabel3.Text = "Foam Level"
        '
        'ToolStripProgressBar3
        '
        Me.ToolStripProgressBar3.Maximum = 688
        Me.ToolStripProgressBar3.Name = "ToolStripProgressBar3"
        Me.ToolStripProgressBar3.Size = New System.Drawing.Size(500, 25)
        Me.ToolStripProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ToolStripProgressBar3.ToolTipText = "Levels Of Rising Foam From C.A.L."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Easy", "Medium", "Hard", "Super Hard"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ToolStripComboBox1.Text = "Choose level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "C.A.L."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(882, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'cal
        '
        Me.cal.BackColor = System.Drawing.Color.Transparent
        Me.cal.Controls.Add(Me.Label1)
        Me.cal.Location = New System.Drawing.Point(872, 248)
        Me.cal.Name = "cal"
        Me.cal.Size = New System.Drawing.Size(304, 266)
        Me.cal.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(963, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.Panel1.Location = New System.Drawing.Point(410, 588)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 93)
        Me.Panel1.TabIndex = 7
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(115, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 24)
        Me.ToolStripMenuItem1.Text = "Open"
        '
        'plug
        '
        Me.plug.BackColor = System.Drawing.Color.Transparent
        Me.plug.Location = New System.Drawing.Point(745, 397)
        Me.plug.Name = "plug"
        Me.plug.Size = New System.Drawing.Size(32, 23)
        Me.plug.TabIndex = 8
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1061, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 28)
        Me.Button3.TabIndex = 9
        Me.Button3.Tag = ""
        Me.Button3.Text = "Records"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.More_Foam.My.Resources.Resources.foam3
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 704)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1177, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'toaster
        '
        Me.toaster.BackColor = System.Drawing.Color.Transparent
        Me.toaster.ContextMenuStrip = Me.ContextMenuStrip1
        Me.toaster.Image = Global.More_Foam.My.Resources.Resources.rg1024_toaster
        Me.toaster.Location = New System.Drawing.Point(217, 31)
        Me.toaster.Name = "toaster"
        Me.toaster.Size = New System.Drawing.Size(40, 25)
        Me.toaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.toaster.TabIndex = 12
        Me.toaster.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArmToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 28)
        '
        'ArmToolStripMenuItem
        '
        Me.ArmToolStripMenuItem.Name = "ArmToolStripMenuItem"
        Me.ArmToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.ArmToolStripMenuItem.Text = "Use"
        '
        'toastxt
        '
        Me.toastxt.AutoSize = True
        Me.toastxt.BackColor = System.Drawing.Color.Transparent
        Me.toastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toastxt.ForeColor = System.Drawing.Color.Red
        Me.toastxt.Location = New System.Drawing.Point(12, 31)
        Me.toastxt.Name = "toastxt"
        Me.toastxt.Size = New System.Drawing.Size(199, 25)
        Me.toastxt.TabIndex = 13
        Me.toastxt.Text = "You Found A Toaster"
        '
        'cat
        '
        Me.cat.BackColor = System.Drawing.Color.Transparent
        Me.cat.Location = New System.Drawing.Point(671, 183)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(54, 33)
        Me.cat.TabIndex = 15
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(1166, 705)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(10, 10)
        Me.AxWindowsMediaPlayer1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.More_Foam.My.Resources.Resources.kitchen1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 714)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.plug)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.toastxt)
        Me.Controls.Add(Me.toaster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More Foam The Game!!"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.cal.ResumeLayout(False)
        Me.cal.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripProgressBar3 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cal As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents plug As System.Windows.Forms.Panel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents toaster As System.Windows.Forms.PictureBox
    Friend WithEvents toastxt As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ArmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cat As System.Windows.Forms.Panel

End Class
