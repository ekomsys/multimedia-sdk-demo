Public Class MainWindow
    Private WithEvents player As EsMediaPlayerCOMLib.EsPlayerCOM
    Private WithEvents cg As CGServerComObjectLib.CGServerCom
    Private WithEvents renderer As EsRenderingServerCOMLib.ServerHandler
    Private WithEvents live As EsLiveServerCOMLib.LiveServer

    Dim retErr As Long
    Dim previewIDS As ArrayList
    Dim previewNames As Array
    Dim sourceIDS As Array
    Dim sourceNames As Array
    Dim playerQueue As ArrayList
    Dim playerPaused As Boolean
    Dim cgID As ArrayList
    Dim outWidth
    Dim outHeight
    Dim layer = 1
    Dim livePictureBoxes(5) As PictureBox
    Dim availablePictureBoxIndex = 0

    Private Sub getFormats_Click(sender As Object, e As EventArgs) Handles getFormats.Click
        retErr = renderer.initialize()
        If (retErr) Then
            Dim msg As String
            msg = "Initialization failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        getOutputDevices()
        UpdateHelp("Awesome !!" & vbCrLf & "Now select desired format from the list and boot the system")
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        livePictureBoxes(0) = LiveDeviceOne
        livePictureBoxes(1) = LiveDeviceTwo
        livePictureBoxes(2) = LiveDeviceThree

        renderer = New EsRenderingServerCOMLib.ServerHandler
        player = New EsMediaPlayerCOMLib.EsPlayerCOM
        cg = New CGServerComObjectLib.CGServerCom
        live = New EsLiveServerCOMLib.LiveServer

        playerQueue = New ArrayList()
        cgID = New ArrayList()
        previewIDS = New ArrayList()

        Dim username As String
        Dim pass As String
        Dim FILE_NAME As String = "license.lic"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            username = objReader.ReadLine()
            pass = objReader.ReadLine()
            renderer.setLicenseKey(username, pass)
            cg.setLicenseKey(username, pass)
            player.setLicenseKey(username, pass)
            live.setLicenseKey(username, pass)
        Else
            LicenseForm.ShowDialog(Me)
            renderer.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
            cg.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
            player.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
            live.setLicenseKey(LicenseForm.UsernameTextBox.Text, LicenseForm.PasswordTextBox.Text)
        End If

        retErr = renderer.setConfigFile("config/EsConfig.ini")
        retErr = player.setConfigFile("config/EsConfig.ini")
        retErr = cg.setConfigFile("config/EsConfig.ini")
        retErr = live.setConfigFile("config/EsConfig.ini")

        If retErr Then
            MsgBox("Invalid configuration file.")
        End If

        GetCGAnimationFiles()
        UpdateHelp("The first step is to fetch the supported formats by the renderer, so please click 'Get Formats'")

        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub populateDeviceInfo(dvc As String)
        Dim portLst
        Dim desc

        retErr = renderer.getDeviceInfo(dvc, portLst, desc)
        If retErr Then
            Dim msg As String
            msg = "Unable to get device info" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        deviceConnection.Items.Clear()
        For i = LBound(portLst) To UBound(portLst)
            deviceConnection.Items.Add(portLst(i))
        Next

        deviceConnection.SelectedIndex = 0
        deviceConnection.Update()

        If dvc.Contains("Desktop") Then
            deviceConnection.Items.Clear()
            deviceConnection.Update()
            deviceConnection.Enabled = False
        Else
            deviceConnection.Enabled = True
        End If
    End Sub
    Private Sub getOutputDevices()
        Dim lstDevices
        retErr = renderer.getDeviceList(lstDevices)
        If retErr Then
            Dim msg As String
            msg = "Unable to get output devices from server" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        For i = LBound(lstDevices) To UBound(lstDevices)
            renderingDevices.Items.Add(lstDevices(i))
        Next

        If (UBound(lstDevices) - LBound(lstDevices) > 0) Then
            populateDeviceInfo(lstDevices(0))
        End If

        Dim fmtList
        retErr = renderer.getDisplayModes(fmtList)
        If retErr Then
            Dim msg As String
            msg = "Unable to get display modes from server" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        For i = LBound(fmtList) To UBound(fmtList)
            OutputFormatList.Items.Add(fmtList(i))
        Next

        renderingDevices.SelectedIndex = 0
        renderingDevices.Update()

        OutputFormatList.SelectedIndex = 0
        OutputFormatList.Update()
    End Sub

    Private Sub BootSystem_Click(sender As Object, e As EventArgs) Handles BootSystem.Click
        If String.IsNullOrEmpty(OutputFormatList.Text) Then
            Dim msg As String
            msg = "Please fetch display formats from server before booting system."
            MsgBox(msg)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        '=================================================================================
        retErr = player.initialize(OutputFormatList.Text)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for player server failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            PlayerServerIndicator.BackColor = Color.LightGreen
            player.setRepeatAll(True)
        End If
        Application.DoEvents()
        'Threading.Thread.Sleep(1000)
        '=================================================================================
        retErr = cg.initialize(OutputFormatList.Text)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for CG server failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            CGServerIndicator.BackColor = Color.LightGreen
        End If
        Application.DoEvents()
        'Threading.Thread.Sleep(1000)

        '=================================================================================
        retErr = live.initialize(OutputFormatList.Text)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for live server failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            LiveServerIndicator.BackColor = Color.LightGreen
        End If
        Application.DoEvents()
        'Threading.Thread.Sleep(1000)
        '=================================================================================
        retErr = renderer.initRenderingServer(OutputFormatList.Text)
        If (retErr) Then
            Dim msg As String
            msg = "Initialization for rendering server failed" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
        Else
            RenderingServerIndicator.BackColor = Color.LightGreen
        End If

        Application.DoEvents()
        'Threading.Thread.Sleep(4000)
        '=================================================================================
        Dim liveDevices
        retErr = live.getDeviceList(liveDevices)
        If retErr Then
            Dim msg As String
            msg = "Unable to get live sources" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        For i = LBound(liveDevices) To UBound(liveDevices)
            LiveDevicesList.Items.Add(liveDevices(i))
        Next
        '=================================================================================
        ' Get preview devices and render the data in windows
        Dim ids
        Dim previewDevices = renderer.getPreviewSources(ids, previewNames)

        For i = LBound(previewNames) To UBound(previewNames)
            previewOneSelector.Items.Add(previewNames(i))
            previewTwoSelector.Items.Add(previewNames(i))
            previewThreeSelector.Items.Add(previewNames(i))
            biggerPreviewSelector.Items.Add(previewNames(i))
            previewIDS.Add(ids(i))
        Next
        If OutputFormatList.Text.Contains("PAL") Then
            outWidth = 720
            outHeight = 576
        ElseIf OutputFormatList.Text.Contains("720") Then
            outWidth = 1280
            outHeight = 720
        ElseIf OutputFormatList.Text.Contains("NTSC") Then
            outWidth = 720
            outHeight = 486
        ElseIf OutputFormatList.Text.Contains("1080") Then
            outWidth = 1920
            outHeight = 1080
        End If

        VUMeterTimer.Start()
        VUMeterDecayTimer.Start()
        PlaylistTimer.Start()

        UpdateHelp("Now you have devices except live available for preview and you can add files " &
                "in player Or play animations in CG. For live initialize the device from live section." & vbCrLf & vbCrLf &
                "In case all the devices are not visible in drop down please refresh sources from source section")


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub startRenderingDevice_Click(sender As Object, e As EventArgs) Handles startRenderingDevice.Click
        Dim vConn As String
        If renderingDevices.Text.Contains("Desktop") Then
            'Desktop renderer
            vConn = "0;0"
            retErr = renderer.initDevice(renderingDevices.Text, vConn)
        ElseIf renderingDevices.Text.Contains("Writer") Then
            DiskWriterDialog.OutFileLabel.Text = "File:"
            DiskWriterDialog.BrowseButton.Enabled = True
            'Disk Writer renderer
            DiskWriterDialog.ShowDialog()

            ' Format for additional options is :
            ' filename;width;height;video_bit_rate;audio_sample_rate;audio_bit_rate;profile;preset;crf;level
            vConn = DiskWriterDialog.OutFile.Text & ";"
            vConn = vConn & DiskWriterDialog.VideoWidth.Text & ";" & DiskWriterDialog.VideoHeight.Text & ";"
            vConn = vConn & DiskWriterDialog.VideoBitRate.Text & ";"
            vConn = vConn & DiskWriterDialog.AudioSampleRate.Text & ";" & DiskWriterDialog.AudioBitrate.Text & ";"
            vConn = vConn & "realtime;reserved_for_preset;"
            vConn = vConn & "10;reserved_for_level;"
            retErr = renderer.initDevice(renderingDevices.Text, vConn)
        ElseIf renderingDevices.Text.Contains("Publisher") Then
            DiskWriterDialog.OutFileLabel.Text = "URL:"
            DiskWriterDialog.BrowseButton.Enabled = False

            DiskWriterDialog.ShowDialog()

            ' Format for additional options is :
            ' filename;width;height;video_bit_rate;audio_sample_rate;audio_bit_rate;profile;preset;crf;level
            vConn = DiskWriterDialog.OutFile.Text & ";"
            vConn = vConn & DiskWriterDialog.VideoWidth.Text & ";" & DiskWriterDialog.VideoHeight.Text & ";"
            vConn = vConn & DiskWriterDialog.VideoBitRate.Text & ";"
            vConn = vConn & DiskWriterDialog.AudioSampleRate.Text & ";" & DiskWriterDialog.AudioBitrate.Text & ";"
            vConn = vConn & "realtime;reserved_for_preset;"
            vConn = vConn & "10;reserved_for_level;"
            retErr = renderer.initDevice(renderingDevices.Text, vConn)
        Else
            retErr = renderer.initDevice(renderingDevices.Text, deviceConnection.Text)
        End If

        If retErr Then
            Dim msg As String
            msg = "Unable to initialize output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        retErr = renderer.startDevice(renderingDevices.Text)
        If retErr Then
            Dim msg As String
            msg = "Unable to start output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If

        If renderingDevices.Text.Contains("Desktop") Then
            renderer.showDesktopWindowRenderer(100, 100)
        End If

    End Sub

    Private Sub stopRenderingDevice_Click(sender As Object, e As EventArgs) Handles stopRenderingDevice.Click
        retErr = renderer.stopDevice(renderingDevices.Text)
        If retErr Then
            Dim msg As String
            msg = "Unable to stop output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        retErr = renderer.deInitDevice(renderingDevices.Text)
        If retErr Then
            Dim msg As String
            msg = "Unable to deinitialize output device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub biggerPreviewSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles biggerPreviewSelector.SelectedIndexChanged
        Dim id = previewIDS.Item(biggerPreviewSelector.SelectedIndex)
        retErr = renderer.startPreview(id, biggerPreview.Handle, biggerPreview.Width, biggerPreview.Height)
        If retErr Then
            Dim msg As String
            msg = "Unable to start preview" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub previewTwoSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles previewTwoSelector.SelectedIndexChanged
        Dim id = previewIDS.Item(previewTwoSelector.SelectedIndex)
        retErr = renderer.startPreview(id, smallPreviewTwo.Handle, smallPreviewTwo.Width, smallPreviewTwo.Height)
        If retErr Then
            Dim msg As String
            msg = "Unable to start preview" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub previewOneSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles previewOneSelector.SelectedIndexChanged
        Dim id = previewIDS.Item(previewOneSelector.SelectedIndex)
        retErr = renderer.startPreview(id, smallPreviewOne.Handle, smallPreviewOne.Width, smallPreviewOne.Height)
        If retErr Then
            Dim msg As String
            msg = "Unable to start preview" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub previewThreeSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles previewThreeSelector.SelectedIndexChanged
        Dim id = previewIDS.Item(previewThreeSelector.SelectedIndex)
        retErr = renderer.startPreview(id, smallPreviewThree.Handle, smallPreviewThree.Width, smallPreviewThree.Height)
        If retErr Then
            Dim msg As String
            msg = "Unable to start preview" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
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
        Dim arNum As Long
        Dim arDen As Long
        Dim vstream As Long
        Dim astream As Long

        markin = CType(AddMediaForm.MarkInTxtBox.Text, Long)
        markout = CType(AddMediaForm.MarkOutTxtBox.Text, Long)
        cropt = CType(AddMediaForm.CropTop.Text, Long)
        cropb = CType(AddMediaForm.CropBottom.Text, Long)
        cropl = CType(AddMediaForm.CropLeft.Text, Long)
        cropr = CType(AddMediaForm.CropRight.Text, Long)
        arNum = CType(AddMediaForm.ArNumTxtBox.Text, Long)
        arDen = CType(AddMediaForm.ArDenTxtBox.Text, Long)
        astream = CType(AddMediaForm.AudioStream.Text, Long)
        vstream = CType(AddMediaForm.VideoStream.Text, Long)

        Dim id As String
        retErr = player.queueMedia(file, "", markin, markout,
                                    AddMediaForm.RemoveAfterPlayChkBox.Checked(),
                                    AddMediaForm.MaintainARChkBox.Checked(), arNum, arDen, cropl, cropr, cropt, cropb, vstream, astream, -1, "0dB", True, False, 0, id)
        If retErr Then
            Dim dsc As String
            dsc = "Queue failed: Details: " & player.getErrorDescription(retErr)
            MsgBox(dsc)
        Else
            PlayerMediaList.Items.Add(file)
            PlayerMediaList.Items(PlayerMediaList.Items.Count - 1).Selected = True
            playerQueue.Add(id)
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
            player.resume()
            Return
        End If

        If PlayerMediaList.SelectedItems.Count <= 0 Then
            Dim msg As String
            msg = "Please select a file to play."
            MsgBox(msg)
            Return
        End If

        Dim id = playerQueue.Item(PlayerMediaList.SelectedIndices(0))
        retErr = player.play(id)
        If retErr Then
            Dim msg As String
            msg = "Unable to play file" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub PlayerPauseBtn_Click(sender As Object, e As EventArgs) Handles PlayerPauseBtn.Click
        player.pause()
        playerPaused = True
    End Sub

    Private Sub PlayerPreviousBtn_Click(sender As Object, e As EventArgs) Handles PlayerPreviousBtn.Click
        retErr = player.previous()
        If retErr Then
            Dim dsc As String
            dsc = "Next failed: Details: " & player.getErrorDescription(retErr)
            MsgBox(dsc)
        End If
    End Sub

    Private Sub PlayerNextBtn_Click(sender As Object, e As EventArgs) Handles PlayerNextBtn.Click
        retErr = player.next()
        If retErr Then
            Dim dsc As String
            dsc = "Next failed: Details: " & player.getErrorDescription(retErr)
            MsgBox(dsc)
        End If
    End Sub

    Private Sub player_playerStateUpdated(ByRef oldState As String, ByRef newState As String) Handles player.playerStateUpdated
        Dim str = "[PLAYER] State Updated " & oldState & " -> " & newState
        Log(str)
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
                cgID.Add(xmlID)
            End If
        Next
        CGAvailableAnimations.Update()
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
        Dim id = cgID.Item(CGAvailableAnimations.SelectedItems.Item(0).Index)
        retErr = cg.load(filepath, id, False, True, "")
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
        Dim id = cgID.Item(CGPlayingAnimations.SelectedItems.Item(0).Index)
        retErr = cg.unLoad(id)
        If retErr Then
            Dim msg As String
            msg = "Unable to unload animation file" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        CGPlayingAnimations.Items.RemoveAt(CGPlayingAnimations.SelectedItems.Item(0).Index)
        CGAvailableAnimations.Items.Add(file)
    End Sub
    Private Sub InitLiveMediaPlayer(id As String)
        Dim vConn As String
        Dim mar As Integer
        Dim removeAfterPlay As Integer

        Dim newPath As String
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            newPath = dialog.FileName

            AddMediaForm.ShowDialog(Me)
            If (AddMediaForm.RemoveAfterPlayChkBox.Checked) Then
                removeAfterPlay = 1
            Else
                removeAfterPlay = 0
            End If

            If (AddMediaForm.MaintainARChkBox.Checked) Then
                mar = 1
            Else
                mar = 0
            End If

            vConn = newPath & ";"
            vConn = vConn & mar & ";" & AddMediaForm.ArNumTxtBox.Text & ";" & AddMediaForm.ArDenTxtBox.Text & ";"

            vConn = vConn & AddMediaForm.CropLeft.Text & ";" & AddMediaForm.CropRight.Text & ";" & AddMediaForm.CropTop.Text & ";" & AddMediaForm.CropBottom.Text & ";"
            vConn = vConn & removeAfterPlay & ";"
            vConn = vConn & AddMediaForm.MarkInTxtBox.Text & ";" & AddMediaForm.MarkOutTxtBox.Text
            vConn = vConn & ";1;0dB;-1;-1;1;0"
            retErr = live.initDevice(id, vConn, "")
            If retErr Then
                Dim msg As String
                msg = "Unable to initialize live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
                MsgBox(msg)
                Return
            End If
            retErr = live.startDevice(id)
            If retErr Then
                Dim msg As String
                msg = "Unable to start live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
                MsgBox(msg)
                Return
            End If
        End Using
    End Sub

    Private Sub StartLive_Click(sender As Object, e As EventArgs) Handles StartLive.Click
        If LiveDevicesList.Text.Contains("Player") Then
            InitLiveMediaPlayer(LiveDevicesList.Text)
        End If
        RefreshPreviewSources()
        UpdateHelp("If you did not got any error message, you now have a live device online. " &
        "It is now available in Sources list so that you " &
        "can tell renderer to start rendering the content from this device." & vbCrLf & vbCrLf &
        "Once you enable the device in sources section, on the biggest preview window, you can drag this device to change its position in the final output.")

    End Sub
    Private Sub SetRenderingAreaFromPictureBox(layer As Integer, box As PictureBox)
        Dim l = box.Left
        Dim t = box.Top
        Dim r = biggerPreview.Width - box.Right
        Dim b = biggerPreview.Height - box.Bottom

        Dim ll = (l / biggerPreview.Width) * outWidth
        Dim tt = (t / biggerPreview.Height) * outHeight
        Dim rr = (r / biggerPreview.Width) * outWidth
        Dim bb = (b / biggerPreview.Height) * outHeight

        retErr = renderer.setRenderingArea(layer, ll, rr, tt, bb, 0)
        If retErr Then
            Dim msg As String
            msg = "Unable to set rendering area" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub
    Private Sub StopLive_Click(sender As Object, e As EventArgs) Handles StopLive.Click
        retErr = live.stopDevice(LiveDevicesList.Text)
        If retErr Then
            Dim msg As String
            msg = "Unable to stop live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        retErr = live.deInitDevice(LiveDevicesList.Text)
        If retErr Then
            Dim msg As String
            msg = "Unable to deinitialize live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub RefreshPreviewSources()
        Dim temppreviewIDs, tempPreviewNames
        Dim previewDevices = renderer.getPreviewSources(temppreviewIDs, tempPreviewNames)
        For i = LBound(tempPreviewNames) To UBound(tempPreviewNames)
            If previewOneSelector.Items.Contains(tempPreviewNames(i)) Then
                Continue For
            End If
            previewOneSelector.Items.Insert(0, tempPreviewNames(i))
            previewTwoSelector.Items.Insert(0, tempPreviewNames(i))
            previewThreeSelector.Items.Insert(0, tempPreviewNames(i))
            biggerPreviewSelector.Items.Insert(0, tempPreviewNames(i))
            previewIDS.Insert(0, temppreviewIDs(i))
        Next
    End Sub

    Private Sub cg_xmlEvent(ByRef xmlid As String, ByRef id As String) Handles cg.xmlEvent
        Dim str = "[CG] XML event " & xmlid & " : " & id
        Log(str)
    End Sub

    Private Sub cg_xmlStateUpdated(ByRef id As String, ByRef newState As String) Handles cg.xmlStateUpdated
        Dim str = "[CG] XML state updated " & id & " : " & newState
        Log(str)
    End Sub

    Private Sub renderer_SourceAdded(ByRef id As String) Handles renderer.SourceAdded
        ' For simplicity recreate entire combo box
        retErr = renderer.getSources(sourceIDS, sourceNames)
        If retErr Then
            Dim msg As String
            msg = "Unable to get sources" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        SourceList.Items.Clear()

        For i = LBound(sourceIDS) To UBound(sourceIDS)
            SourceList.Items.Add(sourceNames(i))
        Next

        Dim str = "[RENDERER] Source added : " & id
        Log(str)
    End Sub

    Private Sub renderer_SourceRemoved(ByRef id As String) Handles renderer.SourceRemoved
        ' For simplicity recreate entire combo box
        retErr = renderer.getSources(sourceIDS, sourceNames)
        If retErr Then
            Dim msg As String
            msg = "Unable to get sources" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
        SourceList.Items.Clear()

        For i = LBound(sourceIDS) To UBound(sourceIDS)
            SourceList.Items.Add(sourceNames(i))
        Next

        Dim str = "[RENDERER] Source removed : " & id
        Log(str)
    End Sub







    Private Sub LiveDeviceOne_MouseMove(sender As Object, e As MouseEventArgs) Handles LiveDeviceOne.MouseMove
        Static mousePosX As Single, mousePosY As Single
        If e.Button = 0 Then
            mousePosX = e.X
            mousePosY = e.Y
        Else
            Dim currentx = LiveDeviceOne.Left + (e.X - mousePosX)
            If Not (currentx < 0 Or currentx + LiveDeviceOne.Width > Me.biggerPreview.Width) Then
                LiveDeviceOne.Left = currentx
            End If

            Dim currenty = LiveDeviceOne.Top + (e.Y - mousePosY)
            If Not (currenty < 0 Or currenty + LiveDeviceOne.Height > Me.biggerPreview.Height) Then
                LiveDeviceOne.Top = currenty
            End If
            SetRenderingAreaFromPictureBox(1, LiveDeviceOne)
        End If
    End Sub

    Private Sub LiveDeviceTwo_MouseMove(sender As Object, e As MouseEventArgs) Handles LiveDeviceTwo.MouseMove
        Static mousePosX As Single, mousePosY As Single
        If e.Button = 0 Then
            mousePosX = e.X
            mousePosY = e.Y
        Else
            Dim currentx = LiveDeviceTwo.Left + (e.X - mousePosX)
            If Not (currentx < 0 Or currentx + LiveDeviceTwo.Width > Me.biggerPreview.Width) Then
                LiveDeviceTwo.Left = currentx
            End If

            Dim currenty = LiveDeviceTwo.Top + (e.Y - mousePosY)
            If Not (currenty < 0 Or currenty + LiveDeviceTwo.Height > Me.biggerPreview.Height) Then
                LiveDeviceTwo.Top = currenty
            End If
            SetRenderingAreaFromPictureBox(2, LiveDeviceTwo)
        End If
    End Sub

    Private Sub VUMeterTimer_Tick(sender As Object, e As EventArgs) Handles VUMeterTimer.Tick
        If previewOneSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(previewOneSelector.SelectedIndex)
            Dim l As Double
            Dim r As Double
            l = -100
            r = -100

            renderer.getPreviewAudioSignalPower(id, l, r)
            smallPreviewOneLeftChannel.Value = l + 100
            smallPreviewOneRightChannel.Value = r + 100
        End If
        '-------------------------------------------------------------------------
        If previewTwoSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(previewTwoSelector.SelectedIndex)
            Dim l As Double
            Dim r As Double
            l = -100
            r = -100

            renderer.getPreviewAudioSignalPower(id, l, r)
            smallPreviewTwoLeftChannel.Value = l + 100
            smallPreviewTwoRightChannel.Value = r + 100
        End If

        '-------------------------------------------------------------------------
        If previewThreeSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(previewThreeSelector.SelectedIndex)
            Dim l As Double
            Dim r As Double
            l = -100
            r = -100

            renderer.getPreviewAudioSignalPower(id, l, r)
            smallPreviewThreeLeftChannel.Value = l + 100
            smallPreviewThreeRightChannel.Value = r + 100
        End If

        '-------------------------------------------------------------------------
        If biggerPreviewSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(biggerPreviewSelector.SelectedIndex)
            Dim l As Double
            Dim r As Double
            l = -100
            r = -100

            renderer.getPreviewAudioSignalPower(id, l, r)
            biggerPreviewLeftChannel.Value = l + 100
            biggerPreviewRightChannel.Value = r + 100
        End If

    End Sub

    Private Sub VUMeterDecayTimer_Tick(sender As Object, e As EventArgs) Handles VUMeterDecayTimer.Tick
        Dim valuel = smallPreviewOneLeftChannel.Value
        Dim valuer = smallPreviewOneRightChannel.Value
        If valuel >= 10 Then
            valuel = valuel - 10
        End If

        If valuer >= 10 Then
            valuer = valuer - 10
        End If

        smallPreviewOneLeftChannel.Value = valuel
        smallPreviewOneRightChannel.Value = valuer

        '---------------------------------------------
        valuel = smallPreviewTwoLeftChannel.Value
        valuer = smallPreviewTwoRightChannel.Value
        If valuel >= 10 Then
            valuel = valuel - 10
        End If

        If valuer >= 10 Then
            valuer = valuer - 10
        End If

        smallPreviewTwoLeftChannel.Value = valuel
        smallPreviewTwoRightChannel.Value = valuer

        '---------------------------------------------
        valuel = smallPreviewThreeLeftChannel.Value
        valuer = smallPreviewThreeRightChannel.Value
        If valuel >= 10 Then
            valuel = valuel - 10
        End If

        If valuer >= 10 Then
            valuer = valuer - 10
        End If

        smallPreviewThreeLeftChannel.Value = valuel
        smallPreviewThreeRightChannel.Value = valuer

        '---------------------------------------------
        valuel = biggerPreviewLeftChannel.Value
        valuer = biggerPreviewRightChannel.Value
        If valuel >= 10 Then
            valuel = valuel - 10
        End If

        If valuer >= 10 Then
            valuer = valuer - 10
        End If

        biggerPreviewLeftChannel.Value = valuel
        biggerPreviewRightChannel.Value = valuer

    End Sub

    Private Sub renderingDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles renderingDevices.SelectedIndexChanged
        populateDeviceInfo(renderingDevices.Text)

    End Sub

    Private Sub previewOneVolume_Scroll(sender As Object, e As EventArgs) Handles previewOneVolume.Scroll
        If previewOneSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(previewOneSelector.SelectedIndex)
            renderer.setPreviewVolumePercentage(id, previewOneVolume.Value)
        End If
    End Sub

    Private Sub previewTwoVolume_Scroll(sender As Object, e As EventArgs) Handles previewTwoVolume.Scroll
        If previewTwoSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(previewTwoSelector.SelectedIndex)
            renderer.setPreviewVolumePercentage(id, previewTwoVolume.Value)
        End If
    End Sub

    Private Sub previewThreeVolume_Scroll(sender As Object, e As EventArgs) Handles previewThreeVolume.Scroll
        If previewThreeSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(previewThreeSelector.SelectedIndex)
            renderer.setPreviewVolumePercentage(id, previewThreeVolume.Value)
        End If
    End Sub

    Private Sub biggerPreviewVolume_Scroll(sender As Object, e As EventArgs) Handles biggerPreviewVolume.Scroll
        If biggerPreviewSelector.SelectedIndex <> -1 Then
            Dim id = previewIDS.Item(biggerPreviewSelector.SelectedIndex)
            renderer.setPreviewVolumePercentage(id, biggerPreviewVolume.Value)
        End If
    End Sub

    Private Sub Log(str As String)
        LogWindow.Items.Insert(0, str)
        If LogWindow.Items.Count > 500 Then
            LogWindow.Items.RemoveAt(LogWindow.Items.Count - 1)
        End If
    End Sub

    Private Sub PlaylistTimer_Tick(sender As Object, e As EventArgs) Handles PlaylistTimer.Tick
        Dim total, curr
        player.getPlaylistTimeInfo(total, curr)

        total = total - curr  ' get remaining

        Dim ts As TimeSpan = TimeSpan.FromMilliseconds(total)
        PlaylistTimeLabel.Text = ts.ToString("hh\:mm\:ss")
    End Sub

    Private Sub live_deviceStateUpdated(ByRef id As String, ByRef newState As String) Handles live.deviceStateUpdated
        Dim str = "[LIVE] Device id " & id & " state updated : " & newState
        Log(str)
    End Sub

    Private Sub UpdateHelp(str As String)
        HelpWindow.Text = str
    End Sub

    Private Sub StartSource_Click(sender As Object, e As EventArgs) Handles StartSource.Click
        Dim index = SourceList.SelectedIndex
        If index < 0 Or SourceList.Items.Count <= 0 Then
            Dim msg As String
            msg = "Not sources available to start."
            MsgBox(msg)
            Return
        End If
        Dim id = sourceIDS.GetValue(index)
        Dim name = sourceNames.GetValue(index)
        If name.Contains("CG") Then
            retErr = renderer.startSource(id, 2)
        ElseIf name.Contains("Live") Then
            If layer < 4 Then
                Dim pb = livePictureBoxes(layer - 1)
                pb.Left = 10 + (layer - 1) * 160
                pb.Width = 160
                pb.Height = 90
                pb.Top = 100
                pb.Visible = True
                pb.BackColor = Color.DarkGreen
                SetRenderingAreaFromPictureBox(layer, pb)
                renderer.startPreview(id, pb.Handle, pb.Width, pb.Height)
                renderer.setPreviewVolumePercentage(id, 0)
                retErr = renderer.startSource(id, layer)
                layer = layer + 1
            End If
        Else
            retErr = renderer.startSource(id, 0)
        End If
        If retErr Then
            Dim msg As String
            msg = "Unable to start source" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub StopSource_Click(sender As Object, e As EventArgs) Handles StopSource.Click
        Dim index = SourceList.SelectedIndex
        If index < 0 Or SourceList.Items.Count <= 0 Then
            Dim msg As String
            msg = "No sources available to stop."
            MsgBox(msg)
            Return
        End If
        Dim id = sourceIDS.GetValue(index)
        retErr = renderer.stopSource(id)
        If retErr Then
            Dim msg As String
            msg = "Unable to start live device" & Constants.vbCrLf & "Details: " & renderer.getErrorDescription(retErr)
            MsgBox(msg)
            Return
        End If
    End Sub

    Private Sub RefreshSources_Click(sender As Object, e As EventArgs) Handles RefreshSources.Click
        retErr = renderer.getSources(sourceIDS, sourceNames)
        If retErr Then
            Dim dsc As String
            dsc = "Unable to fetch sources from server."
            MsgBox(dsc)
            Return
        End If
        SourceList.Items.Clear()

        For i = LBound(sourceIDS) To UBound(sourceIDS)
            SourceList.Items.Add(sourceNames(i))
        Next

        RefreshPreviewSources()
    End Sub
End Class
