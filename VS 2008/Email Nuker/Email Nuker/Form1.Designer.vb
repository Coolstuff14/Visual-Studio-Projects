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
        Me.Send_btn = New System.Windows.Forms.Button
        Me.from_box = New System.Windows.Forms.TextBox
        Me.pass_box = New System.Windows.Forms.MaskedTextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.to_box = New System.Windows.Forms.TextBox
        Me.subject_box = New System.Windows.Forms.TextBox
        Me.Body_box = New System.Windows.Forms.RichTextBox
        Me.Num_Emails = New System.Windows.Forms.NumericUpDown
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        CType(Me.Num_Emails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Send_btn
        '
        Me.Send_btn.BackColor = System.Drawing.Color.Transparent
        Me.Send_btn.BackgroundImage = Global.Email_Nuker.My.Resources.Resources.orcha_india_historic
        Me.Send_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Send_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Send_btn.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Send_btn.Location = New System.Drawing.Point(64, 432)
        Me.Send_btn.Name = "Send_btn"
        Me.Send_btn.Size = New System.Drawing.Size(234, 39)
        Me.Send_btn.TabIndex = 6
        Me.Send_btn.Text = "NUKE"
        Me.Send_btn.UseVisualStyleBackColor = False
        '
        'from_box
        '
        Me.from_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.from_box.BackColor = System.Drawing.Color.Black
        Me.from_box.ForeColor = System.Drawing.Color.Lime
        Me.from_box.Location = New System.Drawing.Point(33, 50)
        Me.from_box.Name = "from_box"
        Me.from_box.Size = New System.Drawing.Size(300, 22)
        Me.from_box.TabIndex = 0
        Me.from_box.Text = "Your gmail address"
        '
        'pass_box
        '
        Me.pass_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pass_box.BackColor = System.Drawing.Color.Black
        Me.pass_box.ForeColor = System.Drawing.Color.Lime
        Me.pass_box.Location = New System.Drawing.Point(33, 78)
        Me.pass_box.Name = "pass_box"
        Me.pass_box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass_box.Size = New System.Drawing.Size(175, 22)
        Me.pass_box.TabIndex = 1
        Me.pass_box.Text = "password"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(33, 398)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(300, 28)
        Me.ProgressBar1.TabIndex = 1000
        '
        'to_box
        '
        Me.to_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.to_box.BackColor = System.Drawing.Color.Black
        Me.to_box.ForeColor = System.Drawing.Color.Lime
        Me.to_box.Location = New System.Drawing.Point(33, 125)
        Me.to_box.Name = "to_box"
        Me.to_box.Size = New System.Drawing.Size(300, 22)
        Me.to_box.TabIndex = 2
        Me.to_box.Text = "Victim's email address"
        '
        'subject_box
        '
        Me.subject_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.subject_box.BackColor = System.Drawing.Color.Black
        Me.subject_box.ForeColor = System.Drawing.Color.Lime
        Me.subject_box.Location = New System.Drawing.Point(33, 170)
        Me.subject_box.Name = "subject_box"
        Me.subject_box.Size = New System.Drawing.Size(300, 22)
        Me.subject_box.TabIndex = 3
        Me.subject_box.Text = "Subject"
        '
        'Body_box
        '
        Me.Body_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Body_box.BackColor = System.Drawing.Color.Black
        Me.Body_box.ForeColor = System.Drawing.Color.Lime
        Me.Body_box.Location = New System.Drawing.Point(33, 198)
        Me.Body_box.Name = "Body_box"
        Me.Body_box.Size = New System.Drawing.Size(300, 166)
        Me.Body_box.TabIndex = 4
        Me.Body_box.Text = "Body"
        '
        'Num_Emails
        '
        Me.Num_Emails.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Num_Emails.AutoSize = True
        Me.Num_Emails.BackColor = System.Drawing.Color.Black
        Me.Num_Emails.ForeColor = System.Drawing.Color.Lime
        Me.Num_Emails.Location = New System.Drawing.Point(33, 370)
        Me.Num_Emails.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.Num_Emails.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num_Emails.Name = "Num_Emails"
        Me.Num_Emails.Size = New System.Drawing.Size(201, 22)
        Me.Num_Emails.TabIndex = 5
        Me.Num_Emails.ThousandsSeparator = True
        Me.Num_Emails.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Email_Nuker.My.Resources.Resources.nuke_sign
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(362, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Num_Emails)
        Me.Controls.Add(Me.Body_box)
        Me.Controls.Add(Me.subject_box)
        Me.Controls.Add(Me.to_box)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.pass_box)
        Me.Controls.Add(Me.from_box)
        Me.Controls.Add(Me.Send_btn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Nuker"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.Num_Emails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Send_btn As System.Windows.Forms.Button
    Friend WithEvents from_box As System.Windows.Forms.TextBox
    Friend WithEvents pass_box As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents to_box As System.Windows.Forms.TextBox
    Friend WithEvents subject_box As System.Windows.Forms.TextBox
    Friend WithEvents Body_box As System.Windows.Forms.RichTextBox
    Friend WithEvents Num_Emails As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
