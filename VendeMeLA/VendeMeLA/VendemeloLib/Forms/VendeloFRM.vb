Imports VendeMeLA
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf


Public Class VendeloFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private sqlAM As ArticulosManagerSQL = New ArticulosManagerSQL()
    Private CM As ClientesManager = New ClientesManager()
    Private FM As FacturasManager = New FacturasManager()
    Private detalles As List(Of Detalle) = New List(Of Detalle)
    Private factura As Factura
    Private hay_producto_seleccionado As Boolean = False
    Private seleccionadoId As Integer
    Private cliente_id As Integer
    Private articulosDetalles As List(Of Articulo) = New List(Of Articulo)
    Private total As Decimal = 0
    Private no_ha_agregado As Boolean = True
    Private puede_completar_venta As Boolean = False
    Private ultima_factura_id As Integer
    Private texto_factura As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        removerBtn.Hide()
        agregarBtn.Hide()
        completarVentaBtn.Hide()
        Me.reciboUltimaBtn.Hide()
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
        If Me.no_ha_agregado Then
            Me.no_ha_agregado = False
            removerBtn.Show()
        End If
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

    Private Sub clientesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clientesList.SelectedIndexChanged
        If Me.articulosDetalles.Count > 0 Then
            Me.puede_completar_venta = True
        End If
        If Me.puede_completar_venta Then
            completarVentaBtn.Show()
        End If
    End Sub

    Private Sub completarVentaBtn_Click(sender As Object, e As EventArgs) Handles completarVentaBtn.Click
        Dim val As String = clientesList.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.cliente_id = pieces(0)
        Dim f As Factura = New Factura With {
                .cliente_id = Me.cliente_id,
                .usuario_id = Form1.usuarioActual.id
                }
        Me.FM.Insert(f)
        f.id = Me.FM.idDeLaUltimaFactura()
        Me.ultima_factura_id = f.id
        For Each det As Detalle In Me.detalles
            det.factura_id = f.id
            Me.FM.InsertarDetalle(det)
        Next det
        Me.reciboUltimaBtn.Show()
        Me.resetFinVenta()

    End Sub

    Private Sub resetFinVenta()
        Me.facturaJob()
        Me.hay_producto_seleccionado = False
        agregarBtn.Hide()
        Me.detalles.Clear()
        Me.articulosDetalles.Clear()
        Me.puede_completar_venta = False
        completarVentaBtn.Hide()
        Me.no_ha_agregado = True
        removerBtn.Hide()
        Me.total = 0
        Me.llenarDetalles()
        Me.llenarProductosDisponibles()
    End Sub

    Private Sub facturaJob()
        Dim doc As Pdf.PdfDocument = New Pdf.PdfDocument()
        Dim page As Pdf.PdfPage = doc.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        Dim font As XFont = New XFont("Verdana", 20, XFontStyle.BoldItalic)
        Me.setTextoFactura()
        gfx.DrawString(Me.texto_factura, font, XBrushes.Black, New XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft)
        'Save the document...
        Dim filename As String = "Factura#" & Me.ultima_factura_id & ".pdf"
        doc.Save(filename)
        Process.Start(filename)
    End Sub

    Private Sub setTextoFactura()
        Me.texto_factura = "Factura #" & Me.ultima_factura_id & vbCrLf
        Me.texto_factura &= "Factura #" & Me.ultima_factura_id & Environment.NewLine

    End Sub

    Private Sub removerBtn_Click(sender As Object, e As EventArgs) Handles removerBtn.Click
        Dim si = MessageBox.Show("Reiniciar Factura", "caption", MessageBoxButtons.OKCancel)
        If si = DialogResult.OK Then
            For Each art As Articulo In Me.articulosDetalles
                art.cantidad = art.cantidad + 1
                Me.sqlAM.Update(art)
            Next art
            Me.resetFinVenta()
        End If
    End Sub
End Class