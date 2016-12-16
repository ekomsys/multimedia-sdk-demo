<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMediaForm
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
        Me.RemoveAfterPlayChkBox = New System.Windows.Forms.CheckBox()
        Me.MaintainARChkBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ArNumTxtBox = New System.Windows.Forms.TextBox()
        Me.ArDenTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MarkOutTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MarkInTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CropBottom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CropTop = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CropLeft = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CropRight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VideoStreamlbl = New System.Windows.Forms.Label()
        Me.VideoStream = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AudioStream = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RemoveAfterPlayChkBox
        '
        Me.RemoveAfterPlayChkBox.AutoSize = True
        Me.RemoveAfterPlayChkBox.Location = New System.Drawing.Point(22, 23)
        Me.RemoveAfterPlayChkBox.Name = "RemoveAfterPlayChkBox"
        Me.RemoveAfterPlayChkBox.Size = New System.Drawing.Size(114, 17)
        Me.RemoveAfterPlayChkBox.TabIndex = 0
        Me.RemoveAfterPlayChkBox.Text = "Remove After Play"
        Me.RemoveAfterPlayChkBox.UseVisualStyleBackColor = True
        '
        'MaintainARChkBox
        '
        Me.MaintainARChkBox.AutoSize = True
        Me.MaintainARChkBox.Checked = True
        Me.MaintainARChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaintainARChkBox.Location = New System.Drawing.Point(22, 55)
        Me.MaintainARChkBox.Name = "MaintainARChkBox"
        Me.MaintainARChkBox.Size = New System.Drawing.Size(84, 17)
        Me.MaintainARChkBox.TabIndex = 1
        Me.MaintainARChkBox.Text = "Maintain AR"
        Me.MaintainARChkBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Num"
        '
        'ArNumTxtBox
        '
        Me.ArNumTxtBox.Location = New System.Drawing.Point(172, 52)
        Me.ArNumTxtBox.Name = "ArNumTxtBox"
        Me.ArNumTxtBox.Size = New System.Drawing.Size(57, 20)
        Me.ArNumTxtBox.TabIndex = 3
        Me.ArNumTxtBox.Text = "16"
        '
        'ArDenTxtBox
        '
        Me.ArDenTxtBox.Location = New System.Drawing.Point(302, 53)
        Me.ArDenTxtBox.Name = "ArDenTxtBox"
        Me.ArDenTxtBox.Size = New System.Drawing.Size(57, 20)
        Me.ArDenTxtBox.TabIndex = 5
        Me.ArDenTxtBox.Text = "9"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Den"
        '
        'MarkOutTxtBox
        '
        Me.MarkOutTxtBox.Location = New System.Drawing.Point(302, 98)
        Me.MarkOutTxtBox.Name = "MarkOutTxtBox"
        Me.MarkOutTxtBox.Size = New System.Drawing.Size(57, 20)
        Me.MarkOutTxtBox.TabIndex = 9
        Me.MarkOutTxtBox.Text = "-1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mark Out"
        '
        'MarkInTxtBox
        '
        Me.MarkInTxtBox.Location = New System.Drawing.Point(172, 97)
        Me.MarkInTxtBox.Name = "MarkInTxtBox"
        Me.MarkInTxtBox.Size = New System.Drawing.Size(57, 20)
        Me.MarkInTxtBox.TabIndex = 7
        Me.MarkInTxtBox.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mark In"
        '
        'CropBottom
        '
        Me.CropBottom.Location = New System.Drawing.Point(302, 141)
        Me.CropBottom.Name = "CropBottom"
        Me.CropBottom.Size = New System.Drawing.Size(57, 20)
        Me.CropBottom.TabIndex = 13
        Me.CropBottom.Text = "-1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Bottom"
        '
        'CropTop
        '
        Me.CropTop.Location = New System.Drawing.Point(172, 140)
        Me.CropTop.Name = "CropTop"
        Me.CropTop.Size = New System.Drawing.Size(57, 20)
        Me.CropTop.TabIndex = 11
        Me.CropTop.Text = "-1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Top"
        '
        'CropLeft
        '
        Me.CropLeft.Location = New System.Drawing.Point(302, 178)
        Me.CropLeft.Name = "CropLeft"
        Me.CropLeft.Size = New System.Drawing.Size(57, 20)
        Me.CropLeft.TabIndex = 17
        Me.CropLeft.Text = "-1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Left"
        '
        'CropRight
        '
        Me.CropRight.Location = New System.Drawing.Point(172, 177)
        Me.CropRight.Name = "CropRight"
        Me.CropRight.Size = New System.Drawing.Size(57, 20)
        Me.CropRight.TabIndex = 15
        Me.CropRight.Text = "-1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Right"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Crop"
        '
        'VideoStreamlbl
        '
        Me.VideoStreamlbl.AutoSize = True
        Me.VideoStreamlbl.Location = New System.Drawing.Point(19, 216)
        Me.VideoStreamlbl.Name = "VideoStreamlbl"
        Me.VideoStreamlbl.Size = New System.Drawing.Size(67, 13)
        Me.VideoStreamlbl.TabIndex = 20
        Me.VideoStreamlbl.Text = "VideoStream"
        '
        'VideoStream
        '
        Me.VideoStream.Location = New System.Drawing.Point(172, 216)
        Me.VideoStream.Name = "VideoStream"
        Me.VideoStream.Size = New System.Drawing.Size(57, 20)
        Me.VideoStream.TabIndex = 19
        Me.VideoStream.Text = "-1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "AudioStream"
        '
        'AudioStream
        '
        Me.AudioStream.Location = New System.Drawing.Point(172, 252)
        Me.AudioStream.Name = "AudioStream"
        Me.AudioStream.Size = New System.Drawing.Size(57, 20)
        Me.AudioStream.TabIndex = 21
        Me.AudioStream.Text = "-1"
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(272, 311)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 23
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "In/Out"
        '
        'AddMediaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 346)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AudioStream)
        Me.Controls.Add(Me.VideoStreamlbl)
        Me.Controls.Add(Me.VideoStream)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CropLeft)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CropRight)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CropBottom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CropTop)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MarkOutTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MarkInTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ArDenTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ArNumTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaintainARChkBox)
        Me.Controls.Add(Me.RemoveAfterPlayChkBox)
        Me.Name = "AddMediaForm"
        Me.Text = "AddMediaForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RemoveAfterPlayChkBox As CheckBox
    Friend WithEvents MaintainARChkBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ArNumTxtBox As TextBox
    Friend WithEvents ArDenTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MarkOutTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MarkInTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CropBottom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CropTop As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CropLeft As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CropRight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents VideoStreamlbl As Label
    Friend WithEvents VideoStream As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents AudioStream As TextBox
    Friend WithEvents OkBtn As Button
    Friend WithEvents Label12 As Label
End Class
