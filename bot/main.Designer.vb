<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.progress_sec = New System.Windows.Forms.Timer(Me.components)
        Me.notify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FormSkin1 = New bot.FormSkin()
        Me.tg_notification = New bot.FlatToggle()
        Me.FlatLabel28 = New bot.FlatLabel()
        Me.ch_9 = New bot.FlatCheckBox()
        Me.ch_8 = New bot.FlatCheckBox()
        Me.ch_7 = New bot.FlatCheckBox()
        Me.ch_6 = New bot.FlatCheckBox()
        Me.ch_5 = New bot.FlatCheckBox()
        Me.ch_4 = New bot.FlatCheckBox()
        Me.ch_3 = New bot.FlatCheckBox()
        Me.ch_2 = New bot.FlatCheckBox()
        Me.ch_1 = New bot.FlatCheckBox()
        Me.ch_0 = New bot.FlatCheckBox()
        Me.btn_channel = New bot.FlatButton()
        Me.FlatLabel52 = New bot.FlatLabel()
        Me.num_sleep = New bot.FlatNumeric()
        Me.FlatLabel53 = New bot.FlatLabel()
        Me.FlatLabel50 = New bot.FlatLabel()
        Me.num_total = New bot.FlatNumeric()
        Me.FlatLabel51 = New bot.FlatLabel()
        Me.lb_9 = New bot.FlatLabel()
        Me.lb_8 = New bot.FlatLabel()
        Me.lb_7 = New bot.FlatLabel()
        Me.lb_6 = New bot.FlatLabel()
        Me.lb_5 = New bot.FlatLabel()
        Me.lb_4 = New bot.FlatLabel()
        Me.lb_3 = New bot.FlatLabel()
        Me.lb_2 = New bot.FlatLabel()
        Me.lb_1 = New bot.FlatLabel()
        Me.lb_0 = New bot.FlatLabel()
        Me.FlatLabel39 = New bot.FlatLabel()
        Me.FlatLabel38 = New bot.FlatLabel()
        Me.FlatLabel37 = New bot.FlatLabel()
        Me.FlatLabel36 = New bot.FlatLabel()
        Me.FlatLabel35 = New bot.FlatLabel()
        Me.FlatLabel34 = New bot.FlatLabel()
        Me.FlatLabel33 = New bot.FlatLabel()
        Me.FlatLabel32 = New bot.FlatLabel()
        Me.FlatLabel31 = New bot.FlatLabel()
        Me.FlatLabel30 = New bot.FlatLabel()
        Me.lb_pwr = New bot.FlatLabel()
        Me.lb_total = New bot.FlatLabel()
        Me.btn_stop = New bot.FlatButton()
        Me.ch_independent = New bot.FlatCheckBox()
        Me.btn_start = New bot.FlatButton()
        Me.FlatLabel27 = New bot.FlatLabel()
        Me.FlatLabel26 = New bot.FlatLabel()
        Me.FlatLabel25 = New bot.FlatLabel()
        Me.FlatLabel23 = New bot.FlatLabel()
        Me.rd_equal = New bot.RadioButton()
        Me.rd_half = New bot.RadioButton()
        Me.FlatLabel18 = New bot.FlatLabel()
        Me.FlatLabel17 = New bot.FlatLabel()
        Me.FlatLabel16 = New bot.FlatLabel()
        Me.FlatLabel15 = New bot.FlatLabel()
        Me.FlatLabel14 = New bot.FlatLabel()
        Me.FlatLabel13 = New bot.FlatLabel()
        Me.FlatLabel12 = New bot.FlatLabel()
        Me.FlatLabel11 = New bot.FlatLabel()
        Me.btn_exit = New bot.FlatClose()
        Me.btn_minimize = New bot.FlatMini()
        Me.num_9 = New bot.FlatNumeric()
        Me.FlatLabel10 = New bot.FlatLabel()
        Me.num_8 = New bot.FlatNumeric()
        Me.FlatLabel9 = New bot.FlatLabel()
        Me.num_7 = New bot.FlatNumeric()
        Me.FlatLabel8 = New bot.FlatLabel()
        Me.num_6 = New bot.FlatNumeric()
        Me.FlatLabel7 = New bot.FlatLabel()
        Me.num_5 = New bot.FlatNumeric()
        Me.FlatLabel6 = New bot.FlatLabel()
        Me.num_4 = New bot.FlatNumeric()
        Me.FlatLabel5 = New bot.FlatLabel()
        Me.num_3 = New bot.FlatNumeric()
        Me.FlatLabel4 = New bot.FlatLabel()
        Me.num_2 = New bot.FlatNumeric()
        Me.FlatLabel3 = New bot.FlatLabel()
        Me.num_1 = New bot.FlatNumeric()
        Me.FlatLabel2 = New bot.FlatLabel()
        Me.num_0 = New bot.FlatNumeric()
        Me.FlatLabel1 = New bot.FlatLabel()
        Me.stb = New bot.FlatStatusBar()
        Me.FlatLabel19 = New bot.FlatLabel()
        Me.FlatLabel20 = New bot.FlatLabel()
        Me.FlatLabel21 = New bot.FlatLabel()
        Me.FlatLabel22 = New bot.FlatLabel()
        Me.FlatLabel24 = New bot.FlatLabel()
        Me.pb_total = New bot.FlatProgressBar()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'progress_sec
        '
        Me.progress_sec.Interval = 1000
        '
        'notify
        '
        Me.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notify.Icon = CType(resources.GetObject("notify.Icon"), System.Drawing.Icon)
        Me.notify.Text = "BİROL AKSOY-BOT"
        Me.notify.Visible = True
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.tg_notification)
        Me.FormSkin1.Controls.Add(Me.FlatLabel28)
        Me.FormSkin1.Controls.Add(Me.ch_9)
        Me.FormSkin1.Controls.Add(Me.ch_8)
        Me.FormSkin1.Controls.Add(Me.ch_7)
        Me.FormSkin1.Controls.Add(Me.ch_6)
        Me.FormSkin1.Controls.Add(Me.ch_5)
        Me.FormSkin1.Controls.Add(Me.ch_4)
        Me.FormSkin1.Controls.Add(Me.ch_3)
        Me.FormSkin1.Controls.Add(Me.ch_2)
        Me.FormSkin1.Controls.Add(Me.ch_1)
        Me.FormSkin1.Controls.Add(Me.ch_0)
        Me.FormSkin1.Controls.Add(Me.btn_channel)
        Me.FormSkin1.Controls.Add(Me.FlatLabel52)
        Me.FormSkin1.Controls.Add(Me.num_sleep)
        Me.FormSkin1.Controls.Add(Me.FlatLabel53)
        Me.FormSkin1.Controls.Add(Me.FlatLabel50)
        Me.FormSkin1.Controls.Add(Me.num_total)
        Me.FormSkin1.Controls.Add(Me.FlatLabel51)
        Me.FormSkin1.Controls.Add(Me.lb_9)
        Me.FormSkin1.Controls.Add(Me.lb_8)
        Me.FormSkin1.Controls.Add(Me.lb_7)
        Me.FormSkin1.Controls.Add(Me.lb_6)
        Me.FormSkin1.Controls.Add(Me.lb_5)
        Me.FormSkin1.Controls.Add(Me.lb_4)
        Me.FormSkin1.Controls.Add(Me.lb_3)
        Me.FormSkin1.Controls.Add(Me.lb_2)
        Me.FormSkin1.Controls.Add(Me.lb_1)
        Me.FormSkin1.Controls.Add(Me.lb_0)
        Me.FormSkin1.Controls.Add(Me.FlatLabel39)
        Me.FormSkin1.Controls.Add(Me.FlatLabel38)
        Me.FormSkin1.Controls.Add(Me.FlatLabel37)
        Me.FormSkin1.Controls.Add(Me.FlatLabel36)
        Me.FormSkin1.Controls.Add(Me.FlatLabel35)
        Me.FormSkin1.Controls.Add(Me.FlatLabel34)
        Me.FormSkin1.Controls.Add(Me.FlatLabel33)
        Me.FormSkin1.Controls.Add(Me.FlatLabel32)
        Me.FormSkin1.Controls.Add(Me.FlatLabel31)
        Me.FormSkin1.Controls.Add(Me.FlatLabel30)
        Me.FormSkin1.Controls.Add(Me.lb_pwr)
        Me.FormSkin1.Controls.Add(Me.lb_total)
        Me.FormSkin1.Controls.Add(Me.btn_stop)
        Me.FormSkin1.Controls.Add(Me.ch_independent)
        Me.FormSkin1.Controls.Add(Me.btn_start)
        Me.FormSkin1.Controls.Add(Me.FlatLabel27)
        Me.FormSkin1.Controls.Add(Me.FlatLabel26)
        Me.FormSkin1.Controls.Add(Me.FlatLabel25)
        Me.FormSkin1.Controls.Add(Me.FlatLabel23)
        Me.FormSkin1.Controls.Add(Me.rd_equal)
        Me.FormSkin1.Controls.Add(Me.rd_half)
        Me.FormSkin1.Controls.Add(Me.FlatLabel18)
        Me.FormSkin1.Controls.Add(Me.FlatLabel17)
        Me.FormSkin1.Controls.Add(Me.FlatLabel16)
        Me.FormSkin1.Controls.Add(Me.FlatLabel15)
        Me.FormSkin1.Controls.Add(Me.FlatLabel14)
        Me.FormSkin1.Controls.Add(Me.FlatLabel13)
        Me.FormSkin1.Controls.Add(Me.FlatLabel12)
        Me.FormSkin1.Controls.Add(Me.FlatLabel11)
        Me.FormSkin1.Controls.Add(Me.btn_exit)
        Me.FormSkin1.Controls.Add(Me.btn_minimize)
        Me.FormSkin1.Controls.Add(Me.num_9)
        Me.FormSkin1.Controls.Add(Me.FlatLabel10)
        Me.FormSkin1.Controls.Add(Me.num_8)
        Me.FormSkin1.Controls.Add(Me.FlatLabel9)
        Me.FormSkin1.Controls.Add(Me.num_7)
        Me.FormSkin1.Controls.Add(Me.FlatLabel8)
        Me.FormSkin1.Controls.Add(Me.num_6)
        Me.FormSkin1.Controls.Add(Me.FlatLabel7)
        Me.FormSkin1.Controls.Add(Me.num_5)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.num_4)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.num_3)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.num_2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.num_1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.num_0)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.stb)
        Me.FormSkin1.Controls.Add(Me.FlatLabel19)
        Me.FormSkin1.Controls.Add(Me.FlatLabel20)
        Me.FormSkin1.Controls.Add(Me.FlatLabel21)
        Me.FormSkin1.Controls.Add(Me.FlatLabel22)
        Me.FormSkin1.Controls.Add(Me.FlatLabel24)
        Me.FormSkin1.Controls.Add(Me.pb_total)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(417, 500)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "DeadSound-BOT"
        '
        'tg_notification
        '
        Me.tg_notification.BackColor = System.Drawing.Color.Transparent
        Me.tg_notification.Checked = False
        Me.tg_notification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tg_notification.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tg_notification.Location = New System.Drawing.Point(298, 137)
        Me.tg_notification.Name = "tg_notification"
        Me.tg_notification.Options = bot.FlatToggle._Options.Style1
        Me.tg_notification.Size = New System.Drawing.Size(76, 33)
        Me.tg_notification.TabIndex = 87
        Me.tg_notification.Text = "FlatToggle1"
        '
        'FlatLabel28
        '
        Me.FlatLabel28.AutoSize = True
        Me.FlatLabel28.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel28.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel28.ForeColor = System.Drawing.Color.White
        Me.FlatLabel28.Location = New System.Drawing.Point(187, 146)
        Me.FlatLabel28.Name = "FlatLabel28"
        Me.FlatLabel28.Size = New System.Drawing.Size(85, 13)
        Me.FlatLabel28.TabIndex = 86
        Me.FlatLabel28.Text = "Bildirim Kutusu"
        '
        'ch_9
        '
        Me.ch_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_9.BorderColor = System.Drawing.Color.Yellow
        Me.ch_9.Checked = False
        Me.ch_9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_9.Location = New System.Drawing.Point(17, 393)
        Me.ch_9.Name = "ch_9"
        Me.ch_9.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_9.Size = New System.Drawing.Size(25, 22)
        Me.ch_9.TabIndex = 85
        '
        'ch_8
        '
        Me.ch_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_8.BorderColor = System.Drawing.Color.Yellow
        Me.ch_8.Checked = False
        Me.ch_8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_8.Location = New System.Drawing.Point(17, 358)
        Me.ch_8.Name = "ch_8"
        Me.ch_8.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_8.Size = New System.Drawing.Size(25, 22)
        Me.ch_8.TabIndex = 84
        '
        'ch_7
        '
        Me.ch_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_7.BorderColor = System.Drawing.Color.Yellow
        Me.ch_7.Checked = False
        Me.ch_7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_7.Location = New System.Drawing.Point(17, 321)
        Me.ch_7.Name = "ch_7"
        Me.ch_7.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_7.Size = New System.Drawing.Size(25, 22)
        Me.ch_7.TabIndex = 83
        '
        'ch_6
        '
        Me.ch_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_6.BorderColor = System.Drawing.Color.Yellow
        Me.ch_6.Checked = False
        Me.ch_6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_6.Location = New System.Drawing.Point(17, 286)
        Me.ch_6.Name = "ch_6"
        Me.ch_6.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_6.Size = New System.Drawing.Size(25, 22)
        Me.ch_6.TabIndex = 82
        '
        'ch_5
        '
        Me.ch_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_5.BorderColor = System.Drawing.Color.Yellow
        Me.ch_5.Checked = False
        Me.ch_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_5.Location = New System.Drawing.Point(17, 249)
        Me.ch_5.Name = "ch_5"
        Me.ch_5.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_5.Size = New System.Drawing.Size(25, 22)
        Me.ch_5.TabIndex = 81
        '
        'ch_4
        '
        Me.ch_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_4.BorderColor = System.Drawing.Color.Yellow
        Me.ch_4.Checked = False
        Me.ch_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_4.Location = New System.Drawing.Point(17, 213)
        Me.ch_4.Name = "ch_4"
        Me.ch_4.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_4.Size = New System.Drawing.Size(25, 22)
        Me.ch_4.TabIndex = 80
        '
        'ch_3
        '
        Me.ch_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_3.BorderColor = System.Drawing.Color.Yellow
        Me.ch_3.Checked = False
        Me.ch_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_3.Location = New System.Drawing.Point(17, 177)
        Me.ch_3.Name = "ch_3"
        Me.ch_3.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_3.Size = New System.Drawing.Size(25, 22)
        Me.ch_3.TabIndex = 79
        '
        'ch_2
        '
        Me.ch_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_2.BorderColor = System.Drawing.Color.Yellow
        Me.ch_2.Checked = False
        Me.ch_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_2.Location = New System.Drawing.Point(17, 141)
        Me.ch_2.Name = "ch_2"
        Me.ch_2.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_2.Size = New System.Drawing.Size(25, 22)
        Me.ch_2.TabIndex = 78
        '
        'ch_1
        '
        Me.ch_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_1.BorderColor = System.Drawing.Color.Yellow
        Me.ch_1.Checked = False
        Me.ch_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_1.Location = New System.Drawing.Point(17, 106)
        Me.ch_1.Name = "ch_1"
        Me.ch_1.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_1.Size = New System.Drawing.Size(25, 22)
        Me.ch_1.TabIndex = 77
        '
        'ch_0
        '
        Me.ch_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_0.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_0.BorderColor = System.Drawing.Color.Yellow
        Me.ch_0.Checked = False
        Me.ch_0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_0.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_0.Location = New System.Drawing.Point(17, 71)
        Me.ch_0.Name = "ch_0"
        Me.ch_0.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_0.Size = New System.Drawing.Size(25, 22)
        Me.ch_0.TabIndex = 76
        '
        'btn_channel
        '
        Me.btn_channel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_channel.BackColor = System.Drawing.Color.Transparent
        Me.btn_channel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_channel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_channel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_channel.Location = New System.Drawing.Point(335, 12)
        Me.btn_channel.Name = "btn_channel"
        Me.btn_channel.Rounded = False
        Me.btn_channel.Size = New System.Drawing.Size(18, 18)
        Me.btn_channel.TabIndex = 75
        Me.btn_channel.Text = "⌥"
        Me.btn_channel.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel52
        '
        Me.FlatLabel52.AutoSize = True
        Me.FlatLabel52.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel52.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel52.ForeColor = System.Drawing.Color.White
        Me.FlatLabel52.Location = New System.Drawing.Point(379, 74)
        Me.FlatLabel52.Name = "FlatLabel52"
        Me.FlatLabel52.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel52.TabIndex = 74
        Me.FlatLabel52.Text = "sn"
        '
        'num_sleep
        '
        Me.num_sleep.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_sleep.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_sleep.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.num_sleep.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_sleep.ForeColor = System.Drawing.Color.White
        Me.num_sleep.Location = New System.Drawing.Point(298, 65)
        Me.num_sleep.Maximum = CType(100, Long)
        Me.num_sleep.Minimum = CType(1, Long)
        Me.num_sleep.Name = "num_sleep"
        Me.num_sleep.Size = New System.Drawing.Size(75, 30)
        Me.num_sleep.TabIndex = 73
        Me.num_sleep.Text = "FlatNumeric12"
        Me.num_sleep.Value = CType(5, Long)
        '
        'FlatLabel53
        '
        Me.FlatLabel53.AutoSize = True
        Me.FlatLabel53.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel53.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel53.ForeColor = System.Drawing.Color.White
        Me.FlatLabel53.Location = New System.Drawing.Point(187, 74)
        Me.FlatLabel53.Name = "FlatLabel53"
        Me.FlatLabel53.Size = New System.Drawing.Size(93, 13)
        Me.FlatLabel53.TabIndex = 72
        Me.FlatLabel53.Text = "Odaklama Süresi"
        '
        'FlatLabel50
        '
        Me.FlatLabel50.AutoSize = True
        Me.FlatLabel50.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel50.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel50.ForeColor = System.Drawing.Color.White
        Me.FlatLabel50.Location = New System.Drawing.Point(379, 110)
        Me.FlatLabel50.Name = "FlatLabel50"
        Me.FlatLabel50.Size = New System.Drawing.Size(20, 13)
        Me.FlatLabel50.TabIndex = 71
        Me.FlatLabel50.Text = "dk"
        '
        'num_total
        '
        Me.num_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_total.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_total.ButtonColor = System.Drawing.Color.Red
        Me.num_total.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_total.ForeColor = System.Drawing.Color.White
        Me.num_total.Location = New System.Drawing.Point(298, 101)
        Me.num_total.Maximum = CType(1000, Long)
        Me.num_total.Minimum = CType(1, Long)
        Me.num_total.Name = "num_total"
        Me.num_total.Size = New System.Drawing.Size(75, 30)
        Me.num_total.TabIndex = 70
        Me.num_total.Text = "FlatNumeric11"
        Me.num_total.Value = CType(60, Long)
        '
        'FlatLabel51
        '
        Me.FlatLabel51.AutoSize = True
        Me.FlatLabel51.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel51.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel51.ForeColor = System.Drawing.Color.White
        Me.FlatLabel51.Location = New System.Drawing.Point(187, 110)
        Me.FlatLabel51.Name = "FlatLabel51"
        Me.FlatLabel51.Size = New System.Drawing.Size(106, 13)
        Me.FlatLabel51.TabIndex = 69
        Me.FlatLabel51.Text = "Toplam İşlem Süresi"
        '
        'lb_9
        '
        Me.lb_9.AutoSize = True
        Me.lb_9.BackColor = System.Drawing.Color.Transparent
        Me.lb_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_9.ForeColor = System.Drawing.Color.White
        Me.lb_9.Location = New System.Drawing.Point(369, 254)
        Me.lb_9.Name = "lb_9"
        Me.lb_9.Size = New System.Drawing.Size(19, 20)
        Me.lb_9.TabIndex = 68
        Me.lb_9.Text = "●"
        '
        'lb_8
        '
        Me.lb_8.AutoSize = True
        Me.lb_8.BackColor = System.Drawing.Color.Transparent
        Me.lb_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_8.ForeColor = System.Drawing.Color.White
        Me.lb_8.Location = New System.Drawing.Point(350, 254)
        Me.lb_8.Name = "lb_8"
        Me.lb_8.Size = New System.Drawing.Size(19, 20)
        Me.lb_8.TabIndex = 67
        Me.lb_8.Text = "●"
        '
        'lb_7
        '
        Me.lb_7.AutoSize = True
        Me.lb_7.BackColor = System.Drawing.Color.Transparent
        Me.lb_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_7.ForeColor = System.Drawing.Color.White
        Me.lb_7.Location = New System.Drawing.Point(331, 254)
        Me.lb_7.Name = "lb_7"
        Me.lb_7.Size = New System.Drawing.Size(19, 20)
        Me.lb_7.TabIndex = 66
        Me.lb_7.Text = "●"
        '
        'lb_6
        '
        Me.lb_6.AutoSize = True
        Me.lb_6.BackColor = System.Drawing.Color.Transparent
        Me.lb_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_6.ForeColor = System.Drawing.Color.White
        Me.lb_6.Location = New System.Drawing.Point(312, 254)
        Me.lb_6.Name = "lb_6"
        Me.lb_6.Size = New System.Drawing.Size(19, 20)
        Me.lb_6.TabIndex = 65
        Me.lb_6.Text = "●"
        '
        'lb_5
        '
        Me.lb_5.AutoSize = True
        Me.lb_5.BackColor = System.Drawing.Color.Transparent
        Me.lb_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_5.ForeColor = System.Drawing.Color.White
        Me.lb_5.Location = New System.Drawing.Point(293, 254)
        Me.lb_5.Name = "lb_5"
        Me.lb_5.Size = New System.Drawing.Size(19, 20)
        Me.lb_5.TabIndex = 64
        Me.lb_5.Text = "●"
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.lb_4.BackColor = System.Drawing.Color.Transparent
        Me.lb_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_4.ForeColor = System.Drawing.Color.White
        Me.lb_4.Location = New System.Drawing.Point(274, 254)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(19, 20)
        Me.lb_4.TabIndex = 63
        Me.lb_4.Text = "●"
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.lb_3.BackColor = System.Drawing.Color.Transparent
        Me.lb_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_3.ForeColor = System.Drawing.Color.White
        Me.lb_3.Location = New System.Drawing.Point(255, 254)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(19, 20)
        Me.lb_3.TabIndex = 62
        Me.lb_3.Text = "●"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.lb_2.BackColor = System.Drawing.Color.Transparent
        Me.lb_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_2.ForeColor = System.Drawing.Color.White
        Me.lb_2.Location = New System.Drawing.Point(236, 254)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(19, 20)
        Me.lb_2.TabIndex = 61
        Me.lb_2.Text = "●"
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.lb_1.BackColor = System.Drawing.Color.Transparent
        Me.lb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_1.ForeColor = System.Drawing.Color.White
        Me.lb_1.Location = New System.Drawing.Point(217, 254)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(19, 20)
        Me.lb_1.TabIndex = 60
        Me.lb_1.Text = "●"
        '
        'lb_0
        '
        Me.lb_0.AutoSize = True
        Me.lb_0.BackColor = System.Drawing.Color.Transparent
        Me.lb_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lb_0.ForeColor = System.Drawing.Color.White
        Me.lb_0.Location = New System.Drawing.Point(197, 254)
        Me.lb_0.Name = "lb_0"
        Me.lb_0.Size = New System.Drawing.Size(19, 20)
        Me.lb_0.TabIndex = 59
        Me.lb_0.Text = "●"
        '
        'FlatLabel39
        '
        Me.FlatLabel39.AutoSize = True
        Me.FlatLabel39.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel39.ForeColor = System.Drawing.Color.White
        Me.FlatLabel39.Location = New System.Drawing.Point(369, 235)
        Me.FlatLabel39.Name = "FlatLabel39"
        Me.FlatLabel39.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel39.TabIndex = 58
        Me.FlatLabel39.Text = "9"
        '
        'FlatLabel38
        '
        Me.FlatLabel38.AutoSize = True
        Me.FlatLabel38.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel38.ForeColor = System.Drawing.Color.White
        Me.FlatLabel38.Location = New System.Drawing.Point(350, 235)
        Me.FlatLabel38.Name = "FlatLabel38"
        Me.FlatLabel38.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel38.TabIndex = 57
        Me.FlatLabel38.Text = "8"
        '
        'FlatLabel37
        '
        Me.FlatLabel37.AutoSize = True
        Me.FlatLabel37.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel37.ForeColor = System.Drawing.Color.White
        Me.FlatLabel37.Location = New System.Drawing.Point(331, 235)
        Me.FlatLabel37.Name = "FlatLabel37"
        Me.FlatLabel37.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel37.TabIndex = 56
        Me.FlatLabel37.Text = "7"
        '
        'FlatLabel36
        '
        Me.FlatLabel36.AutoSize = True
        Me.FlatLabel36.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel36.ForeColor = System.Drawing.Color.White
        Me.FlatLabel36.Location = New System.Drawing.Point(312, 235)
        Me.FlatLabel36.Name = "FlatLabel36"
        Me.FlatLabel36.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel36.TabIndex = 55
        Me.FlatLabel36.Text = "6"
        '
        'FlatLabel35
        '
        Me.FlatLabel35.AutoSize = True
        Me.FlatLabel35.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel35.ForeColor = System.Drawing.Color.White
        Me.FlatLabel35.Location = New System.Drawing.Point(293, 235)
        Me.FlatLabel35.Name = "FlatLabel35"
        Me.FlatLabel35.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel35.TabIndex = 54
        Me.FlatLabel35.Text = "5"
        '
        'FlatLabel34
        '
        Me.FlatLabel34.AutoSize = True
        Me.FlatLabel34.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel34.ForeColor = System.Drawing.Color.White
        Me.FlatLabel34.Location = New System.Drawing.Point(274, 235)
        Me.FlatLabel34.Name = "FlatLabel34"
        Me.FlatLabel34.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel34.TabIndex = 53
        Me.FlatLabel34.Text = "4"
        '
        'FlatLabel33
        '
        Me.FlatLabel33.AutoSize = True
        Me.FlatLabel33.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel33.ForeColor = System.Drawing.Color.White
        Me.FlatLabel33.Location = New System.Drawing.Point(255, 235)
        Me.FlatLabel33.Name = "FlatLabel33"
        Me.FlatLabel33.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel33.TabIndex = 52
        Me.FlatLabel33.Text = "3"
        '
        'FlatLabel32
        '
        Me.FlatLabel32.AutoSize = True
        Me.FlatLabel32.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel32.ForeColor = System.Drawing.Color.White
        Me.FlatLabel32.Location = New System.Drawing.Point(236, 235)
        Me.FlatLabel32.Name = "FlatLabel32"
        Me.FlatLabel32.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel32.TabIndex = 51
        Me.FlatLabel32.Text = "2"
        '
        'FlatLabel31
        '
        Me.FlatLabel31.AutoSize = True
        Me.FlatLabel31.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel31.ForeColor = System.Drawing.Color.White
        Me.FlatLabel31.Location = New System.Drawing.Point(217, 235)
        Me.FlatLabel31.Name = "FlatLabel31"
        Me.FlatLabel31.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel31.TabIndex = 50
        Me.FlatLabel31.Text = "1"
        '
        'FlatLabel30
        '
        Me.FlatLabel30.AutoSize = True
        Me.FlatLabel30.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FlatLabel30.ForeColor = System.Drawing.Color.White
        Me.FlatLabel30.Location = New System.Drawing.Point(198, 235)
        Me.FlatLabel30.Name = "FlatLabel30"
        Me.FlatLabel30.Size = New System.Drawing.Size(18, 20)
        Me.FlatLabel30.TabIndex = 49
        Me.FlatLabel30.Text = "0"
        '
        'lb_pwr
        '
        Me.lb_pwr.AutoSize = True
        Me.lb_pwr.BackColor = System.Drawing.Color.Transparent
        Me.lb_pwr.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lb_pwr.ForeColor = System.Drawing.Color.White
        Me.lb_pwr.Location = New System.Drawing.Point(275, 424)
        Me.lb_pwr.Name = "lb_pwr"
        Me.lb_pwr.Size = New System.Drawing.Size(131, 13)
        Me.lb_pwr.TabIndex = 48
        Me.lb_pwr.Text = "Powered By DeadSound"
        '
        'lb_total
        '
        Me.lb_total.AutoSize = True
        Me.lb_total.BackColor = System.Drawing.Color.Transparent
        Me.lb_total.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lb_total.ForeColor = System.Drawing.Color.White
        Me.lb_total.Location = New System.Drawing.Point(18, 451)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(19, 13)
        Me.lb_total.TabIndex = 47
        Me.lb_total.Text = "00"
        '
        'btn_stop
        '
        Me.btn_stop.BackColor = System.Drawing.Color.Transparent
        Me.btn_stop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stop.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_stop.Location = New System.Drawing.Point(298, 181)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Rounded = False
        Me.btn_stop.Size = New System.Drawing.Size(106, 32)
        Me.btn_stop.TabIndex = 45
        Me.btn_stop.Text = "DURDUR"
        Me.btn_stop.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ch_independent
        '
        Me.ch_independent.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ch_independent.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ch_independent.BorderColor = System.Drawing.Color.Yellow
        Me.ch_independent.Checked = False
        Me.ch_independent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ch_independent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ch_independent.Location = New System.Drawing.Point(302, 375)
        Me.ch_independent.Name = "ch_independent"
        Me.ch_independent.Options = bot.FlatCheckBox._Options.Style1
        Me.ch_independent.Size = New System.Drawing.Size(85, 22)
        Me.ch_independent.TabIndex = 44
        Me.ch_independent.Text = "BAĞIMSIZ"
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.Transparent
        Me.btn_start.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_start.Location = New System.Drawing.Point(186, 181)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Rounded = False
        Me.btn_start.Size = New System.Drawing.Size(106, 32)
        Me.btn_start.TabIndex = 43
        Me.btn_start.Text = "BAŞLAT"
        Me.btn_start.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel27
        '
        Me.FlatLabel27.AutoSize = True
        Me.FlatLabel27.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel27.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel27.ForeColor = System.Drawing.Color.White
        Me.FlatLabel27.Location = New System.Drawing.Point(233, 399)
        Me.FlatLabel27.Name = "FlatLabel27"
        Me.FlatLabel27.Size = New System.Drawing.Size(85, 13)
        Me.FlatLabel27.TabIndex = 42
        Me.FlatLabel27.Text = "────────────┘"
        '
        'FlatLabel26
        '
        Me.FlatLabel26.AutoSize = True
        Me.FlatLabel26.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel26.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel26.ForeColor = System.Drawing.Color.White
        Me.FlatLabel26.Location = New System.Drawing.Point(233, 357)
        Me.FlatLabel26.Name = "FlatLabel26"
        Me.FlatLabel26.Size = New System.Drawing.Size(85, 13)
        Me.FlatLabel26.TabIndex = 41
        Me.FlatLabel26.Text = "────────────┐"
        '
        'FlatLabel25
        '
        Me.FlatLabel25.AutoSize = True
        Me.FlatLabel25.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel25.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel25.ForeColor = System.Drawing.Color.White
        Me.FlatLabel25.Location = New System.Drawing.Point(228, 398)
        Me.FlatLabel25.Name = "FlatLabel25"
        Me.FlatLabel25.Size = New System.Drawing.Size(10, 13)
        Me.FlatLabel25.TabIndex = 39
        Me.FlatLabel25.Text = "|"
        '
        'FlatLabel23
        '
        Me.FlatLabel23.AutoSize = True
        Me.FlatLabel23.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel23.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel23.ForeColor = System.Drawing.Color.White
        Me.FlatLabel23.Location = New System.Drawing.Point(145, 379)
        Me.FlatLabel23.Name = "FlatLabel23"
        Me.FlatLabel23.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel23.TabIndex = 37
        Me.FlatLabel23.Text = "sn"
        '
        'rd_equal
        '
        Me.rd_equal.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.rd_equal.Checked = False
        Me.rd_equal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rd_equal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rd_equal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rd_equal.Location = New System.Drawing.Point(224, 375)
        Me.rd_equal.Name = "rd_equal"
        Me.rd_equal.Options = bot.RadioButton._Options.Style1
        Me.rd_equal.Size = New System.Drawing.Size(56, 22)
        Me.rd_equal.TabIndex = 36
        Me.rd_equal.Text = "%100"
        '
        'rd_half
        '
        Me.rd_half.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.rd_half.Checked = False
        Me.rd_half.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rd_half.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rd_half.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rd_half.Location = New System.Drawing.Point(164, 375)
        Me.rd_half.Name = "rd_half"
        Me.rd_half.Options = bot.RadioButton._Options.Style1
        Me.rd_half.Size = New System.Drawing.Size(56, 22)
        Me.rd_half.TabIndex = 33
        Me.rd_half.Text = "%50"
        '
        'FlatLabel18
        '
        Me.FlatLabel18.AutoSize = True
        Me.FlatLabel18.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel18.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel18.ForeColor = System.Drawing.Color.White
        Me.FlatLabel18.Location = New System.Drawing.Point(151, 326)
        Me.FlatLabel18.Name = "FlatLabel18"
        Me.FlatLabel18.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel18.TabIndex = 30
        Me.FlatLabel18.Text = "sn"
        '
        'FlatLabel17
        '
        Me.FlatLabel17.AutoSize = True
        Me.FlatLabel17.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel17.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel17.ForeColor = System.Drawing.Color.White
        Me.FlatLabel17.Location = New System.Drawing.Point(151, 290)
        Me.FlatLabel17.Name = "FlatLabel17"
        Me.FlatLabel17.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel17.TabIndex = 29
        Me.FlatLabel17.Text = "sn"
        '
        'FlatLabel16
        '
        Me.FlatLabel16.AutoSize = True
        Me.FlatLabel16.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel16.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel16.ForeColor = System.Drawing.Color.White
        Me.FlatLabel16.Location = New System.Drawing.Point(151, 254)
        Me.FlatLabel16.Name = "FlatLabel16"
        Me.FlatLabel16.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel16.TabIndex = 28
        Me.FlatLabel16.Text = "sn"
        '
        'FlatLabel15
        '
        Me.FlatLabel15.AutoSize = True
        Me.FlatLabel15.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel15.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel15.ForeColor = System.Drawing.Color.White
        Me.FlatLabel15.Location = New System.Drawing.Point(151, 218)
        Me.FlatLabel15.Name = "FlatLabel15"
        Me.FlatLabel15.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel15.TabIndex = 27
        Me.FlatLabel15.Text = "sn"
        '
        'FlatLabel14
        '
        Me.FlatLabel14.AutoSize = True
        Me.FlatLabel14.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel14.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel14.ForeColor = System.Drawing.Color.White
        Me.FlatLabel14.Location = New System.Drawing.Point(151, 182)
        Me.FlatLabel14.Name = "FlatLabel14"
        Me.FlatLabel14.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel14.TabIndex = 26
        Me.FlatLabel14.Text = "sn"
        '
        'FlatLabel13
        '
        Me.FlatLabel13.AutoSize = True
        Me.FlatLabel13.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel13.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel13.ForeColor = System.Drawing.Color.White
        Me.FlatLabel13.Location = New System.Drawing.Point(151, 146)
        Me.FlatLabel13.Name = "FlatLabel13"
        Me.FlatLabel13.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel13.TabIndex = 25
        Me.FlatLabel13.Text = "sn"
        '
        'FlatLabel12
        '
        Me.FlatLabel12.AutoSize = True
        Me.FlatLabel12.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel12.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel12.ForeColor = System.Drawing.Color.White
        Me.FlatLabel12.Location = New System.Drawing.Point(151, 110)
        Me.FlatLabel12.Name = "FlatLabel12"
        Me.FlatLabel12.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel12.TabIndex = 24
        Me.FlatLabel12.Text = "sn"
        '
        'FlatLabel11
        '
        Me.FlatLabel11.AutoSize = True
        Me.FlatLabel11.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel11.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel11.ForeColor = System.Drawing.Color.White
        Me.FlatLabel11.Location = New System.Drawing.Point(151, 74)
        Me.FlatLabel11.Name = "FlatLabel11"
        Me.FlatLabel11.Size = New System.Drawing.Size(19, 13)
        Me.FlatLabel11.TabIndex = 23
        Me.FlatLabel11.Text = "sn"
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.BackColor = System.Drawing.Color.White
        Me.btn_exit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btn_exit.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.btn_exit.Location = New System.Drawing.Point(383, 12)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(18, 18)
        Me.btn_exit.TabIndex = 22
        Me.btn_exit.Text = "FlatClose1"
        Me.btn_exit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.BackColor = System.Drawing.Color.White
        Me.btn_minimize.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_minimize.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.btn_minimize.Location = New System.Drawing.Point(359, 12)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(18, 18)
        Me.btn_minimize.TabIndex = 21
        Me.btn_minimize.Text = "FlatMini1"
        Me.btn_minimize.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'num_9
        '
        Me.num_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_9.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.num_9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_9.ForeColor = System.Drawing.Color.White
        Me.num_9.Location = New System.Drawing.Point(70, 389)
        Me.num_9.Maximum = CType(100, Long)
        Me.num_9.Minimum = CType(1, Long)
        Me.num_9.Name = "num_9"
        Me.num_9.Size = New System.Drawing.Size(75, 30)
        Me.num_9.TabIndex = 20
        Me.num_9.Text = "FlatNumeric10"
        Me.num_9.Value = CType(15, Long)
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(40, 398)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel10.TabIndex = 19
        Me.FlatLabel10.Text = "9"
        '
        'num_8
        '
        Me.num_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_8.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.num_8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_8.ForeColor = System.Drawing.Color.White
        Me.num_8.Location = New System.Drawing.Point(70, 353)
        Me.num_8.Maximum = CType(100, Long)
        Me.num_8.Minimum = CType(1, Long)
        Me.num_8.Name = "num_8"
        Me.num_8.Size = New System.Drawing.Size(75, 30)
        Me.num_8.TabIndex = 18
        Me.num_8.Text = "FlatNumeric9"
        Me.num_8.Value = CType(15, Long)
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(40, 362)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel9.TabIndex = 17
        Me.FlatLabel9.Text = "8"
        '
        'num_7
        '
        Me.num_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_7.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_7.ForeColor = System.Drawing.Color.White
        Me.num_7.Location = New System.Drawing.Point(70, 317)
        Me.num_7.Maximum = CType(100, Long)
        Me.num_7.Minimum = CType(1, Long)
        Me.num_7.Name = "num_7"
        Me.num_7.Size = New System.Drawing.Size(75, 30)
        Me.num_7.TabIndex = 16
        Me.num_7.Text = "FlatNumeric8"
        Me.num_7.Value = CType(4, Long)
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(40, 326)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel8.TabIndex = 15
        Me.FlatLabel8.Text = "7"
        '
        'num_6
        '
        Me.num_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_6.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_6.ForeColor = System.Drawing.Color.White
        Me.num_6.Location = New System.Drawing.Point(70, 281)
        Me.num_6.Maximum = CType(100, Long)
        Me.num_6.Minimum = CType(1, Long)
        Me.num_6.Name = "num_6"
        Me.num_6.Size = New System.Drawing.Size(75, 30)
        Me.num_6.TabIndex = 14
        Me.num_6.Text = "FlatNumeric7"
        Me.num_6.Value = CType(4, Long)
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(40, 290)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel7.TabIndex = 13
        Me.FlatLabel7.Text = "6"
        '
        'num_5
        '
        Me.num_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_5.ForeColor = System.Drawing.Color.White
        Me.num_5.Location = New System.Drawing.Point(70, 245)
        Me.num_5.Maximum = CType(100, Long)
        Me.num_5.Minimum = CType(1, Long)
        Me.num_5.Name = "num_5"
        Me.num_5.Size = New System.Drawing.Size(75, 30)
        Me.num_5.TabIndex = 12
        Me.num_5.Text = "FlatNumeric6"
        Me.num_5.Value = CType(4, Long)
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(40, 254)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel6.TabIndex = 11
        Me.FlatLabel6.Text = "5"
        '
        'num_4
        '
        Me.num_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_4.ForeColor = System.Drawing.Color.White
        Me.num_4.Location = New System.Drawing.Point(70, 209)
        Me.num_4.Maximum = CType(100, Long)
        Me.num_4.Minimum = CType(1, Long)
        Me.num_4.Name = "num_4"
        Me.num_4.Size = New System.Drawing.Size(75, 30)
        Me.num_4.TabIndex = 10
        Me.num_4.Text = "FlatNumeric5"
        Me.num_4.Value = CType(4, Long)
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(40, 218)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel5.TabIndex = 9
        Me.FlatLabel5.Text = "4"
        '
        'num_3
        '
        Me.num_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_3.ForeColor = System.Drawing.Color.White
        Me.num_3.Location = New System.Drawing.Point(70, 173)
        Me.num_3.Maximum = CType(100, Long)
        Me.num_3.Minimum = CType(1, Long)
        Me.num_3.Name = "num_3"
        Me.num_3.Size = New System.Drawing.Size(75, 30)
        Me.num_3.TabIndex = 8
        Me.num_3.Text = "FlatNumeric4"
        Me.num_3.Value = CType(4, Long)
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(40, 182)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel4.TabIndex = 7
        Me.FlatLabel4.Text = "3"
        '
        'num_2
        '
        Me.num_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_2.ForeColor = System.Drawing.Color.White
        Me.num_2.Location = New System.Drawing.Point(70, 137)
        Me.num_2.Maximum = CType(100, Long)
        Me.num_2.Minimum = CType(1, Long)
        Me.num_2.Name = "num_2"
        Me.num_2.Size = New System.Drawing.Size(75, 30)
        Me.num_2.TabIndex = 6
        Me.num_2.Text = "FlatNumeric3"
        Me.num_2.Value = CType(4, Long)
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(40, 146)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel3.TabIndex = 5
        Me.FlatLabel3.Text = "2"
        '
        'num_1
        '
        Me.num_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_1.ForeColor = System.Drawing.Color.White
        Me.num_1.Location = New System.Drawing.Point(70, 101)
        Me.num_1.Maximum = CType(100, Long)
        Me.num_1.Minimum = CType(1, Long)
        Me.num_1.Name = "num_1"
        Me.num_1.Size = New System.Drawing.Size(75, 30)
        Me.num_1.TabIndex = 4
        Me.num_1.Text = "FlatNumeric2"
        Me.num_1.Value = CType(4, Long)
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(40, 110)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel2.TabIndex = 3
        Me.FlatLabel2.Text = "1"
        '
        'num_0
        '
        Me.num_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.num_0.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.num_0.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.num_0.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.num_0.ForeColor = System.Drawing.Color.White
        Me.num_0.Location = New System.Drawing.Point(70, 65)
        Me.num_0.Maximum = CType(100, Long)
        Me.num_0.Minimum = CType(1, Long)
        Me.num_0.Name = "num_0"
        Me.num_0.Size = New System.Drawing.Size(75, 30)
        Me.num_0.TabIndex = 2
        Me.num_0.Text = "FlatNumeric1"
        Me.num_0.Value = CType(4, Long)
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(40, 74)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(13, 13)
        Me.FlatLabel1.TabIndex = 1
        Me.FlatLabel1.Text = "0"
        '
        'stb
        '
        Me.stb.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.stb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.stb.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.stb.ForeColor = System.Drawing.Color.White
        Me.stb.Location = New System.Drawing.Point(0, 477)
        Me.stb.Name = "stb"
        Me.stb.RectColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.stb.ShowTimeDate = False
        Me.stb.Size = New System.Drawing.Size(417, 23)
        Me.stb.TabIndex = 0
        Me.stb.Text = "Bu program Birol Aksoy'a aittir."
        Me.stb.TextColor = System.Drawing.Color.White
        '
        'FlatLabel19
        '
        Me.FlatLabel19.AutoSize = True
        Me.FlatLabel19.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel19.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel19.ForeColor = System.Drawing.Color.White
        Me.FlatLabel19.Location = New System.Drawing.Point(143, 360)
        Me.FlatLabel19.Name = "FlatLabel19"
        Me.FlatLabel19.Size = New System.Drawing.Size(37, 13)
        Me.FlatLabel19.TabIndex = 31
        Me.FlatLabel19.Text = "────┐"
        '
        'FlatLabel20
        '
        Me.FlatLabel20.AutoSize = True
        Me.FlatLabel20.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel20.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel20.ForeColor = System.Drawing.Color.White
        Me.FlatLabel20.Location = New System.Drawing.Point(143, 396)
        Me.FlatLabel20.Name = "FlatLabel20"
        Me.FlatLabel20.Size = New System.Drawing.Size(37, 13)
        Me.FlatLabel20.TabIndex = 32
        Me.FlatLabel20.Text = "────┘"
        '
        'FlatLabel21
        '
        Me.FlatLabel21.AutoSize = True
        Me.FlatLabel21.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel21.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel21.ForeColor = System.Drawing.Color.White
        Me.FlatLabel21.Location = New System.Drawing.Point(143, 348)
        Me.FlatLabel21.Name = "FlatLabel21"
        Me.FlatLabel21.Size = New System.Drawing.Size(97, 13)
        Me.FlatLabel21.TabIndex = 34
        Me.FlatLabel21.Text = "──────────────┐"
        '
        'FlatLabel22
        '
        Me.FlatLabel22.AutoSize = True
        Me.FlatLabel22.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel22.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel22.ForeColor = System.Drawing.Color.White
        Me.FlatLabel22.Location = New System.Drawing.Point(143, 407)
        Me.FlatLabel22.Name = "FlatLabel22"
        Me.FlatLabel22.Size = New System.Drawing.Size(97, 13)
        Me.FlatLabel22.TabIndex = 35
        Me.FlatLabel22.Text = "──────────────┘"
        '
        'FlatLabel24
        '
        Me.FlatLabel24.AutoSize = True
        Me.FlatLabel24.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel24.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel24.ForeColor = System.Drawing.Color.White
        Me.FlatLabel24.Location = New System.Drawing.Point(228, 358)
        Me.FlatLabel24.Name = "FlatLabel24"
        Me.FlatLabel24.Size = New System.Drawing.Size(10, 13)
        Me.FlatLabel24.TabIndex = 38
        Me.FlatLabel24.Text = "|"
        '
        'pb_total
        '
        Me.pb_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pb_total.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pb_total.Location = New System.Drawing.Point(70, 424)
        Me.pb_total.Maximum = 100
        Me.pb_total.Name = "pb_total"
        Me.pb_total.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pb_total.Size = New System.Drawing.Size(334, 42)
        Me.pb_total.TabIndex = 46
        Me.pb_total.Text = "FlatProgressBar1"
        Me.pb_total.Value = 0
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 500)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bot"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As bot.FormSkin
    Friend WithEvents stb As bot.FlatStatusBar
    Friend WithEvents num_0 As bot.FlatNumeric
    Friend WithEvents FlatLabel1 As bot.FlatLabel
    Friend WithEvents num_8 As bot.FlatNumeric
    Friend WithEvents FlatLabel9 As bot.FlatLabel
    Friend WithEvents num_7 As bot.FlatNumeric
    Friend WithEvents FlatLabel8 As bot.FlatLabel
    Friend WithEvents num_6 As bot.FlatNumeric
    Friend WithEvents FlatLabel7 As bot.FlatLabel
    Friend WithEvents num_5 As bot.FlatNumeric
    Friend WithEvents FlatLabel6 As bot.FlatLabel
    Friend WithEvents num_4 As bot.FlatNumeric
    Friend WithEvents FlatLabel5 As bot.FlatLabel
    Friend WithEvents num_3 As bot.FlatNumeric
    Friend WithEvents FlatLabel4 As bot.FlatLabel
    Friend WithEvents num_2 As bot.FlatNumeric
    Friend WithEvents FlatLabel3 As bot.FlatLabel
    Friend WithEvents num_1 As bot.FlatNumeric
    Friend WithEvents FlatLabel2 As bot.FlatLabel
    Friend WithEvents num_9 As bot.FlatNumeric
    Friend WithEvents FlatLabel10 As bot.FlatLabel
    Friend WithEvents btn_minimize As bot.FlatMini
    Friend WithEvents FlatLabel18 As bot.FlatLabel
    Friend WithEvents FlatLabel17 As bot.FlatLabel
    Friend WithEvents FlatLabel16 As bot.FlatLabel
    Friend WithEvents FlatLabel15 As bot.FlatLabel
    Friend WithEvents FlatLabel14 As bot.FlatLabel
    Friend WithEvents FlatLabel13 As bot.FlatLabel
    Friend WithEvents FlatLabel12 As bot.FlatLabel
    Friend WithEvents FlatLabel11 As bot.FlatLabel
    Friend WithEvents FlatLabel19 As bot.FlatLabel
    Friend WithEvents FlatLabel20 As bot.FlatLabel
    Friend WithEvents rd_half As bot.RadioButton
    Friend WithEvents rd_equal As bot.RadioButton
    Friend WithEvents FlatLabel21 As bot.FlatLabel
    Friend WithEvents FlatLabel22 As bot.FlatLabel
    Friend WithEvents FlatLabel23 As bot.FlatLabel
    Friend WithEvents FlatLabel25 As bot.FlatLabel
    Friend WithEvents FlatLabel24 As bot.FlatLabel
    Friend WithEvents FlatLabel27 As bot.FlatLabel
    Friend WithEvents FlatLabel26 As bot.FlatLabel
    Friend WithEvents ch_independent As bot.FlatCheckBox
    Friend WithEvents btn_start As bot.FlatButton
    Friend WithEvents btn_stop As bot.FlatButton
    Friend WithEvents lb_total As bot.FlatLabel
    Friend WithEvents pb_total As bot.FlatProgressBar
    Friend WithEvents lb_pwr As bot.FlatLabel
    Friend WithEvents FlatLabel39 As bot.FlatLabel
    Friend WithEvents FlatLabel38 As bot.FlatLabel
    Friend WithEvents FlatLabel37 As bot.FlatLabel
    Friend WithEvents FlatLabel36 As bot.FlatLabel
    Friend WithEvents FlatLabel35 As bot.FlatLabel
    Friend WithEvents FlatLabel34 As bot.FlatLabel
    Friend WithEvents FlatLabel33 As bot.FlatLabel
    Friend WithEvents FlatLabel32 As bot.FlatLabel
    Friend WithEvents FlatLabel31 As bot.FlatLabel
    Friend WithEvents FlatLabel30 As bot.FlatLabel
    Friend WithEvents lb_9 As bot.FlatLabel
    Friend WithEvents lb_8 As bot.FlatLabel
    Friend WithEvents lb_7 As bot.FlatLabel
    Friend WithEvents lb_6 As bot.FlatLabel
    Friend WithEvents lb_5 As bot.FlatLabel
    Friend WithEvents lb_4 As bot.FlatLabel
    Friend WithEvents lb_3 As bot.FlatLabel
    Friend WithEvents lb_2 As bot.FlatLabel
    Friend WithEvents lb_1 As bot.FlatLabel
    Friend WithEvents lb_0 As bot.FlatLabel
    Friend WithEvents FlatLabel50 As bot.FlatLabel
    Friend WithEvents num_total As bot.FlatNumeric
    Friend WithEvents FlatLabel51 As bot.FlatLabel
    Friend WithEvents FlatLabel52 As bot.FlatLabel
    Friend WithEvents num_sleep As bot.FlatNumeric
    Friend WithEvents FlatLabel53 As bot.FlatLabel
    Friend WithEvents btn_channel As bot.FlatButton
    Friend WithEvents progress_sec As System.Windows.Forms.Timer
    Friend WithEvents ch_9 As bot.FlatCheckBox
    Friend WithEvents ch_8 As bot.FlatCheckBox
    Friend WithEvents ch_7 As bot.FlatCheckBox
    Friend WithEvents ch_6 As bot.FlatCheckBox
    Friend WithEvents ch_5 As bot.FlatCheckBox
    Friend WithEvents ch_4 As bot.FlatCheckBox
    Friend WithEvents ch_3 As bot.FlatCheckBox
    Friend WithEvents ch_2 As bot.FlatCheckBox
    Friend WithEvents ch_1 As bot.FlatCheckBox
    Friend WithEvents ch_0 As bot.FlatCheckBox
    Friend WithEvents FlatLabel28 As bot.FlatLabel
    Friend WithEvents tg_notification As bot.FlatToggle
    Friend WithEvents notify As System.Windows.Forms.NotifyIcon
    Friend WithEvents btn_exit As bot.FlatClose

End Class
