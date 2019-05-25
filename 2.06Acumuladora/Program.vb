Imports System

Module Acumuladora
    Sub Main(args As String())

        Dim valor As Decimal

        SubRutina(valor)
        SubRutina(valor)
        SubRutina(valor)
    End Sub
    Private Sub SubRutina(ByRef valor As Decimal)
        valor += 1
        Console.WriteLine("El acumulador es: " & valor)
    End Sub
End Module
