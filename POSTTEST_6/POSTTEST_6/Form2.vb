Public Class Form2

    Dim idTerpilih As Integer = -1

    Sub Tampil()
        DataGridView2.DataSource = GetAllInstrumen()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaInstrumen.Text = "" Then
            MessageBox.Show("Nama kosong")
            Exit Sub
        End If

        SimpanInstrumen(txtNamaInstrumen.Text)
        Tampil()
        txtNamaInstrumen.Clear()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idTerpilih = -1 Then
            MessageBox.Show("Pilih data dulu")
            Exit Sub
        End If

        UbahInstrumen(idTerpilih, txtNamaInstrumen.Text)
        Tampil()
        txtNamaInstrumen.Clear()
        idTerpilih = -1
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView2.CurrentRow Is Nothing Then Exit Sub

        Dim id As Integer = DataGridView2.CurrentRow.Cells("idInstrumen").Value
        HapusInstrumen(id)
        Tampil()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView2.Rows(e.RowIndex)

            idTerpilih = row.Cells("idInstrumen").Value
            txtNamaInstrumen.Text = row.Cells("namaInstrumen").Value.ToString()
        End If
    End Sub

End Class