Public Class frm_DataBarang
    Public Sub RefreshDataBarang()
        Call _DB.tampilTabel1(GridDataBarang, "SELECT * FROM tabel_barang")

        With GridDataBarang
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "Barcode"
            .Columns(1).Width = 250
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).Width = 150
            .Columns(2).HeaderText = "Harga Beli"
            .Columns(3).Width = 250
            .Columns(3).HeaderText = "Harga Jual"
            .Columns(4).Width = 150
            .Columns(4).HeaderText = "Selisih Harga"
            .Columns(5).Width = 250
            .Columns(5).HeaderText = "Sub Total Selisih"
            .Columns(6).Width = 150
            .Columns(6).HeaderText = "Stik"
            .Columns(7).Width = 250
            .Columns(7).HeaderText = "ID Jenis"
            .Columns(8).Width = 150
            .Columns(8).HeaderText = "ID Satuan"
            .Columns(9).Width = 250
            .Columns(9).HeaderText = "ID Merk"
        End With
    End Sub

    Private Sub frm_DataBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call _DB.tampilTabel1(GridDataBarang, "SELECT * FROM tabel_barang")
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        Kondisi = True
        _FS.FormShow(False, frm_DataBarang_Input, Me)
    End Sub

    Private Sub PilihDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilihDataToolStripMenuItem.Click
        With GridDataBarang
            frm_DataBarang_Input.TextBox1.Text = .Item(0, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox2.Text = .Item(1, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox3.Text = .Item(2, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox4.Text = .Item(3, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox5.Text = .Item(4, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox6.Text = .Item(5, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox7.Text = .Item(6, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox8.Text = .Item(7, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox9.Text = .Item(8, .CurrentRow.Index).Value
            frm_DataBarang_Input.TextBox10.Text = .Item(9, .CurrentRow.Index).Value
            Kondisi = False
            _FS.FormShow(False, frm_DataBarang_Input, Me)
        End With
    End Sub

    Private Sub txtpencarian_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpencarian.TextChanged
        Try
            _DB.cariData1(GridDataBarang, "SELECT * FROM TABEL_BARANG WHERE NAMA_BARANG LIKE '%" & txtpencarian.Text & "%'")
            With GridDataBarang
                .Columns(0).Width = 150
                .Columns(0).HeaderText = "Barcode"
                .Columns(1).Width = 250
                .Columns(1).HeaderText = "Nama Barang"
                .Columns(2).Width = 150
                .Columns(2).HeaderText = "Harga Beli"
                .Columns(3).Width = 250
                .Columns(3).HeaderText = "Harga Jual"
                .Columns(4).Width = 150
                .Columns(4).HeaderText = "Selisih Harga"
                .Columns(5).Width = 250
                .Columns(5).HeaderText = "Sub Total Selisih"
                .Columns(6).Width = 150
                .Columns(6).HeaderText = "Stik"
                .Columns(7).Width = 250
                .Columns(7).HeaderText = "ID Jenis"
                .Columns(8).Width = 150
                .Columns(8).HeaderText = "ID Satuan"
                .Columns(9).Width = 250
                .Columns(9).HeaderText = "ID Merk"
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class