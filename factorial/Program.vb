Imports System

Module Program
    Sub Main(args As String())

        Console.Write("escriba un numero: ")
        Dim num As Integer = CInt(Console.ReadLine())

        Console.WriteLine("el factorial de " + num.ToString + " es " + factorial(num).ToString)




    End Sub

    Private Function factorial(num As Integer) As Integer

        Return Enumerable.Range(1, num).Aggregate(Function(total, siguente) total * siguente)

    End Function
End Module
