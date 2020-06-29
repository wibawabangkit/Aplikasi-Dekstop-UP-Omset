Public Class Menu_Utama


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Data_Barang.ShowDialog()

    End Sub

    Private Sub PerhitunganLabaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerhitunganLabaToolStripMenuItem.Click
        Login_Perhitungan.ShowDialog()

    End Sub

    Private Sub InputDataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Input_Barang.ShowDialog()

    End Sub

    Private Sub KalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Kalkulator.ShowDialog()

    End Sub

    Private Sub PekembanganUsahaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PekembanganUsahaToolStripMenuItem.Click
        Perkembangan_Usaha.ShowDialog()

    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Ganti_Password.ShowDialog()

    End Sub

    Private Sub DataBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem1.Click
        Login_DataBarang.ShowDialog()
    End Sub

    Private Sub InputBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputBarangToolStripMenuItem.Click
        Input_Barang.ShowDialog()
    End Sub

    Private Sub KalkulatorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KalkulatorToolStripMenuItem1.Click
        kalkulator.ShowDialog()
    End Sub

    Private Sub TargetPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TargetPenjualanToolStripMenuItem.Click
        Login_Target.ShowDialog()
    End Sub

    Private Sub TargetPenjualamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TargetPenjualamToolStripMenuItem.Click
        Target_Penjualan.ShowDialog()
    End Sub
End Class