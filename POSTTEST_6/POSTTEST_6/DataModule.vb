Imports MySqlConnector

Module DataModule

    ' ================= INSTRUMEN =================
    Public Function GetAllInstrumen() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbinstrumen"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SimpanInstrumen(nama As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbinstrumen (namaInstrumen) VALUES (@nama)"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan instrumen: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahInstrumen(id As Integer, nama As String) As Boolean
        Try
            Dim query As String = "UPDATE tbinstrumen SET namaInstrumen=@nama WHERE idInstrumen=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal ubah instrumen: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusInstrumen(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbinstrumen WHERE idInstrumen=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal hapus instrumen: " & ex.Message)
            Return False
        End Try
    End Function


    ' ================= PARTITUR =================
    Public Function GetAllPartitur() As DataTable
        Dim dt As New DataTable()

        Dim query As String =
        "SELECT tbpartitur.idPartitur,
                tbpartitur.judul,
                tbpartitur.komposer,
                tbinstrumen.namaInstrumen,
                tbpartitur.genre,
                tbpartitur.tingkat,
                tbpartitur.filePartitur
         FROM tbpartitur
         INNER JOIN tbinstrumen 
         ON tbpartitur.idInstrumen = tbinstrumen.idInstrumen
         ORDER BY tbpartitur.idPartitur ASC"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SearchPartitur(keyword As String) As DataTable
        Dim dt As New DataTable()

        Dim query As String =
        "SELECT tbpartitur.idPartitur,
                tbpartitur.judul,
                tbpartitur.komposer,
                tbinstrumen.namaInstrumen,
                tbpartitur.genre,
                tbpartitur.tingkat,
                tbpartitur.filePartitur
         FROM tbpartitur
         INNER JOIN tbinstrumen 
         ON tbpartitur.idInstrumen = tbinstrumen.idInstrumen
         WHERE tbpartitur.judul LIKE @key
         OR tbpartitur.komposer LIKE @key
         OR tbinstrumen.namaInstrumen LIKE @key
         OR tbpartitur.genre LIKE @key"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SimpanPartitur(judul As String, komposer As String,
                                  genre As String, tingkat As String,
                                  filePath As String, idInstrumen As Integer) As Boolean
        Try
            Dim query As String =
            "INSERT INTO tbpartitur (judul, komposer, genre, tingkat, filePartitur, idInstrumen)
             VALUES (@judul,@komposer,@genre,@tingkat,@file,@idInstrumen)"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@komposer", komposer)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@tingkat", tingkat)
                    cmd.Parameters.AddWithValue("@file", filePath)
                    cmd.Parameters.AddWithValue("@idInstrumen", idInstrumen)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahPartitur(id As Integer, judul As String,
                                komposer As String, genre As String,
                                tingkat As String, filePath As String,
                                idInstrumen As Integer) As Boolean
        Try
            Dim query As String =
            "UPDATE tbpartitur SET judul=@judul, komposer=@komposer,
             genre=@genre, tingkat=@tingkat,
             filePartitur=@file, idInstrumen=@idInstrumen
             WHERE idPartitur=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@komposer", komposer)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@tingkat", tingkat)
                    cmd.Parameters.AddWithValue("@file", filePath)
                    cmd.Parameters.AddWithValue("@idInstrumen", idInstrumen)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusPartitur(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpartitur WHERE idPartitur=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function

End Module