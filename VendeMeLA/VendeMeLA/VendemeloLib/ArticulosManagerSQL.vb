Public Class ArticulosManagerSQL

    Private db As MSSQLDBObject
    Private result As New List(Of String)

    Public Sub New()
        Me.db = New MSSQLDBObject()
    End Sub

    Public Function listAll()
        Dim result As New List(Of Articulo)
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM articulos"
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
        Do While reader.Read()
            Dim art As Articulo = New Articulo With {
            .id = reader.GetValue(0),
            .cantidad = reader.GetValue(2),
            .etiqueta = reader.GetString(1),
              .precio = reader.GetValue(3)
            }
            result.Add(art)
            'System.Console.WriteLine(reader.GetValue(0))
        Loop
        Return result
    End Function

    Public Function todosConExistencias()
        Dim result As New List(Of Articulo)
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM articulos WHERE cantidad > 0"
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
        Do While reader.Read()
            Dim art As Articulo = New Articulo With {
            .id = reader.GetValue(0),
            .cantidad = reader.GetValue(2),
            .etiqueta = reader.GetString(1),
              .precio = reader.GetValue(3)
            }
            result.Add(art)
        Loop
        reader.Close()
        Return result
    End Function

    Public Function CheckIfEtiquetaExists(etiqueta As String)
        Dim etiquetaExists As Boolean = False
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT count(*) FROM articulos WHERE etiqueta = '" & etiqueta & "'"
        Dim count As Integer = cmd.ExecuteScalar()
        'System.Console.WriteLine(count)
        If count > 0 Then
            etiquetaExists = True
        End If

        Return etiquetaExists
    End Function

    Public Sub Insert(art As Articulo)
        Dim query As String = String.Empty
        query &= "INSERT INTO articulos (etiqueta, cantidad, precio) "
        query &= "VALUES (@etiqueta,@cantidad, @precio)"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@etiqueta", art.etiqueta)
                .Parameters.AddWithValue("@cantidad", art.cantidad)
                .Parameters.AddWithValue("@precio", art.precio)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Guardando Articulo")
            End Try
        End Using
    End Sub

End Class
