Imports System.Threading

Public Class WeighBridgeSimulator

    Public WithEvents _serial As New SerialCommunication
    Dim _port As String = Configuration.Default.PortName
    Dim _thread1 As Thread
    Dim _thread2 As Thread

    Private Sub WeighBridgeSimulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = GetData()
        ConnectToPort()
        _thread1 = New Thread(AddressOf WeighIn)
        _thread1.Start()
        _thread2 = New Thread(AddressOf WeighOut)
        _thread2.Start()
    End Sub

    Private Sub ConnectToPort()
        Try
            _serial.Connect(_port)
            AddHandler _serial.DataReceived, AddressOf _serial_DataReceived
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub _serial_DataReceived(sender As Object, e As DataReceivedEventArgs)
        GetRfid(e.dataReceived)
    End Sub
    Private Delegate Sub TextDelegate([message] As String)
    Private Sub GetRfid([message] As String)
        If txtRfid.InvokeRequired Then
            Dim d As New TextDelegate(AddressOf GetRfid)
            txtRfid.Invoke(d, {[message]})
        Else
            txtRfid.Text = ""
            txtRfid.AppendText([message])
        End If
    End Sub
    Private Sub txtRfid_TextChanged(sender As Object, e As EventArgs) Handles txtRfid.TextChanged
        If txtRfid.Text = "" Then
        Else
            UpdateData(Convert.ToInt32(txtRfid.Text), Convert.ToDecimal(txtWeighIn.Text), Convert.ToDecimal(txtWeighOut.Text))
        End If
    End Sub

    Public Sub WeighIn()

    End Sub

    Public Sub WeighOut()

    End Sub

End Class