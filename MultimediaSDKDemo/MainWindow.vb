Public Class MainWindow
    Private WithEvents player As MultiMediaSDK.Player
    Private WithEvents cg As MultiMediaSDK.CharacterGenerator
    Private WithEvents renderer As MultiMediaSDK.renderer
    Private WithEvents renderingDevice As MultiMediaSDK.RenderingDevice
    Private WithEvents mixer As MultiMediaSDK.Mixer
    Private WithEvents live As MultiMediaSDK.LiveManager
    Private WithEvents liveDevice As MultiMediaSDK.LiveDevice
    Dim liveSources As ArrayList
    Dim renderingDevicesList As ArrayList
    Private WithEvents livePreviewObj As MultiMediaSDK.Preview
    Private WithEvents cgPreviewObj As MultiMediaSDK.Preview
    Private WithEvents playerPreviewObj As MultiMediaSDK.Preview
    Private WithEvents mixerPreviewObj As MultiMediaSDK.Preview
    Private playlistInfo As MultiMediaSDK.PlaylistInfo
    Private mediaInfo As MultiMediaSDK.MediaInfo
    Dim currTrackDuration As Integer

    Dim retErr As Long
    Dim playerQueue As ArrayList
    Dim playerPaused As Boolean
    Dim cgID As Dictionary(Of String, String)

    Dim logs As ArrayList

    Private Sub MainWindow_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        player.ShutDown()
        cg.ShutDown()
    End Sub
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logs = New ArrayList
        LogTimer.Start()

        currTrackDuration = 0
        playlistInfo = New MultiMediaSDK.PlaylistInfo
        mediaInfo = New MultiMediaSDK.MediaInfo

        renderer = New MultiMediaSDK.renderer
        player = New MultiMediaSDK.Player
        cg = New MultiMediaSDK.CharacterGenerator
        live = New MultiMediaSDK.LiveManager

        playerQueue = New ArrayList()
        cgID = New Dictionary(Of String, String)

        'Dim username As String
        'Dim pass As String
        'Dim FILE_NAME As String = "license.lic"
        'If System.IO.File.Exists(FILE_NAME) = True Then
        '    Dim objReader As New System.IO.StreamReader(FILE_NAME)
        '    username = objReader.ReadLine()
        '    pass = objReader.ReadLine()
        '    renderer.setLicenseKey(username, pass)
        '    cg.setLicenseKey(username, pass)
        '    player.setLicenseKey(username, pass)
        '    live.setLicenseKey(username, pass)
        'Else
        '    LicenseForm.ShowDialog(Me)
        '    renderer.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
        '    cg.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
        '    player.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
        '    live.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
        'End If

        'retErr = renderer.setConfigFile("config/EsConfig.ini")
        'retErr = player.setConfigFile("config/EsConfig.ini")
        'retErr = cg.setConfigFile("config/EsConfig.ini")
        'retErr = live.setConfigFile("config/EsConfig.ini")

        'If retErr Then
        '    MsgBox("Invalid configuration file.")
        'End If

        GetCGAnimationFiles()
        UpdateHelp("The first step is to fetch the supported formats by the renderer, so please click 'Get Formats'")

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub InitializePlayer()
        Dim pconfig = New MultiMediaSDK.PlayerConfig
        pconfig.format = OutputFormatList.Text
        pconfig.is_ndi = False
        pconfig.is_remote = False
        pconfig.is_server = False

        retErr = player.Initialize(pconfig)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for player module failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            PlayerServerIndicator.BackColor = Color.LightGreen
        End If

        playerPreviewObj = New MultiMediaSDK.Preview
        Dim playerPreviewConfig = New MultiMediaSDK.PreviewConfig
        playerPreviewConfig.format = OutputFormatList.Text
        playerPreviewConfig.handle = smallPreviewOne.Handle
        playerPreviewConfig.height = smallPreviewOne.Height
        playerPreviewConfig.width = smallPreviewOne.Width
        playerPreviewConfig.calc_audio_signal_power = True

        playerPreviewObj.Initialize(playerPreviewConfig)
        playerPreviewObj.AddSource(player)

        Application.DoEvents()
    End Sub

    Private Sub InitializeCG()
        Dim cgConfig = New MultiMediaSDK.CGConfig
        cgConfig.format = OutputFormatList.Text
        cgConfig.is_ndi = False
        cgConfig.is_remote = False
        cgConfig.is_server = False

        retErr = cg.Initialize(cgConfig)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for CG module failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            CGServerIndicator.BackColor = Color.LightGreen
        End If

        cgPreviewObj = New MultiMediaSDK.Preview
        Dim previewConfig = New MultiMediaSDK.PreviewConfig
        previewConfig.format = OutputFormatList.Text
        previewConfig.handle = smallPreviewTwo.Handle
        previewConfig.height = smallPreviewTwo.Height
        previewConfig.width = smallPreviewTwo.Width
        previewConfig.calc_audio_signal_power = True

        cgPreviewObj.Initialize(previewConfig)
        cgPreviewObj.AddSource(cg)

        Application.DoEvents()
    End Sub

    Private Sub InitializeLive()
        Dim liveConfig = New MultiMediaSDK.LiveManagerConfig
        liveConfig.format = OutputFormatList.Text
        liveConfig.is_remote = False
        liveConfig.is_server = False

        retErr = live.Initialize(liveConfig)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for live module failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            LiveServerIndicator.BackColor = Color.LightGreen
        End If

        Dim liveDevices As Array
        retErr = live.GetDevices(liveDevices)
        If retErr Then
            Dim msg As String
            msg = "Unable to get live sources" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        liveSources = New ArrayList()
        For i = 0 To UBound(liveDevices)
            Dim liveDevice = CType(liveDevices(i), MultiMediaSDK.ILiveDevice)
            Dim name As String
            liveDevice.GetName(name)
            SourceList.Items.Add(name)
            liveSources.Add(liveDevice)
        Next

        If (liveSources.Count > 0) Then
            populateLiveDeviceInfo(liveSources(0))
        End If

        Application.DoEvents()
    End Sub

    Private Sub InitializeRenderer()
        Dim rendererConfig = New MultiMediaSDK.RendererConfig
        rendererConfig.format = OutputFormatList.Text
        rendererConfig.is_remote = False
        rendererConfig.is_server = False

        retErr = renderer.Initialize(rendererConfig)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for rendering module failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            RenderingServerIndicator.BackColor = Color.LightGreen
        End If

        Dim rDevices As Array
        retErr = renderer.GetDevices(rDevices)
        If retErr Then
            Dim msg As String
            msg = "Unable to get live sources" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        renderingDevicesList = New ArrayList()
        For i = 0 To UBound(rDevices)
            Dim device = CType(rDevices(i), MultiMediaSDK.RenderingDevice)
            Dim name As String
            device.GetName(name)
            renderingDevices.Items.Add(name)
            renderingDevicesList.Add(device)
        Next

        If (renderingDevicesList.Count > 0) Then
            populateDeviceInfo(renderingDevicesList(0))
        End If

        Application.DoEvents()
    End Sub

    Private Sub InitializeMixer()
        mixer = New MultiMediaSDK.Mixer

        Dim config = New MultiMediaSDK.MixerConfig
        config.is_ndi = False
        config.is_server = False
        config.is_remote = False
        config.format = OutputFormatList.Text

        retErr = mixer.Initialize(config)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for nixer module failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            RenderingServerIndicator.BackColor = Color.LightGreen
        End If

        mixerPreviewObj = New MultiMediaSDK.Preview
        Dim previewConfig = New MultiMediaSDK.PreviewConfig
        previewConfig.format = OutputFormatList.Text
        previewConfig.handle = biggerPreview.Handle
        previewConfig.height = biggerPreview.Height
        previewConfig.width = biggerPreview.Width
        previewConfig.calc_audio_signal_power = True

        mixerPreviewObj.Initialize(previewConfig)
        mixerPreviewObj.AddSource(mixer)

        mixer.AddSource(player, 0)
        mixer.SetEnable(player, True)
        mixer.AddSource(cg, 2)
        mixer.SetEnable(cg, True)

        mixer.AddRenderer(renderer)
    End Sub

    Private Sub BootSystem_Click(sender As Object, e As EventArgs) Handles BootSystem.Click
        If String.IsNullOrEmpty(OutputFormatList.Text) Then
            Dim msg As String
            msg = "Please select display formats before booting system."
            MsgBox(msg)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Log("Booting system...")
        InitializePlayer()
        Log("Player                     [OK]")
        InitializeCG()
        Log("CG                          [OK]")
        InitializeLive()
        Log("Live                        [OK]")
        InitializeRenderer()
        Log("Renderer               [OK]")
        InitializeMixer()
        Log("Mixer                     [OK]")
        Log("System Ready.")
        VUMeterTimer.Start()
        VUMeterDecayTimer.Start()
        PlaylistTimer.Start()

        UpdateHelp("Now you have devices except live available for preview and you can add files " &
            "in player Or play animations in CG. For live initialize the device from live section." & vbCrLf & vbCrLf &
            "In case all the devices are not visible in drop down please refresh sources from source section")

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub UpdateHelp(str As String)
        HelpWindow.Text = str
    End Sub
    Private Sub GetCGAnimationFiles()
        Dim di As New IO.DirectoryInfo("./cg-samples")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        Dim count As Long

        For Each dra In diar1
            If dra.Extension Like ".xml" Then
                CGAvailableAnimations.Items.Add(dra.Name)
                count = count + 1
                Dim xmlID = "xmlid_" & count
                cgID.Add(dra.Name, xmlID)
            End If
        Next
        CGAvailableAnimations.Update()
    End Sub

    Private Sub populateDeviceInfo(dvc As MultiMediaSDK.RenderingDevice)
        Dim audioHW
        Dim videoHW

        retErr = dvc.GetSupportedAudioHw(audioHW)
        If retErr Then
            Dim msg As String
            msg = "Unable to get device info" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        retErr = dvc.GetSupportedVideoHw(videoHW)
        If retErr Then
            Dim msg As String
            msg = "Unable to get device info" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        renderingDeviceAudioHwList.Items.Clear()
        For i = LBound(audioHW) To UBound(audioHW)
            renderingDeviceAudioHwList.Items.Add(audioHW(i))
        Next

        If (renderingDeviceAudioHwList.Items.Count > 0) Then
            renderingDeviceAudioHwList.SelectedIndex = 0
            renderingDeviceAudioHwList.Update()
        End If

        renderingDeviceVideoHwList.Items.Clear()
        For i = LBound(videoHW) To UBound(videoHW)
            renderingDeviceVideoHwList.Items.Add(videoHW(i))
        Next

        If (renderingDeviceVideoHwList.Items.Count > 0) Then
            renderingDeviceVideoHwList.SelectedIndex = 0
            renderingDeviceVideoHwList.Update()
        End If


    End Sub
    Private Sub populateLiveDeviceInfo(dvc As MultiMediaSDK.LiveDevice)
        Dim audioHW
        Dim videoHW
        Dim modes

        retErr = dvc.GetSupportedAudioHw(audioHW)
        If retErr Then
            Dim msg As String
            msg = "Unable to get device info" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        retErr = dvc.GetSupportedVideoHw(audioHW)
        If retErr Then
            Dim msg As String
            msg = "Unable to get device info" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        retErr = dvc.GetSupportedModes(modes)
        If retErr Then
            Dim msg As String
            msg = "Unable to get device info" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        liveDeviceModeList.Items.Clear()
        For i = LBound(modes) To UBound(modes)
            liveDeviceModeList.Items.Add(modes(i))
        Next

        liveDeviceModeList.SelectedIndex = 0
        liveDeviceModeList.Update()
    End Sub

    Private Sub startRenderingDevice_Click(sender As Object, e As EventArgs) Handles startRenderingDevice.Click
        Dim index = renderingDevices.SelectedIndex
        Dim device = CType(renderingDevicesList.Item(index), MultiMediaSDK.RenderingDevice)
        renderingDevice = device
        Dim settings = New MultiMediaSDK.RenderingDeviceSettings
        settings.audio_hw = renderingDeviceAudioHwList.Text
        settings.video_hw = renderingDeviceVideoHwList.Text
        settings.mode = OutputFormatList.Text

        retErr = device.Initialize(settings)

        If retErr Then
            Dim msg As String
            msg = "Unable to initialize output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        retErr = device.StartDevice()
        If retErr Then
            Dim msg As String
            msg = "Unable to start output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub stopRenderingDevice_Click(sender As Object, e As EventArgs) Handles stopRenderingDevice.Click
        Dim index = renderingDevices.SelectedIndex
        Dim device = CType(renderingDevicesList.Item(index), MultiMediaSDK.RenderingDevice)

        retErr = device.StopDevice()
        If retErr Then
            Dim msg As String
            msg = "Unable to stop output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub AddFile(file As String)
        AddMediaForm.ShowDialog(Me)

        Dim markin As Long
        Dim markout As Long
        Dim cropt As Long
        Dim cropb As Long
        Dim cropl As Long
        Dim cropr As Long
        Dim vstream As Long
        Dim astream As Long

        markin = CType(AddMediaForm.MarkInTxtBox.Text, Long)
        markout = CType(AddMediaForm.MarkOutTxtBox.Text, Long)
        cropt = CType(AddMediaForm.CropTop.Text, Long)
        cropb = CType(AddMediaForm.CropBottom.Text, Long)
        cropl = CType(AddMediaForm.CropLeft.Text, Long)
        cropr = CType(AddMediaForm.CropRight.Text, Long)
        astream = CType(AddMediaForm.AudioStream.Text, Long)
        vstream = CType(AddMediaForm.VideoStream.Text, Long)

        Dim id As String

        Dim params = New MultiMediaSDK.MediaParams
        params.fileName = file
        Dim c As MultiMediaSDK.Crop
        c.left = cropl
        c.right = cropr
        c.top = cropt
        c.bottom = cropb

        params.Crop = c
        params.deinterlace = True
        params.markInMs = markin
        params.markOutMs = markout
        params.audioStreamIndex = astream
        params.videoStreamIndex = vstream

        retErr = player.AddMedia(params)
        If retErr Then
            Dim dsc As String
            dsc = "Queue failed: Details: " & player.getErrorDescription(retErr)
            MsgBox(dsc)
        Else
            PlayerMediaList.Items.Add(file)
            PlayerMediaList.Items(PlayerMediaList.Items.Count - 1).Selected = True
            playerQueue.Add(id)

            If currTrackDuration <= 0 Then
                ' Query the current track
                player.GetPlaylistInfo(playlistInfo)
                player.GetMediainfo(playlistInfo.currentTrackIndex, mediaInfo)
                currTrackDuration = mediaInfo.duration
            End If
        End If
        UpdateHelp("Now you can select this file and play it.")
    End Sub
    Private Sub PlayerQueueBtn_Click(sender As Object, e As EventArgs) Handles PlayerQueueBtn.Click
        Dim newPath As String
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            newPath = dialog.FileName
            AddFile(newPath)
        End Using
    End Sub

    Private Sub PlayerPlayBtn_Click(sender As Object, e As EventArgs) Handles PlayerPlayBtn.Click
        If playerPaused Then
            player.Resume()
            Return
        End If

        If PlayerMediaList.SelectedItems.Count <= 0 Then
            Dim msg As String
            msg = "Please select a file to play."
            MsgBox(msg)
            Return
        End If

        Dim id = playerQueue.Item(PlayerMediaList.SelectedIndices(0))
        retErr = player.Play(id)
        If retErr Then
            Dim msg As String
            msg = "Unable to play file" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        player.GetPlaylistInfo(playlistInfo)
        player.GetMediainfo(playlistInfo.currentTrackIndex, mediaInfo)
        currTrackDuration = mediaInfo.duration
    End Sub

    Private Sub PlayerPauseBtn_Click(sender As Object, e As EventArgs) Handles PlayerPauseBtn.Click
        player.Pause()
        playerPaused = True
    End Sub

    Private Sub PlayerPreviousBtn_Click(sender As Object, e As EventArgs) Handles PlayerPreviousBtn.Click
        retErr = player.Previous()
        If retErr Then
            Dim dsc As String
            dsc = "Next failed: Details: " & player.getErrorDescription(retErr)
            MsgBox(dsc)
        End If
    End Sub

    Private Sub PlayerNextBtn_Click(sender As Object, e As EventArgs) Handles PlayerNextBtn.Click
        retErr = player.Next()
        If retErr Then
            Dim dsc As String
            dsc = "Next failed: Details: " & player.getErrorDescription(retErr)
            MsgBox(dsc)
        End If
    End Sub
    Private Sub Log(str As String)
        str = "[*]" & str
        logs.Add(str)
    End Sub

    Private Sub player_OnEvent(ByRef eventName As String, ByRef eventParams As String) Handles player.OnEvent
        Dim str = "[PLAYER EVENT] Name " & eventName & " -> " & eventParams
        Log(str)
    End Sub
    Private Sub cg_OnEvent(ByRef eventName As String, ByRef eventParams As String) Handles cg.OnEvent
        Dim str = "[CG EVENT] Name " & eventName & " -> " & eventParams
        Log(str)
    End Sub
    Private Sub mixer_OnEvent(ByRef eventName As String, ByRef eventParams As String) Handles mixer.OnEvent
        Dim str = "[MIXER EVENT] Name " & eventName & " -> " & eventParams
        Log(str)
    End Sub
    Private Sub liveDevice_OnEvent(ByRef eventName As String, ByRef eventParams As String) Handles liveDevice.OnEvent
        Dim str = "[LIVEDEVICE EVENT] Name " & eventName & " -> " & eventParams
        Log(str)
    End Sub
    Private Sub renderingDevice_OnEvent(ByRef eventName As String, ByRef eventParams As String) Handles renderingDevice.OnEvent
        Dim str = "[RENDERINGDEVICE EVENT] Name " & eventName & " -> " & eventParams
        Log(str)
    End Sub
    Private Sub CGPlayAnimation_Click(sender As Object, e As EventArgs) Handles CGPlayAnimation.Click
        If CGAvailableAnimations.SelectedItems.Count <= 0 Then
            Dim msg As String
            msg = "Please select animation file before playing it."
            MsgBox(msg)
            Return
        End If
        Dim file = CGAvailableAnimations.SelectedItems.Item(0).Text
        Dim filepath = "./cg-samples/" & file
        Dim id = cgID.Item(CGAvailableAnimations.SelectedItems.Item(0).Text)
        retErr = cg.Load(filepath, id, False, True, "")
        If retErr Then
            Dim msg As String
            msg = "Unable to load animation file" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        CGAvailableAnimations.Items.RemoveAt(CGAvailableAnimations.SelectedItems.Item(0).Index)
        CGPlayingAnimations.Items.Add(file)
    End Sub
    Private Sub CGUnloadAnimation_Click(sender As Object, e As EventArgs) Handles CGUnloadAnimation.Click
        If CGPlayingAnimations.SelectedItems.Count <= 0 Then
            Dim msg As String
            msg = "Please select animation file before stopping it."
            MsgBox(msg)
            Return
        End If
        Dim file = CGPlayingAnimations.SelectedItems.Item(0).Text
        Dim filepath = "./cg-samples/" & file
        Dim id = cgID.Item(CGPlayingAnimations.SelectedItems.Item(0).Text)
        retErr = cg.UnLoad(id)
        If retErr Then
            Dim msg As String
            msg = "Unable to unload animation file" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        CGPlayingAnimations.Items.RemoveAt(CGPlayingAnimations.SelectedItems.Item(0).Index)
        CGAvailableAnimations.Items.Add(file)
    End Sub

    Private Sub StartSource_Click(sender As Object, e As EventArgs) Handles StartSource.Click
        Dim index = SourceList.SelectedIndex
        Dim device = CType(liveSources.Item(index), MultiMediaSDK.LiveDevice)
        liveDevice = device

        Dim settings = New MultiMediaSDK.LiveDeviceSettings
        settings.audio_hw = liveDeviceAudioHwList.Text
        settings.video_hw = liveDeviceVideoHwList.Text
        settings.is_ndi = False
        settings.mode = OutputFormatList.Text

        retErr = device.Initialize(settings)
        If retErr Then
            Dim msg As String
            msg = "Unable to initialize live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        retErr = device.StartDevice()
        If retErr Then
            Dim msg As String
            msg = "Unable to start live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        livePreviewObj = New MultiMediaSDK.Preview
        Dim previewConfig = New MultiMediaSDK.PreviewConfig
        previewConfig.format = OutputFormatList.Text
        previewConfig.handle = smallPreviewThree.Handle
        previewConfig.height = smallPreviewThree.Height
        previewConfig.width = smallPreviewThree.Width
        previewConfig.calc_audio_signal_power = True

        livePreviewObj.Initialize(previewConfig)
        livePreviewObj.AddSource(device)

        ' Add to mixer 
        Dim rect = New MultiMediaSDK.Rect
        rect.x = 100
        rect.y = 100
        rect.width = 240
        rect.height = 160

        mixer.AddSource(device, 1)
        mixer.SetViewArea(device, rect)
        mixer.SetEnable(device, True)
    End Sub
    Private Sub StopLive_Click(sender As Object, e As EventArgs) Handles StopSource.Click
        Dim index = SourceList.SelectedIndex
        Dim device = CType(liveSources.Item(index), MultiMediaSDK.LiveDevice)

        retErr = device.StopDevice()
        If retErr Then
            Dim msg As String
            msg = "Unable to stop live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub
    Private Sub VUMeterTimer_Tick(sender As Object, e As EventArgs) Handles VUMeterTimer.Tick
        Dim l As Double
        Dim r As Double
        l = 0
        r = 0

        playerPreviewObj.GetAudioSignalPower(l, r)
        smallPreviewOneLeftChannel.Value = l
        smallPreviewOneRightChannel.Value = r

        cgPreviewObj.GetAudioSignalPower(l, r)
        smallPreviewTwoLeftChannel.Value = l
        smallPreviewTwoRightChannel.Value = r

        If Not livePreviewObj Is Nothing Then
            livePreviewObj.GetAudioSignalPower(l, r)
            smallPreviewThreeLeftChannel.Value = l
            smallPreviewThreeRightChannel.Value = r
        End If

        mixerPreviewObj.GetAudioSignalPower(l, r)
        biggerPreviewLeftChannel.Value = l
        biggerPreviewRightChannel.Value = r
    End Sub
    Private Sub renderingDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles renderingDevices.SelectedIndexChanged
        Dim index = renderingDevices.SelectedIndex
        Dim device = CType(renderingDevicesList.Item(index), MultiMediaSDK.RenderingDevice)
        populateDeviceInfo(device)
    End Sub
    Private Sub LiveDevicesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SourceList.SelectedIndexChanged
        Dim index = SourceList.SelectedIndex
        Dim device = CType(liveSources.Item(index), MultiMediaSDK.LiveDevice)
        populateLiveDeviceInfo(device)
    End Sub
    Private Sub previewOneVolume_Scroll(sender As Object, e As EventArgs) Handles previewOneVolume.Scroll
        playerPreviewObj.SetVolumePercentage(previewOneVolume.Value)
    End Sub
    Private Sub previewtwovolume_scroll(sender As Object, e As EventArgs) Handles previewTwoVolume.Scroll
        cgPreviewObj.SetVolumePercentage(previewTwoVolume.Value)
    End Sub
    Private Sub previewthreevolume_scroll(sender As Object, e As EventArgs) Handles previewThreeVolume.Scroll
        livePreviewObj.SetVolumePercentage(previewThreeVolume.Value)
    End Sub
    Private Sub biggerpreviewvolume_scroll(sender As Object, e As EventArgs) Handles biggerPreviewVolume.Scroll
        mixerPreviewObj.SetVolumePercentage(biggerPreviewVolume.Value)
    End Sub
    Private Sub PlaylistTimer_Tick(sender As Object, e As EventArgs) Handles PlaylistTimer.Tick
        If (currTrackDuration <= 0) Then
            Return
        End If
        currTrackDuration = currTrackDuration - 1000
        Dim ts As TimeSpan = TimeSpan.FromMilliseconds(currTrackDuration)
        PlaylistTimeLabel.Text = ts.ToString("hh\:mm\:ss")
    End Sub

    Private Sub LogTimer_Tick(sender As Object, e As EventArgs) Handles LogTimer.Tick
        For Each s In logs
            LogWindow.Items.Insert(0, s)
            If LogWindow.Items.Count > 500 Then
                LogWindow.Items.RemoveAt(LogWindow.Items.Count - 1)
            End If
        Next
        logs.Clear()
    End Sub

    Private Sub smallPreviewTwo_Paint(sender As Object, e As PaintEventArgs) Handles smallPreviewTwo.Paint

    End Sub

    Private Sub renderingDeviceAudioHwList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles renderingDeviceAudioHwList.SelectedIndexChanged

    End Sub

    Private Sub renderingDeviceVideoHwList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles renderingDeviceVideoHwList.SelectedIndexChanged

    End Sub

    Private Sub PlayerMediaList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerMediaList.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
