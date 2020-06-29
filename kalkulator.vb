Public Class kalkulator
    Dim bil1, bil2, hasil As Integer



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bil1 = TextBox1.Text
        bil2 = TextBox2.Text
        hasil = bil1 * bil2
        MsgBox(hasil, , "Hasilnya")
        TextBox1.Clear()
        TextBox2.Clear()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bil1 = TextBox1.Text
        bil2 = TextBox2.Text
        hasil = bil1 + bil2
        MsgBox(hasil, , "Hasilnya")
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        bil1 = TextBox1.Text
        bil2 = TextBox2.Text
        hasil = bil1 / bil2
        MsgBox(hasil, , "Hasilnya")
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bil1 = TextBox1.Text
        bil2 = TextBox2.Text
        hasil = bil1 ^ bil2
        MsgBox(hasil, , "Hasilnya")
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


End Class
