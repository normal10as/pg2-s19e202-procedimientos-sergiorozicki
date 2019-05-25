Imports System

Module NuevaFecha
    Sub Main(args As String())

        Dim dias_a_sumar As Integer
        Dim fecha As Date

        Console.Write("Ingrese feche: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese dias a sumar: ")
        dias_a_sumar = Console.ReadLine()
        Console.WriteLine("Fecha obtenida de la suma: " & SumarDias(fecha, dias_a_sumar))
    End Sub
    Function SumarDias(fecha, dias_a_sumar)
        Return fecha.AddDays(dias_a_sumar)
    End Function
End Module
