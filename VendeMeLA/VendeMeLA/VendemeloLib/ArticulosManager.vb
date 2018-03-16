Public Class ArticulosManager

    Private db As DBObject
    Public articulos

    Public Sub New()
        Me.db = New DBObject()
        Me.articulos = Me.db.db.GetCollection(Of Articulo)("articulo")
    End Sub

    Public Function GetNextArticuloID()
        Dim nextId As Integer
        Dim r = Me.articulos.FindAll
        nextId = r.Count() + 1
        'Return nextId
        'Dim nextId As Integer
        'Using db As LiteDB.LiteDatabase = New LiteDB.LiteDatabase("VendeMela.db")
        ' Dim articulos = db.GetCollection(Of Articulo)("articulo")
        ' Dim r = articulos.FindAll
        ' nextId = r.Count + 1
        ' End Using
        Return nextId
    End Function

    Public Function CheckIfEtiquetaExists(etiqueta As String)
        Dim etiquetaExists As Boolean = False
        Dim query As LiteDB.Query
        Dim result = Me.articulos.FindOne(query.EQ("etiqueta", etiqueta))
        If Not IsNothing(result) Then
            etiquetaExists = True
        End If
        Return etiquetaExists
    End Function

End Class
