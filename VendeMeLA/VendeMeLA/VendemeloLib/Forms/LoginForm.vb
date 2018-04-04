Public Class LoginForm

    Private sounds As VMLSounds = New VMLSounds()
    Private LM As LoginManager = New LoginManager()

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.sounds.clickSound.Play()
        If Me.isValidForm Then
            Me.LM.usuario = UsernameTextBox.Text
            Me.LM.getClave(PasswordTextBox.Text)
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


End Class
