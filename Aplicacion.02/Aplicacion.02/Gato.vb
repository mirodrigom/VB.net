<Serializable()> _
Public Class Gato
    Inherits Mascota

    Public Maullar As Boolean

    Sub New(ByVal Nombre As String, ByVal Raza As eRaza)
        MyBase.New(Nombre, Raza) REM MODIFICAR ESTO
    End Sub

    Public Overrides Sub Mostrar()
        Console.WriteLine("Nombre: " & MyBase._nombre & "\nEdad: " & MyBase._edad & "\nRaza: " & MyBase._raza)
    End Sub

    Public Function RetornarRaza(ByVal gatito As Gato) As eRaza
        Return gatito._raza
    End Function

End Class
