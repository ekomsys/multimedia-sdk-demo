<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiskWriterDialog
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
        Me.OutFileLabel = New System.Windows.Forms.Label()
        Me.OutFile = New System.Windows.Forms.TextBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VideoHeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VideoWidth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AudioSampleRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AudioBitrate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VideoBitRate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutFileLabel
        '
        Me.OutFileLabel.AutoSize = True
        Me.OutFileLabel.Location = New System.Drawing.Point(35, 39)
        Me.OutFileLabel.Name = "OutFileLabel"
        Me.OutFileLabel.Size = New System.Drawing.Size(58, 13)
        Me.OutFileLabel.TabIndex = 0
        Me.OutFileLabel.Text = "Output File"
        '
        'OutFile
        '
        Me.OutFile.Location = New System.Drawing.Point(111, 36)
        Me.OutFile.Name = "OutFile"
        Me.OutFile.Size = New System.Drawing.Size(226, 20)
        Me.OutFile.TabIndex = 1
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(384, 36)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 2
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VideoHeight)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.VideoWidth)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 89)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'VideoHeight
        '
        Me.VideoHeight.Location = New System.Drawing.Point(333, 38)
        Me.VideoHeight.Name = "VideoHeight"
        Me.VideoHeight.Size = New System.Drawing.Size(95, 20)
        Me.VideoHeight.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Height"
        '
        'VideoWidth
        '
        Me.VideoWidth.Location = New System.Drawing.Point(81, 38)
        Me.VideoWidth.Name = "VideoWidth"
        Me.VideoWidth.Size = New System.Drawing.Size(95, 20)
        Me.VideoWidth.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Width"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AudioSampleRate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.AudioBitrate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 89)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Audio"
        '
        'AudioSampleRate
        '
        Me.AudioSampleRate.Location = New System.Drawing.Point(333, 38)
        Me.AudioSampleRate.Name = "AudioSampleRate"
        Me.AudioSampleRate.Size = New System.Drawing.Size(95, 20)
        Me.AudioSampleRate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sample Rate"
        '
        'AudioBitrate
        '
        Me.AudioBitrate.Location = New System.Drawing.Point(81, 38)
        Me.AudioBitrate.Name = "AudioBitrate"
        Me.AudioBitrate.Size = New System.Drawing.Size(95, 20)
        Me.AudioBitrate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Bitrate"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.VideoBitRate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(455, 89)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Video"
        '
        'VideoBitRate
        '
        Me.VideoBitRate.Location = New System.Drawing.Point(81, 38)
        Me.VideoBitRate.Name = "VideoBitRate"
        Me.VideoBitRate.Size = New System.Drawing.Size(95, 20)
        Me.VideoBitRate.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Bitrate"
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(311, 373)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 8
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(392, 373)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'DiskWriterDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 408)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.OutFile)
        Me.Controls.Add(Me.OutFileLabel)
        Me.Name = "DiskWriterDialog"
        Me.Text = "DiskWriterDialog"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutFileLabel As Label
    Friend WithEvents OutFile As TextBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VideoHeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents VideoWidth As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AudioSampleRate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AudioBitrate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents VideoBitRate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OkBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
