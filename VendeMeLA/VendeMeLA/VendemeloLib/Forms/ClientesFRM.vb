Public Class ClientesFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private AM As ArticulosManagerSQL = New ArticulosManagerSQL()
    Private CM As ClientesManager = New ClientesManager()
    Private EditId As String
    Private ClienteEditable As Cliente

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

End Class