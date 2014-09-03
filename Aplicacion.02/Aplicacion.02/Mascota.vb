Public Enum eRaza
    Doberman = 1
    PastorAleman = 2
    Dogo = 3
    Siames = 4
    Egipcio = 5
    Persa = 6
End Enum
<Serializable()> _
<Xml.Serialization.XmlInclude(GetType(Perro))> _
<Xml.Serialization.XmlInclude(GetType(Gato))> _
Public MustInherit Class Mascota

    Protected _nombre As String
    Protected _edad As Integer
    Protected _raza As eRaza

    REM VIRTUAL
    Public Overridable Sub Jugar(ByVal conQueJuego As String)
        Console.WriteLine("Juego con: " & conQueJuego)
    End Sub

    REM ABSTRACTO
    Public MustOverride Sub Mostrar()

    Sub New(ByVal Nombre As String, ByVal queRaza As eRaza)
        Me._nombre = Nombre
        Me._raza = queRaza
    End Sub

    Sub New(ByVal Nombre As String, ByVal edad As Integer, ByVal queRaza As eRaza)
        Me._edad = edad
        Me._nombre = Nombre
        Me._raza = queRaza
    End Sub



End Class
