Public Class PLaba

    Private Sub PLaba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim operasional As Double
        Dim Bahan As Double
        Dim Total As Double
        operasional = txtoper1.Text
        Bahan = txtbahan1.Text
        Total = operasional + Bahan
        Txttotal1.Text = Total
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim operasional As Double
        Dim Bahan As Double
        Dim Total As Double
        Bahan = txtbahan2.Text
        operasional = txtoper2.Text
        Total = operasional + Bahan
        Txttotal2.Text = Total
    End Sub


    Sub TotalA1lebihbesar()
        Dim operasional1, operasional2, operasional3 As Integer
        Dim Bahan1, Bahan2, Bahan3 As Integer
        Dim Total1, Total2, Total3 As Integer

        operasional1 = txtoper1b.Text
        operasional2 = txtbahan1b.Text
        operasional3 = txttotal1b.Text

        Bahan1 = txtoper2b.Text
        Bahan2 = txtbahan2b.Text
        Bahan3 = txttotal2b.Text
        Total1 = operasional1 - Bahan1
        Total2 = operasional2 - Bahan2
        Total3 = operasional3 - Bahan3

        txttotaloper1.Text = Total1
        txttotalbahan1.Text = Total2
        txttotalA.Text = Total3

    End Sub
    Private Sub btnharga1_Click(sender As Object, e As EventArgs) Handles btnharga1.Click

        txthargasatuanA.Text = txttotalA.Text - txttotal2b.Text
        If txtbahan1b.Text > txtbahan2b.Text Or txttotal1b.Text > txttotal2b.Text Then
            txtoper1.Text = txtoper1.Text * 1
            txtbbahan1.Text = txttotalA.Text * txtbahan1.Text
            txtbtotal1.Text = Txttotal1.Text * 1
            Call TotalA1lebihbesar()
        Else
            MsgBox("Silahkan Tekan Bulatkan")

        End If

    End Sub
    Sub prosesBarang1()

        txtoper1b.Text = txtoper1.Text * txtoper2.Text
        txtbahan1b.Text = txtoper2.Text * txtbahan1.Text
        txttotal1b.Text = txtoper2.Text * Txttotal1.Text

        txtoper2b.Text = txtoper1.Text * txtoper2.Text
        txtbahan2b.Text = txtoper1.Text * txtbahan2.Text
        txttotal2b.Text = txtoper1.Text * Txttotal2.Text
    End Sub
    Private Sub btnhitunga_Click(sender As Object, e As EventArgs) Handles btnhitunga.Click
        Call prosesBarang1()
    End Sub

    Private Sub btnhitungb_Click(sender As Object, e As EventArgs) Handles btnhitungb.Click

        txtbtotaloper1b.Text = txtboper1.Text * 1
        txtbtotalbahan2.Text = txtbbahan1.Text * 0
        txttotalB.Text = txtbtotal1.Text - txtbbahan1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        txtbtotal1.Text = txtboper1.Text * txtbbahan1.Text
    End Sub



    Sub TotalB1lebihlecil()
        txttotaloper1.Text = txtoper2b.Text - txtoper1b.Text
        txttotalbahan1.Text = txtbahan2b.Text - txtbahan1b.Text
        txttotalB.Text = txttotal2b.Text - txttotal1b.Text
    End Sub

    Private Sub btnhasilb_Click(sender As Object, e As EventArgs) Handles btnhasilb.Click

        txthargasatuanB.Text = txttotalB.Text ^ txtbtotaloper1b.Text
    End Sub

    Private Sub btn1hari_Click(sender As Object, e As EventArgs) Handles btn1hari.Click
        txtlabaA.Text = txthargasatuanA.Text
        txtlabaB.Text = txthargasatuanB.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtlabaA.Text = txthargasatuanA.Text * 7
        txtlabaB.Text = txthargasatuanB.Text * 7
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtlabaA.Text = txthargasatuanA.Text * 30
        txtlabaB.Text = txthargasatuanB.Text * 30
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtlabaA.Text = txthargasatuanA.Text * 365
        txtlabaB.Text = txthargasatuanB.Text * 365
    End Sub
    Sub TotalA1lebihlecil()
        txttotaloper1.Text = txtoper2b.Text - txtoper1b.Text
        txttotalbahan1.Text = txtbahan2b.Text - txtbahan1b.Text
        txttotalA.Text = txttotal2b.Text - txttotal1b.Text
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txthargasatuanA.Text = txttotalA.Text - txttotal2b.Text
        Call TotalA1lebihlecil()
        txtbbahan1.Text = txthargasatuanA.Text * txtbahan1.Text
        txtboper1.Text = txtoper1.Text * 1
        txtbtotal1.Text = Txttotal1.Text * 1

    End Sub
End Class