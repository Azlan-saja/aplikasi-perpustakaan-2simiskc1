Public Class Menu_Utama


    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        Form_Anggota.Show()
        Form_Anggota.MdiParent = Me
    End Sub

    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Form_Buku.Show()
        Form_Buku.MdiParent = Me
    End Sub

    Private Sub PeminjamanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        Form_Peminjaman.MdiParent = Me
        Form_Peminjaman.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        Form_Pengembalian.MdiParent = Me
        Form_Pengembalian.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        End
    End Sub

    Private Sub Menu_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class