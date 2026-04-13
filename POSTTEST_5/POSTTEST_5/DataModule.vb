Imports MySqlConnector

Module DataModule

    Public Function GetAllPartitur() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbpartitur ORDER BY idPartitur ASC"

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
        "SELECT * FROM tbpartitur 
         WHERE judul LIKE @key 
         OR komposer LIKE @key 
         OR instrumen LIKE @key 
         OR genre LIKE @key"

        Using conn = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Function SimpanPartitur(judul As String, komposer As String,
                                  instrumen As String, genre As String,
                                  tingkat As String, filePath As String) As Boolean
        Try
            Dim query As String =
            "INSERT INTO tbpartitur (judul, komposer, instrumen, genre, tingkat, filePartitur)
             VALUES (@judul,@komposer,@instrumen,@genre,@tingkat,@file)"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@komposer", komposer)
                    cmd.Parameters.AddWithValue("@instrumen", instrumen)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@tingkat", tingkat)
                    cmd.Parameters.AddWithValue("@file", filePath)
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
                                komposer As String, instrumen As String,
                                genre As String, tingkat As String,
                                filePath As String) As Boolean
        Try
            Dim query As String =
            "UPDATE tbpartitur SET judul=@judul, komposer=@komposer,
             instrumen=@instrumen, genre=@genre, tingkat=@tingkat,
             filePartitur=@file WHERE idPartitur=@id"

            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@komposer", komposer)
                    cmd.Parameters.AddWithValue("@instrumen", instrumen)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@tingkat", tingkat)
                    cmd.Parameters.AddWithValue("@file", filePath)
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