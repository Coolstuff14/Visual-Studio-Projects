<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overlay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(overlay))
        Me.overlayFeed = New AxAXVLC.AxVLCPlugin2()
        Me.unlockBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        CType(Me.overlayFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'overlayFeed
        '
        Me.overlayFeed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.overlayFeed.Enabled = True
        Me.overlayFeed.Location = New System.Drawing.Point(0, 0)
        Me.overlayFeed.Name = "overlayFeed"
        Me.overlayFeed.OcxState = CType(resources.GetObject("overlayFeed.OcxState"), System.Windows.Forms.AxHost.State)
        Me.overlayFeed.Size = New System.Drawing.Size(216, 162)
        Me.overlayFeed.TabIndex = 0
        '
        'unlockBtn
        '
        Me.unlockBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.unlockBtn.AutoSize = True
        Me.unlockBtn.Enabled = False
        Me.unlockBtn.Location = New System.Drawing.Point(0, 168)
        Me.unlockBtn.Name = "unlockBtn"
        Me.unlockBtn.Size = New System.Drawing.Size(100, 30)
        Me.unlockBtn.TabIndex = 1
        Me.unlockBtn.Text = "Unlock Door"
        Me.unlockBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.AutoSize = True
        Me.closeBtn.Location = New System.Drawing.Point(115, 168)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(100, 30)
        Me.closeBtn.TabIndex = 2
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'overlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(216, 210)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.unlockBtn)
        Me.Controls.Add(Me.overlayFeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "overlay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "overlay"
        Me.TopMost = True
        CType(Me.overlayFeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents overlayFeed As AxAXVLC.AxVLCPlugin2
    Friend WithEvents unlockBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.Button
End Class
