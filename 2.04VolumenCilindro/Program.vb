Imports System.Math

Module VolumenCilindro
    Sub Main(args As String())

        Dim radio, altura As Integer

        Console.Write("Ingrese el radio del cicilindro: ")
        radio = Console.ReadLine()
        Console.Write("Ingrese la altura del cilindro: ")
        altura = Console.ReadLine()
        Console.WriteLine("El volumen del cilindro es: " & Volumen(radio, altura))
    End Sub
    Function Volumen(radio, altura)
        Return Sqrt((Math.PI) * Pow(radio, 2) * altura)
    End Function
End Module
