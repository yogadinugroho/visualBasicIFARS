Public Class ProgramHitungNilai
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nilaiTatapMuka, nilaiMidTest, nilaiFinalTest, nilaiAkhir As Double
        nilaiTatapMuka = Val(txtTatapMuka.Text)
        nilaiMidTest = Val(txtMidTest.Text)
        nilaiFinalTest = Val(txtFinalTest.Text)

        nilaiAkhir = (nilaiTatapMuka + nilaiMidTest + nilaiFinalTest) / 3

        txtNilaiAkhir.Text = nilaiAkhir
    End Sub
End Class
