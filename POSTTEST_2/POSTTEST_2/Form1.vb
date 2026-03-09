Public Class Form1

    'Procedure tambah buku (ByRef)
    Sub TambahBuku(ByRef judul As String, ByRef genre As String)
        buku(jumlahBuku) = judul & " (" & genre & ")"
        jumlahBuku += 1
        TampilkanBuku()
    End Sub

    'Function mencari index buku
    Function CariBuku(judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If buku(i).ToLower.Contains(judul.ToLower) Then
                Return i
            End If
        Next
        Return -1
    End Function

    'Procedure menampilkan buku ke ListBox
    Sub TampilkanBuku()
        listBuku.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            listBuku.Items.Add(buku(i))
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahBuku(txtJudul.Text, txtGenre.Text)

        txtJudul.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim index As Integer = CariBuku(txtHapus.Text)

        If index <> -1 Then
            For i As Integer = index To jumlahBuku - 2
                buku(i) = buku(i + 1)
            Next

            jumlahBuku -= 1
            TampilkanBuku()
        Else
            MessageBox.Show("Buku tidak ditemukan")
        End If

        txtHapus.Clear()
    End Sub

End Class