Imports System.Data.Odbc
Public Class Form_Pengembalian
    Private Shared DSN As String = "Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Port=3307;Database=project;User=root;Password=;"
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim RD As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim ds As DataSet
    Dim table As DataTable


    Sub koneksi()
        conn = New OdbcConnection(DSN)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub tampilkan_data()
        koneksi()
        da = New OdbcDataAdapter("select * from pengembalian", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "peminjaman")
        DataPengembalian.DataSource = (ds.Tables("peminjaman"))
        cmd = New OdbcCommand("select * FROM peminjaman", conn)
        RD = cmd.ExecuteReader
        Do While RD.Read
            CmbKodePinjam.Items.Add(RD.Item(0))
        Loop
    End Sub


    Private Sub Form_Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
    End Sub

    Private Sub CmbKodePinjam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKodePinjam.SelectedIndexChanged
        cmd = New OdbcCommand("Select * from peminjaman where Kode_Pinjam='" & CmbKodePinjam.Text & "'", conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TxtKodeBuku.Text = RD.Item("Kode_Buku")
            TxtNim.Text = RD.Item("Nim")
            DtpTglPinjam.Value = RD.Item("Tanggal_Pinjam")
            DateTimePicker2.Value = RD.Item("Tanggal_Kembali")
            DtpTglPinjam.Enabled = False
            TxtLamaPinjam.Text = DateDiff(DateInterval.Day, DtpTglPinjam.Value, DateTimePicker2.Value) & " Hari"
        End If
    End Sub
    Private Sub DtpTglKembali_ValueChanged(sender As Object, e As EventArgs) Handles DtpTglKembali.ValueChanged
        TxtJatuhTempo.Text = DateDiff(DateInterval.Day, DateTimePicker2.Value, DtpTglKembali.Value)
    End Sub

    Private Sub TxtDenda_TextChanged(sender As Object, e As EventArgs) Handles TxtDenda.TextChanged
        TxtTotalDenda.Text = TxtJatuhTempo.Text * TxtDenda.Text
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        conn.Close()
        Dim insertquery As String
        Dim hasil As Integer


        insertquery = "insert into pengembalian" & "(Kode_Pinjam, Kode_Buku, Nim, Tanggal_Pinjam , Tanggal_Kembali, Jatuh_Tempo, Denda_Perhari, Total_Denda)" & "values('" & CmbKodePinjam.Text & "', " & " ' " & TxtKodeBuku.Text & "' , " & " ' " & TxtNim.Text & "' , " & " ' " & Format(DtpTglPinjam.Value, "yyyy-MM-dd") & "' , " & " ' " & Format(DtpTglKembali.Value, "yyyy-MM-dd") & "', " & " ' " & TxtJatuhTempo.Text & "', " & " ' " & TxtDenda.Text & "', " & " ' " & TxtTotalDenda.Text & "'   )"
        Try
            cmd = New OdbcCommand(insertquery, conn)
            cmd.Connection.Open()
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then MessageBox.Show("Buku dikembalikan", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd = New OdbcCommand("DELETE FROM peminjaman WHERE Kode_Pinjam = '" + CmbKodePinjam.Text + "'", conn) 
            With cmd
                .ExecuteNonQuery()
                .Dispose()
                DataPengembalian.Refresh()
            End With
            conn.Close()
            tampilkan_data()
            CmbKodePinjam.Text = ""
            CmbKodePinjam.Focus()
        Catch ex As Exception
            MessageBox.Show("failed :" & ex.Message, "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class