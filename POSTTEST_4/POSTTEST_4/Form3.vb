Public Class Form3

    Private Sub menuInput_Click(sender As Object, e As EventArgs) Handles menuInput.Click
        Form1.Show()
    End Sub

    Private Sub menuLihat_Click(sender As Object, e As EventArgs) Handles menuLihat.Click
        Form2.Show()
    End Sub

    Private Sub menuKeluar_Click(sender As Object, e As EventArgs) Handles menuKeluar.Click
        If MessageBox.Show("Keluar aplikasi?", "Konfirmasi",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub menuSimpan_Click(sender As Object, e As EventArgs) Handles menuSimpan.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text File|*.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Dim data As String =
                Form1.txtNama.Text & ";" &
                Form1.txtID.Text & ";" &
                Form1.comboDivisi.Text & ";" &
                Form1.txtNoTelp.Text & ";" &
                Form1.AmbilAktivitas()

            IO.File.WriteAllText(sfd.FileName, data)
            MessageBox.Show("Data berhasil disimpan")
        End If
    End Sub

    Private Sub menuBuka_Click(sender As Object, e As EventArgs) Handles menuBuka.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog = DialogResult.OK Then

            Dim isi As String = IO.File.ReadAllText(ofd.FileName)

            If isi = "" Then
                MessageBox.Show("File kosong")
                Exit Sub
            End If

            Dim data() As String = isi.Split(";"c)

            ' VALIDASI JUMLAH DATA
            If data.Length < 5 Then
                MessageBox.Show("Format file tidak sesuai")
                Exit Sub
            End If

            ' PASTIKAN FORM INPUT TERBUKA
            If Form1.IsDisposed Then
                Form1 = New Form1
            End If

            Form1.Show()

            ' MASUKKAN DATA
            Form1.txtNama.Text = data(0)
            Form1.txtID.Text = data(1)
            Form1.comboDivisi.Text = data(2)
            Form1.txtNoTelp.Text = data(3)

            MessageBox.Show("Data berhasil dibuka")

        End If
    End Sub

End Class