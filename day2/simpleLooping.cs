Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teks As String
        Dim jumlah As Integer

        teks = txtTeks.Text
        jumlah = txtJumlah.Text

        For i = 1 To jumlah
            ListView1.Items.Add(teks & Environment.NewLine)
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtTeks.Text = ""
        txtJumlah.Text = ""
        ListView1.Items.Clear()
    End Sub
End Class
