Imports System.Data.SqlClient

Public Class MSSQLDBObject

    Public conn As SqlConnection

    Public Sub New()
        Me.initDBConn()
        Me.conn.Open()
    End Sub

    Private Sub initDBConn()
        Me.conn = New SqlConnection("Initial Catalog=vendemela;" & "Data Source=localhost;Integrated Security=SSPI;")
    End Sub

    'fucking destroy ...
    Protected Overrides Sub Finalize()
        Me.conn.Close()
    End Sub

End Class
