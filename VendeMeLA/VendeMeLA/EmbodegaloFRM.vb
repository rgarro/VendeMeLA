﻿Public Class EmbodegaloFRM

    Private Errors As New List(Of String)
    Private nuevo As Producto = New Producto
    Private mdb As LiteDB.LiteDatabase
    Private EditId As String
    Private ArticuloEditable As Articulo
    Private articulos

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'System.Console.WriteLine("no sea bruto vote por ")
        Using db As LiteDB.LiteDatabase = New LiteDB.LiteDatabase("VendeMela.db")
            Me.mdb = db
        End Using
        Me.articulos = Me.mdb.GetCollection(Of Articulo)("articulo")
        Me.FillProductsList()
    End Sub

    Private Sub FillProductsList()
        Dim res = Me.articulos.FindAll
        Dim index As Integer = 0
        'itemsListBox.Items.AddRange(res)
        'Dim arrLVItem(res.Count()) As ListViewItem
        For Each larticulo As Articulo In res
            ListBox1.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades:" & larticulo.cantidad)

            'ListView1.Items.
            'index = index + 1
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
            Me.Errors.Add("El Precion es requerido y debe ser un numero")
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
        If (Me.esValidoEmbodegable()) Then
            Me.obtenerDatosProductoNuevo()
            Me.GuardarArticulo()
        Else
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub

    Private Sub GuardarArticulo()
        Dim isExistingArticle As Boolean = Me.CheckIfEtiquetaExists()
        If Not isExistingArticle Then
            Dim articulo As Articulo = New Articulo With {
                    .id = Me.GetNextArticuloID(),
                    .cantidad = Me.cantidadTXT.Text,
                    .etiqueta = Me.etiquetaComercialTXT.Text,
                    .precio = Me.precioUnidadTXT.Text
                }
            Me.articulos.Insert(articulo)
            Me.CleanForm()
        Else
            MessageBox.Show(etiquetaComercialTXT.Text & "Articulo Existe.")
        End If
    End Sub

    Private Sub CleanForm()
        Me.cantidadTXT.Text = ""
        Me.etiquetaComercialTXT.Text = ""
        Me.precioUnidadTXT.Text = ""
    End Sub

    Private Function GetNextArticuloID()
        Dim nextId As Integer
        Dim r = Me.articulos.FindAll
        nextId = r.Count + 1
        Return nextId
    End Function

    Private Function CheckIfEtiquetaExists()
        Dim etiquetaExists As Boolean = False
        Dim query As LiteDB.Query
        Dim result = Me.articulos.FindOne(query.EQ("etiqueta", Me.etiquetaComercialTXT.Text))
        If Not IsNothing(result) Then
            etiquetaExists = True
        End If
        Return etiquetaExists
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim val As String = ListBox1.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.EditId = pieces(0)
        Me.getEditArticulo()
        Me.setArticuloForm()
    End Sub

    Private Sub getEditArticulo()
        Me.ArticuloEditable = Me.articulos.FindById(Convert.ToInt32(Me.EditId))
    End Sub

    Private Sub setArticuloForm()
        'MessageBox.Show(Me.ArticuloEditable.etiqueta)
        'Debug.Print(Me.ArticuloEditable.GetHashCode)
        editArticuloBox.Show()
        EetiquetaComercialTXT.Text = Me.ArticuloEditable.etiqueta
    End Sub

End Class