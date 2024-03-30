Public Class Form1
    Dim ExitYN As System.Windows.Forms.DialogResult

    'Perulangan Do Until mirip dengan Do While, namun akan terus berjalan sampai kondisi yang diberikan bernilai true 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 10
            ListBox1.Items.Add("Do Until : " & i)
            i = i + 1
        Loop
    End Sub

    'Perulangan Do While digunakan ketika suatu kondisi bernilai benar. setidaknya kode yang dicheck akan dijalankan sekali terlebih dahulu untuk mengecek kondisinya apakah benar atau salah
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            ListBox1.Items.Add("Do While : " & i)
            i = i + 1
        Loop
    End Sub

    'Perulangan For Next digunakan ketika kita tahu berapa iterasi yang akan kita perlukan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add("For Next " & i)
        Next
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub
End Class
