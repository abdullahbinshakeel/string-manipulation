Module Module1

    Sub Main()
        'decleration
        Dim l, x, y, sum As Integer
        Console.Write("Enter Max Value: ")

        'initialisation
        l = Console.ReadLine
        sum = 0
        x = 0
        y = 1
        Console.Write(x & " , " & y)
        While sum <= l
            sum = x + y
            Console.Write(" , " & Str(sum))
            x = y
            y = sum

        End While
        Console.ReadKey()

    End Sub

End Module
