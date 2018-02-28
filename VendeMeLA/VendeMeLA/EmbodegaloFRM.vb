Public Class EmbodegaloFRM

    Private Function esValidoEmbodegable()
        Dim isValid As Boolean
        isValid = True
        Return isValid
    End Function

    Private Sub showEmbodegarBTN_Click(sender As Object, e As EventArgs) Handles showEmbodegarBTN.Click
        If (Me.esValidoEmbodegable()) Then
            MessageBox.Show("valid Form")
        Else
            MessageBox.Show("Invalid Form")
        End If
    End Sub
End Class