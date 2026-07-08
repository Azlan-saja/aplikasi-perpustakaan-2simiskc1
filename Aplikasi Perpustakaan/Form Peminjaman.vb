Imports System.Data.Odbc
Public Class Form_Peminjaman
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
        da = New OdbcDataAdapter("select * from peminjaman", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        table = ds.Tables(0)
        DataPeminjaman.DataSource = table
        conn.Close()
    End Sub
    Sub tampilDataComboBox1()
        Call koneksi()
        Dim str As String
        str = "select Nim from anggota"
        cmd = New OdbcCommand(str, conn)
        RD = cmd.ExecuteReader
        If RD.HasRows Then
            Do While RD.Read
                CmbNim.Items.Add(RD("Nim"))
            Loop
        Else

        End If
        conn.Close()
    End Sub

    Sub tampilDataComboBox2()
        Call koneksi()
        Dim str As String
        str = "select Kode_Buku from buku"
        cmd = New OdbcCommand(str, conn)
        RD = cmd.ExecuteReader
        If RD.HasRows Then
            Do While RD.Read
                CmbKodeBuku.Items.Add(RD("Kode_Buku"))
            Loop
        Else

        End If
        conn.Close()
    End Sub

    Private Sub Form_Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
        tampilDataComboBox1()
        tampilDataComboBox2()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim insertquery As String
        Dim hasil As Integer

        insertquery = "insert into peminjaman" & "(Kode_Pinjam, Kode_Buku, Nim, Tanggal_Pinjam , Tanggal_Kembali)" & _
            "values('" & TxtKodePinjam.Text & "', " & "'" & CmbKodeBuku.Text & "' , " & _
            "'" & CmbNim.Text & "' , " & "'" & Format(DtpTglPinjam.Value, "yyyy-MM-dd") & _
            "' , " & "'" & Format(DtpLamaPinjam.Value, "yyyy-MM-dd") & "')"

        Try
            cmd = New OdbcCommand(insertquery, conn)
            cmd.Connection.Open()
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then MessageBox.Show("Peminjaman Sukses", "OK",
MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkan_data()
            TxtKodePinjam.Text = ""
            CmbKodeBuku.Text = ""
            CmbNim.Text = ""
            TxtKodePinjam.Focus()
            DataPeminjaman.Refresh()
        Catch ex As Exception
            MessageBox.Show("failed :" & ex.Message, "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Close()
    End Sub


End Class