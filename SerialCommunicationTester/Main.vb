Imports System.IO.Ports
Imports System.Text.Encoding
Public Class Main

    Public WithEvents _serial As New SerialCommunication
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPortName.DataSource = SerialPort.GetPortNames
        LoadConfiguation(cboPortName, cboBaudRate, cboParity, cboDataBits, cboStopBits)
    End Sub
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If lblStatus.Text = "Disconnected" Then
            AddHandler _serial.DataReceived, AddressOf _serial_DataReceived
            _serial.Connect(cboPortName.SelectedItem)
            lblStatus.Text = "Connected"
            lblStatus.ForeColor = Color.Green
            btnDisconnect.Enabled = True
            btnEdit.Enabled = False
            btnConnect.Enabled = False
        End If
    End Sub
    Private Sub _serial_DataReceived(sender As Object, e As DataReceivedEventArgs)
        AddOutput(e.dataReceived)
    End Sub
    Private Delegate Sub TextDelegate(s As String)
    Private Sub AddOutput([message] As String)
        If txtReceived.InvokeRequired Then
            Dim d As New TextDelegate(AddressOf AddOutput)
            txtReceived.Invoke(d, {[message]})
        Else
            txtReceived.AppendText([message])
        End If
    End Sub
    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        If lblStatus.Text = "Connected" Then
            _serial.Disconnect()
            lblStatus.Text = "Disconnected"
            lblStatus.ForeColor = Color.Red
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If _serial.isConnected Then
            _serial.SendData(txtSendText.Text)
            txtSent.AppendText(txtSendText.Text + vbNewLine)
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit(cboPortName, cboBaudRate, cboParity, cboDataBits, cboStopBits, btnSave, btnEdit)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save(cboPortName, cboBaudRate, cboParity, cboDataBits, cboStopBits, btnSave, btnEdit)
    End Sub
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _serial.Disconnect()
    End Sub
    Private Sub radioHexadecimal_CheckedChanged(sender As Object, e As EventArgs) Handles radioHexadecimal.CheckedChanged

    End Sub
    Private Sub radioString_CheckedChanged(sender As Object, e As EventArgs) Handles radioString.CheckedChanged

    End Sub
    Private Sub txtSent_TextChanged(sender As Object, e As EventArgs) Handles txtSent.TextChanged
        txtSent.SelectionStart = txtSent.Text.Length
        txtSent.ScrollToCaret()
    End Sub
    Private Sub txtReceived_TextChanged(sender As Object, e As EventArgs) Handles txtReceived.TextChanged
        txtReceived.SelectionStart = txtReceived.Text.Length
        txtReceived.ScrollToCaret()
    End Sub
End Class
