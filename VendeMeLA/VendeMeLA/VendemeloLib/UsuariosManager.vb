Public Class UsuariosManager

    Private db As MSSQLDBObject

    Public Sub New()
        Me.db = New MSSQLDBObject()
    End Sub

    Public Function listAll()
        Dim result As New List(Of Usuario)
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM usuarios"
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
        Do While reader.Read()
            Dim u As Usuario = New Usuario With {
            .id = reader.GetValue(0),
            .usuario = reader.GetString(1),
            .clave = reader.GetString(2),
            .es_cajero = reader.GetValue(3),
            .es_admin = reader.GetValue(4)
            }
            result.Add(u)
        Loop
        Return result
    End Function

End Class
