Public Class EmbodegaloFRM

    Private Errors As New List(Of String)
    Private nuevo As Producto = New Producto

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        System.Console.WriteLine("no sea bruto vote por ")

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
            MessageBox.Show(Me.nuevo.ToString)
        Else
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub
End Class