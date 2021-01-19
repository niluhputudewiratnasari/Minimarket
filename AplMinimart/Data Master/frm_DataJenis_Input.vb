Public Class frm_DataJenis_Input
    Private Sub IDOtomatis()
        Dim tgl, jam As String
        tgl = Format(Now, "ddMMyy")
        jam = Format(Now, "hhmmss")

        Dim id As String = "JNS-" & tgl & jam
        TextBox1.Text = id
    End Sub

    Private Sub frm_DataJenis_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Kondisi = True Then
            Call IDOtomatis()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            If Kondisi = True Then
                Call _DB.manipulasi("INSERT IGNORE INTO TABEL_JENIS VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", "Simpan")
            Else
                Call _DB.manipulasi("UPDATE TABEL_JENIS SET NAMA_JENIS='" & TextBox2.Text & "',KETERANGAN='" & TextBox3.Text & "' WHERE ID_JENIS='" & TextBox1.Text & "'", "Ubah")
            End If
            Call IDOtomatis()
            TextBox2.Clear()
            TextBox3.Clear()
            Call frm_DataJenis.RefreshDataJenis()
            Kondisi = True
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim tanya As Object
        tanya = MsgBox("Yakin data dihapus ? ", MsgBoxStyle.Question + vbYesNo, "Informasi") = vbYes = True
        If tanya = True Then
            Call _DB.manipulasi("DELETE FROM TABEL_JENIS WHERE ID_JENIS ='" & TextBox1.Text & "'", "Hapus")
            Call IDOtomatis()
            TextBox2.Clear()
            TextBox3.Clear()
            Call frm_DataJenis.RefreshDataJenis()
            Kondisi = True
        End If
    End Sub
End Class