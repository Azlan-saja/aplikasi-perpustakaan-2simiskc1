Imports System.Data.Odbc
Public Class Form_Anggota

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
        da = New OdbcDataAdapter("select * from anggota", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        table = ds.Tables(0)
        DataAnggota.DataSource = table
        conn.Close()
    End Sub

    Private Sub Form_Anggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkan_data()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim insertquery As String
        Dim hasil As Integer

        insertquery = "insert into anggota" & "(Nim, Nama, Kelas ,Jurusan ,No_Hp)" & "values('" & TxtNim.Text & "', " & " ' " & TxtNama.Text & "' , " & " ' " & TxtKelas.Text & "' , " & " ' " & TxtJurusan.Text & "' , " & " ' " & TxtHp.Text & "')"
        Try
            cmd = New OdbcCommand(insertquery, conn)
            cmd.Connection.Open()
            hasil = cmd.ExecuteNonQuery()
            If (hasil > 0) Then MessageBox.Show("Berhasil Menambahkan Data", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNim.Text = ""
            TxtNama.Text = ""
            TxtKelas.Text = ""
            TxtJurusan.Text = ""
            TxtHp.Text = ""
            tampilkan_data()
        Catch ex As Exception
            MessageBox.Show("failed :" & ex.Message, "gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

     Private Sub DataAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataAnggota.CellClick 
        If DataAnggota.RowCount > 0 Then
            Dim baris As Integer
            With DataAnggota
                baris = .CurrentRow.Index
                TxtNim.Text = .Item(0, baris).Value
                TxtNama.Text = .Item(1, baris).Value
                TxtKelas.Text = .Item(2, baris).Value
                TxtJurusan.Text = .Item(3, baris).Value
                TxtHp.Text = .Item(4, baris).Value
            End With
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            koneksi()
            cmd = New OdbcCommand("update anggota set Nama = ? , Kelas = ? , Jurusan = ? , No_Hp = ? where Nim = ?", conn) 
            With cmd
                .Parameters.AddWithValue("?", TxtNama.Text)
                .Parameters.AddWithValue("?", TxtKelas.Text)
                .Parameters.AddWithValue("?", TxtJurusan.Text)
                .Parameters.AddWithValue("?", TxtHp.Text)
                .Parameters.AddWithValue("?", TxtNim.Text)
                .ExecuteNonQuery()
                DataAnggota.Refresh()

            End With
            conn.Close()
            tampilkan_data()
            TxtNim.Text = ""
            TxtNama.Text = ""
            TxtKelas.Text = ""
            TxtJurusan.Text = ""
            TxtHp.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        koneksi()
        cmd = New OdbcCommand("DELETE FROM anggota WHERE Nim = '" + TxtNim.Text + "'", conn) 
        With cmd
            .ExecuteNonQuery()
            .Dispose()
            DataAnggota.Refresh()

        End With
        conn.Close()
        tampilkan_data()
        TxtNim.Text = ""
        TxtNama.Text = ""
        TxtKelas.Text = ""
        TxtJurusan.Text = ""
        TxtHp.Text = ""
        TxtNim.Focus()
    End Sub
End Class