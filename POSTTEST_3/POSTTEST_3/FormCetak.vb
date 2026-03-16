Public Class formCetak
    Private Sub formCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto"

        If ofd.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso
           Not Char.IsWhiteSpace(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTlp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTlp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Function AdaHobbyDipilih() As Boolean
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Function AmbilHobby() As String
        Dim hobby As String = ""

        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    hobby &= cb.Text & ", "
                End If
            End If
        Next

        If hobby.EndsWith(", ") Then
            hobby = hobby.Substring(0, hobby.Length - 2)
        End If

        Return hobby
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        'Validasi TextBox kosong
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTlp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Validasi Foto
        If picFoto.Image Is Nothing Then
            MessageBox.Show("Foto harus diupload", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Validasi Gender
        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Validasi Hobby
        If Not AdaHobbyDipilih() Then
            MessageBox.Show("Pilih minimal satu hobby", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Ambil Gender
        Dim gender As String
        If rbLaki.Checked Then
            gender = "Laki-laki"
        Else
            gender = "Perempuan"
        End If

        'Ambil Hobby
        Dim hobby As String = AmbilHobby()

        'Kirim ke FormKartu
        Dim kartu As New formHasil

        kartu.lblNama.Text = txtNama.Text
        kartu.lblUmur.Text = txtUmur.Text
        kartu.lblTlp.Text = txtTlp.Text
        kartu.lblAlamat.Text = txtAlamat.Text
        kartu.lblTanggalLahir.Text = tanggalLahir.Value.ToString("dd MMMM yyyy")
        kartu.lblGender.Text = gender
        kartu.lblHobby.Text = hobby
        kartu.picFoto.Image = picFoto.Image

        kartu.Show()

    End Sub

End Class
