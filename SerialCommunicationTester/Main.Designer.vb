<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cboPortName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboStopBits = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDataBits = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboParity = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBaudRate = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioString = New System.Windows.Forms.RadioButton()
        Me.radioHexadecimal = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSent = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSendText = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtReceived = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 182)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cboPortName
        '
        Me.cboPortName.Enabled = False
        Me.cboPortName.FormattingEnabled = True
        Me.cboPortName.Location = New System.Drawing.Point(76, 9)
        Me.cboPortName.Name = "cboPortName"
        Me.cboPortName.Size = New System.Drawing.Size(88, 21)
        Me.cboPortName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ports:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnDisconnect)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cboStopBits)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cboDataBits)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cboParity)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboBaudRate)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Controls.Add(Me.cboPortName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel1, 2)
        Me.Panel1.Size = New System.Drawing.Size(178, 464)
        Me.Panel1.TabIndex = 5
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Enabled = False
        Me.btnDisconnect.Location = New System.Drawing.Point(89, 182)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 18
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(89, 153)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 153)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 16
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Stop Bits:"
        '
        'cboStopBits
        '
        Me.cboStopBits.Enabled = False
        Me.cboStopBits.FormattingEnabled = True
        Me.cboStopBits.Items.AddRange(New Object() {"1", "2"})
        Me.cboStopBits.Location = New System.Drawing.Point(76, 117)
        Me.cboStopBits.Name = "cboStopBits"
        Me.cboStopBits.Size = New System.Drawing.Size(88, 21)
        Me.cboStopBits.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Data Bits:"
        '
        'cboDataBits
        '
        Me.cboDataBits.Enabled = False
        Me.cboDataBits.FormattingEnabled = True
        Me.cboDataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.cboDataBits.Location = New System.Drawing.Point(76, 90)
        Me.cboDataBits.Name = "cboDataBits"
        Me.cboDataBits.Size = New System.Drawing.Size(88, 21)
        Me.cboDataBits.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Parity:"
        '
        'cboParity
        '
        Me.cboParity.Enabled = False
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Items.AddRange(New Object() {"none", "even", "odd", "mark", "space"})
        Me.cboParity.Location = New System.Drawing.Point(76, 63)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(88, 21)
        Me.cboParity.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Baud Rate:"
        '
        'cboBaudRate
        '
        Me.cboBaudRate.Enabled = False
        Me.cboBaudRate.FormattingEnabled = True
        Me.cboBaudRate.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000", "256000"})
        Me.cboBaudRate.Location = New System.Drawing.Point(76, 36)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(88, 21)
        Me.cboBaudRate.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioString)
        Me.GroupBox1.Controls.Add(Me.radioHexadecimal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 82)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Convert"
        '
        'radioString
        '
        Me.radioString.AutoSize = True
        Me.radioString.Checked = True
        Me.radioString.Location = New System.Drawing.Point(18, 22)
        Me.radioString.Name = "radioString"
        Me.radioString.Size = New System.Drawing.Size(75, 17)
        Me.radioString.TabIndex = 4
        Me.radioString.TabStop = True
        Me.radioString.Text = "StringView"
        Me.radioString.UseVisualStyleBackColor = True
        '
        'radioHexadecimal
        '
        Me.radioHexadecimal.AutoSize = True
        Me.radioHexadecimal.Location = New System.Drawing.Point(18, 48)
        Me.radioHexadecimal.Name = "radioHexadecimal"
        Me.radioHexadecimal.Size = New System.Drawing.Size(67, 17)
        Me.radioHexadecimal.TabIndex = 5
        Me.radioHexadecimal.TabStop = True
        Me.radioHexadecimal.Text = "HexView"
        Me.radioHexadecimal.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.73613!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.26387!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.12766!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.87234!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(667, 503)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtSent)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtSendText)
        Me.Panel2.Controls.Add(Me.btnSend)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(187, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(477, 239)
        Me.Panel2.TabIndex = 7
        '
        'txtSent
        '
        Me.txtSent.BackColor = System.Drawing.Color.Black
        Me.txtSent.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtSent.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSent.Location = New System.Drawing.Point(0, 23)
        Me.txtSent.Name = "txtSent"
        Me.txtSent.Size = New System.Drawing.Size(477, 174)
        Me.txtSent.TabIndex = 10
        Me.txtSent.Text = ""
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(477, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Sent"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSendText
        '
        Me.txtSendText.Location = New System.Drawing.Point(3, 203)
        Me.txtSendText.Name = "txtSendText"
        Me.txtSendText.Size = New System.Drawing.Size(390, 20)
        Me.txtSendText.TabIndex = 8
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(399, 203)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel3, 2)
        Me.Panel3.Controls.Add(Me.lblStatus)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 473)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(661, 27)
        Me.Panel3.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(55, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(73, 13)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "Disconnected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.txtReceived)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(187, 248)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(477, 219)
        Me.Panel4.TabIndex = 10
        '
        'txtReceived
        '
        Me.txtReceived.BackColor = System.Drawing.Color.Black
        Me.txtReceived.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReceived.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceived.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtReceived.Location = New System.Drawing.Point(0, 23)
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.Size = New System.Drawing.Size(477, 196)
        Me.txtReceived.TabIndex = 11
        Me.txtReceived.Text = ""
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Received"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(667, 503)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Serial Communication Tester"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConnect As Button
    Friend WithEvents cboPortName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSend As Button
    Friend WithEvents txtSendText As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioString As RadioButton
    Friend WithEvents radioHexadecimal As RadioButton
    Friend WithEvents txtSent As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtReceived As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboStopBits As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboDataBits As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboParity As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBaudRate As ComboBox
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
End Class
