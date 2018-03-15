
Imports VendeMeLA

Public Class Form1

    Private clickSound = New System.Media.SoundPlayer("C:\Users\rolando\Documents\UHispanoamericana\VendemelaE\VendeMeLA\VendeMeLA\VendeMeLA\VendemeloLib\wavs\potatoCruch.wav")

    Private Sub showVendeFormBtn_Click(sender As Object, e As EventArgs) Handles showVendeFormBtn.Click
        Me.clickSound.Play()
        VendeloFRM.Show()
    End Sub

    Private Sub showEmbodegaFormBtn_Click(sender As Object, e As EventArgs) Handles showEmbodegaFormBtn.Click
        Me.clickSound.Play()
        EmbodegaloFRM.Show()
    End Sub
End Class
