<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeighBridgeSimulator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoWithTruckIn = New System.Windows.Forms.RadioButton()
        Me.rdoNoTuckIn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoWithTruckOut = New System.Windows.Forms.RadioButton()
        Me.rdoNoTruckOut = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRfid = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtWeighIn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWeighOut = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtWeighIn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rdoWithTruckIn)
        Me.GroupBox1.Controls.Add(Me.rdoNoTuckIn)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weigh In"
        '
        'rdoWithTruckIn
        '
        Me.rdoWithTruckIn.AutoSize = True
        Me.rdoWithTruckIn.Location = New System.Drawing.Point(18, 63)
        Me.rdoWithTruckIn.Name = "rdoWithTruckIn"
        Me.rdoWithTruckIn.Size = New System.Drawing.Size(100, 17)
        Me.rdoWithTruckIn.TabIndex = 1
        Me.rdoWithTruckIn.Text = "Truck Detected"
        Me.rdoWithTruckIn.UseVisualStyleBackColor = True
        '
        'rdoNoTuckIn
        '
        Me.rdoNoTuckIn.AutoSize = True
        Me.rdoNoTuckIn.Checked = True
        Me.rdoNoTuckIn.Location = New System.Drawing.Point(18, 31)
        Me.rdoNoTuckIn.Name = "rdoNoTuckIn"
        Me.rdoNoTuckIn.Size = New System.Drawing.Size(70, 17)
        Me.rdoNoTuckIn.TabIndex = 0
        Me.rdoNoTuckIn.TabStop = True
        Me.rdoNoTuckIn.Text = "No Truck"
        Me.rdoNoTuckIn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtWeighOut)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.rdoWithTruckOut)
        Me.GroupBox2.Controls.Add(Me.rdoNoTruckOut)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weigh Out"
        '
        'rdoWithTruckOut
        '
        Me.rdoWithTruckOut.AutoSize = True
        Me.rdoWithTruckOut.Location = New System.Drawing.Point(12, 64)
        Me.rdoWithTruckOut.Name = "rdoWithTruckOut"
        Me.rdoWithTruckOut.Size = New System.Drawing.Size(100, 17)
        Me.rdoWithTruckOut.TabIndex = 3
        Me.rdoWithTruckOut.Text = "Truck Detected"
        Me.rdoWithTruckOut.UseVisualStyleBackColor = True
        '
        'rdoNoTruckOut
        '
        Me.rdoNoTruckOut.AutoSize = True
        Me.rdoNoTruckOut.Checked = True
        Me.rdoNoTruckOut.Location = New System.Drawing.Point(12, 32)
        Me.rdoNoTruckOut.Name = "rdoNoTruckOut"
        Me.rdoNoTruckOut.Size = New System.Drawing.Size(70, 17)
        Me.rdoNoTruckOut.TabIndex = 2
        Me.rdoNoTruckOut.TabStop = True
        Me.rdoNoTruckOut.Text = "No Truck"
        Me.rdoNoTruckOut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RFID:"
        '
        'txtRfid
        '
        Me.txtRfid.Enabled = False
        Me.txtRfid.Location = New System.Drawing.Point(15, 34)
        Me.txtRfid.Name = "txtRfid"
        Me.txtRfid.Size = New System.Drawing.Size(153, 20)
        Me.txtRfid.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(174, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(417, 307)
        Me.DataGridView1.TabIndex = 4
        '
        'txtWeighIn
        '
        Me.txtWeighIn.Enabled = False
        Me.txtWeighIn.Location = New System.Drawing.Point(59, 93)
        Me.txtWeighIn.Name = "txtWeighIn"
        Me.txtWeighIn.Size = New System.Drawing.Size(85, 20)
        Me.txtWeighIn.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Weight:"
        '
        'txtWeighOut
        '
        Me.txtWeighOut.Enabled = False
        Me.txtWeighOut.Location = New System.Drawing.Point(59, 87)
        Me.txtWeighOut.Name = "txtWeighOut"
        Me.txtWeighOut.Size = New System.Drawing.Size(85, 20)
        Me.txtWeighOut.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Weight:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "0"
        '
        'WeighBridgeSimulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 340)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtRfid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WeighBridgeSimulator"
        Me.ShowIcon = False
        Me.Text = "Weigh Bridge Simulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRfid As TextBox
    Friend WithEvents rdoWithTruckIn As RadioButton
    Friend WithEvents rdoNoTuckIn As RadioButton
    Friend WithEvents rdoWithTruckOut As RadioButton
    Friend WithEvents rdoNoTruckOut As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtWeighIn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeighOut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
