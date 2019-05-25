Imports System.Math

Module Hipotenusa
    Sub Main(args As String())
        Dim a, b As String
        Console.Write("Ingrese el lado A del triangulo: ")
        a = Console.ReadLine()
        Console.Write("Ingrese el lado B del triangulo: ")
        b = Console.ReadLine()
        Console.WriteLine("El resultado de la hipotenusa es: " & CalculoC(a, b))
    End Sub

    Function CalculoC(a As UInt16, b As UInt16) As UInt16
        Return Sqrt(Pow(a, 2) + Pow(b, 2))
    End Function
End Module
