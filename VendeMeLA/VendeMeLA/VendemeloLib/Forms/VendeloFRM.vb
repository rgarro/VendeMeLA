Imports VendeMeLA

Public Class VendeloFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private sqlAM As ArticulosManagerSQL = New ArticulosManagerSQL()
    Private CM As ClientesManager = New ClientesManager()
    Private detalles As List(Of Detalle)
    Private factura As Factura

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
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
        Dim val As String = articulosList.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        System.Console.WriteLine(pieces(0))

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class