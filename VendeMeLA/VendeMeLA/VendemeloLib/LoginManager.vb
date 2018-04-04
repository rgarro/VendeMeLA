Imports System.Security.Cryptography

Public Class LoginManager

    Private db As MSSQLDBObject
    Public usuario As String
    Private clave As String
    Private clave_is_set As Boolean = False

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

    Private Function verificarCredenciales()
        Dim is_valid_user = False
        If Me.clave_is_set Then

        Else
            Throw New System.Exception("must get clave first.")
        End If
        Return is_valid_user
    End Function

End Class
