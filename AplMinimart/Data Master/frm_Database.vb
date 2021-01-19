Public Class frm_Database


    Private Sub btnkoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkoneksi.Click
        If txtipserver.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or txtdatabase.Text = "" Or cbport.Text = "" Then
            MsgBox("Settingan belum lengkap", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call KoneksiDatabase()
            Me.Close()
        End If
    End Sub
End Class