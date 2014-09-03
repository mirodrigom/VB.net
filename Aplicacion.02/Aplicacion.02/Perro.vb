<Serializable()> _
Public NotInheritable Class Perro
    Inherits Mascota

    Public Ladrar As Boolean

    Sub New(ByVal Nombre As String, ByVal Raza As eRaza)
        MyBase.New(Nombre, Raza) REM MODIFICAR ESTO
    End Sub

    Public Overrides Sub Mostrar()
        Console.WriteLine("Nombre: " & MyBase._nombre & "\nEdad: " & MyBase._edad & "\nRaza: " & MyBase._raza)
    End Sub

    Public Function RetornarRaza(ByVal perrito As Perro) As eRaza
        Return perrito._raza
    End Function


End Class
