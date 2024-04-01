Public Class Form1
    'Sub Procedure
    'Make Sub-Procedure in Public
    Sub bersih()
        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        txtSatuan.Clear()
        txtHargaSatuan.Clear()
        txtJumlah.Clear()
        txtTotalHarga.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Call Sub-Procedure
        Call bersih()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
    End Sub

    'define function hitung
    Private Function Hitung()
        Dim jumlah, hargaSatuan, totalHarga As Integer
        'grab data from form
        jumlah = txtJumlah.Text
        hargaSatuan = txtHargaSatuan.Text
        totalHarga = jumlah * hargaSatuan

        'set total to form
        txtTotalHarga.Text = totalHarga
        Return totalHarga
    End Function

    'define sub-procedure cek data kosong
    Sub cekDataKosong()
        If txtKodeBarang.Text = "" Then
            MessageBox.Show("Kode Barang Harus Diisi Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeBarang.Focus()
        ElseIf txtNamaBarang.Text = "" Then
            MessageBox.Show("Nama Barang Harus Diisi Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaBarang.Focus()
        ElseIf txtSatuan.Text = "" Then
            MessageBox.Show("Satuan Barang Harus Diisi Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSatuan.Focus()
        ElseIf txtHargaSatuan.Text = "" Then
            MessageBox.Show("Harga Satuan Barang Harus Diisi Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHargaSatuan.Focus()
        ElseIf txtJumlah.Text = "" Then
            MessageBox.Show("Jumlah Barang Harus Diisi Terlebih Dahulu", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlah.Focus()
        Else
            Call Hitung()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call cekDataKosong()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tutup As String
        tutup = MessageBox.Show("Yakin ingin menutup form ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
