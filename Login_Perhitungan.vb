Imports System.Data.OleDb
Public Class Login_Perhitungan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Login Gagal!!!")
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where password='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Me.Close()
                TextBox1.Clear()
                PLaba.ShowDialog()
            Else
                MsgBox(" Anda Bukan Admin !!")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Login_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"
    End Sub
End Class