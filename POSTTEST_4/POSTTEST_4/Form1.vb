Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.png"

        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Public Function AmbilAktivitas() As String
        Dim hasil As String = ""

        For Each ctrl As Control In grpAktivitas.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    hasil &= cb.Text & ", "
                End If
            End If
        Next

        If hasil.EndsWith(", ") Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    Private Function AdaAktivitas() As Boolean
        For Each ctrl As Control In grpAktivitas.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        If Not AdaAktivitas() Then
            MessageBox.Show("Pilih minimal satu aktivitas")
            Exit Sub
        End If

        If MessageBox.Show("Cetak kartu?", "Konfirmasi",
                           MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        Dim gender As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")

        Dim f As New Form2

        f.lblNama.Text = txtNama.Text
        f.lblID.Text = txtID.Text
        f.lblDivisi.Text = comboDivisi.Text
        f.lblAktivitas.Text = AmbilAktivitas()
        f.PictureBox1.Image = PictureBox1.Image
        f.labelKontak.Text = txtNoTelp.Text
        f.Show()

    End Sub
End Class
