Imports System.Security.Cryptography

Public Class UsuariosForm

    Private sounds As VMLSounds = New VMLSounds()
    Private UM As UsuariosManager = New UsuariosManager()
    Private Errors As New List(Of String)
    Private EditId As String
    Private UsuarioEditable As Usuario

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.llenarUsuariosDisponibles()
        editBox.Hide()
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

    Private Sub usuariosList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usuariosList.SelectedIndexChanged
        Me.sounds.clickSound.Play()
        Dim val As String = usuariosList.SelectedItem.ToString()
        Dim pieces As Array = val.Split("#")
        Me.EditId = pieces(0)
        Me.getEditUsuario()
        Me.setEditForm()
    End Sub

    Private Sub getEditUsuario()
        Me.UsuarioEditable = Me.UM.obtenerPorID(Convert.ToInt32(Me.EditId))
    End Sub

    Private Sub setEditForm()
        editBox.Show()
        esCajeroCk.Checked = False
        esAdminCk.Checked = False
        usuarioETxt.Text = Me.UsuarioEditable.usuario
        claveETxt.Text = Me.UsuarioEditable.clave
        If Me.UsuarioEditable.es_cajero Then
            esCajeroCk.Checked = True
        End If
        If Me.UsuarioEditable.es_admin Then
            esAdminCk.Checked = True
        End If
    End Sub

    Private Sub editUsuarioBtn_Click(sender As Object, e As EventArgs) Handles editUsuarioBtn.Click
        Me.sounds.clickSound.Play()
        If (Me.esValidoUsuarioActualizable()) Then
            Me.obtenerDatosUsuarioEditar()
            Me.ActualizarUsuario()
            Me.llenarUsuariosDisponibles()
            Me.CleanEditForm()
            editBox.Hide()
        Else
            Me.sounds.errorSound.Play()
            Dim errorsStr As String = String.Join(Environment.NewLine, Me.Errors)
            MessageBox.Show(errorsStr)
            Me.Errors.Clear()
        End If
    End Sub

    Private Sub ActualizarUsuario()
        Me.UM.Update(Me.UsuarioEditable)
        actionLabel.Text = "El Usuario #" & Me.UsuarioEditable.id.ToString() & " - " & Me.UsuarioEditable.usuario & " ha sido Actualizado."
    End Sub

    Private Sub obtenerDatosUsuarioEditar()
        Me.UsuarioEditable.usuario = usuarioETxt.Text
        If Me.UsuarioEditable.clave <> claveETxt.Text Then
            Me.UsuarioEditable.clave = Me.hashClave(claveTxt.Text)
        End If
        Me.UsuarioEditable.es_admin = esAdminCk.Checked
        Me.UsuarioEditable.es_cajero = esCajeroCk.Checked
    End Sub

    Private Function esValidoUsuarioActualizable()
        Dim isValid As Boolean = True
        'Usuario
        If (usuarioETxt.Text.Length < 1) Then
            Me.Errors.Add("Usuario es requerido")
        End If
        If (claveETxt.Text.Length < 1) Then
            Me.Errors.Add("la clave es requerido")
        End If
        If Errors.Count > 0 Then
            isValid = False
        End If
        Return isValid
    End Function

    Private Function hashClave(claveNOhashed As String)
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(claveNOhashed)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)

        Dim hashedClave As String = ""

        For Each b As Byte In bytesToHash
            hashedClave += b.ToString("x2")
        Next

        Return hashedClave
    End Function


    Private Sub CleanEditForm()
        usuarioETxt.Text = ""
        claveTxt.Text = ""
        esCajeroCk.Checked = False
        esAdminCk.Checked = False
    End Sub

End Class