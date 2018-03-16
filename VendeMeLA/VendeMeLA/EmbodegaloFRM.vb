Public Class EmbodegaloFRM

    Private Errors As New List(Of String)
    Private nuevo As Producto = New Producto
    Private mdb As LiteDB.LiteDatabase
    Private EditId As String
    Private ArticuloEditable As Articulo
    Private OriginalEtiqueta As String
    'Private articulos
    Private sounds As VMLSounds = New VMLSounds()
    Private AM As ArticulosManager = New ArticulosManager()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'System.Console.WriteLine("no sea bruto vote por ")
        Using db As LiteDB.LiteDatabase = New LiteDB.LiteDatabase("VendeMela.db")
            Me.mdb = db
        End Using
        'Me.articulos = Me.mdb.GetCollection(Of Articulo)("articulo")
        Me.FillProductsList()
    End Sub

    Private Sub FillProductsList()
        Me.sounds.processSound.Play()
        Dim res = Me.AM.articulos.FindAll
        Dim index As Integer = 0
        For Each larticulo As Articulo In res
            ListBox1.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades:" & larticulo.cantidad)
        Next larticulo
    End Sub

    Private Function esValidoEmbodegable()
        Dim isValid As Boolean = True
        'Etiqueta del producto
        If (etiquetaComercialTXT.Text.Length < 1) Then
            Me.Errors.Add("La Etiqueta es requerida")
        End If
        'Precio del producto
        If (Not IsNumeric(precioUnidadTXT.Text)) Then
            Me.Errors.Add("El Precio es requerido y debe ser un numero")
        End If
        'Cantidad de producto
        If (Not IsNumeric(cantidadTXT.Text)) Then
            Me.Errors.Add("La Cantidad es requerida y debe ser numerica")
        End If
        If Errors.Count > 0 Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Sub obtenerDatosProductoNuevo()
        Me.nuevo.etiqueta = etiquetaComercialTXT.Text
        Me.nuevo.cantidad = cantidadTXT.Text
        Me.nuevo.precio = precioUnidadTXT.Text
    End Sub

    Private Sub showEmbodegarBTN_Click(sender As Object, e As EventArgs) Handles showEmbodegarBTN.Click
        Me.sounds.clickSound.Play()
        If (Me.esValidoEmbodegable()) Then
            Me.obtenerDatosProductoNuevo()
            Me.GuardarArticulo()
        Else
            Me.sounds.errorSound.Play()
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub

    Private Sub GuardarArticulo()
        Dim isExistingArticle As Boolean = Me.AM.CheckIfEtiquetaExists(Me.etiquetaComercialTXT.Text)
        If Not isExistingArticle Then
            Dim articulo As Articulo = New Articulo With {
                    .id = Me.AM.GetNextArticuloID(),
                    .cantidad = Me.cantidadTXT.Text,
                    .etiqueta = Me.etiquetaComercialTXT.Text,
                    .precio = Me.precioUnidadTXT.Text
                }
            Me.AM.articulos.Insert(articulo)
            actionLabel.Text = "El Articulo #" & articulo.id.ToString() & " - " & articulo.etiqueta & " ha sido Embodegado."
            Me.CleanForm()
        Else
            Me.sounds.errorSound.Play()
            MessageBox.Show("Articulo " & etiquetaComercialTXT.Text & " Existe.")
        End If
    End Sub

    Private Sub CleanForm()
        Me.cantidadTXT.Text = ""
        Me.etiquetaComercialTXT.Text = ""
        Me.precioUnidadTXT.Text = ""
    End Sub

    ' Private Function GetNextArticuloID()
    '  Dim nextId As Integer
    ' Dim r = Me.AM.articulos.FindAll
    '     nextId = r.Count() + 1
    'Return nextId
    'Dim nextId As Integer
    'Using db As LiteDB.LiteDatabase = New LiteDB.LiteDatabase("VendeMela.db")
    ' Dim articulos = db.GetCollection(Of Articulo)("articulo")
    ' Dim r = articulos.FindAll
    ' nextId = r.Count + 1
    ' End Using
    '   Return nextId
    '  End Function



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.sounds.clickSound.Play()
        Dim val As String = ListBox1.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.EditId = pieces(0)
        Me.getEditArticulo()
        Me.setArticuloForm()
    End Sub

    Private Sub getEditArticulo()
        Me.ArticuloEditable = Me.AM.articulos.FindById(Convert.ToInt32(Me.EditId))
    End Sub

    Private Sub setArticuloForm()
        editArticuloBox.Show()
        EetiquetaComercialTXT.Text = Me.ArticuloEditable.etiqueta
        EcantidadTXT.Text = Me.ArticuloEditable.cantidad
        EprecioUnidadTXT.Text = Me.ArticuloEditable.precio
    End Sub

    Private Sub obtenerDatosProductoEditar()
        Me.ArticuloEditable.etiqueta = EetiquetaComercialTXT.Text
        Me.ArticuloEditable.cantidad = EcantidadTXT.Text
        Me.ArticuloEditable.precio = EprecioUnidadTXT.Text
    End Sub

    Private Function esValidoEmbodegableActualizable()
        Dim isValid As Boolean = True
        'Etiqueta del producto
        If (EetiquetaComercialTXT.Text.Length < 1) Then
            Me.Errors.Add("La Etiqueta es requerida")
        End If
        'Precio del producto
        If (Not IsNumeric(EprecioUnidadTXT.Text)) Then
            Me.Errors.Add("El Precio es requerido y debe ser un numero")
        End If
        'Cantidad de producto
        If (Not IsNumeric(EcantidadTXT.Text)) Then
            Me.Errors.Add("La Cantidad es requerida y debe ser numerica")
        End If
        If Errors.Count > 0 Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Sub actualizarArticuloBTN_Click(sender As Object, e As EventArgs) Handles actualizarArticuloBTN.Click
        Me.sounds.clickSound.Play()
        If (Me.esValidoEmbodegableActualizable()) Then
            Me.obtenerDatosProductoEditar()
            Me.ActualizarArticulo()
            ListBox1.Items.Clear()
            Me.FillProductsList()
            Me.CleanEditForm()
            editArticuloBox.Hide()
        Else
            Me.sounds.errorSound.Play()
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub

    Private Sub CleanEditForm()
        Me.EcantidadTXT.Text = ""
        Me.EetiquetaComercialTXT.Text = ""
        Me.EprecioUnidadTXT.Text = ""
    End Sub

    Private Function CheckIfEtiquetaExistsTwice(etiqueta As String)
        Dim etiquetaExists As Boolean = False
        Dim query As LiteDB.Query
        Dim result = Me.AM.articulos.FindOne(query.EQ("etiqueta", etiqueta))
        If Not IsNothing(result) Then
            etiquetaExists = True
        End If
        Return etiquetaExists
    End Function

    Private Sub ActualizarArticulo()
        'Dim isExistingArticle As Boolean = Me.CheckIfEtiquetaExistsTwice(Me.etiquetaComercialTXT.Text)
        'If Not isExistingArticle Then
        Me.AM.articulos.Update(Me.ArticuloEditable)
        actionLabel.Text = "El Articulo #" & Me.ArticuloEditable.id.ToString() & " - " & Me.ArticuloEditable.etiqueta & " ha sido Actualizado."
        'Me.CleanForm()
        'Else
        'MessageBox.Show(etiquetaComercialTXT.Text & "Articulo Existe.")
        'End If
    End Sub

    Private Sub borrarArticuloBTN_Click(sender As Object, e As EventArgs) Handles borrarArticuloBTN.Click
        Dim siBorrar = MessageBox.Show("Remover " & Me.ArticuloEditable.etiqueta, "caption", MessageBoxButtons.OKCancel)
        If siBorrar = DialogResult.OK Then
            actionLabel.Text = "El Articulo #" & Me.ArticuloEditable.id.ToString() & " - " & Me.ArticuloEditable.etiqueta & "ha sido BORRADO."
            Me.AM.articulos.Delete(Me.ArticuloEditable.id)
            ListBox1.Items.Clear()
            Me.FillProductsList()
            Me.CleanEditForm()
            editArticuloBox.Hide()
        End If
    End Sub
End Class