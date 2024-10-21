'Učitati N cijelih brojeva (N unosi korisnik). Ispisati najmanji i najveći od unesenih
'brojeva.

Imports System

Module Program
    Sub Main(args As String())
        Dim n, i, brojevi As Integer
        Dim najveci As Integer = 0
        Dim najmanji As Integer = 65536
        Console.WriteLine("Unesi limit brojeva")
        n = Console.ReadLine()
        Console.WriteLine("Unesi {0} brojeva", n)
        For i = 1 To n Step 1
            brojevi = Console.ReadLine()
            If brojevi > najveci Then
                najveci = brojevi
            End If

            If brojevi < najmanji Then
                najmanji = brojevi
            End If
        Next
        Console.WriteLine("Najveci broj je:")
        Console.WriteLine(najveci)
        Console.WriteLine("Najmanji broj je:")
        Console.WriteLine(najmanji)


    End Sub
End Module
