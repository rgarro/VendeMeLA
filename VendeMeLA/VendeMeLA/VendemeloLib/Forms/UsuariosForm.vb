
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.sounds.clickSound.Play()
        If (Me.esUsuarioValido()) Then
            Me.GuardarUsuario()
            Me.llenarUsuariosDisponibles()
        Else
            Me.sounds.errorSound.Play()
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            errorsLabel.Text = errorsStr
            Me.Errors.Clear()
        End If
    End Sub

    Private Function esUsuarioValido()
        Dim isValid As Boolean = True
        'Usuario
        If (usuarioTxt.Text.Length < 1) Then
            Me.Errors.Add("El Usuario es requerido")
        End If
        'Clave
        If (claveTxt.Text.Length < 1) Then
            Me.Errors.Add("la clave es requerido")
        End If
        If Errors.Count > 0 Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Sub GuardarUsuario()
        Dim isExistingUsuario As Boolean = Me.UM.CheckIfUsuarioExists(Me.usuarioTxt.Text)
        If Not isExistingUsuario Then
            Dim u As Usuario = New Usuario With {
                .usuario = Me.usuarioTxt.Text,
                .clave = Me.claveTxt.Text,
                .es_cajero = Me.es_cajeroCk.Checked,
                .es_admin = Me.es_admin.Checked
                }
            Me.UM.Insert(u)
            actionLabel.Text = "El Usuario #" & u.id.ToString() & " - " & u.usuario & " ha sido agregado."
            Me.CleanForm()
        Else
            Me.sounds.errorSound.Play()
            errorsLabel.Text = "Usuario " & usuarioTxt.Text & " Existe."
        End If
    End Sub

    Private Sub CleanForm()
        Me.usuarioTxt.Text = ""
        Me.claveTxt.Text = ""
        Me.es_cajeroCk.Checked = False
        Me.es_admin.Checked = False
    End Sub

End Class