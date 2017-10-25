Public Class Form1
    Dim SAPI = CreateObject("SAPI.spvoice")
    Dim lv
    Dim clickcal
    Dim start
    Dim msg
    Dim progs
    Dim killcal
    Dim calclk
    Dim diff As String
    Dim world As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        lv = 0
        clickcal = 0
        ToolStripProgressBar2.Value = ToolStripProgressBar2.Maximum
        start = False
        Button1.Enabled = False
        toaster.Visible = False
        toastxt.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.more_foam, AudioPlayMode.BackgroundLoop)
        If ToolStripComboBox1.Text = "Easy" Then
            If lv = 0 Then
                world = 10
                diff = "easy"
                ToolStripProgressBar2.Maximum = 20
                ToolStripProgressBar2.Value = 20
                Timer1.Interval = 500
                PictureBox1.Visible = True
                PictureBox1.Height = (0)
                Timer1.Enabled = True
                start = True
            End If
        End If
        If ToolStripComboBox1.Text = "Medium" Then
            If lv = 0 Then
                world = 20
                diff = "med"
                ToolStripProgressBar2.Maximum = 25
                ToolStripProgressBar2.Value = 25
                Timer1.Interval = 200
                PictureBox1.Visible = True
                PictureBox1.Height = (0)
                Timer1.Enabled = True
                start = True
            End If
        End If
        If ToolStripComboBox1.Text = "Hard" Then
            If lv = 0 Then
                world = 15
                diff = "hard"
                ToolStripProgressBar2.Maximum = 30
                ToolStripProgressBar2.Value = 30
                Timer1.Interval = 60
                PictureBox1.Visible = True
                PictureBox1.Height = (0)
                Timer1.Enabled = True
                start = True
            End If
        End If
        If ToolStripComboBox1.Text = "Super Hard" Then
            If lv = 0 Then
                world = 30
                diff = "shard"
                ToolStripProgressBar2.Maximum = 50
                ToolStripProgressBar2.Value = 50
                Timer1.Interval = 30
                PictureBox1.Visible = True
                PictureBox1.Height = (0)
                Timer1.Enabled = True
                start = True
            End If
        End If

        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lv = lv + 4
        ToolStripProgressBar3.Value = lv
        PictureBox1.Height = (lv)
        If lv = 688 Then
            lost()
        End If
    End Sub

    Private Sub cal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cal.Click
        If start = True Then
            If killcal = True Then
              ToolStripProgressBar2.Increment(-1)
                If ToolStripProgressBar2.Value = 0 Then
                    win()
                End If
                If ToolStripProgressBar2.Value = world Then
                    My.Computer.Audio.Play(My.Resources.earth, AudioPlayMode.WaitToComplete)
                    killcal = False
                    My.Computer.Audio.Play(My.Resources.more_foam, AudioPlayMode.BackgroundLoop)
                    killcal = True
                End If
            End If
        End If
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reset()
    End Sub

    Private Sub plug_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles plug.Click
        If start = True Then
            killcal = False
            My.Computer.Audio.Stop()
            progs = ToolStripProgressBar2.Value
            ToolStripProgressBar2.Value = 0
            Timer1.Stop()
            Timer2.Enabled = True
            Me.BackgroundImage = My.Resources.unplug_kitchen
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
      End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        SAPI.speak("Switching to reserve power")
        killcal = True
        ToolStripProgressBar2.Value = progs
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.more_foam, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub ToolStripComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.TextChanged
        If ToolStripComboBox1.Text = "Choose level" Then
            Button1.Enabled = False
        End If
        If Not ToolStripComboBox1.Text = "Choose level" Then
            Button1.Enabled = True
        End If

    End Sub

    Private Sub reset()
        ToolStripProgressBar3.Value = 0
        PictureBox1.Height = (0)
        lv = 0
        Timer1.Enabled = False
        ToolStripProgressBar2.Value = 20
        clickcal = 0
        start = False
        Me.BackgroundImage = My.Resources.kitchen1
        Me.BackgroundImageLayout = ImageLayout.Stretch
        toaster.Visible = False
        toastxt.Visible = False
        killcal = False
        ToolStripProgressBar2.Value = ToolStripProgressBar2.Maximum
        Me.Cursor = Cursors.Default
        toastxt.Text = "You Found A Toaster"
        Button1.Enabled = False
        ToolStripComboBox1.Text = "Choose level"
        My.Computer.Audio.Stop()
    End Sub
    Private Sub win()
        My.Computer.Audio.Stop()
        If diff = "easy" Then
            My.Settings.easyW = My.Settings.easyW + 1
        End If
        If diff = "med" Then
            My.Settings.medW = My.Settings.medW + 1
        End If
        If diff = "hard" Then
            My.Settings.hardW = My.Settings.hardW + 1
        End If
        If diff = "shard" Then
            My.Settings.shardW = My.Settings.shardW + 1
        End If
        My.Settings.Save()
        ToolStripProgressBar3.Value = 0
        PictureBox1.Height = (0)
        lv = 0
        Timer1.Enabled = False
        msg = MsgBox("Would you like to reset?", MsgBoxStyle.YesNo, "YOU HAVE WON!!!")
        If msg = 6 Then
            reset()
        End If
        If msg = 7 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        rec.Show()
    End Sub

   
    Private Sub lost()
        My.Computer.Audio.Stop()
        Timer1.Enabled = False
        msg = MsgBox("Would you like to reset?", MsgBoxStyle.YesNo, "You Lost")
        If msg = 6 Then
            reset()
        End If
        If msg = 7 Then
            Me.Close()
        End If
        If diff = "easy" Then
            My.Settings.easyL = My.Settings.easyL + 1
        End If
        If diff = "med" Then
            My.Settings.medL = My.Settings.medL + 1
        End If
        If diff = "hard" Then
            My.Settings.hardL = My.Settings.hardL + 1
        End If
        If diff = "shard" Then
            My.Settings.shardL = My.Settings.shardL + 1
        End If
        My.Settings.Save()
    End Sub

    Private Sub ArmToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ArmToolStripMenuItem.Click
        Me.Cursor = Cursors.Cross
        killcal = True
        toastxt.Text = "Armed With Toaster"
        toaster.Visible = False
    End Sub
    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
        If start = True Then
            toaster.Visible = True
            toastxt.Visible = True
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If start = True Then
            toaster.Visible = True
            toastxt.Visible = True
        End If
    End Sub

    Private Sub cat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cat.Click
        If start = True Then
            AxWindowsMediaPlayer1.URL = "cat.wav"
        End If
    End Sub

   

End Class
