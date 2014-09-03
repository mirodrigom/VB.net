Public Class Gerente
    Inherits SerHumano


    Public Overrides Sub Comer(ByVal hola As String)
        Console.WriteLine(hola)
    End Sub

    Public Overrides Sub Dormir()
        Console.WriteLine("Durmiendo..")
    End Sub
End Class
