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
        Me.LiveDeviceThree = New System.Windows.Forms.PictureBox()
        Me.LiveDeviceTwo = New System.Windows.Forms.PictureBox()
        Me.LiveDeviceOne = New System.Windows.Forms.PictureBox()
        Me.smallPreviewOne = New System.Windows.Forms.Panel()
        Me.smallPreviewTwo = New System.Windows.Forms.Panel()
        Me.previewOneSelector = New System.Windows.Forms.ComboBox()
        Me.previewTwoSelector = New System.Windows.Forms.ComboBox()
        Me.biggerPreviewSelector = New System.Windows.Forms.ComboBox()
        Me.smallPreviewThree = New System.Windows.Forms.Panel()
        Me.previewThreeSelector = New System.Windows.Forms.ComboBox()
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
        Me.getFormats = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deviceConnection = New System.Windows.Forms.ComboBox()
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.StopLive = New System.Windows.Forms.Button()
        Me.StartLive = New System.Windows.Forms.Button()
        Me.LiveDevicesList = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
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
        Me.biggerPreview.SuspendLayout()
        CType(Me.LiveDeviceThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiveDeviceTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LiveDeviceOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LiveServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CGServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RenderingServerIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.biggerPreview.Controls.Add(Me.LiveDeviceThree)
        Me.biggerPreview.Controls.Add(Me.LiveDeviceTwo)
        Me.biggerPreview.Controls.Add(Me.LiveDeviceOne)
        Me.biggerPreview.Location = New System.Drawing.Point(1025, 27)
        Me.biggerPreview.Name = "biggerPreview"
        Me.biggerPreview.Size = New System.Drawing.Size(877, 574)
        Me.biggerPreview.TabIndex = 0
        '
        'LiveDeviceThree
        '
        Me.LiveDeviceThree.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LiveDeviceThree.Location = New System.Drawing.Point(138, 311)
        Me.LiveDeviceThree.Name = "LiveDeviceThree"
        Me.LiveDeviceThree.Size = New System.Drawing.Size(242, 183)
        Me.LiveDeviceThree.TabIndex = 2
        Me.LiveDeviceThree.TabStop = False
        Me.LiveDeviceThree.Visible = False
        '
        'LiveDeviceTwo
        '
        Me.LiveDeviceTwo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LiveDeviceTwo.Location = New System.Drawing.Point(420, 118)
        Me.LiveDeviceTwo.Name = "LiveDeviceTwo"
        Me.LiveDeviceTwo.Size = New System.Drawing.Size(242, 183)
        Me.LiveDeviceTwo.TabIndex = 1
        Me.LiveDeviceTwo.TabStop = False
        Me.LiveDeviceTwo.Visible = False
        '
        'LiveDeviceOne
        '
        Me.LiveDeviceOne.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LiveDeviceOne.Location = New System.Drawing.Point(138, 113)
        Me.LiveDeviceOne.Name = "LiveDeviceOne"
        Me.LiveDeviceOne.Size = New System.Drawing.Size(242, 183)
        Me.LiveDeviceOne.TabIndex = 0
        Me.LiveDeviceOne.TabStop = False
        Me.LiveDeviceOne.Visible = False
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
        'previewOneSelector
        '
        Me.previewOneSelector.FormattingEnabled = True
        Me.previewOneSelector.Location = New System.Drawing.Point(12, 287)
        Me.previewOneSelector.Name = "previewOneSelector"
        Me.previewOneSelector.Size = New System.Drawing.Size(276, 21)
        Me.previewOneSelector.TabIndex = 3
        '
        'previewTwoSelector
        '
        Me.previewTwoSelector.FormattingEnabled = True
        Me.previewTwoSelector.Location = New System.Drawing.Point(360, 287)
        Me.previewTwoSelector.Name = "previewTwoSelector"
        Me.previewTwoSelector.Size = New System.Drawing.Size(276, 21)
        Me.previewTwoSelector.TabIndex = 4
        '
        'biggerPreviewSelector
        '
        Me.biggerPreviewSelector.FormattingEnabled = True
        Me.biggerPreviewSelector.Location = New System.Drawing.Point(1602, 616)
        Me.biggerPreviewSelector.Name = "biggerPreviewSelector"
        Me.biggerPreviewSelector.Size = New System.Drawing.Size(300, 21)
        Me.biggerPreviewSelector.TabIndex = 5
        '
        'smallPreviewThree
        '
        Me.smallPreviewThree.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.smallPreviewThree.Location = New System.Drawing.Point(707, 27)
        Me.smallPreviewThree.Name = "smallPreviewThree"
        Me.smallPreviewThree.Size = New System.Drawing.Size(276, 254)
        Me.smallPreviewThree.TabIndex = 2
        '
        'previewThreeSelector
        '
        Me.previewThreeSelector.FormattingEnabled = True
        Me.previewThreeSelector.Location = New System.Drawing.Point(707, 287)
        Me.previewThreeSelector.Name = "previewThreeSelector"
        Me.previewThreeSelector.Size = New System.Drawing.Size(276, 21)
        Me.previewThreeSelector.TabIndex = 6
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
        Me.GroupBox1.Controls.Add(Me.getFormats)
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
        Me.OutputFormatList.Location = New System.Drawing.Point(21, 41)
        Me.OutputFormatList.Name = "OutputFormatList"
        Me.OutputFormatList.Size = New System.Drawing.Size(169, 21)
        Me.OutputFormatList.TabIndex = 1
        '
        'getFormats
        '
        Me.getFormats.Location = New System.Drawing.Point(212, 41)
        Me.getFormats.Name = "getFormats"
        Me.getFormats.Size = New System.Drawing.Size(109, 23)
        Me.getFormats.TabIndex = 0
        Me.getFormats.Text = "Get Formats"
        Me.getFormats.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deviceConnection)
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
        'deviceConnection
        '
        Me.deviceConnection.FormattingEnabled = True
        Me.deviceConnection.Location = New System.Drawing.Point(24, 101)
        Me.deviceConnection.Name = "deviceConnection"
        Me.deviceConnection.Size = New System.Drawing.Size(154, 21)
        Me.deviceConnection.TabIndex = 5
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
        Me.renderingDevices.Location = New System.Drawing.Point(24, 57)
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.StopLive)
        Me.GroupBox5.Controls.Add(Me.StartLive)
        Me.GroupBox5.Controls.Add(Me.LiveDevicesList)
        Me.GroupBox5.Location = New System.Drawing.Point(707, 527)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(288, 227)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Live"
        '
        'StopLive
        '
        Me.StopLive.Location = New System.Drawing.Point(142, 120)
        Me.StopLive.Name = "StopLive"
        Me.StopLive.Size = New System.Drawing.Size(109, 23)
        Me.StopLive.TabIndex = 7
        Me.StopLive.Text = "Stop"
        Me.StopLive.UseVisualStyleBackColor = True
        '
        'StartLive
        '
        Me.StartLive.Location = New System.Drawing.Point(9, 118)
        Me.StartLive.Name = "StartLive"
        Me.StartLive.Size = New System.Drawing.Size(109, 23)
        Me.StartLive.TabIndex = 6
        Me.StartLive.Text = "Start"
        Me.StartLive.UseVisualStyleBackColor = True
        '
        'LiveDevicesList
        '
        Me.LiveDevicesList.FormattingEnabled = True
        Me.LiveDevicesList.Location = New System.Drawing.Point(6, 67)
        Me.LiveDevicesList.Name = "LiveDevicesList"
        Me.LiveDevicesList.Size = New System.Drawing.Size(245, 21)
        Me.LiveDevicesList.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RefreshSources)
        Me.GroupBox6.Controls.Add(Me.StopSource)
        Me.GroupBox6.Controls.Add(Me.StartSource)
        Me.GroupBox6.Controls.Add(Me.SourceList)
        Me.GroupBox6.Location = New System.Drawing.Point(707, 363)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(288, 158)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sources"
        '
        'RefreshSources
        '
        Me.RefreshSources.Location = New System.Drawing.Point(220, 97)
        Me.RefreshSources.Name = "RefreshSources"
        Me.RefreshSources.Size = New System.Drawing.Size(61, 23)
        Me.RefreshSources.TabIndex = 11
        Me.RefreshSources.Text = "Refresh"
        Me.RefreshSources.UseVisualStyleBackColor = True
        '
        'StopSource
        '
        Me.StopSource.Location = New System.Drawing.Point(121, 97)
        Me.StopSource.Name = "StopSource"
        Me.StopSource.Size = New System.Drawing.Size(61, 23)
        Me.StopSource.TabIndex = 10
        Me.StopSource.Text = "Stop"
        Me.StopSource.UseVisualStyleBackColor = True
        '
        'StartSource
        '
        Me.StartSource.Location = New System.Drawing.Point(9, 97)
        Me.StartSource.Name = "StartSource"
        Me.StartSource.Size = New System.Drawing.Size(61, 23)
        Me.StartSource.TabIndex = 8
        Me.StartSource.Text = "Start"
        Me.StartSource.UseVisualStyleBackColor = True
        '
        'SourceList
        '
        Me.SourceList.FormattingEnabled = True
        Me.SourceList.Location = New System.Drawing.Point(9, 41)
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
        'VUMeterDecayTimer
        '
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
        Me.Label7.Text = "Copyright 2016, Ekomsys, LLC , All rights reserved"
        '
        'LogWindow
        '
        Me.LogWindow.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LogWindow.FormattingEnabled = True
        Me.LogWindow.Location = New System.Drawing.Point(1025, 669)
        Me.LogWindow.Name = "LogWindow"
        Me.LogWindow.Size = New System.Drawing.Size(877, 290)
        Me.LogWindow.TabIndex = 30
        '
        'PlaylistTimer
        '
        Me.PlaylistTimer.Interval = 1000
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1914, 1009)
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
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.previewThreeSelector)
        Me.Controls.Add(Me.smallPreviewThree)
        Me.Controls.Add(Me.biggerPreviewSelector)
        Me.Controls.Add(Me.previewTwoSelector)
        Me.Controls.Add(Me.previewOneSelector)
        Me.Controls.Add(Me.smallPreviewTwo)
        Me.Controls.Add(Me.smallPreviewOne)
        Me.Controls.Add(Me.biggerPreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "Ekomsys Multimedia SDK Demo"
        Me.biggerPreview.ResumeLayout(False)
        CType(Me.LiveDeviceThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiveDeviceTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LiveDeviceOne, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.GroupBox5.ResumeLayout(False)
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
    Friend WithEvents previewOneSelector As ComboBox
    Friend WithEvents previewTwoSelector As ComboBox
    Friend WithEvents biggerPreviewSelector As ComboBox
    Friend WithEvents smallPreviewThree As Panel
    Friend WithEvents previewThreeSelector As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents getFormats As Button
    Friend WithEvents BootSystem As Button
    Friend WithEvents OutputFormatList As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents stopRenderingDevice As Button
    Friend WithEvents startRenderingDevice As Button
    Friend WithEvents renderingDevices As ComboBox
    Friend WithEvents deviceConnection As ComboBox
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
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LiveDevicesList As ComboBox
    Friend WithEvents StopLive As Button
    Friend WithEvents StartLive As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents StopSource As Button
    Friend WithEvents StartSource As Button
    Friend WithEvents SourceList As ComboBox
    Friend WithEvents RefreshSources As Button
    Friend WithEvents LiveDeviceOne As PictureBox
    Friend WithEvents LiveDeviceTwo As PictureBox
    Friend WithEvents LiveDeviceThree As PictureBox
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
End Class
