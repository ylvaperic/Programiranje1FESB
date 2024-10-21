'U?itati N cijelih brojeva (N unosi korisnik). Izra?unati i ispisati njihovu aritmeti?ku sredinu.


Imports System

Module Program
    Sub Main(args As String())
        Dim n, i As Integer
        Dim suma As Integer = 0
        Dim broj As Integer

        Console.WriteLine("Unesi limit broja!")
        n = Console.ReadLine()
        Console.WriteLine("Unosi brojeve")
        For i = 1 To n Step 1
            broj = Console.ReadLine()
            suma += broj
        Next

        Console.WriteLine("Aritmeti?ka sredina brojeva iznosi {0}", suma / n)
    End Sub
End Module
