Public Class LoginForm

    Private sounds As VMLSounds = New VMLSounds()

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.sounds.clickSound.Play()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.sounds.clickSound.Play()
        Form1.Close()
        Me.Close()
    End Sub


End Class
