Imports alfathNET
Module ModulDatabase
    Public _DB As New Database
    Public _FS As New Fungsi
    Public _LP As New Laporan
    Public Kondisi As Boolean



    Sub KoneksiDatabase()
        Dim IP, Username, Password, Database, Port As String
        With frm_Database
            IP = .txtipserver.Text
            Username = .txtusername.Text
            Password = .txtpassword.Text
            Database = .txtdatabase.Text
            Port = .cbport.Text


            Call _DB.Koneksi(IP, Username, Password, Database, Port, frm_Utama.StatusDB)
        End With


    End Sub

End Module
