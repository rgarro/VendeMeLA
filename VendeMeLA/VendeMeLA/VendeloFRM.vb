Imports VendeMeLA

Public Class VendeloFRM

    Private sounds As VMLSounds = New VMLSounds()
    Private AM As ArticulosManager = New ArticulosManager()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.llenarProductosDisponibles()
    End Sub

    Private Sub llenarProductosDisponibles()
        Me.sounds.processSound.Play()
        Dim res = Me.AM.todosConExistencias()
        For Each larticulo As Articulo In res
            articulosList.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades:" & larticulo.cantidad)
        Next larticulo
    End Sub

    Private Sub VendeloFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub articulosList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles articulosList.SelectedIndexChanged
        Me.sounds.clickSound.Play()
        Dim val As String = articulosList.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        System.Console.WriteLine(pieces(0))

    End Sub
End Class