Public Class Form1

    Dim akumulasiIPS As New List(Of Double)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ips As Double

        If Double.TryParse(txtIPS.Text, ips) Then
            If ips >= 0 And ips <= 4 Then

                akumulasiIPS.Add(ips)

                Dim total As Double = 0
                For Each nilai In akumulasiIPS
                    total += nilai
                Next

                Dim ipk As Double = total / akumulasiIPS.Count
                txtIPK.Text = ipk.ToString("F2")

                If ipk >= 2.0 And ipk <= 2.75 Then
                    lblPredikat.Text = "Cukup"
                    lblPredikat.ForeColor = Color.Orange
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"
                    lblPredikat.ForeColor = Color.Blue
                ElseIf ipk >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                    lblPredikat.ForeColor = Color.Green
                Else
                    lblPredikat.Text = "-"
                End If

                txtIPS.Clear()
                txtIPS.Focus()

            Else
                MessageBox.Show("IP harus berupa angka antara 0 - 4")
            End If
        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        akumulasiIPS.Clear()
        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"
    End Sub
End Class
