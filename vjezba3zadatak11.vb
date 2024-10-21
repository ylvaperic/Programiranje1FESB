'Učitavati brojeve dok se ne unese 0. Ispisati zbroj učitanih brojeva, te one koji su djeljivi
's 5 ili sa 7.

Imports System

Module Program
    Sub Main(args As String())
        Dim brojevi, suma As Integer
        Dim i As Integer
        suma = 0
        Console.WriteLine("Unosi brojeve, za kraj unesi 0")
        Do
            brojevi = Console.ReadLine()
            suma = suma + brojevi
            If brojevi Mod 5 = 0 Or brojevi Mod 7 = 0 Then
                Console.WriteLine(" Brojevi koji su djeljivi sa 5 ili sa 7", brojevi)
            End If
        Loop While (brojevi <> 0)
        Console.WriteLine("{0}", suma)
    End Sub
End Module
