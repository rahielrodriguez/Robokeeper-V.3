Imports System.IO.Ports
Imports System.Threading.Thread
Imports System.Windows.Forms.ComponentModel.Com2Interop
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports Microsoft.VisualBasic.Logging
Public Class RobokeeperV3
    Dim previousPosition_Global As Integer
    Dim objectivePosition_Global As Integer
    Dim steps_Multiplying_Factor As Integer = 2

    Dim newCameraX As Integer
    Dim oldCameraX As Integer
    Dim cameraY As Integer
    Dim cameraWidth As Integer
    Dim motorX As Integer
    Dim motorX_HB As Integer
    Dim motorX_LB As Integer
    Dim cameraXHighByte As Integer
    Dim cameraXLowByte As Integer
    Dim cameraYHighByte As Integer
    Dim cameraYLowByte As Integer
    Dim cameraWidthHighByte As Integer
    Dim cameraWidthLowByte As Integer
    Dim scaled_Pixy_X As Integer
    Sub WriteHandshake()

        Dim Data(0) As Byte
        Data(0) = &H24 'Handshake value
        PICSerialPort.Write(Data, 0, 1) 'transmits handshake value

    End Sub
    Sub PICSerialConnect(portName As String)
        PICSerialPort.Close()
        PICSerialPort.PortName = portName
        PICSerialPort.BaudRate = 115200
        PICSerialPort.Open()
    End Sub
    Sub PixySerialConnect(portName As String)
        PixySerialPort.Close()
        PixySerialPort.PortName = portName
        PixySerialPort.BaudRate = 115200
        PixySerialPort.Open()
    End Sub
    Sub GetPorts1()
        'add all available ports to the port combobox
        PICPortComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            'If s = "COM3" Then  'COM3 & 4 are built in com ports of the computer, not usable for this project

            If s = "COM4" Then

            Else
                PICPortComboBox.Items.Add($"{s}")
            End If
        Next
        PICPortComboBox.SelectedIndex = 0
    End Sub
    Sub GetPorts2()
        'add all available ports to the port combobox
        PixyComboBox.Items.Clear()
        For Each s As String In SerialPort.GetPortNames()
            'If s = "COM3" Then  'COM3 & 4 are built in com ports of the computer, not usable for this project

            If s = "COM4" Then

            Else
                PixyComboBox.Items.Add($"{s}")
            End If
        Next
        PixyComboBox.SelectedIndex = 1
    End Sub

    Private Sub ComButton_Click(sender As Object, e As EventArgs) Handles ComButton.Click
        GetPorts1()
        GetPorts2()
    End Sub

    Private Sub PortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PICPortComboBox.SelectedIndexChanged
        PICSerialConnect(PICPortComboBox.SelectedItem)
    End Sub
    Private Sub RobokeeperV3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'motorStoppedFlag = True
        GetPorts1() 'Loads and open the ports for the PIC and the Pixy Camera
        'GetPorts2()
        PICSerialPort.DiscardInBuffer() 'Discards any non desired data On the port When start up happens
        'PixySerialPort.DiscardInBuffer()
        previousPosition_Global = 9 * steps_Multiplying_Factor 'Starts at position 1 by default.
        ResetTimer.Start() 'starts the semi-automatic control timer used by the physical button on the board.
    End Sub
    Sub Button1_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H1
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button2_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H2
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button3_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H3
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button4_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H4
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button5_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H5
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button6_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H6
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button7_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H7
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button8_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H8
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Sub Button9_Task()
        Dim position_Data(0) As Byte
        position_Data(0) = &H9
        objectivePosition_Global = CInt(position_Data(0)) * steps_Multiplying_Factor 'Determines the objective position based on the position that is desired to go.
        Try
            If objectivePosition_Global <> previousPosition_Global Then
                Dim received_Data(PICSerialPort.BytesToRead) As Byte
                Console.Write($"Position = ")
                Console.Write($"{Hex(position_Data(0))}")
                Console.WriteLine()
                StepsComparison(previousPosition_Global, objectivePosition_Global) 'Compare Objective Position and Previous Position
                Sleep(10)
                PICSerialPort.Read(received_Data, 0, PICSerialPort.BytesToRead)
                Console.Write($"PIC Stepping Data: {Hex(received_Data(0))}")
                Console.WriteLine()
                previousPosition_Global = objectivePosition_Global 'Objective position reached, becomes previous position
            Else
                Console.Write($"Same position as before (Position {position_Data(0)}), motor did not move")
                Console.WriteLine()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1_Task()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2_Task()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3_Task()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4_Task()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5_Task()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6_Task()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7_Task()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8_Task()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9_Task()
    End Sub
    Sub StepsComparison(previousPosition As Integer, objectivePosition As Integer)

        Dim tx_Position(0) As Byte
        If objectivePosition > previousPosition Then 'Moving a greater position: from 1 up to 9
            tx_Position(0) = objectivePosition - previousPosition 'takes the difference to determine the number of steps to be done, going to the left
            PICSerialPort.Write(tx_Position, 0, 1) 'transmit #steps byte
            Console.Write($"Transmitted Position Hex = ")
            Console.Write($"{Hex(tx_Position(0))}")
            Console.WriteLine()
            Console.Write($"Transmitted Position Dec = ")
            Console.Write($"{Int(tx_Position(0))}")
            Console.WriteLine()
            Sleep(5)
        ElseIf objectivePosition < previousPosition Then 'Moving a greater position: from 9 up to 1
            tx_Position(0) = previousPosition - objectivePosition + 128 'Sets MSB of the byte to indicate change in direction, going to the right.
            PICSerialPort.Write(tx_Position, 0, 1)
            Console.Write($"Transmitted Position Hex = ")
            Console.Write($"{Hex(tx_Position(0))}")
            Console.WriteLine()
            Console.Write($"Transmitted Position Dec = ")
            Console.Write($"{Int(tx_Position(0))}")
            Console.WriteLine()
            Sleep(5)
        Else
            Console.Write($"No Steps Sent, same position as before")
            Console.WriteLine()
        End If
    End Sub
    Private Sub CameraTimer_Tick(sender As Object, e As EventArgs) Handles CameraTimer.Tick
        Try
            Dim data(PixySerialPort.BytesToRead) As Byte
            PixySerialPort.Read(data, 0, PixySerialPort.BytesToRead)
            If data(2) = &H55 And data(3) = &HAA And data(4) = &H55 And data(5) = &HAA And data.Length >= 18 And CameraControlCheckBox.Checked = True Then 'If Pixy Cam Handshake is detected and has the correct number of bytes
                cameraXHighByte = CInt(data(11))
                cameraXLowByte = CInt(data(10))
                newCameraX = (cameraXHighByte * 256) + cameraXLowByte 'Takes the low and high byte to make the whole number/word
                Console.Write($"Pixy Cam Original X Data = {Hex(cameraXHighByte)} {Hex(cameraXLowByte)}")
                Console.WriteLine()
                Console.Write($"Pixy Cam Original Y Data = {Hex(cameraYHighByte)} {Hex(cameraYLowByte)}")
                Console.WriteLine()
                Console.Write($"Pixy Cam Original Width Data = {Hex(cameraWidthHighByte)} {Hex(cameraWidthLowByte)}")
                Console.WriteLine()
            End If
            PixySerialPort.DiscardInBuffer()

            If oldCameraX >= newCameraX + 5 Or oldCameraX <= newCameraX - 5 Then
                If newCameraX <= 108 Then
                    Button7_Task()
                ElseIf newCameraX > 112 And newCameraX <= 119 Then
                    Button6_Task()
                ElseIf newCameraX > 123 And newCameraX <= 130 Then
                    Button5_Task()
                ElseIf newCameraX > 134 And newCameraX <= 141 Then
                    Button4_Task()
                ElseIf newCameraX > 145 And newCameraX <= 152 Then
                    Button3_Task()
                ElseIf newCameraX > 156 And newCameraX <= 163 Then
                    Button2_Task()
                ElseIf newCameraX > 167 Then
                    Button1_Task()
                ElseIf newCameraX <= 0 Then

                Else

                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub CameraControlCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CameraControlCheckBox.CheckedChanged
        If CameraControlCheckBox.Checked = True Then
            CameraTimer.Start() 'starts automated control
        Else
            CameraTimer.Stop() 'stops automated control
        End If
    End Sub

    Private Sub GOButton_Click(sender As Object, e As EventArgs) Handles GOButton.Click
        ResetTimer.Stop()
        CameraControlCheckBox.Checked = True
    End Sub
End Class