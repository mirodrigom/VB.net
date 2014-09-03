Module Module1

    Sub Main()

        Console.WriteLine("")
        Dim gato1 As New Gato("Pepe", eRaza.Persa)
        Dim gato2 As New Gato("Lolo", eRaza.Siames)
        Dim gato3 As New Gato("hi", eRaza.Egipcio)

        Console.WriteLine("")
        Dim perro1 As New Perro("Dogo", eRaza.Dogo)
        Dim perro2 As New Perro("Jeje", eRaza.Doberman)
        Dim perro3 As New Perro("Pastor", eRaza.PastorAleman)

        Console.WriteLine("")
        Dim Guarde As New Guarderia()
        Guarde = Guarde + perro2
        Console.WriteLine("Total Facturado: ")
        Guarde.MostrarTotalFacturado()

        Console.WriteLine("Total Facturado por Gatos: ")
        Guarde.MostrarTotalFacturado(EMascota.Gato)
        Console.WriteLine("Total Facturado por Perros: ")
        Guarde.MostrarTotalFacturado(EMascota.Perro)
        Console.WriteLine("Imprimir Datos Lista Mascotas")
        Guarde.ImprimirDatosListaMascotas()
        Console.WriteLine("Serializar Lista Mascotas")
        Guarde.SerializarListaMascota("@C:\ASD\")
        Console.WriteLine("Deserializar Lista Mascotas")
        Guarde.DeserealizarListaMascota()
        Console.WriteLine("Traer Datos Lista Mascotas")
        Guarde.TraerDatosMascota()
        Console.WriteLine("Mostrar Por Consola todos los atributos de las mascotas")
        Guarde.ToString()

    End Sub

End Module
