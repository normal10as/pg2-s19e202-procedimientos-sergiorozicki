Imports System

Module Program
    Sub Main(args As String())

        Dim valor3 As Integer = 15
        Dim valor1 As Integer = 5
        Dim valor2 As Integer = 9
        Dim valor4 As Integer = 21
        Console.WriteLine("La suma de valor1 y valor2 es: " & Suma(valor1, valor2))
        Console.WriteLine("La suma de valor 1, valor3 y valor4 es: " & Suma(valor1, valor3, valor4))
        Console.WriteLine("La suma de valor1, valor2, valor3 y valor4 es: " & Suma(valor1, valor2, valor3, valor4))
    End Sub
    Private Function Suma(valor1 As Integer, valor2 As Integer) As Integer
        Return valor1 + valor2
    End Function
    Private Function Suma(valor1 As Integer, valor3 As Integer, valor4 As Integer) As Integer
        Return valor1 + valor3 + valor4
    End Function
    Private Function Suma(valor1 As Integer, valor2 As Integer, valor3 As Integer, valor4 As Integer) As Integer
        Return valor1 + valor2 + valor3 + valor4
    End Function
End Module
