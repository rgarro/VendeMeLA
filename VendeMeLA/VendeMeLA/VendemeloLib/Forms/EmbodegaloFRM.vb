Public Class EmbodegaloFRM

    Private Errors As New List(Of String)
    Private EditId As String
    Private ArticuloEditable As Articulo
    Private OriginalEtiqueta As String
    Private sounds As VMLSounds = New VMLSounds()
    Private sqlAM As ArticulosManagerSQL = New ArticulosManagerSQL()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.FillProductsList()
    End Sub

    Private Sub FillProductsList()
        Me.sounds.processSound.Play()
        ListBox1.Items.Clear()
        'Dim res = Me.AM.articulos.FindAll
        Dim res As List(Of Articulo) = Me.sqlAM.listAll()
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

    Private Sub showEmbodegarBTN_Click(sender As Object, e As EventArgs) Handles showEmbodegarBTN.Click
        Me.sounds.clickSound.Play()
        If (Me.esValidoEmbodegable()) Then
            Me.GuardarArticulo()
            Me.FillProductsList()
        Else
            Me.sounds.errorSound.Play()
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub

    Private Sub GuardarArticulo()
        Dim isExistingArticle As Boolean = Me.sqlAM.CheckIfEtiquetaExists(Me.etiquetaComercialTXT.Text)
        If Not isExistingArticle Then
            Dim articulo As Articulo = New Articulo With {
                .cantidad = Me.cantidadTXT.Text,
                    .etiqueta = Me.etiquetaComercialTXT.Text,
                    .precio = Me.precioUnidadTXT.Text
                }
            Me.sqlAM.Insert(articulo)
            actionLabel.Text = "El Articulo #" & articulo.id.ToString() & " - " & articulo.etiqueta & " ha sido Embodegado."
            Me.CleanForm()
        Else
            Me.sounds.errorSound.Play()
            errorsLabel.Text = "Articulo " & etiquetaComercialTXT.Text & " Existe."
        End If
    End Sub

    Private Sub CleanForm()
        Me.cantidadTXT.Text = ""
        Me.etiquetaComercialTXT.Text = ""
        Me.precioUnidadTXT.Text = ""
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.sounds.clickSound.Play()
        Dim val As String = ListBox1.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.EditId = pieces(0)
        Me.getEditArticulo()
        Me.setArticuloForm()
    End Sub

    Private Sub getEditArticulo()
        Me.ArticuloEditable = Me.sqlAM.obtenerPorID(Convert.ToInt32(Me.EditId))
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

    Private Sub ActualizarArticulo()
        Me.sqlAM.Update(Me.ArticuloEditable)
        actionLabel.Text = "El Articulo #" & Me.ArticuloEditable.id.ToString() & " - " & Me.ArticuloEditable.etiqueta & " ha sido Actualizado."
    End Sub

    Private Sub borrarArticuloBTN_Click(sender As Object, e As EventArgs) Handles borrarArticuloBTN.Click
        Dim siBorrar = MessageBox.Show("Remover " & Me.ArticuloEditable.etiqueta, "caption", MessageBoxButtons.OKCancel)
        If siBorrar = DialogResult.OK Then
            actionLabel.Text = "El Articulo #" & Me.ArticuloEditable.id.ToString() & " - " & Me.ArticuloEditable.etiqueta & "ha sido BORRADO."
            Me.sqlAM.Delete(Me.ArticuloEditable.id)
            ListBox1.Items.Clear()
            Me.FillProductsList()
            Me.CleanEditForm()
            editArticuloBox.Hide()
        End If
    End Sub

    Private Sub EmbodegaloFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class