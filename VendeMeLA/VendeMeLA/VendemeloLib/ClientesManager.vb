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

End Class
