Imports System.Data.OleDb

Public Class Input_Barang
    Dim Data As New DataSet
    Dim Sqlstring As String = "select * from tbl_barang order by item_barang"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Txtnama.Text = "" Or Txtitem.Text = "" Or Txtjumlah.Text = "" Or Txtharga.Text = "" Then
            MsgBox("Data Masih Ada yang Kosong !", MsgBoxStyle.Critical, "Perhatian")
            Txtitem.Focus()
        Else
            koneksi()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into tbl_barang (nama_barang,item_barang,jumlah,harga_satuan) values ('" & Txtnama.Text & "','" & Txtitem.Text & "', '" & Txtjumlah.Text & "', '" & Txtharga.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Perhatian")
            Txtnama.Clear()
            Txtitem.Clear()
            Txtjumlah.Clear()
            Txtharga.Clear()
            Txtnama.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Input_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Data As New DataSet
        Dim Sqlstring As String = "select * from tbl_barang order by item_barang"
        koneksi()
        Tabel = New OleDbDataAdapter(Sqlstring, conn)
        Tabel.Fill(Data, "tbl_barang")
        DataGridView1.DataSource = Data.Tables("tbl_barang")
        Label6.Text = "Jumlah Data= " & DataGridView1.RowCount
        conn.Close()

        DataGridView1.GridColor = Color.Red
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.BackgroundColor = Color.LightGray

        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToResizeColumns = False

        DataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Txtitem.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan Item")
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim cmd As OleDbCommand
                Dim hapus As String = "delete From tbl_barang  where item_barang='" & Txtitem.Text & "'"
                cmd = New OleDbCommand(hapus, conn)
                cmd.ExecuteNonQuery()
            End If
        End If
    End Sub
End Class