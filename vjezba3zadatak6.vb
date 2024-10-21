' Korisnik unosi broj n, potrebno je napraviti ispis kao na predlošku

Imports System

Module Program
    Sub Main(args As String())
        Dim n As Integer
        Dim i, j As Integer
        Console.WriteLine("Unesite neki broj")
        n = Integer.Parse(Console.ReadLine())
        For i = n To 0 Step -1
            For j = 0 To i - 1
                Console.Write("+")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
