Module ValidationModule
    Public Function ValidasiKosong(txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            MessageBox.Show(pesan)
            txt.Focus()
            Return False
        End If
        Return True
    End Function
End Module