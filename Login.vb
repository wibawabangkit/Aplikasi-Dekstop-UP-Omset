Imports System.Data.OleDb

Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("login yang benar")
            Exit Sub
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Me.Hide()
                Menu_Utama.ShowDialog()
            Else
                MsgBox("username atau Password salah")
            End If
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 8
        TextBox2.PasswordChar = "*"
    End Sub

End Class
