Imports System.IO.Ports

Public Class SerialCommunication
    Private WithEvents _port As New SerialPort
    Public Event DataReceived(sender As Object, e As DataReceivedEventArgs)
    Public Sub Connect(portName As String)
        Try
            Dim config As New Configuration
            With _port
                .PortName = portName
                .BaudRate = config.BaudRate
                .Parity = [Enum].Parse(GetType(Parity), config.Parity, True)
                .DataBits = config.DataBits
                .StopBits = config.StopBits
            End With
            If Not _port.IsOpen Then
                _port.Open()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Disconnect()
        Try
            If _port.IsOpen Then
                _port.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SendData(ByVal [message] As String)
        Try
            If _port.IsOpen Then
                _port.WriteLine([message])
            Else
                MessageBox.Show("Not connection established. Please press Connect")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _port_DataReceived(ByVal sender As System.Object, ByVal e As SerialDataReceivedEventArgs) Handles _port.DataReceived
        Dim result As String = ""
        Try
            If _port.IsOpen Then
                result = _port.ReadExisting()
            Else
                MessageBox.Show("Not connection established. Please press Connect")
            End If
        Catch ex As Exception
        End Try
        RaiseEvent DataReceived(Me, New DataReceivedEventArgs With {.dataReceived = New String(result)})
    End Sub
End Class
Public Class DataReceivedEventArgs
    Inherits EventArgs
    Public dataReceived As String
End Class
