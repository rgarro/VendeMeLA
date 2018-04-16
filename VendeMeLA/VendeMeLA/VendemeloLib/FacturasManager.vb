Public Class FacturasManager
    Private db As MSSQLDBObject

    Public Sub New()
        Me.db = New MSSQLDBObject()
    End Sub

    Public Sub Insert(f As Factura)
        Dim query As String = String.Empty
        query &= "INSERT INTO factura (usuario_id,cliente_id) "
        query &= "VALUES (@usuario_id,@cliente_id)"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@usuario_id", f.usuario_id)
                .Parameters.AddWithValue("@cliente_id", f.cliente_id)
            End With
            'System.Console.WriteLine()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Guardando Factura")
            End Try
        End Using
    End Sub
End Class
