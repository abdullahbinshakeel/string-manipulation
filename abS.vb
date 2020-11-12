Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim str2 As String = ""

        Dim sum1 As Integer = 0
        Dim sum2 As Integer = 0

        Dim i As Integer = 0

        Dim myChar As Char = ""
        Dim ASCIICODE As Integer = 0

        Console.Write("Enter 1st string: ")
        str1 = Console.ReadLine

        Console.Write("Enter 2nd string: ")
        str2 = Console.ReadLine

        str1 = UCase(str1)
        str2 = UCase(str2)

        For i = 1 To Len(str1)
            myChar = Mid(str1, i, 1)
            ASCIICODE = Asc(myChar)
            sum1 = sum1 + ASCIICODE
        Next

        For i = 1 To Len(str2)
            myChar = Mid(str2, i, 1)
            ASCIICODE = Asc(myChar)
            sum2 = sum2 + ASCIICODE
        Next

        If sum1 = sum2 Then
            Console.WriteLine(str1 & " and " & str2 & " are anagrams.")
        Else
            Console.WriteLine(str1 & " and " & str2 & " are NOT anagrams.")
        End If

        Console.ReadKey()
    End Sub

End Module
