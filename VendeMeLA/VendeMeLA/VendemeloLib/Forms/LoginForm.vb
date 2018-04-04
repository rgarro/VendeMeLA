Public Class LoginForm

    Private sounds As VMLSounds = New VMLSounds()
    Private LM As LoginManager = New LoginManager()
    Private no_verificado As Boolean = True

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.sounds.clickSound.Play()
        If Me.isValidForm Then
            Me.LM.usuario_str = UsernameTextBox.Text
            Me.LM.getClave(PasswordTextBox.Text)
            If Me.LM.verificarCredenciales() Then
                Me.no_verificado = False
                Form1.usuarioActual = LM.usuarioVerificado
                Form1.despuesDeAutenticar()
                Me.Close()
            Else
                Me.sounds.errorSound.Play()
                errorsLabel.Text = "Usuario o Clave erroneos"
            End If
        Else
            Me.sounds.errorSound.Play()
            errorsLabel.Text = "Usuario y Clave son requeridos"
        End If
    End Sub

    Public Function isValidForm()
        Dim is_valid As Boolean = True
        If (UsernameTextBox.Text.Length < 1) Then
            is_valid = False
        End If
        If (PasswordTextBox.Text.Length < 1) Then
            is_valid = False
        End If

        Return is_valid
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.sounds.clickSound.Play()
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.no_verificado Then
            Form1.Close()
        End If
    End Sub


End Class
