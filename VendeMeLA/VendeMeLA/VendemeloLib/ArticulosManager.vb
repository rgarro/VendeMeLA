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
        Dim query As LiteDB.Query
        Dim res = Me.articulos.Find(query.And(query.All("etiqueta", query.Ascending), query.GTE("cantidad", 1)))
        'Dim r = From art In res Order By art.etiqueta
        Return res
    End Function

End Class
