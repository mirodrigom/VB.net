Public MustInherit Class SerHumano

    Private _nombre As String
    Private _peso As Single
    Private _altura As Single
    Private _sexo As String

    Public MustOverride Sub Comer(ByVal comida As String)

    Public MustOverride Sub Dormir()


End Class
