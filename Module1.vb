Module Module1

    Sub Main()

        Console.WriteLine("Wel-Come To Prectiacl 1")
        Console.ReadKey()
        Console.Clear()

        desed_line()
        Console.WriteLine("Wel-Come To Arithmetic Calculator")
        desed_line()

        Dim a, b, subt, mul, div, add As Double

        Console.Write("Enter The Velue Of A ::::")
        a = Console.ReadLine()
        desed_line()

        Console.Write("Enter The Velue Of B ::::")
        b = Console.ReadLine()
        desed_line()

        add = a + b
        div = a / b
        mul = a * b
        subt = a - b

        ans("addition", add)
        desed_line()

        ans("subtraction", subt)
        desed_line()

        ans("division", div)
        desed_line()

        ans("multiplication", mul)
        desed_line()

        Console.ReadKey()
    End Sub

    Sub desed_line()
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------")
    End Sub
    Sub ans(answer, anstype)
        Console.WriteLine(answer & " = " & anstype)
    End Sub
End Module
