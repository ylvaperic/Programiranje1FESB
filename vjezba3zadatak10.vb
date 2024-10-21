'Učitati 10 troznamenkastih brojeva i za svaki od učitanih brojeva ispisati aritmetičku
'sredinu njegovih znamenki.

Imports System

Module Program
    Sub Main(args As String())
        Dim brojevi, i, ostatak As Integer
        Dim suma As Integer = 0
        Console.WriteLine("Unesi 10 troznamenkastih brojeva:")
        For i = 0 To 9 Step 1
            brojevi = Console.ReadLine()
            suma = 0
            Do
                ostatak = brojevi Mod 10
                suma = suma + ostatak
                brojevi = brojevi \ 10
            Loop Until brojevi = 0
            Console.WriteLine("Aritmetička sredina znamenki je {0}", suma / 3)

        Next
    End Sub
End Module
