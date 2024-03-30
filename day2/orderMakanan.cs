Public Class Form1
    Public hargaMakanan, hargaMinuman As Double

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                hargaMakananText.Text = "Rp. 3500"
                hargaMakanan = 3500
            Case "Bakso"
                hargaMakananText.Text = "Rp. 6000"
                hargaMakanan = 6000
            Case "Mie Ayam"
                hargaMakananText.Text = "Rp. 7000"
                hargaMakanan = 7000
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                hargaMinumanText.Text = "Rp. 3000"
                hargaMinuman = 3000
            Case "Jus Alpukat"
                hargaMinumanText.Text = "Rp. 7000"
                hargaMinuman = 7000
            Case "Teh Manis"
                hargaMinumanText.Text = "Rp. 4000"
                hargaMinuman = 4000
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalHarga, porsiMakan, porsiMinum As Double

        porsiMakan = Val(txtPorsiMakan.Text)
        porsiMinum = Val(txtPorsiMinum.Text)

        totalHarga = (porsiMinum * hargaMinuman) + (porsiMakan * hargaMakanan)

        txtTotalHarga.Text = totalHarga

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox2.Visible = False
        Else
            ComboBox2.Visible = True
        End If
    End Sub
End Class
