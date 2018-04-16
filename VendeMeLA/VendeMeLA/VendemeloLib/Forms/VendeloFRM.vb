Imports VendeMeLA

Public Class VendeloFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private sqlAM As ArticulosManagerSQL = New ArticulosManagerSQL()
    Private CM As ClientesManager = New ClientesManager()
    Private detalles As List(Of Detalle) = New List(Of Detalle)
    Private factura As Factura
    Private hay_producto_seleccionado As Boolean = False
    Private seleccionadoId As Integer
    Private articulosDetalles As List(Of Articulo) = New List(Of Articulo)
    Private total As Decimal = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        removerBtn.Hide()
        agregarBtn.Hide()
        completarVentaBtn.Hide()
        Me.llenarProductosDisponibles()
        Me.llenarClientesDisponibles()
    End Sub

    Private Sub llenarProductosDisponibles()
        Me.sounds.processSound.Play()
        articulosList.Items.Clear()
        Dim res = Me.sqlAM.todosConExistencias()
        For Each larticulo As Articulo In res
            articulosList.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades:" & larticulo.cantidad)
        Next larticulo
    End Sub

    Private Sub llenarClientesDisponibles()
        Me.sounds.processSound.Play()
        clientesList.Items.Clear()
        Dim res = Me.CM.listAll()
        For Each cli As Cliente In res
            clientesList.Items.Add(cli.id & "# " & cli.nombre & " %" & cli.descuento)
        Next cli
    End Sub

    Private Sub VendeloFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub articulosList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles articulosList.SelectedIndexChanged
        Me.sounds.clickSound.Play()
        If Not Me.hay_producto_seleccionado Then
            Me.hay_producto_seleccionado = True
            'removerBtn.Show()
            agregarBtn.Show()
        End If

        Dim val As String = articulosList.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.seleccionadoId = pieces(0)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub agregarBtn_Click(sender As Object, e As EventArgs) Handles agregarBtn.Click
        Dim art As Articulo = Me.sqlAM.obtenerPorID(Me.seleccionadoId)
        'System.Console.WriteLine(art.etiqueta)
        Dim d As Detalle = New Detalle With {
            .articulo_id = art.id,
            .cobrado = art.precio,
            .factura_id = 0
        }
        System.Console.WriteLine(d.cobrado)
        Me.detalles.Add(d)
        Me.articulosDetalles.Add(art)
        art.cantidad = art.cantidad - 1
        Me.sqlAM.Update(art)
        Me.llenarProductosDisponibles()
        Me.llenarDetalles()
    End Sub

    Private Sub llenarDetalles()
        Me.sounds.processSound.Play()
        preventaList.Items.Clear()
        For Each larticulo As Articulo In Me.articulosDetalles
            preventaList.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades: 1")
            Me.total = Me.total + larticulo.precio
        Next larticulo
        labelTotal.Text = "Total: ¢" & Me.total
    End Sub
End Class