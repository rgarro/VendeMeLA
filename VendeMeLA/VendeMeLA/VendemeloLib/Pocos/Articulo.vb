Public Class Articulo
    Public idVal As Integer
    'Public etiqueta As String
    'Public cantidad As String
    'Public precio As Decimal

    Public Property id As Integer
        Get
            Return idVal
        End Get
        Set(value As Integer)
            idVal = value
        End Set
    End Property

End Class
