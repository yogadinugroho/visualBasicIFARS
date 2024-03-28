Public Class Form1
// Deklatasi nama kelas atau nama form dalam aplikasi
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    // function yang akan dijalankan ketika tombol button dengan nama btnTampilkan diklik, metode ini akan menghandle clik dari button tersebut. 
        MessageBox.Show(txtNama.Text & vbCrLf & cboJenisKelamin.Text & vbCrLf & cboFakultas.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
        // baris yang digunakan untuk menampilkan messagebox dengan keterangan sebagai berikut :

        // MessageBox.Show
        // ===> Digunakan untuk menampilkan sebuah dialog pesan
        // Ada 4 Parameter yang ada dalam MessageBox.Show
        // 1. Pesan
        // 2. Caption
        // 3. Button
        // 4. Icon

        // vbCrLf
        // ===> Merupakan operator CONCATENATION untuk menambah baris baru 
    End Sub
End Class
