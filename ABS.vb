
Module middleStr

    Sub main()
        'DECLERATION
        Dim x As String = ""
        Dim myChar As Char = ""
        Dim C As Integer = 0
        Dim L1 As Integer = 0

        Console.Write("Enter The String: ")
        x = Console.ReadLine

        L1 = Len(x)

        For C = L1 To 1 Step -1
            myChar = Mid(x, C, 1)
            Console.Write(myChar)
        Next
        Console.ReadKey()


    End Sub

End Module
