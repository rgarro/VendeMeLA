Public Class ClientesFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private AM As ArticulosManagerSQL = New ArticulosManagerSQL()
    Private CM As ClientesManager = New ClientesManager()
    Private EditId As String
    Private ClienteEditable As Cliente
    Private Errors As New List(Of String)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        updateClienteBox.Hide()
        Me.llenarClientesDisponibles()
    End Sub

    Private Sub llenarClientesDisponibles()
        Me.sounds.processSound.Play()
        clientesList.Items.Clear()
        Dim res = Me.CM.listAll()
        For Each cli As Cliente In res
            clientesList.Items.Add(cli.id & "# " & cli.nombre & " %" & cli.descuento)
        Next cli
    End Sub

    Private Sub clientesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clientesList.SelectedIndexChanged
        Me.sounds.clickSound.Play()
        Dim val As String = clientesList.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.EditId = pieces(0)
        Me.getEditCliente()
        Me.setArticuloForm()
    End Sub

    Private Sub getEditCliente()
        Me.ClienteEditable = Me.CM.obtenerPorID(Convert.ToInt32(Me.EditId))
    End Sub

    Private Sub setArticuloForm()
        updateClienteBox.Show()
        clienteEditNombreTXT.Text = Me.ClienteEditable.nombre
        clienteEditDescuento.Text = Me.ClienteEditable.descuento
    End Sub

    Private Sub NuevoCliBtn_Click(sender As Object, e As EventArgs) Handles NuevoCliBtn.Click
        Me.sounds.clickSound.Play()
        If (Me.esClienteValido()) Then
            Me.GuardarCliente()
            Me.llenarClientesDisponibles()
        Else
            Me.sounds.errorSound.Play()
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub

    Private Function esClienteValido()
        Dim isValid As Boolean = True
        'Nombre del Cliente
        If (clienteNombreTXT.Text.Length < 1) Then
            Me.Errors.Add("El Nombre es requerido")
        End If
        'Descuento del cliente
        If (Not IsNumeric(clienteDescuentoTXT.Text)) Then
            Me.Errors.Add("El Descuento es requerido y debe ser un numero")
        End If
        If Errors.Count > 0 Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Sub GuardarCliente()
        Dim isExistingArticle As Boolean = Me.CM.CheckIfNombreExists(Me.clienteNombreTXT.Text)
        If Not isExistingArticle Then
            Dim client As Cliente = New Cliente With {
                .nombre = Me.clienteNombreTXT.Text,
                .descuento = Me.clienteDescuentoTXT.Text
                }
            Me.CM.Insert(client)
            actionLabel.Text = "El Cliente #" & client.id.ToString() & " - " & client.nombre & " ha sido agregado."
            Me.CleanForm()
        Else
            Me.sounds.errorSound.Play()
            errorsLabel.Text = "Cliente " & clienteNombreTXT.Text & " Existe."
        End If
    End Sub

    Private Sub CleanForm()
        Me.clienteNombreTXT.Text = ""
        Me.clienteDescuentoTXT.Text = ""
    End Sub

End Class