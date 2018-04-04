Public Class UsuariosForm

    Private sounds As VMLSounds = New VMLSounds()
    Private UM As UsuariosManager = New UsuariosManager()
    Private Errors As New List(Of String)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.llenarUsuariosDisponibles()
    End Sub

    Private Sub llenarUsuariosDisponibles()
        Me.sounds.processSound.Play()
        usuariosList.Items.Clear()
        Dim res = Me.UM.listAll()
        For Each u As Usuario In res
            Dim ustr As String = u.id & "# " & u.usuario
            If u.es_admin Then
                ustr = ustr & " es_admin"
            End If
            If u.es_cajero Then
                ustr = ustr & " es_cajero"
            End If
            usuariosList.Items.Add(ustr)
        Next u
    End Sub

    Private Sub clienteMGroup_Enter(sender As Object, e As EventArgs) Handles clienteMGroup.Enter

    End Sub

    Private Sub UsuariosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class