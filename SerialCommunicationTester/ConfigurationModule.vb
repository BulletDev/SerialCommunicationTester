
Imports System.Configuration

Module ConfigurationModule
    Public Sub Edit(portName As ComboBox, baudRate As ComboBox, parity As ComboBox, dataBits As ComboBox, stopBits As ComboBox, save As Button, edit As Button)
        portName.Enabled = True
        baudRate.Enabled = True
        parity.Enabled = True
        dataBits.Enabled = True
        stopBits.Enabled = True
        save.Enabled = True
        edit.Enabled = False
    End Sub
    Public Sub Save(portName As ComboBox, baudRate As ComboBox, parity As ComboBox, dataBits As ComboBox, stopBits As ComboBox, save As Button, edit As Button)

        Configuration.Default.PortName = portName.Text
        Configuration.Default.BaudRate = baudRate.Text
        Configuration.Default.Parity = parity.Text
        Configuration.Default.DataBits = dataBits.Text
        Configuration.Default.StopBits = stopBits.Text
        Configuration.Default.Save()
        portName.Enabled = False
        baudRate.Enabled = False
        parity.Enabled = False
        dataBits.Enabled = False
        stopBits.Enabled = False
        save.Enabled = False
        edit.Enabled = True
    End Sub

    Public Sub LoadConfiguation(portName As ComboBox, baudRate As ComboBox, parity As ComboBox, dataBits As ComboBox, stopBits As ComboBox)
        portName.Text = Configuration.Default.PortName
        baudRate.Text = Configuration.Default.BaudRate
        parity.Text = Configuration.Default.Parity
        dataBits.Text = Configuration.Default.DataBits
        stopBits.Text = Configuration.Default.StopBits
    End Sub

End Module
