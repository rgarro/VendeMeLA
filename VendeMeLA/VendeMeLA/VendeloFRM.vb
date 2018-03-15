Imports VendeMeLA

Public Class VendeloFRM

    Private clickSound = New System.Media.SoundPlayer("C:\Users\rolando\Documents\UHispanoamericana\VendemelaE\VendeMeLA\VendeMeLA\VendeMeLA\VendemeloLib\wavs\potatoCruch.wav")
    Private processSound = New System.Media.SoundPlayer("C:\Users\rolando\Documents\UHispanoamericana\VendemelaE\VendeMeLA\VendeMeLA\VendeMeLA\VendemeloLib\wavs\fryingChips.wav")
    Private errorSound = New System.Media.SoundPlayer("C:\Users\rolando\Documents\UHispanoamericana\VendemelaE\VendeMeLA\VendeMeLA\VendeMeLA\VendemeloLib\wavs\errorSound.wav")
    Private mdb As LiteDB.LiteDatabase
    Private articulos

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        'System.Console.WriteLine("no sea bruto vote por ")
        Using db As LiteDB.LiteDatabase = New LiteDB.LiteDatabase("VendeMela.db")
            Me.mdb = db
        End Using
        Me.articulos = Me.mdb.GetCollection(Of Articulo)("articulo")
        Me.llenarProductosDisponibles()
    End Sub

    Private Sub llenarProductosDisponibles()
        Me.processSound.Play()
        Dim res = Me.articulos.FindAll
        Dim index As Integer = 0
        For Each larticulo As Articulo In res
            articulosList.Items.Add(larticulo.id & "# " & larticulo.etiqueta & " ¢" & larticulo.precio & " Unidades:" & larticulo.cantidad)
        Next larticulo
    End Sub

End Class