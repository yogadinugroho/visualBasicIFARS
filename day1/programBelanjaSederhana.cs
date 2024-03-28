Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNamaBarang.Text = ("")
        txtHargaSatuan.Text = ("")
        txtJumlahSatuan.Text = ("")
        txtTotalHarga.Text = ("")
        txtDiskon.Text = ("")
        txtTotalBayar.Text = ("")
        txtBonus.Text = ("")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalBayar, totalHarga, hargaSatuan, jumlahBeli, diskon As Double

        hargaSatuan = Val(txtHargaSatuan.Text)
        jumlahBeli = Val(txtJumlahSatuan.Text)
        totalHarga = hargaSatuan * jumlahBeli

        txtTotalHarga.Text = totalHarga

        If totalHarga < 50000 Then
            diskon = 0
            txtDiskon.Text = "0"
            txtBonus.Text = "Tidak Ada"
            txtTotalBayar.Text = totalHarga - diskon
        ElseIf totalHarga > 50000 And totalHarga < 100000 Then
            diskon = 0.05 * totalHarga
            txtDiskon.Text = diskon
            txtBonus.Text = "Cangkir"
            txtTotalBayar.Text = totalHarga - diskon
        ElseIf totalHarga > 100000 And totalHarga < 200000 Then
            diskon = 0.1 * totalHarga
            txtDiskon.Text = diskon
            txtBonus.Text = "Kaos"
            txtTotalBayar.Text = totalHarga - diskon
        ElseIf totalHarga > 200000 And totalHarga < 500000 Then
            diskon = 0.15 * totalHarga
            txtDiskon.Text = diskon
            txtBonus.Text = "Payung"
            txtTotalBayar.Text = totalHarga - diskon
        ElseIf totalHarga >= 500000 Then
            diskon = 0.2 * totalHarga
            txtDiskon.Text = diskon
            txtBonus.Text = "Tas Pinggang"
            txtTotalBayar.Text = totalHarga - diskon
        End If
    End Sub
End Class
