<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Pengembalian
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
        Me.DataPengembalian = New System.Windows.Forms.DataGridView()
        Me.DtpTglKembali = New System.Windows.Forms.DateTimePicker()
        Me.DtpTglPinjam = New System.Windows.Forms.DateTimePicker()
        Me.CmbKodePinjam = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKodeBuku = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalDenda = New System.Windows.Forms.TextBox()
        Me.TxtDenda = New System.Windows.Forms.TextBox()
        Me.TxtJatuhTempo = New System.Windows.Forms.TextBox()
        Me.TxtNim = New System.Windows.Forms.TextBox()
        Me.TxtLamaPinjam = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataPengembalian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataPengembalian
        '
        Me.DataPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPengembalian.Location = New System.Drawing.Point(16, 37)
        Me.DataPengembalian.Name = "DataPengembalian"
        Me.DataPengembalian.RowTemplate.Height = 24
        Me.DataPengembalian.Size = New System.Drawing.Size(1266, 197)
        Me.DataPengembalian.TabIndex = 0
        '
        'DtpTglKembali
        '
        Me.DtpTglKembali.Location = New System.Drawing.Point(865, 171)
        Me.DtpTglKembali.Name = "DtpTglKembali"
        Me.DtpTglKembali.Size = New System.Drawing.Size(406, 38)
        Me.DtpTglKembali.TabIndex = 7
        '
        'DtpTglPinjam
        '
        Me.DtpTglPinjam.Location = New System.Drawing.Point(865, 50)
        Me.DtpTglPinjam.Name = "DtpTglPinjam"
        Me.DtpTglPinjam.Size = New System.Drawing.Size(406, 38)
        Me.DtpTglPinjam.TabIndex = 7
        '
        'CmbKodePinjam
        '
        Me.CmbKodePinjam.FormattingEnabled = True
        Me.CmbKodePinjam.Location = New System.Drawing.Point(224, 53)
        Me.CmbKodePinjam.Name = "CmbKodePinjam"
        Me.CmbKodePinjam.Size = New System.Drawing.Size(266, 39)
        Me.CmbKodePinjam.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Pinjam"
        '
        'TxtKodeBuku
        '
        Me.TxtKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKodeBuku.Location = New System.Drawing.Point(224, 106)
        Me.TxtKodeBuku.Name = "TxtKodeBuku"
        Me.TxtKodeBuku.Size = New System.Drawing.Size(266, 38)
        Me.TxtKodeBuku.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(1289, 37)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(168, 62)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(532, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Pengembalian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Pinjam"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataPengembalian)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 473)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1299, 240)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pengmbalian"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpTglKembali)
        Me.GroupBox2.Controls.Add(Me.DtpTglPinjam)
        Me.GroupBox2.Controls.Add(Me.CmbKodePinjam)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtTotalDenda)
        Me.GroupBox2.Controls.Add(Me.TxtDenda)
        Me.GroupBox2.Controls.Add(Me.TxtJatuhTempo)
        Me.GroupBox2.Controls.Add(Me.TxtNim)
        Me.GroupBox2.Controls.Add(Me.TxtLamaPinjam)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtKodeBuku)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BtnSave)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1463, 313)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Pengembalian Buku"
        '
        'TxtTotalDenda
        '
        Me.TxtTotalDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDenda.Location = New System.Drawing.Point(1181, 254)
        Me.TxtTotalDenda.Name = "TxtTotalDenda"
        Me.TxtTotalDenda.Size = New System.Drawing.Size(266, 38)
        Me.TxtTotalDenda.TabIndex = 3
        '
        'TxtDenda
        '
        Me.TxtDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDenda.Location = New System.Drawing.Point(661, 257)
        Me.TxtDenda.Name = "TxtDenda"
        Me.TxtDenda.Size = New System.Drawing.Size(266, 38)
        Me.TxtDenda.TabIndex = 3
        '
        'TxtJatuhTempo
        '
        Me.TxtJatuhTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJatuhTempo.Location = New System.Drawing.Point(208, 257)
        Me.TxtJatuhTempo.Name = "TxtJatuhTempo"
        Me.TxtJatuhTempo.Size = New System.Drawing.Size(266, 38)
        Me.TxtJatuhTempo.TabIndex = 3
        '
        'TxtNim
        '
        Me.TxtNim.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNim.Location = New System.Drawing.Point(224, 161)
        Me.TxtNim.Name = "TxtNim"
        Me.TxtNim.Size = New System.Drawing.Size(266, 38)
        Me.TxtNim.TabIndex = 3
        '
        'TxtLamaPinjam
        '
        Me.TxtLamaPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLamaPinjam.Location = New System.Drawing.Point(865, 112)
        Me.TxtLamaPinjam.Name = "TxtLamaPinjam"
        Me.TxtLamaPinjam.Size = New System.Drawing.Size(266, 38)
        Me.TxtLamaPinjam.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(994, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 32)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Denda"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(559, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 32)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Denta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 32)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Jatuh Tempo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(532, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 32)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Lama Pinjam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kode Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(161, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 29)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Universitas Duta Bangsa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(159, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(477, 44)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Input Pengembalian Buku"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1487, 136)
        Me.Panel1.TabIndex = 15
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(898, 50)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(406, 22)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Form_Pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1487, 720)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_Pengembalian"
        Me.Text = "Form Pengembalian"
        CType(Me.DataPengembalian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataPengembalian As System.Windows.Forms.DataGridView
    Friend WithEvents DtpTglKembali As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpTglPinjam As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbKodePinjam As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtTotalDenda As System.Windows.Forms.TextBox
    Friend WithEvents TxtDenda As System.Windows.Forms.TextBox
    Friend WithEvents TxtJatuhTempo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNim As System.Windows.Forms.TextBox
    Friend WithEvents TxtLamaPinjam As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
