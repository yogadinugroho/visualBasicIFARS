Public Class Form2
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Dim angka1, angka2, hasil As Double
        Dim angka1 = Val(txtAngka1.Text)
        Dim angka2 = Val(txtAngka2.Text)
        hasil = angka1 + angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Dim angka1, angka2, hasil As Double
        Dim angka1 = Val(txtAngka1.Text)
        Dim angka2 = Val(txtAngka2.Text)
        hasil = angka1 * angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim angka1, angka2, hasil As Double
        Dim angka1 = Val(txtAngka1.Text)
        Dim angka2 = Val(txtAngka2.Text)
        hasil = angka1 / angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim angka1, angka2, hasil As Double
        Dim angka1 = Val(txtAngka1.Text)
        Dim angka2 = Val(txtAngka2.Text)
        hasil = angka1 - angka2
        txtHasil.Text = hasil
    End Sub
End Class