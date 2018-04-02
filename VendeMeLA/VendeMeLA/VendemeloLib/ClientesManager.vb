Public Class ClientesManager

    Private db As MSSQLDBObject

    Public Sub New()
        Me.db = New MSSQLDBObject()
    End Sub

    Public Function listAll()
        Dim result As New List(Of Cliente)
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM clientes"
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
        Do While reader.Read()
            Dim cli As Cliente = New Cliente With {
            .id = reader.GetValue(0),
            .nombre = reader.GetString(1),
            .descuento = reader.GetValue(2)
            }
            result.Add(cli)
        Loop
        Return result
    End Function

    Public Function obtenerPorID(id As Integer)
        Dim result As Cliente
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM clientes WHERE id = @id"
        cmd.Parameters.AddWithValue("@id", id.ToString())
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()

        Do While reader.Read()
            result = New Cliente With {
            .id = reader.GetValue(0),
            .nombre = reader.GetString(1),
              .descuento = reader.GetValue(2)
            }

        Loop
        reader.Close()
        Return result
    End Function

    Public Function CheckIfNombreExists(nombre As String)
        Dim nombreExists As Boolean = False
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT count(*) FROM clientes WHERE nombre = '" & nombre & "'"
        Dim count As Integer = cmd.ExecuteScalar()
        'System.Console.WriteLine(count)
        If count > 0 Then
            nombreExists = True
        End If

        Return nombreExists
    End Function

    Public Sub Insert(cli As Cliente)
        Dim query As String = String.Empty
        query &= "INSERT INTO clientes (nombre, descuento) "
        query &= "VALUES (@nombre,@descuento)"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@nombre", cli.nombre)
                .Parameters.AddWithValue("@descuento", cli.descuento)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Guardando Cliente")
            End Try
        End Using
    End Sub

    Public Sub Update(cli As Cliente)
        Dim query As String = String.Empty
        query &= "UPDATE clientes SET nombre = @nombre, descuento=@descuento "
        query &= "WHERE id=@id"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@id", cli.id)
                .Parameters.AddWithValue("@nombre", cli.nombre)
                .Parameters.AddWithValue("@descuento", cli.descuento)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Actualizando Cliente")
            End Try
        End Using
    End Sub

    Public Sub Delete(id As Integer)
        Dim query As String = String.Empty
        query &= "DELETE FROM clientes "
        query &= "WHERE id = @id"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@id", id)

            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Borrando Cliente")
            End Try
        End Using
    End Sub

End Class
