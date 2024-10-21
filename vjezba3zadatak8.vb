'Učitati N cijelih brojeva (N unosi korisnik). Izračunati i ispisati aritmetičku sredinu
'unesenih parnih brojeva osim onih koji završavaju s 4.


Imports System

Module Program
    Sub Main(args As String())
        Dim n, i As Integer
        Dim broj As Double
        Dim suma As Integer = 0
        Console.WriteLine("Unesi rang brojeva")
        n = Console.ReadLine()
        For i = 0 To n
            Console.WriteLine("Unesi neke brojeve")
            broj = Console.ReadLine()
            If broj Mod 2 = 0 And broj Mod 10 <> 4 Then
                suma = suma + broj
            End If
        Next
        Console.WriteLine("Aritmetička sredina ovih brojeva je: {0}", suma / n)



    End Sub
End Module
