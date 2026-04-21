Imports System.Diagnostics

Public Class Form1

    Dim idTerpilih As Integer = -1

    ' ================= TAMPIL DATA =================
    Sub TampilData()
        DataGridView1.DataSource = GetAllPartitur()
    End Sub

    ' ================= LOAD COMBOBOX =================
    Sub LoadInstrumen()
        cbInstrumen.DataSource = GetAllInstrumen()
        cbInstrumen.DisplayMember = "namaInstrumen"
        cbInstrumen.ValueMember = "idInstrumen"
    End Sub

    ' ================= RESET =================
    Sub Kosong()
        txtJudul.Clear()
        txtKomposer.Clear()
        txtGenre.Clear()
        txtTingkat.Clear()
        txtFile.Clear()
        txtSearch.Clear()
        cbInstrumen.SelectedIndex = -1
        idTerpilih = -1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        LoadInstrumen()
    End Sub

    ' ================= SIMPAN =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtJudul.Text = "" Then
            MessageBox.Show("Judul kosong")
            Exit Sub
        End If

        If cbInstrumen.SelectedIndex = -1 Then
            MessageBox.Show("Pilih instrumen dulu")
            Exit Sub
        End If

        Dim idInstrumen As Integer = cbInstrumen.SelectedValue

        If SimpanPartitur(txtJudul.Text, txtKomposer.Text,
                          txtGenre.Text, txtTingkat.Text,
                          txtFile.Text, idInstrumen) Then
            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If
    End Sub

    ' ================= UBAH =================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idTerpilih = -1 Then
            MessageBox.Show("Pilih data dulu")
            Exit Sub
        End If

        Dim idInstrumen As Integer = cbInstrumen.SelectedValue

        If UbahPartitur(idTerpilih, txtJudul.Text, txtKomposer.Text,
                        txtGenre.Text, txtTingkat.Text,
                        txtFile.Text, idInstrumen) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        End If
    End Sub

    ' ================= HAPUS =================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idTerpilih = -1 Then
            MessageBox.Show("Pilih data dulu")
            Exit Sub
        End If

        If HapusPartitur(idTerpilih) Then
            MessageBox.Show("Data berhasil dihapus")
            TampilData()
            Kosong()
        End If
    End Sub

    ' ================= BATAL =================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' ================= KLIK DATA =================
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)

            idTerpilih = row.Cells("idPartitur").Value

            txtJudul.Text = row.Cells("judul").Value.ToString()
            txtKomposer.Text = row.Cells("komposer").Value.ToString()
            txtGenre.Text = row.Cells("genre").Value.ToString()
            txtTingkat.Text = row.Cells("tingkat").Value.ToString()
            txtFile.Text = row.Cells("filePartitur").Value.ToString()
            cbInstrumen.Text = row.Cells("namaInstrumen").Value.ToString()
        End If
    End Sub

    ' ================= SEARCH =================
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            DataGridView1.DataSource = SearchPartitur(txtSearch.Text)
        End If
    End Sub

    ' ================= BROWSE FILE =================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "PDF Files|*.pdf"

        If ofd.ShowDialog() = DialogResult.OK Then
            txtFile.Text = ofd.FileName
        End If
    End Sub

    ' ================= BUKA FILE =================
    Private Sub btnBuka_Click(sender As Object, e As EventArgs) Handles btnBuka.Click
        If txtFile.Text <> "" Then
            Try
                Process.Start(New ProcessStartInfo(txtFile.Text) With {
                    .UseShellExecute = True
                })
            Catch ex As Exception
                MessageBox.Show("Gagal membuka file: " & ex.Message)
            End Try
        Else
            MessageBox.Show("File belum dipilih")
        End If
    End Sub

    Private Sub btnInstrumen_Click(sender As Object, e As EventArgs) Handles btnInstrumen.Click
        Dim f As New Form2
        f.ShowDialog()

        LoadInstrumen()
    End Sub
End Class