'Učitavati cijele brojeve s konzole sve dok se upisuju pozitivni brojevi. Ispisati koliko je
'korisnik upisao prostih brojeva.

Imports System
Imports System.Linq.Expressions

Module Program
    Sub Main(args As String())
        Dim broj As Integer
        Dim brojac As Integer = 0
        Dim prost As Boolean
        Console.WriteLine("Unosi pozitivne brojeve, za kraj unesi negativni.")
        broj = Console.ReadLine()
        Do While broj > 0
            For i = 2 To broj - 1
                prost = True
                If broj Mod i = 0 Then
                    prost = False
                    Exit For
                End If
            Next
            If prost Then
                brojac += 1
            End If
            broj = Console.ReadLine()
        Loop
        Console.WriteLine("Uneseno je {0} prostih brojeva", brojac)

    End Sub
End Module
