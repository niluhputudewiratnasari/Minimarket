Public Class frm_DataBarang_Input
    Private Sub IDOtomatis()
        Dim tgl, jam As String
        tgl = Format(Now, "ddMMyy")
        jam = Format(Now, "hhmmss")

        Dim id As String = "BRG-" & tgl & jam
        TextBox1.Text = id
    End Sub

    Private Sub frm_DataBarang_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Kondisi = True Then
            Call IDOtomatis()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            If Kondisi = True Then
                Call _DB.manipulasi("INSERT IGNORE INTO TABEL_BARANG VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "', '" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')", "Simpan")
            Else
                Call _DB.manipulasi("UPDATE TABEL_BARANG SET NAMA_BARANG='" & TextBox2.Text & "',HARGA_BELI='" & TextBox3.Text & "', HARGA_JUAL='" & TextBox4.Text & "',SELISIH_HARGA='" & TextBox5.Text & "', SUB_TOTAL_SELISIH='" & TextBox6.Text & "',STOK='" & TextBox7.Text & "', ID_JENIS='" & TextBox8.Text & "',ID_SATUAN='" & TextBox9.Text & "' ,ID_MERK='" & TextBox10.Text & "' WHERE BARCODE='" & TextBox1.Text & "'", "Ubah")
            End If
            Call IDOtomatis()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            Call frm_DataBarang.RefreshDataBarang()
            Kondisi = True
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim tanya As Object
        tanya = MsgBox("Yakin data dihapus ? ", MsgBoxStyle.Question + vbYesNo, "Informasi") = vbYes = True
        If tanya = True Then
            Call _DB.manipulasi("DELETE FROM TABEL_BARANG WHERE  BARCODE='" & TextBox1.Text & "'", "Hapus")
            Call IDOtomatis()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox10.Clear()
            Call frm_DataBarang.RefreshDataBarang()
            Kondisi = True
        End If
    End Sub
End Class