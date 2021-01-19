Public Class frm_DataMerk
    Public Sub RefreshDataMerk()
        Call _DB.tampilTabel1(GridDataMerk, "SELECT * FROM tabel_merk")

        With GridDataMerk
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "ID Merk"
            .Columns(1).Width = 250
            .Columns(1).HeaderText = "Merk"
            .Columns(2).Width = 350
        End With
    End Sub

    Private Sub frm_DataMerk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataMerk()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        Kondisi = True
        _FS.FormShow(False, frm_DataMerk_Input, Me)

    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataMerk
            frm_DataMerk_Input.TextBox1.Text = .Item(0, .CurrentRow.Index).Value
            frm_DataMerk_Input.TextBox2.Text = .Item(1, .CurrentRow.Index).Value
            frm_DataMerk_Input.TextBox3.Text = .Item(2, .CurrentRow.Index).Value

            Kondisi = False
            _FS.FormShow(False, frm_DataMerk_Input, Me)
        End With
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Try
            _DB.cariData1(GridDataMerk, "SELECT * FROM TABEL_MERK WHERE NAMA_MERK LIKE '%" & txtpencarian.Text & "%'")
            With GridDataMerk
                .Columns(0).Width = 150
                .Columns(0).HeaderText = "ID Merk"
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "Merk"
                .Columns(2).Width = 350
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class