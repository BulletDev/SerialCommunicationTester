Imports System.Data
Imports System.Data.OleDb
Module DatabaseHelper

    Public con As New OleDbConnection(ConnectionString())
    Public cmd As OleDbCommand
    Public query As String = String.Empty
    Dim da As OleDbDataAdapter

    Public Function ConnectionString() As String
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath
        connString &= "\WeighBridge.accdb;Persist Security Info=False;"
        Return connString
    End Function

    Public Function GetData() As DataTable
        query = "SELECT * FROM WeighBridgeTable"
        Dim dt As New DataTable()
        Try
            cmd = New OleDbCommand(query, con)
            da = New OleDbDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dt = Nothing
        End Try
        Return dt
    End Function

    Public Sub UpdateData(ByVal rfid As Integer, ByVal weightIn As Integer, ByVal weightOut As Integer)
        query = "UPDATE WeighBridgeTable SET RifdNumber=@rfid, WeightIn=@weightIn, WeightOut=@weightOut"
        query &= "WHERE RifdNumber=@rfid"
        cmd = New OleDbCommand(query, con)
        cmd.ExecuteNonQuery()
    End Sub

End Module
