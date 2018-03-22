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
            Dim articulo As Articulo = New Articulo With {
                .id = reader.GetString(0),
                .cantidad = reader.GetString(2),
                    .etiqueta = reader.GetString(1),
                    .precio = reader.GetString(3)
                }
            result.Add(articulo)
        Loop

        Return result
    End Function

End Class
