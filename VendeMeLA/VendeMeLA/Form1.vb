
Imports VendeMeLA

Public Class Form1

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Will open login

        LoginForm.Show()
        LoginForm.TopMost = True

    End Sub
End Class
