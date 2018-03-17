Public Class ArticulosManager

    Private db As DBObject
    Public articulos

    Public Sub New()
        Me.db = New DBObject()
        Me.articulos = Me.db.db.GetCollection(Of Articulo)("articulo")
    End Sub

    Public Function CheckIfEtiquetaExists(etiqueta As String)
        Dim etiquetaExists As Boolean = False
        Dim query As LiteDB.Query
        Dim result = Me.articulos.FindOne(query.EQ("etiqueta", etiqueta))
        If Not IsNothing(result) Then
            etiquetaExists = True
        End If
        Return etiquetaExists
    End Function

    Public Function todosConExistencias()

    End Function

End Class
