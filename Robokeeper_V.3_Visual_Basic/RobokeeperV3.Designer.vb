<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobokeeperV3
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
        Me.PixyPortLabel = New System.Windows.Forms.Label()
        Me.PICPortLabel = New System.Windows.Forms.Label()
        Me.GOButton = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.CameraControlCheckBox = New System.Windows.Forms.CheckBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.PixyComboBox = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComButton = New System.Windows.Forms.Button()
        Me.PICPortComboBox = New System.Windows.Forms.ComboBox()
        Me.PICSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.PixySerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.CameraTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ResetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'PixyPortLabel
        '
        Me.PixyPortLabel.AutoSize = True
        Me.PixyPortLabel.Location = New System.Drawing.Point(202, 11)
        Me.PixyPortLabel.Name = "PixyPortLabel"
        Me.PixyPortLabel.Size = New System.Drawing.Size(59, 16)
        Me.PixyPortLabel.TabIndex = 38
        Me.PixyPortLabel.Text = "Pixy Port"
        '
        'PICPortLabel
        '
        Me.PICPortLabel.AutoSize = True
        Me.PICPortLabel.Location = New System.Drawing.Point(12, 11)
        Me.PICPortLabel.Name = "PICPortLabel"
        Me.PICPortLabel.Size = New System.Drawing.Size(55, 16)
        Me.PICPortLabel.TabIndex = 37
        Me.PICPortLabel.Text = "PIC Port"
        '
        'GOButton
        '
        Me.GOButton.Location = New System.Drawing.Point(662, 205)
        Me.GOButton.Name = "GOButton"
        Me.GOButton.Size = New System.Drawing.Size(126, 74)
        Me.GOButton.TabIndex = 36
        Me.GOButton.Text = "Go"
        Me.GOButton.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(382, 255)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(94, 72)
        Me.Button9.TabIndex = 35
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(282, 255)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(94, 72)
        Me.Button8.TabIndex = 34
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'CameraControlCheckBox
        '
        Me.CameraControlCheckBox.AutoSize = True
        Me.CameraControlCheckBox.Enabled = False
        Me.CameraControlCheckBox.Location = New System.Drawing.Point(182, 365)
        Me.CameraControlCheckBox.Name = "CameraControlCheckBox"
        Me.CameraControlCheckBox.Size = New System.Drawing.Size(138, 20)
        Me.CameraControlCheckBox.TabIndex = 33
        Me.CameraControlCheckBox.Text = "Camera Controled"
        Me.CameraControlCheckBox.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(662, 285)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(126, 74)
        Me.HomeButton.TabIndex = 31
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'PixyComboBox
        '
        Me.PixyComboBox.FormattingEnabled = True
        Me.PixyComboBox.Location = New System.Drawing.Point(205, 30)
        Me.PixyComboBox.Name = "PixyComboBox"
        Me.PixyComboBox.Size = New System.Drawing.Size(171, 24)
        Me.PixyComboBox.TabIndex = 30
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(182, 255)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(94, 72)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(382, 177)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 72)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(282, 177)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 72)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(182, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 72)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(382, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 72)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(282, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 72)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 72)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComButton
        '
        Me.ComButton.Location = New System.Drawing.Point(662, 365)
        Me.ComButton.Name = "ComButton"
        Me.ComButton.Size = New System.Drawing.Size(126, 74)
        Me.ComButton.TabIndex = 22
        Me.ComButton.Text = "Com"
        Me.ComButton.UseVisualStyleBackColor = True
        '
        'PICPortComboBox
        '
        Me.PICPortComboBox.FormattingEnabled = True
        Me.PICPortComboBox.Location = New System.Drawing.Point(12, 30)
        Me.PICPortComboBox.Name = "PICPortComboBox"
        Me.PICPortComboBox.Size = New System.Drawing.Size(171, 24)
        Me.PICPortComboBox.TabIndex = 21
        '
        'PICSerialPort
        '
        Me.PICSerialPort.BaudRate = 115200
        '
        'PixySerialPort
        '
        Me.PixySerialPort.BaudRate = 115200
        Me.PixySerialPort.ReceivedBytesThreshold = 18
        '
        'CameraTimer
        '
        Me.CameraTimer.Interval = 50
        '
        'ResetTimer
        '
        Me.ResetTimer.Interval = 50
        '
        'RobokeeperV3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PixyPortLabel)
        Me.Controls.Add(Me.PICPortLabel)
        Me.Controls.Add(Me.GOButton)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.CameraControlCheckBox)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PixyComboBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComButton)
        Me.Controls.Add(Me.PICPortComboBox)
        Me.Name = "RobokeeperV3"
        Me.Text = "RobokeeperV3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PixyPortLabel As Label
    Friend WithEvents PICPortLabel As Label
    Friend WithEvents GOButton As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents CameraControlCheckBox As CheckBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents PixyComboBox As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComButton As Button
    Friend WithEvents PICPortComboBox As ComboBox
    Friend WithEvents PICSerialPort As IO.Ports.SerialPort
    Friend WithEvents PixySerialPort As IO.Ports.SerialPort
    Friend WithEvents CameraTimer As Timer
    Friend WithEvents ResetTimer As Timer
End Class
