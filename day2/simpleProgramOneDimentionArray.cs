Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("Nama", 115)
        ListView1.Columns.Add("Prodi", 110)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Define Array dengan panjang 3 data dan indeks 2
        Dim arrOne(2) As String
        arrOne(0) = txtNim.Text
        arrOne(1) = txtNama.Text
        arrOne(2) = txtProdi.Text

        'ambil Data listview untuk kita passing data arraynya ke dalam listview yang sudah kita buat
        Dim listItem As ListViewItem
        'buat instance dari list view item
        listItem = New ListViewItem
        listItem = ListView1.Items.Add(arrOne(0))
        listItem.SubItems.Add(arrOne(1))
        listItem.SubItems.Add(arrOne(2))

    End Sub
End Class
