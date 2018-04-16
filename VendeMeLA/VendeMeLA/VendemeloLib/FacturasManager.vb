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

    Public Function idDeLaUltimaFactura()
        Dim cmd As SqlClient.SqlCommand = Me.db.conn.CreateCommand()
        cmd.CommandText = "SELECT IDENT_CURRENT('factura') as total"

        Dim id As Integer = cmd.ExecuteScalar()
        Return id
    End Function

    Public Sub InsertarDetalle(det As Detalle)
        Dim query As String = String.Empty
        query &= "INSERT INTO detalles (factura_id, articulo_id, precio) "
        query &= "VALUES (@factura_id,@articulo_id, @precio)"
        Using cmd As New SqlClient.SqlCommand()
            With cmd
                .Connection = Me.db.conn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@factura_id", det.factura_id)
                .Parameters.AddWithValue("@articulo_id", det.articulo_id)
                .Parameters.AddWithValue("@precio", det.cobrado)
            End With
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                MessageBox.Show(ex.Message.ToString(), "Error Guardando Detalle")
            End Try
        End Using
    End Sub

End Class
