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

End Class
