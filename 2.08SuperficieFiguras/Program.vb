Imports System

Module SuperficieFiguras
    Sub Main(args As String())

        Dim base As Integer = 3
        Dim base2 As Integer = 7
        Dim altura As Integer = 4

        Console.WriteLine("La superficie del cubo es: " & Superficie(base))
        Console.WriteLine("La superficie del rectangulo es: " & Superficie(base, altura))
        Console.WriteLine("La superficie del trapecio es: " & Superficie(base, base2, altura))
    End Sub
    Private Function Superficie(lado_cubo As Integer) As Integer
        Return lado_cubo * lado_cubo
    End Function
    Private Function Superficie(base_rectangulo As Integer, altura_rectangulo As Integer) As Integer
        Return base_rectangulo * altura_rectangulo
    End Function
    Private Function Superficie(base_menor_trapecio As Integer, base_mayor_trapecio As Integer, altura_trapecio As Integer) As Integer
        Return (base_mayor_trapecio + base_menor_trapecio) * (altura_trapecio) / (2)
    End Function
End Module
