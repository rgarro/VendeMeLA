Public Class DBObject

    Public db As LiteDB.LiteDatabase

    Public Sub New()
        Using mdb As LiteDB.LiteDatabase = New LiteDB.LiteDatabase("VendeMela.db")
            Me.db = mdb
        End Using
    End Sub

End Class
