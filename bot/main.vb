Imports System.Runtime.InteropServices
Public Class main
    Dim progress As Integer = 0
    Dim half As Boolean = False
    <DllImport("user32.dll")> _
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Private Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal text As System.Text.StringBuilder, ByVal count As Integer) As Integer
    End Function

    Private Function GetActiveWindowTitle() As String
        Const nChars As Integer = 256
        Dim handle As IntPtr = IntPtr.Zero
        Dim Buff As New System.Text.StringBuilder(nChars)
        handle = GetForegroundWindow()

        If GetWindowText(handle, Buff, nChars) > 0 Then
            Return Buff.ToString()
        End If
        Return Nothing
    End Function

    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        stb.Text = "Odaklayın"
        System.Threading.Thread.Sleep(num_sleep.Value * 1000)
        pb_total.Value = 0
        progress_sec.Enabled = True
    End Sub

    Private Sub ch_0_CheckedChanged(ByVal sender As System.Object) Handles ch_0.CheckedChanged
        If (ch_0.Checked) Then
            num_0.Enabled = True
        Else
            num_0.Enabled = False
        End If
    End Sub

    Private Sub ch_1_CheckedChanged(ByVal sender As System.Object) Handles ch_1.CheckedChanged
        If (ch_1.Checked) Then
            num_1.Enabled = True
        Else
            num_1.Enabled = False
        End If
    End Sub

    Private Sub ch_2_CheckedChanged(ByVal sender As System.Object) Handles ch_2.CheckedChanged
        If (ch_2.Checked) Then
            num_2.Enabled = True
        Else
            num_2.Enabled = False
        End If
    End Sub

    Private Sub ch_3_CheckedChanged(ByVal sender As System.Object) Handles ch_3.CheckedChanged
        If (ch_3.Checked) Then
            num_3.Enabled = True
        Else
            num_3.Enabled = False
        End If
    End Sub

    Private Sub ch_4_CheckedChanged(ByVal sender As System.Object) Handles ch_4.CheckedChanged
        If (ch_4.Checked) Then
            num_4.Enabled = True
        Else
            num_4.Enabled = False
        End If
    End Sub

    Private Sub ch_5_CheckedChanged(ByVal sender As System.Object) Handles ch_5.CheckedChanged
        If (ch_5.Checked) Then
            num_5.Enabled = True
        Else
            num_5.Enabled = False
        End If
    End Sub

    Private Sub ch_6_CheckedChanged(ByVal sender As System.Object) Handles ch_6.CheckedChanged
        If (ch_6.Checked) Then
            num_6.Enabled = True
        Else
            num_6.Enabled = False
        End If
    End Sub

    Private Sub ch_7_CheckedChanged(ByVal sender As System.Object) Handles ch_7.CheckedChanged
        If (ch_7.Checked) Then
            num_7.Enabled = True
        Else
            num_7.Enabled = False
        End If
    End Sub

    Private Sub ch_8_CheckedChanged(ByVal sender As System.Object) Handles ch_8.CheckedChanged
        If (ch_8.Checked) Then
            num_8.Enabled = True
        Else
            num_8.Enabled = False
        End If
    End Sub

    Private Sub ch_9_CheckedChanged(ByVal sender As System.Object) Handles ch_9.CheckedChanged
        If (ch_9.Checked) Then
            num_9.Enabled = True
        Else
            num_9.Enabled = False
        End If
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Bu program MEYTA Kanalı yöneticisi DeadSound tarafından yapılmıştır." +
        Environment.NewLine + "Kötü amaçla kullanılması durumunda sorumluluk kabul etmiyoruz.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ch_0.Checked = True
        ch_1.Checked = True
        ch_2.Checked = True
        ch_3.Checked = True
        ch_4.Checked = True
        ch_5.Checked = True
        ch_6.Checked = True
        ch_7.Checked = True
        ch_8.Checked = True
        ch_9.Checked = True
        rd_half.Checked = True
        tg_notification.Checked = True

        num_0.Value = My.MySettings.Default.num_0
        num_1.Value = My.MySettings.Default.num_1
        num_2.Value = My.MySettings.Default.num_2
        num_3.Value = My.MySettings.Default.num_3
        num_4.Value = My.MySettings.Default.num_4
        num_5.Value = My.MySettings.Default.num_5
        num_6.Value = My.MySettings.Default.num_6
        num_7.Value = My.MySettings.Default.num_7
        num_8.Value = My.MySettings.Default.num_8
        num_9.Value = My.MySettings.Default.num_9
        num_total.Value = My.MySettings.Default.num_total



    End Sub

    Private Sub ch_independent_CheckedChanged(ByVal sender As System.Object) Handles ch_independent.CheckedChanged
        If (ch_independent.Checked) Then
            rd_equal.Enabled = False
            rd_half.Enabled = False
            rd_equal.Checked = False
            rd_half.Checked = False
            ch_9.Enabled = True
            num_9.Enabled = True
        Else
            rd_equal.Enabled = True
            rd_half.Enabled = True
        End If
    End Sub

    Private Sub btn_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        progress_sec.Enabled = False
        progress = 0
        lb_0.ForeColor = Color.White
        lb_1.ForeColor = Color.White
        lb_2.ForeColor = Color.White
        lb_3.ForeColor = Color.White
        lb_4.ForeColor = Color.White
        lb_5.ForeColor = Color.White
        lb_6.ForeColor = Color.White
        lb_7.ForeColor = Color.White
        lb_8.ForeColor = Color.White
        lb_9.ForeColor = Color.White
    End Sub

    Private Sub progress_sec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles progress_sec.Tick
        lb_0.ForeColor = Color.Green
        lb_1.ForeColor = Color.Green
        lb_2.ForeColor = Color.Green
        lb_3.ForeColor = Color.Green
        lb_4.ForeColor = Color.Green
        lb_5.ForeColor = Color.Green
        lb_6.ForeColor = Color.Green
        lb_7.ForeColor = Color.Green
        lb_8.ForeColor = Color.Green
        lb_9.ForeColor = Color.Green
        If (ch_0.Checked And progress Mod num_0.Value = 0) Then
            SendKeys.Send("0")
            lb_0.ForeColor = Color.Red
        End If
        If (ch_1.Checked And progress Mod num_1.Value = 0) Then
            SendKeys.Send("1")
            lb_1.ForeColor = Color.Red
        End If
        If (ch_2.Checked And progress Mod num_2.Value = 0) Then
            SendKeys.Send("2")
            lb_2.ForeColor = Color.Red
        End If
        If (ch_3.Checked And progress Mod num_3.Value = 0) Then
            SendKeys.Send("3")
            lb_3.ForeColor = Color.Red
        End If
        If (ch_4.Checked And progress Mod num_4.Value = 0) Then
            SendKeys.Send("4")
            lb_4.ForeColor = Color.Red
        End If
        If (ch_5.Checked And progress Mod num_5.Value = 0) Then
            SendKeys.Send("5")
            lb_5.ForeColor = Color.Red
        End If
        If (ch_6.Checked And progress Mod num_6.Value = 0) Then
            SendKeys.Send("6")
            lb_6.ForeColor = Color.Red
        End If
        If (ch_7.Checked And progress Mod num_7.Value = 0) Then
            SendKeys.Send("7")
            lb_7.ForeColor = Color.Red
        End If

        If (ch_8.Checked And ch_independent.Checked And progress Mod num_8.Value = 0) Then
            SendKeys.Send("8")
            lb_8.ForeColor = Color.Red
        End If

        If (ch_9.Checked And ch_independent.Checked And progress Mod num_9.Value = 0) Then
            SendKeys.Send("9")
            lb_9.ForeColor = Color.Red
        End If

        If (ch_8.Checked And rd_equal.Checked And progress Mod num_8.Value = 0) Then
            SendKeys.Send("8")
            SendKeys.Send("9")
            lb_8.ForeColor = Color.Red
            lb_9.ForeColor = Color.Red
        End If

        If (ch_8.Checked And rd_half.Checked And progress Mod num_8.Value = 0) Then
            If (half) Then
                SendKeys.Send("8")
                lb_8.ForeColor = Color.Red
                half = False
            Else
                SendKeys.Send("9")
                lb_9.ForeColor = Color.Red
                half = True
            End If
        End If
        If (progress <= num_total.Value * 60) Then
            pb_total.Value = 100 / (num_total.Value * 60 / progress)
            lb_total.Text = (num_total.Value * 60 - progress).ToString() + " sn"
            stb.Text = "Aktif Pencere : " + GetActiveWindowTitle()
            Dim rd As Random = New Random
            'lb_pwr.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255))
            progress += 1
        ElseIf (progress = (num_total.Value * 60) + 1) Then
            progress_sec.Enabled = False
            notify.BalloonTipIcon = ToolTipIcon.Info
            notify.BalloonTipText = num_total.Value.ToString() + " dakikalik süre tamamlandı"
            notify.BalloonTipTitle = "BİROL AKSOY-BOT"
            notify.ShowBalloonTip(2000)
            notify.Visible = False
            lb_0.ForeColor = Color.White
            lb_1.ForeColor = Color.White
            lb_2.ForeColor = Color.White
            lb_3.ForeColor = Color.White
            lb_4.ForeColor = Color.White
            lb_5.ForeColor = Color.White
            lb_6.ForeColor = Color.White
            lb_7.ForeColor = Color.White
            lb_8.ForeColor = Color.White
            lb_9.ForeColor = Color.White
            progress = 0
        End If
    End Sub

    Private Sub rd_equal_CheckedChanged(ByVal sender As System.Object) Handles rd_equal.CheckedChanged
        If (rd_equal.Checked) Then
            ch_9.Enabled = False
            num_9.Enabled = False
            ch_9.Checked = True
        End If
    End Sub

    Private Sub num_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num_8.Click
        If (rd_equal.Checked) Then
            num_9.Value = num_8.Value
        End If
    End Sub

    Private Sub rd_half_CheckedChanged(ByVal sender As System.Object) Handles rd_half.CheckedChanged
        If (rd_half.Checked) Then
            ch_9.Enabled = False
            num_9.Enabled = False
            ch_9.Checked = True
        End If
    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_channel.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCltJlvbcFATfBm0qHttpZNg?view_as=subscriber")
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        My.MySettings.Default.num_total = num_total.Value
        My.MySettings.Default.num_0 = num_0.Value
        My.MySettings.Default.num_1 = num_1.Value
        My.MySettings.Default.num_2 = num_2.Value
        My.MySettings.Default.num_3 = num_3.Value
        My.MySettings.Default.num_4 = num_4.Value
        My.MySettings.Default.num_5 = num_5.Value
        My.MySettings.Default.num_6 = num_6.Value
        My.MySettings.Default.num_7 = num_7.Value
        My.MySettings.Default.num_8 = num_8.Value
        My.MySettings.Default.num_9 = num_9.Value
        My.MySettings.Default.Save()
    End Sub
End Class
