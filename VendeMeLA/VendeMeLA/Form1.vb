
Imports VendeMeLA

Public Class Form1
    Public usuarioActual As Usuario
    Private sounds As VMLSounds = New VMLSounds()

    Private Sub showVendeFormBtn_Click(sender As Object, e As EventArgs) Handles showVendeFormBtn.Click
        Me.sounds.clickSound.Play()
        VendeloFRM.Show()
    End Sub

    Private Sub showEmbodegaFormBtn_Click(sender As Object, e As EventArgs) Handles showEmbodegaFormBtn.Click
        Me.sounds.clickSound.Play()
        EmbodegaloFRM.Show()
    End Sub

    Private Sub clientesBTN_Click(sender As Object, e As EventArgs) Handles clientesBTN.Click
        'open  clientes form here
        Me.sounds.clickSound.Play()
        ClientesFRM.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Will open login
        Me.HideAllButtons()
        LoginForm.Show()
        LoginForm.TopMost = True

    End Sub

    Private Sub HideAllButtons()
        showVendeFormBtn.Hide()
        showEmbodegaFormBtn.Hide()
        clientesBTN.Hide()
        usersBtn.Hide()
    End Sub

    Private Sub ShowAdminButtons()
        showEmbodegaFormBtn.Show()
        clientesBTN.Show()
        usersBtn.Show()
    End Sub

    Private Sub ShowCajeroButtons()
        showVendeFormBtn.Show()
    End Sub

    Private Sub usersBtn_Click(sender As Object, e As EventArgs) Handles usersBtn.Click
        Me.sounds.clickSound.Play()
        UsuariosForm.Show()
    End Sub

    Public Sub despuesDeAutenticar()
        Me.sounds.processSound.Play()
        'System.Console.WriteLine(Me.usuarioActual.usuario)
        Me.actionLabel.Text = "Bienvenido: " & Me.usuarioActual.usuario
        If Me.usuarioActual.es_admin Then
            Me.ShowAdminButtons()
        End If
        If Me.usuarioActual.es_cajero Then
            Me.ShowCajeroButtons()
        End If
    End Sub

End Class
