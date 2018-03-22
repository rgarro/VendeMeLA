
Imports VendeMeLA

Public Class Form1

    Private sounds As VMLSounds = New VMLSounds()

    Private Sub showVendeFormBtn_Click(sender As Object, e As EventArgs) Handles showVendeFormBtn.Click
        Dim ob As MSSQLDBObject = New MSSQLDBObject()

        Me.sounds.clickSound.Play()
        VendeloFRM.Show()
    End Sub

    Private Sub showEmbodegaFormBtn_Click(sender As Object, e As EventArgs) Handles showEmbodegaFormBtn.Click
        Me.sounds.clickSound.Play()
        EmbodegaloFRM.Show()
    End Sub
End Class
