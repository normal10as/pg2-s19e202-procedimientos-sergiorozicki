Imports System.Math

Module Potencias
    Sub Main(args As String())

        Dim valor As Integer

        Console.Write("Ingrese un valor numerico valor: ")
        valor = Console.ReadLine()
        Console.WriteLine("El valor elevado a 2 es: " & ElevadoAl2(valor))
        Console.WriteLine("El valor elevado a 3 es: " & ElevadoAl3(valor))
        Console.WriteLine("El valor elevado a 5 es: " & ElevadoAl5(valor))
    End Sub
    Function ElevadoAl2(valor)
        Return Pow(valor, 2)
    End Function
    Function ElevadoAl3(valor)
        Return Pow(valor, 3)
    End Function
    Function ElevadoAl5(valor)
        Return Pow(valor, 5)
    End Function
End Module
