Public Class EmbodegaloFRM

    Private Function esValidoEmbodegable()
        Dim isValid As Boolean = True
        Dim Errors As New List(Of String)
        'Etiqueta del producto
        If (etiquetaComercialTXT.Text.Length < 1) Then
            Errors.Add("La Etiqueta es requerida")
        End If
        'Precio del producto
        If (Not IsNumeric(precioUnidadTXT.Text)) Then
            Errors.Add("El Precion es requerido y debe ser un numero")
        End If
        If Errors.Count > 0 Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Sub showEmbodegarBTN_Click(sender As Object, e As EventArgs) Handles showEmbodegarBTN.Click
        If (Me.esValidoEmbodegable()) Then
            MessageBox.Show("valid Form")
        Else
            MessageBox.Show("Invalid Form")
        End If
    End Sub
End Class