Imports System.Data.OleDb
Module Module1

    Public str As String
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public Tabel As OleDbDataAdapter



    Sub koneksi()
        str = “Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Db_upomset.accdb”
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        Else
            MsgBox(“Koneksi gagal”)

        End If

    End Sub

End Module