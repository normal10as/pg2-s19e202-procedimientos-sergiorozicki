Imports System.DateTime

Module AhoraEs
    Sub Main(args As String())
        ImprimirFecha()
        Console.WriteLine("La hora es: " & ObtenerHora())
    End Sub

    Sub ImprimirFecha()
        Console.WriteLine("Hoy es: " & Now.Date)
    End Sub

    Function ObtenerHora() As String
        Return Now.Hour & ":" & Now.Minute
    End Function
End Module
