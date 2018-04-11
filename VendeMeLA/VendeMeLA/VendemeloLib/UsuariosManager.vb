Imports System.Security.Cryptography

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

    Private Function hashClave(claveNOhashed As String)
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(claveNOhashed)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim hashedClave As String = ""

        For Each b As Byte In bytesToHash
            hashedClave += b.ToString("x2")
        Next

        Return hashedClave
    End Function

    Public Sub Insert(u As Usuario)
        Dim query As String = String.Empty
        query &= "INSERT INTO usuarios (usuario, clave, es_cajero,es_admin) "
        query &= "VALUES (@usuario,@clave,@es_cajero,@es_admin)"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@usuario", u.usuario)
                .Parameters.AddWithValue("@clave", Me.hashClave(u.clave))
                .Parameters.AddWithValue("@es_cajero", u.es_cajero)
                .Parameters.AddWithValue("@es_admin", u.es_admin)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Guardando Usuario")
            End Try
        End Using
    End Sub

    Public Function CheckIfUsuarioExists(usuario As String)
        Dim usuarioExists As Boolean = False
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT count(*) FROM usuarios WHERE usuario = '" & usuario & "'"
        Dim count As Integer = cmd.ExecuteScalar()
        'System.Console.WriteLine(count)
        If count > 0 Then
            usuarioExists = True
        End If

        Return usuarioExists
    End Function

    Public Function obtenerPorID(id As Integer)
        Dim result As Usuario
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM usuarios WHERE id = @id"
        cmd.Parameters.AddWithValue("@id", id.ToString())
        Dim reader As SqlClient.SqlDataReader = cmd.ExecuteReader()

        Do While reader.Read()
            result = New Usuario With {
            .id = reader.GetValue(0),
            .usuario = reader.GetString(1),
              .clave = reader.GetString(2),
              .es_cajero = reader.GetValue(3),
              .es_admin = reader.GetValue(4)
            }

        Loop
        reader.Close()
        Return result
    End Function

    Public Sub Update(u As Usuario)
        Dim query As String = String.Empty
        query &= "UPDATE usuarios SET usuario = @usuario, clave=@clave, es_cajero=@es_cajero, es_admin=@es_admin "
        query &= "WHERE id=@id"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@id", u.id)
                .Parameters.AddWithValue("@usuario", u.usuario)
                .Parameters.AddWithValue("@clave", u.clave)
                .Parameters.AddWithValue("@es_cajero", u.es_cajero)
                .Parameters.AddWithValue("@es_admin", u.es_admin)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Actualizando Usuario")
            End Try
        End Using
    End Sub

End Class
