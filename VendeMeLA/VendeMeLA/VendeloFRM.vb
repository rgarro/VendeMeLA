Imports VendeMeLA

Public Class VendeloFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private AM As ArticulosManager = New ArticulosManager()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.llenarProductosDisponibles()
    End Sub

    Private Sub llenarProductosDisponibles()
        Me.sounds.processSound.Play()
        Dim query As LiteDB.Query
        Dim res = Me.AM.articulos.Find(query.GTE("cantidad", 1))
        For Each larticulo As Articulo In res
            articulosList.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades:" & larticulo.cantidad)
        Next larticulo
    End Sub

    Private Sub VendeloFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class