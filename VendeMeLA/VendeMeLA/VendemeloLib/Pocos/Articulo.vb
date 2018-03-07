Public Class Articulo
    Public idVal As Integer
    Public etiquetaVal As String
    Public cantidadVal As Integer
    Public precioVal As Decimal

    Public Property id As Integer
        Get
            Return idVal
        End Get
        Set(value As Integer)
            idVal = value
        End Set
    End Property

    Public Property etiqueta As String
        Get
            Return etiquetaVal
        End Get
        Set(value As String)
            etiquetaVal = value
        End Set
    End Property

    Public Property cantidad As Integer
        Get
            Return cantidadVal
        End Get
        Set(value As Integer)
            cantidadVal = value
        End Set
    End Property

    Public Property precio As Decimal
        Get
            Return precioVal
        End Get
        Set(value As Decimal)
            precioVal = value
        End Set
    End Property

End Class
