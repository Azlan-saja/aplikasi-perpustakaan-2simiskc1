Imports System.Data.Odbc
Public Class Form_Login

    Private Shared DSN As String = "Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Port=3307;Database=project;User=root;Password=;"
    Dim conn As OdbcConnection

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            conn = New OdbcConnection(DSN)
            conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal. " & ex.ToString)
        End Try
        Dim myadapter As New OdbcDataAdapter
        Dim sqlQuery = "SELECT * FROM user WHERE username='" + TxtUsername.Text + "' AND password='" + TxtPassword.Text + "'"
        Dim myCommand As New OdbcCommand
        myCommand.Connection = conn
        myCommand.CommandText = sqlQuery

        myadapter.SelectCommand = myCommand
        Dim myData As OdbcDataReader
        myData = myCommand.ExecuteReader()
        If myData.HasRows = 0 Then
            MsgBox("Username / Password salah", MsgBoxStyle.Exclamation, "Error Login ")
        Else
            MsgBox("Login Berhasil, Selamat Datang " & TxtUsername.Text & "!", MsgBoxStyle.Information, "Sukses Login")
            BtnPinjam.Enabled = True
            BtnBuku.Enabled = True
            BtnAnggota.Enabled = True
            BtnKembali.Enabled = True
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            Menu_Utama.Show()
            Me.Hide()
        End If
    End Sub
End Class