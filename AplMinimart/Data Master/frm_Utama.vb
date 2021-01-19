Public Class frm_Utama

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusTanggal.Text = Format(Now, "dd-MM-yyyy")
        StatusJam.Text = Format(Now, "hh:mm:ss")

    End Sub

    Private Sub KoneksiDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KoneksiDatabaseToolStripMenuItem.Click
        Call _FS.FormShow(False, frm_Database, Me)
    End Sub

    Private Sub DataJenisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJenisToolStripMenuItem.Click
        Call _FS.FormShow(True, frm_DataJenis, Me)
    End Sub

    Private Sub DataMerkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataMerkToolStripMenuItem.Click
        Call _FS.FormShow(True, frm_DataMerk, Me)
    End Sub

    Private Sub DataSatuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSatuanToolStripMenuItem.Click
        Call _FS.FormShow(True, frm_DataSatuan, Me)
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        Call _FS.FormShow(True, frm_DataBarang, Me)
    End Sub
End Class
