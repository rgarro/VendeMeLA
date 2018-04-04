Imports System.Security.Cryptography

Public Class LoginManager

    Private db As MSSQLDBObject
    Public usuario_str As String
    Private clave As String
    Private clave_is_set As Boolean = False
    Public usuarioVerificado As Usuario


    Public Sub New()
        Me.db = New MSSQLDBObject()
    End Sub

    Public Sub getClave(clave_del_form As String)
        Me.clave = Me.hashClave(clave_del_form)
        Me.clave_is_set = True
    End Sub

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

    Public Function verificarCredenciales()
        Dim is_valid_user = False
        If Me.clave_is_set Then
            'System.Console.WriteLine(Me.clave)
            If Me.contarPorCredenciales(Me.usuario_str, Me.clave) > 0 Then
                Me.usuarioVerificado = Me.obtenerPorCredenciales(Me.usuario_str, Me.clave)
                is_valid_user = True
            End If
        Else
            Throw New System.Exception("must get clave first.")
        End If
        Return is_valid_user
    End Function

    Private Function contarPorCredenciales(u As String, c As String)
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT count(*) FROM usuarios WHERE usuario = @u AND clave = @c"
        cmd.Parameters.AddWithValue("@u", u)
        cmd.Parameters.AddWithValue("@c", c)
        Dim count As Integer = cmd.ExecuteScalar()
        'System.Console.WriteLine(count)
        Return count
    End Function

    Private Function obtenerPorCredenciales(u As String, c As String)
        Dim result As Usuario
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM usuarios WHERE usuario = @u AND clave = @c"
        cmd.Parameters.AddWithValue("@u", u)
        cmd.Parameters.AddWithValue("@c", c)
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

End Class
