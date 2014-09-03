Module Module1

    Sub Main()
        Dim ger As New Gerente()
        Dim emp As New Empleado()

        ger.Comer("Hamburguesa")
        ger.Dormir()
        emp.Comer("Pastas")
        emp.Dormir()
        emp.Trabajar()

        Console.ReadKey()


    End Sub

End Module
