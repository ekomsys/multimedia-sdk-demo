<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.biggerPreview = New System.Windows.Forms.Panel()
        Me.smallPreviewOne = New System.Windows.Forms.Panel()
        Me.smallPreviewTwo = New System.Windows.Forms.Panel()
        Me.smallPreviewThree = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LiveServerIndicator = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CGServerIndicator = New System.Windows.Forms.PictureBox()
        Me.PlayerServerIndicator = New System.Windows.Forms.PictureBox()
        Me.RenderingServerIndicator = New System.Windows.Forms.PictureBox()
        Me.BootSystem = New System.Windows.Forms.Button()
        Me.OutputFormatList = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.renderingDeviceVideoHwList = New System.Windows.Forms.ComboBox()
        Me.renderingDeviceAudioHwList = New System.Windows.Forms.ComboBox()
        Me.stopRenderingDevice = New System.Windows.Forms.Button()
        Me.startRenderingDevice = New System.Windows.Forms.Button()
        Me.renderingDevices = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PlaylistTimeLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PlayerNextBtn = New System.Windows.Forms.Button()
        Me.PlayerPauseBtn = New System.Windows.Forms.Button()
        Me.PlayerPlayBtn = New System.Windows.Forms.Button()
        Me.PlayerPreviousBtn = New System.Windows.Forms.Button()
        Me.PlayerQueueBtn = New System.Windows.Forms.Button()
        Me.PlayerMediaList = New System.Windows.Forms.ListView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CGUnloadAnimation = New System.Windows.Forms.Button()
        Me.CGPlayAnimation = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CGPlayingAnimations = New System.Windows.Forms.ListView()
        Me.CGAvailableAnimations = New System.Windows.Forms.ListView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.liveDeviceModeList = New System.Windows.Forms.ComboBox()
        Me.liveDeviceVideoHwList = New System.Windows.Forms.ComboBox()
        Me.liveDeviceAudioHwList = New System.Windows.Forms.ComboBox()
        Me.RefreshSources = New System.Windows.Forms.Button()
        Me.StopSource = New System.Windows.Forms.Button()
        Me.StartSource = New System.Windows.Forms.Button()
        Me.SourceList = New System.Windows.Forms.ComboBox()
        Me.HelpWindow = New System.Windows.Forms.RichTextBox()
        Me.smallPreviewOneLeftChannel = New System.Windows.Forms.ProgressBar()
        Me.smallPreviewOneRightChannel = New System.Windows.Forms.ProgressBar()
        Me.VUMeterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.VUMeterDecayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.smallPreviewTwoRightChannel = New System.Windows.Forms.ProgressBar()
        Me.smallPreviewTwoLeftChannel = New System.Windows.Forms.ProgressBar()
        Me.smallPreviewThreeRightChannel = New System.Windows.Forms.ProgressBar()
        Me.smallPreviewThreeLeftChannel = New System.Windows.Forms.ProgressBar()
        Me.biggerPreviewRightChannel = New System.Windows.Forms.ProgressBar()
        Me.biggerPreviewLeftChannel = New System.Windows.Forms.ProgressBar()
        Me.previewOneVolume = New System.Windows.Forms.TrackBar()
        Me.previewTwoVolume = New System.Windows.Forms.TrackBar()
        Me.previewThreeVolume = New System.Windows.Forms.TrackBar()
        Me.biggerPreviewVolume = New System.Windows.Forms.TrackBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LogWindow = New System.Windows.Forms.ListBox()
        Me.PlaylistTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.LiveServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CGServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenderingServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.previewOneVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewTwoVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewThreeVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biggerPreviewVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'biggerPreview
        '
        Me.biggerPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.biggerPreview.Location = New System.Drawing.Point(1025, 27)
        Me.biggerPreview.Name = "biggerPreview"
        Me.biggerPreview.Size = New System.Drawing.Size(877, 574)
        Me.biggerPreview.TabIndex = 0
        '
        'smallPreviewOne
        '
        Me.smallPreviewOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.smallPreviewOne.Location = New System.Drawing.Point(12, 27)
        Me.smallPreviewOne.Name = "smallPreviewOne"
        Me.smallPreviewOne.Size = New System.Drawing.Size(276, 254)
        Me.smallPreviewOne.TabIndex = 1
        '
        'smallPreviewTwo
        '
        Me.smallPreviewTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.smallPreviewTwo.Location = New System.Drawing.Point(360, 27)
        Me.smallPreviewTwo.Name = "smallPreviewTwo"
        Me.smallPreviewTwo.Size = New System.Drawing.Size(276, 254)
        Me.smallPreviewTwo.TabIndex = 2
        '
        'smallPreviewThree
        '
        Me.smallPreviewThree.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.smallPreviewThree.Location = New System.Drawing.Point(707, 27)
        Me.smallPreviewThree.Name = "smallPreviewThree"
        Me.smallPreviewThree.Size = New System.Drawing.Size(276, 254)
        Me.smallPreviewThree.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LiveServerIndicator)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CGServerIndicator)
        Me.GroupBox1.Controls.Add(Me.PlayerServerIndicator)
        Me.GroupBox1.Controls.Add(Me.RenderingServerIndicator)
        Me.GroupBox1.Controls.Add(Me.BootSystem)
        Me.GroupBox1.Controls.Add(Me.OutputFormatList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 158)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "System Control"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(130, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Live"
        '
        'LiveServerIndicator
        '
        Me.LiveServerIndicator.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LiveServerIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LiveServerIndicator.Location = New System.Drawing.Point(122, 101)
        Me.LiveServerIndicator.Name = "LiveServerIndicator"
        Me.LiveServerIndicator.Size = New System.Drawing.Size(37, 21)
        Me.LiveServerIndicator.TabIndex = 9
        Me.LiveServerIndicator.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "CG    "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Player"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Renderer"
        '
        'CGServerIndicator
        '
        Me.CGServerIndicator.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CGServerIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CGServerIndicator.Location = New System.Drawing.Point(73, 101)
        Me.CGServerIndicator.Name = "CGServerIndicator"
        Me.CGServerIndicator.Size = New System.Drawing.Size(37, 21)
        Me.CGServerIndicator.TabIndex = 5
        Me.CGServerIndicator.TabStop = False
        '
        'PlayerServerIndicator
        '
        Me.PlayerServerIndicator.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PlayerServerIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerServerIndicator.Location = New System.Drawing.Point(21, 101)
        Me.PlayerServerIndicator.Name = "PlayerServerIndicator"
        Me.PlayerServerIndicator.Size = New System.Drawing.Size(37, 21)
        Me.PlayerServerIndicator.TabIndex = 4
        Me.PlayerServerIndicator.TabStop = False
        '
        'RenderingServerIndicator
        '
        Me.RenderingServerIndicator.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.RenderingServerIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RenderingServerIndicator.Location = New System.Drawing.Point(165, 101)
        Me.RenderingServerIndicator.Name = "RenderingServerIndicator"
        Me.RenderingServerIndicator.Size = New System.Drawing.Size(37, 21)
        Me.RenderingServerIndicator.TabIndex = 3
        Me.RenderingServerIndicator.TabStop = False
        '
        'BootSystem
        '
        Me.BootSystem.Location = New System.Drawing.Point(212, 101)
        Me.BootSystem.Name = "BootSystem"
        Me.BootSystem.Size = New System.Drawing.Size(109, 23)
        Me.BootSystem.TabIndex = 2
        Me.BootSystem.Text = "Boot System"
        Me.BootSystem.UseVisualStyleBackColor = True
        '
        'OutputFormatList
        '
        Me.OutputFormatList.FormattingEnabled = True
        Me.OutputFormatList.Items.AddRange(New Object() {"PAL", "NTSC", "HD 720p 60", "HD 1080p 24", "HD 1080i 59.94"})
        Me.OutputFormatList.Location = New System.Drawing.Point(21, 41)
        Me.OutputFormatList.Name = "OutputFormatList"
        Me.OutputFormatList.Size = New System.Drawing.Size(300, 21)
        Me.OutputFormatList.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.renderingDeviceVideoHwList)
        Me.GroupBox2.Controls.Add(Me.renderingDeviceAudioHwList)
        Me.GroupBox2.Controls.Add(Me.stopRenderingDevice)
        Me.GroupBox2.Controls.Add(Me.startRenderingDevice)
        Me.GroupBox2.Controls.Add(Me.renderingDevices)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 158)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Devices"
        '
        'renderingDeviceVideoHwList
        '
        Me.renderingDeviceVideoHwList.FormattingEnabled = True
        Me.renderingDeviceVideoHwList.Location = New System.Drawing.Point(24, 116)
        Me.renderingDeviceVideoHwList.Name = "renderingDeviceVideoHwList"
        Me.renderingDeviceVideoHwList.Size = New System.Drawing.Size(154, 21)
        Me.renderingDeviceVideoHwList.TabIndex = 6
        '
        'renderingDeviceAudioHwList
        '
        Me.renderingDeviceAudioHwList.FormattingEnabled = True
        Me.renderingDeviceAudioHwList.Location = New System.Drawing.Point(24, 70)
        Me.renderingDeviceAudioHwList.Name = "renderingDeviceAudioHwList"
        Me.renderingDeviceAudioHwList.Size = New System.Drawing.Size(154, 21)
        Me.renderingDeviceAudioHwList.TabIndex = 5
        '
        'stopRenderingDevice
        '
        Me.stopRenderingDevice.Location = New System.Drawing.Point(202, 97)
        Me.stopRenderingDevice.Name = "stopRenderingDevice"
        Me.stopRenderingDevice.Size = New System.Drawing.Size(71, 23)
        Me.stopRenderingDevice.TabIndex = 4
        Me.stopRenderingDevice.Text = "Stop"
        Me.stopRenderingDevice.UseVisualStyleBackColor = True
        '
        'startRenderingDevice
        '
        Me.startRenderingDevice.Location = New System.Drawing.Point(202, 55)
        Me.startRenderingDevice.Name = "startRenderingDevice"
        Me.startRenderingDevice.Size = New System.Drawing.Size(71, 23)
        Me.startRenderingDevice.TabIndex = 3
        Me.startRenderingDevice.Text = "Start"
        Me.startRenderingDevice.UseVisualStyleBackColor = True
        '
        'renderingDevices
        '
        Me.renderingDevices.FormattingEnabled = True
        Me.renderingDevices.Location = New System.Drawing.Point(24, 28)
        Me.renderingDevices.Name = "renderingDevices"
        Me.renderingDevices.Size = New System.Drawing.Size(154, 21)
        Me.renderingDevices.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PlaylistTimeLabel)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.PlayerNextBtn)
        Me.GroupBox3.Controls.Add(Me.PlayerPauseBtn)
        Me.GroupBox3.Controls.Add(Me.PlayerPlayBtn)
        Me.GroupBox3.Controls.Add(Me.PlayerPreviousBtn)
        Me.GroupBox3.Controls.Add(Me.PlayerQueueBtn)
        Me.GroupBox3.Controls.Add(Me.PlayerMediaList)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 527)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 227)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Player"
        '
        'PlaylistTimeLabel
        '
        Me.PlaylistTimeLabel.AutoSize = True
        Me.PlaylistTimeLabel.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaylistTimeLabel.ForeColor = System.Drawing.Color.OliveDrab
        Me.PlaylistTimeLabel.Location = New System.Drawing.Point(58, 26)
        Me.PlaylistTimeLabel.Name = "PlaylistTimeLabel"
        Me.PlaylistTimeLabel.Size = New System.Drawing.Size(149, 35)
        Me.PlaylistTimeLabel.TabIndex = 12
        Me.PlaylistTimeLabel.Text = "00:00:00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 11
        '
        'PlayerNextBtn
        '
        Me.PlayerNextBtn.Location = New System.Drawing.Point(156, 198)
        Me.PlayerNextBtn.Name = "PlayerNextBtn"
        Me.PlayerNextBtn.Size = New System.Drawing.Size(31, 23)
        Me.PlayerNextBtn.TabIndex = 10
        Me.PlayerNextBtn.Text = ">"
        Me.PlayerNextBtn.UseVisualStyleBackColor = True
        '
        'PlayerPauseBtn
        '
        Me.PlayerPauseBtn.Location = New System.Drawing.Point(119, 198)
        Me.PlayerPauseBtn.Name = "PlayerPauseBtn"
        Me.PlayerPauseBtn.Size = New System.Drawing.Size(31, 23)
        Me.PlayerPauseBtn.TabIndex = 9
        Me.PlayerPauseBtn.Text = "||"
        Me.PlayerPauseBtn.UseVisualStyleBackColor = True
        '
        'PlayerPlayBtn
        '
        Me.PlayerPlayBtn.Location = New System.Drawing.Point(82, 198)
        Me.PlayerPlayBtn.Name = "PlayerPlayBtn"
        Me.PlayerPlayBtn.Size = New System.Drawing.Size(31, 23)
        Me.PlayerPlayBtn.TabIndex = 8
        Me.PlayerPlayBtn.Text = "|>"
        Me.PlayerPlayBtn.UseVisualStyleBackColor = True
        '
        'PlayerPreviousBtn
        '
        Me.PlayerPreviousBtn.Location = New System.Drawing.Point(38, 198)
        Me.PlayerPreviousBtn.Name = "PlayerPreviousBtn"
        Me.PlayerPreviousBtn.Size = New System.Drawing.Size(31, 23)
        Me.PlayerPreviousBtn.TabIndex = 7
        Me.PlayerPreviousBtn.Text = "<"
        Me.PlayerPreviousBtn.UseVisualStyleBackColor = True
        '
        'PlayerQueueBtn
        '
        Me.PlayerQueueBtn.Location = New System.Drawing.Point(236, 198)
        Me.PlayerQueueBtn.Name = "PlayerQueueBtn"
        Me.PlayerQueueBtn.Size = New System.Drawing.Size(31, 23)
        Me.PlayerQueueBtn.TabIndex = 6
        Me.PlayerQueueBtn.Text = "+"
        Me.PlayerQueueBtn.UseVisualStyleBackColor = True
        '
        'PlayerMediaList
        '
        Me.PlayerMediaList.GridLines = True
        Me.PlayerMediaList.Location = New System.Drawing.Point(38, 66)
        Me.PlayerMediaList.MultiSelect = False
        Me.PlayerMediaList.Name = "PlayerMediaList"
        Me.PlayerMediaList.Size = New System.Drawing.Size(189, 126)
        Me.PlayerMediaList.TabIndex = 0
        Me.PlayerMediaList.UseCompatibleStateImageBehavior = False
        Me.PlayerMediaList.View = System.Windows.Forms.View.List
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CGUnloadAnimation)
        Me.GroupBox4.Controls.Add(Me.CGPlayAnimation)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.CGPlayingAnimations)
        Me.GroupBox4.Controls.Add(Me.CGAvailableAnimations)
        Me.GroupBox4.Location = New System.Drawing.Point(334, 527)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(357, 227)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CG"
        '
        'CGUnloadAnimation
        '
        Me.CGUnloadAnimation.Location = New System.Drawing.Point(153, 142)
        Me.CGUnloadAnimation.Name = "CGUnloadAnimation"
        Me.CGUnloadAnimation.Size = New System.Drawing.Size(40, 23)
        Me.CGUnloadAnimation.TabIndex = 7
        Me.CGUnloadAnimation.Text = "<-"
        Me.CGUnloadAnimation.UseVisualStyleBackColor = True
        '
        'CGPlayAnimation
        '
        Me.CGPlayAnimation.Location = New System.Drawing.Point(153, 102)
        Me.CGPlayAnimation.Name = "CGPlayAnimation"
        Me.CGPlayAnimation.Size = New System.Drawing.Size(40, 23)
        Me.CGPlayAnimation.TabIndex = 6
        Me.CGPlayAnimation.Text = "->"
        Me.CGPlayAnimation.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Playing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Available"
        '
        'CGPlayingAnimations
        '
        Me.CGPlayingAnimations.Location = New System.Drawing.Point(199, 67)
        Me.CGPlayingAnimations.Name = "CGPlayingAnimations"
        Me.CGPlayingAnimations.Size = New System.Drawing.Size(123, 137)
        Me.CGPlayingAnimations.TabIndex = 1
        Me.CGPlayingAnimations.UseCompatibleStateImageBehavior = False
        Me.CGPlayingAnimations.View = System.Windows.Forms.View.List
        '
        'CGAvailableAnimations
        '
        Me.CGAvailableAnimations.Location = New System.Drawing.Point(24, 67)
        Me.CGAvailableAnimations.Name = "CGAvailableAnimations"
        Me.CGAvailableAnimations.Size = New System.Drawing.Size(123, 137)
        Me.CGAvailableAnimations.TabIndex = 0
        Me.CGAvailableAnimations.UseCompatibleStateImageBehavior = False
        Me.CGAvailableAnimations.View = System.Windows.Forms.View.List
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.liveDeviceModeList)
        Me.GroupBox6.Controls.Add(Me.liveDeviceVideoHwList)
        Me.GroupBox6.Controls.Add(Me.liveDeviceAudioHwList)
        Me.GroupBox6.Controls.Add(Me.RefreshSources)
        Me.GroupBox6.Controls.Add(Me.StopSource)
        Me.GroupBox6.Controls.Add(Me.StartSource)
        Me.GroupBox6.Controls.Add(Me.SourceList)
        Me.GroupBox6.Location = New System.Drawing.Point(707, 363)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(288, 208)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sources"
        '
        'liveDeviceModeList
        '
        Me.liveDeviceModeList.FormattingEnabled = True
        Me.liveDeviceModeList.Location = New System.Drawing.Point(6, 65)
        Me.liveDeviceModeList.Name = "liveDeviceModeList"
        Me.liveDeviceModeList.Size = New System.Drawing.Size(155, 21)
        Me.liveDeviceModeList.TabIndex = 13
        '
        'liveDeviceVideoHwList
        '
        Me.liveDeviceVideoHwList.FormattingEnabled = True
        Me.liveDeviceVideoHwList.Location = New System.Drawing.Point(6, 127)
        Me.liveDeviceVideoHwList.Name = "liveDeviceVideoHwList"
        Me.liveDeviceVideoHwList.Size = New System.Drawing.Size(267, 21)
        Me.liveDeviceVideoHwList.TabIndex = 12
        '
        'liveDeviceAudioHwList
        '
        Me.liveDeviceAudioHwList.FormattingEnabled = True
        Me.liveDeviceAudioHwList.Location = New System.Drawing.Point(6, 100)
        Me.liveDeviceAudioHwList.Name = "liveDeviceAudioHwList"
        Me.liveDeviceAudioHwList.Size = New System.Drawing.Size(267, 21)
        Me.liveDeviceAudioHwList.TabIndex = 7
        '
        'RefreshSources
        '
        Me.RefreshSources.Location = New System.Drawing.Point(215, 170)
        Me.RefreshSources.Name = "RefreshSources"
        Me.RefreshSources.Size = New System.Drawing.Size(61, 23)
        Me.RefreshSources.TabIndex = 11
        Me.RefreshSources.Text = "Refresh"
        Me.RefreshSources.UseVisualStyleBackColor = True
        '
        'StopSource
        '
        Me.StopSource.Location = New System.Drawing.Point(114, 170)
        Me.StopSource.Name = "StopSource"
        Me.StopSource.Size = New System.Drawing.Size(61, 23)
        Me.StopSource.TabIndex = 10
        Me.StopSource.Text = "Stop"
        Me.StopSource.UseVisualStyleBackColor = True
        '
        'StartSource
        '
        Me.StartSource.Location = New System.Drawing.Point(9, 170)
        Me.StartSource.Name = "StartSource"
        Me.StartSource.Size = New System.Drawing.Size(61, 23)
        Me.StartSource.TabIndex = 8
        Me.StartSource.Text = "Start"
        Me.StartSource.UseVisualStyleBackColor = True
        '
        'SourceList
        '
        Me.SourceList.FormattingEnabled = True
        Me.SourceList.Location = New System.Drawing.Point(6, 24)
        Me.SourceList.Name = "SourceList"
        Me.SourceList.Size = New System.Drawing.Size(267, 21)
        Me.SourceList.TabIndex = 9
        '
        'HelpWindow
        '
        Me.HelpWindow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.HelpWindow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HelpWindow.Enabled = False
        Me.HelpWindow.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpWindow.ForeColor = System.Drawing.Color.RoyalBlue
        Me.HelpWindow.Location = New System.Drawing.Point(12, 778)
        Me.HelpWindow.Name = "HelpWindow"
        Me.HelpWindow.Size = New System.Drawing.Size(983, 179)
        Me.HelpWindow.TabIndex = 15
        Me.HelpWindow.Text = "Help System"
        '
        'smallPreviewOneLeftChannel
        '
        Me.smallPreviewOneLeftChannel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.smallPreviewOneLeftChannel.Location = New System.Drawing.Point(12, 314)
        Me.smallPreviewOneLeftChannel.Name = "smallPreviewOneLeftChannel"
        Me.smallPreviewOneLeftChannel.Size = New System.Drawing.Size(169, 10)
        Me.smallPreviewOneLeftChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.smallPreviewOneLeftChannel.TabIndex = 16
        '
        'smallPreviewOneRightChannel
        '
        Me.smallPreviewOneRightChannel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.smallPreviewOneRightChannel.Location = New System.Drawing.Point(12, 323)
        Me.smallPreviewOneRightChannel.Name = "smallPreviewOneRightChannel"
        Me.smallPreviewOneRightChannel.Size = New System.Drawing.Size(169, 10)
        Me.smallPreviewOneRightChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.smallPreviewOneRightChannel.TabIndex = 17
        '
        'VUMeterTimer
        '
        Me.VUMeterTimer.Interval = 200
        '
        'smallPreviewTwoRightChannel
        '
        Me.smallPreviewTwoRightChannel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.smallPreviewTwoRightChannel.Location = New System.Drawing.Point(360, 323)
        Me.smallPreviewTwoRightChannel.Name = "smallPreviewTwoRightChannel"
        Me.smallPreviewTwoRightChannel.Size = New System.Drawing.Size(167, 10)
        Me.smallPreviewTwoRightChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.smallPreviewTwoRightChannel.TabIndex = 19
        '
        'smallPreviewTwoLeftChannel
        '
        Me.smallPreviewTwoLeftChannel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.smallPreviewTwoLeftChannel.Location = New System.Drawing.Point(360, 314)
        Me.smallPreviewTwoLeftChannel.Name = "smallPreviewTwoLeftChannel"
        Me.smallPreviewTwoLeftChannel.Size = New System.Drawing.Size(167, 10)
        Me.smallPreviewTwoLeftChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.smallPreviewTwoLeftChannel.TabIndex = 18
        '
        'smallPreviewThreeRightChannel
        '
        Me.smallPreviewThreeRightChannel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.smallPreviewThreeRightChannel.Location = New System.Drawing.Point(707, 323)
        Me.smallPreviewThreeRightChannel.Name = "smallPreviewThreeRightChannel"
        Me.smallPreviewThreeRightChannel.Size = New System.Drawing.Size(161, 10)
        Me.smallPreviewThreeRightChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.smallPreviewThreeRightChannel.TabIndex = 21
        '
        'smallPreviewThreeLeftChannel
        '
        Me.smallPreviewThreeLeftChannel.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.smallPreviewThreeLeftChannel.Location = New System.Drawing.Point(707, 314)
        Me.smallPreviewThreeLeftChannel.Name = "smallPreviewThreeLeftChannel"
        Me.smallPreviewThreeLeftChannel.Size = New System.Drawing.Size(161, 10)
        Me.smallPreviewThreeLeftChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.smallPreviewThreeLeftChannel.TabIndex = 20
        '
        'biggerPreviewRightChannel
        '
        Me.biggerPreviewRightChannel.Location = New System.Drawing.Point(1025, 627)
        Me.biggerPreviewRightChannel.Name = "biggerPreviewRightChannel"
        Me.biggerPreviewRightChannel.Size = New System.Drawing.Size(243, 10)
        Me.biggerPreviewRightChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.biggerPreviewRightChannel.TabIndex = 23
        '
        'biggerPreviewLeftChannel
        '
        Me.biggerPreviewLeftChannel.Location = New System.Drawing.Point(1025, 618)
        Me.biggerPreviewLeftChannel.Name = "biggerPreviewLeftChannel"
        Me.biggerPreviewLeftChannel.Size = New System.Drawing.Size(243, 10)
        Me.biggerPreviewLeftChannel.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.biggerPreviewLeftChannel.TabIndex = 22
        '
        'previewOneVolume
        '
        Me.previewOneVolume.Location = New System.Drawing.Point(187, 314)
        Me.previewOneVolume.Maximum = 100
        Me.previewOneVolume.Name = "previewOneVolume"
        Me.previewOneVolume.Size = New System.Drawing.Size(104, 45)
        Me.previewOneVolume.TabIndex = 24
        Me.previewOneVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.previewOneVolume.Value = 80
        '
        'previewTwoVolume
        '
        Me.previewTwoVolume.Location = New System.Drawing.Point(532, 314)
        Me.previewTwoVolume.Maximum = 100
        Me.previewTwoVolume.Name = "previewTwoVolume"
        Me.previewTwoVolume.Size = New System.Drawing.Size(104, 45)
        Me.previewTwoVolume.TabIndex = 25
        Me.previewTwoVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.previewTwoVolume.Value = 80
        '
        'previewThreeVolume
        '
        Me.previewThreeVolume.Location = New System.Drawing.Point(884, 312)
        Me.previewThreeVolume.Maximum = 100
        Me.previewThreeVolume.Name = "previewThreeVolume"
        Me.previewThreeVolume.Size = New System.Drawing.Size(104, 45)
        Me.previewThreeVolume.TabIndex = 26
        Me.previewThreeVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.previewThreeVolume.Value = 80
        '
        'biggerPreviewVolume
        '
        Me.biggerPreviewVolume.Location = New System.Drawing.Point(1353, 618)
        Me.biggerPreviewVolume.Maximum = 100
        Me.biggerPreviewVolume.Name = "biggerPreviewVolume"
        Me.biggerPreviewVolume.Size = New System.Drawing.Size(173, 45)
        Me.biggerPreviewVolume.TabIndex = 27
        Me.biggerPreviewVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.biggerPreviewVolume.Value = 80
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1839, 965)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 38)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1579, 987)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Copyright 2017, Ekomsys, LLC , All rights reserved"
        '
        'LogWindow
        '
        Me.LogWindow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LogWindow.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogWindow.ForeColor = System.Drawing.SystemColors.GrayText
        Me.LogWindow.FormattingEnabled = True
        Me.LogWindow.ItemHeight = 24
        Me.LogWindow.Location = New System.Drawing.Point(1025, 669)
        Me.LogWindow.Name = "LogWindow"
        Me.LogWindow.Size = New System.Drawing.Size(877, 268)
        Me.LogWindow.TabIndex = 30
        '
        'PlaylistTimer
        '
        Me.PlaylistTimer.Interval = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Player"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(357, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "CG"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(704, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Live Device"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1870, 618)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Mixer"
        '
        'LogTimer
        '
        Me.LogTimer.Interval = 500
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1914, 1009)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LogWindow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.biggerPreviewVolume)
        Me.Controls.Add(Me.previewThreeVolume)
        Me.Controls.Add(Me.previewTwoVolume)
        Me.Controls.Add(Me.previewOneVolume)
        Me.Controls.Add(Me.biggerPreviewRightChannel)
        Me.Controls.Add(Me.biggerPreviewLeftChannel)
        Me.Controls.Add(Me.smallPreviewThreeRightChannel)
        Me.Controls.Add(Me.smallPreviewThreeLeftChannel)
        Me.Controls.Add(Me.smallPreviewTwoRightChannel)
        Me.Controls.Add(Me.smallPreviewTwoLeftChannel)
        Me.Controls.Add(Me.smallPreviewOneRightChannel)
        Me.Controls.Add(Me.smallPreviewOneLeftChannel)
        Me.Controls.Add(Me.HelpWindow)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.smallPreviewThree)
        Me.Controls.Add(Me.smallPreviewTwo)
        Me.Controls.Add(Me.smallPreviewOne)
        Me.Controls.Add(Me.biggerPreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "Ekomsys Multimedia SDK Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LiveServerIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CGServerIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerServerIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RenderingServerIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.previewOneVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewTwoVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewThreeVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biggerPreviewVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents biggerPreview As Panel
    Friend WithEvents smallPreviewOne As Panel
    Friend WithEvents smallPreviewTwo As Panel
    Friend WithEvents smallPreviewThree As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BootSystem As Button
    Friend WithEvents OutputFormatList As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents stopRenderingDevice As Button
    Friend WithEvents startRenderingDevice As Button
    Friend WithEvents renderingDevices As ComboBox
    Friend WithEvents renderingDeviceAudioHwList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CGServerIndicator As PictureBox
    Friend WithEvents PlayerServerIndicator As PictureBox
    Friend WithEvents RenderingServerIndicator As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PlayerMediaList As ListView
    Friend WithEvents PlayerNextBtn As Button
    Friend WithEvents PlayerPauseBtn As Button
    Friend WithEvents PlayerPlayBtn As Button
    Friend WithEvents PlayerPreviousBtn As Button
    Friend WithEvents PlayerQueueBtn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CGPlayAnimation As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CGPlayingAnimations As ListView
    Friend WithEvents CGAvailableAnimations As ListView
    Friend WithEvents CGUnloadAnimation As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LiveServerIndicator As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents StopSource As Button
    Friend WithEvents StartSource As Button
    Friend WithEvents SourceList As ComboBox
    Friend WithEvents RefreshSources As Button
    Friend WithEvents HelpWindow As RichTextBox
    Friend WithEvents smallPreviewOneLeftChannel As ProgressBar
    Friend WithEvents smallPreviewOneRightChannel As ProgressBar
    Friend WithEvents VUMeterTimer As Timer
    Friend WithEvents VUMeterDecayTimer As Timer
    Friend WithEvents smallPreviewTwoRightChannel As ProgressBar
    Friend WithEvents smallPreviewTwoLeftChannel As ProgressBar
    Friend WithEvents smallPreviewThreeRightChannel As ProgressBar
    Friend WithEvents smallPreviewThreeLeftChannel As ProgressBar
    Friend WithEvents biggerPreviewRightChannel As ProgressBar
    Friend WithEvents biggerPreviewLeftChannel As ProgressBar
    Friend WithEvents previewOneVolume As TrackBar
    Friend WithEvents previewTwoVolume As TrackBar
    Friend WithEvents previewThreeVolume As TrackBar
    Friend WithEvents biggerPreviewVolume As TrackBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LogWindow As ListBox
    Friend WithEvents PlaylistTimer As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents PlaylistTimeLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents renderingDeviceVideoHwList As ComboBox
    Friend WithEvents liveDeviceVideoHwList As ComboBox
    Friend WithEvents liveDeviceAudioHwList As ComboBox
    Friend WithEvents liveDeviceModeList As ComboBox
    Friend WithEvents LogTimer As Timer
End Class
