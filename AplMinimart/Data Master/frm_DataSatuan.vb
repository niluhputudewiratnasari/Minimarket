Public Class frm_DataSatuan
    Public Sub RefreshDataSatuan()
        Call _DB.tampilTabel1(GridDataSatuan, "SELECT * FROM tabel_satuan")

        With GridDataSatuan
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "ID Satuan"
            .Columns(1).Width = 250
            .Columns(1).HeaderText = "Jenis Satuan"
            .Columns(2).Width = 350
        End With
    End Sub
    Private Sub frm_DataSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RefreshDataSatuan()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        Kondisi = True
        _FS.FormShow(False, frm_DataSatuan_Input, Me)

    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataSatuan
            frm_DataSatuan_Input.TextBox1.Text = .Item(0, .CurrentRow.Index).Value
            frm_DataSatuan_Input.TextBox2.Text = .Item(1, .CurrentRow.Index).Value
            frm_DataSatuan_Input.TextBox3.Text = .Item(2, .CurrentRow.Index).Value

            Kondisi = False
            _FS.FormShow(False, frm_DataSatuan_Input, Me)
        End With
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Try
            _DB.cariData1(GridDataSatuan, "SELECT * FROM TABEL_SATUAN WHERE SATUAN LIKE '%" & txtpencarian.Text & "%'")
            With GridDataSatuan
                .Columns(0).Width = 150
                .Columns(0).HeaderText = "ID Satuan"
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "Jenis Satuan"
                .Columns(2).Width = 350
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class