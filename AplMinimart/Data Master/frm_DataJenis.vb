Public Class frm_DataJenis
    Public Sub RefreshDataJenis()
        Call _DB.tampilTabel1(GridDataJenis, "SELECT * FROM tabel_jenis")

        With GridDataJenis
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "ID Jenis"
            .Columns(1).Width = 250
            .Columns(1).HeaderText = "Jenis Barang"
            .Columns(2).Width = 350
        End With
    End Sub

    Private Sub frm_DataJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataJenis()
    End Sub



    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        Kondisi = True
        _FS.FormShow(False, frm_DataJenis_Input, Me)

    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataJenis
            frm_DataJenis_Input.TextBox1.Text = .Item(0, .CurrentRow.Index).Value
            frm_DataJenis_Input.TextBox2.Text = .Item(1, .CurrentRow.Index).Value
            frm_DataJenis_Input.TextBox3.Text = .Item(2, .CurrentRow.Index).Value

            Kondisi = False
            _FS.FormShow(False, frm_DataJenis_Input, Me)
        End With
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Try
            _DB.cariData1(GridDataJenis, "SELECT * FROM TABEL_JENIS WHERE NAMA_JENIS LIKE '%" & txtpencarian.Text & "%'")
            With GridDataJenis
                .Columns(0).Width = 150
                .Columns(0).HeaderText = "ID Jenis"
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "Jenis Barang"
                .Columns(2).Width = 350
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class