Imports System.Data.Odbc
Public Class Form_Buku
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
        da = New OdbcDataAdapter("select * from buku", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        table = ds.Tables(0)
        DataBuku.DataSource = table
        conn.Close()
    End Sub

    Private Sub Form_Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim insertquery As String
        Dim hasil As Integer

        insertquery = "insert into buku" & "(Kode_Buku, Judul, Penulis , Penerbit , Tahun_Terbit)" & "values('" & TxtKodeBuku.Text & "', " & " ' " & TxtJudul.Text & "' , " & " ' " & TxtPenulis.Text & "' , " & " ' " & TxtPenerbit.Text & "' , " & " ' " & TxtTahun.Text & "')"
        Try
            cmd = New OdbcCommand(insertquery, conn)
            cmd.Connection.Open()
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then MessageBox.Show("Buku disimpan", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilkan_data()
            TxtKodeBuku.Text = ""
            TxtJudul.Text = ""
            TxtPenulis.Text = ""
            TxtPenerbit.Text = ""
            TxtTahun.Text = ""
        Catch ex As Exception
            MessageBox.Show("failed :" & ex.Message, "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBuku.CellClick
        If DataBuku.RowCount > 0 Then
            Dim baris As Integer
            With DataBuku
                baris = .CurrentRow.Index
                TxtKodeBuku.Text = .Item(0, baris).Value
                TxtJudul.Text = .Item(1, baris).Value
                TxtPenulis.Text = .Item(2, baris).Value
                TxtPenerbit.Text = .Item(3, baris).Value
                TxtTahun.Text = .Item(4, baris).Value
            End With
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update buku set Judul = ? , Penulis = ? , Penerbit = ?, Tahun_Terbit = ?  where Kode_Buku = ?", conn) 
            With cmd
                .Parameters.AddWithValue("?", TxtJudul.Text)
                .Parameters.AddWithValue("?", TxtPenulis.Text)
                .Parameters.AddWithValue("?", TxtPenerbit.Text)
                .Parameters.AddWithValue("?", TxtTahun.Text)
                .Parameters.AddWithValue("?", TxtKodeBuku.Text)
                .ExecuteNonQuery()
                DataBuku.Refresh()

            End With
            conn.Close()
            tampilkan_data()
            TxtKodeBuku.Text = ""
            TxtJudul.Text = ""
            TxtPenulis.Text = ""
            TxtPenerbit.Text = ""
            TxtTahun.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        koneksi()
        cmd = New OdbcCommand("DELETE FROM buku WHERE Kode_Buku = '" + TxtKodeBuku.Text + "'", conn)
        With cmd
            .ExecuteNonQuery()
            .Dispose()
            DataBuku.Refresh()
        End With
        conn.Close()
        tampilkan_data()
        TxtKodeBuku.Text = ""
        TxtJudul.Text = ""
        TxtPenulis.Text = ""
        TxtPenerbit.Text = ""
        TxtTahun.Text = ""
        TxtKodeBuku.Focus()
    End Sub



End Class