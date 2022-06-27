Module Module1

    Sub Main()
        Dim myPerson As Person = New Person("Yerson", "Quiroga", 54664, "11545")
        Dim myCat As Cat = New Cat("01", "Teo", "Persa", myPerson, 2)

        Console.WriteLine("No lifes Pet:" & myCat.NumberLifes1)
        Console.WriteLine("Pet:" & myCat.register)
    End Sub

End Module
