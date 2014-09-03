Imports System.Text
Imports System.IO
Imports System.Xml.Serialization

Public Enum EMascota
    Perro = 1
    Gato = 2
End Enum

Public Class Guarderia
    Implements IGuardar, ICargar
    Private _listaDeMascota As List(Of Mascota)
    Private _precioPerro As Double
    Private _precioGato As Double


    Sub New()
        Me._listaDeMascota = New List(Of Mascota)
    End Sub

    Sub New(ByVal PrecioPerro As Double, ByVal PrecioGato As Double)
        Me._precioGato = PrecioGato
        Me._precioPerro = PrecioPerro
    End Sub

    ReadOnly Property PrecioPerro As Double

        Get
            Return Me._precioPerro
        End Get

    End Property

    ReadOnly Property PrecioGato As Double

        Get
            Return Me._precioGato
        End Get

    End Property


    Public Shared Operator +(ByVal unaGuarderia As Guarderia, ByVal algunaMascota As Mascota) As Guarderia
        unaGuarderia._listaDeMascota.Add(algunaMascota)
        Return unaGuarderia
    End Operator

    Function MostrarTotalFacturado() As Single
        REM Hago El Casteo con ctype de DOUBLE a SINGLE
        Return CType(Me._precioGato, Single) + CType(Me._precioPerro, Single)
    End Function

    Function MostrarTotalFacturado(ByVal tipoDeMascota As EMascota) As Single
        If tipoDeMascota = EMascota.Gato Then
            Return CType(Me._precioGato, Single)
        ElseIf tipoDeMascota = EMascota.Perro Then
            Return CType(Me._precioPerro, Single)
        End If
        REM Si no que retorne 0..
        Return 0
    End Function


    'Function MostrarTotalFacturado(ByVal tipoDeMascota As EMascota) As Single
    '    Dim Cantidad As Double
    '    Cantidad = 0
    '    For Each item As Mascota In Me._listaDeMascota

    '        If tipoDeMascota = EMascota.Gato Then
    '            Cantidad = Cantidad + Cantidad REM VER ACA...
    '        ElseIf tipoDeMascota = EMascota.Perro Then
    '            Cantidad = Cantidad + Cantidad REM VER ACA...
    '        End If
    '    Next
    '    REM Si no que retorne 0..
    '    Return CType(Cantidad, Single)
    'End Function


    Public Sub IngresarMascota(ByVal miMascota As Mascota)
        Me._listaDeMascota.Add(miMascota)
    End Sub

    Public Overrides Function ToString() As String
        Dim sbr As New StringBuilder()
        For Each item As Mascota In Me._listaDeMascota
            item.Mostrar()
            sbr.AppendLine("Mascota: ") REM VER QUE ONDA ESTO
        Next
        Return sbr.ToString()
    End Function

    Public Function ImprimirDatosListaMascotas() As Boolean _
        Implements IGuardar.ImprimirDatosListaMascotas
        Try
            Using Escritor As StreamWriter = New StreamWriter("@C:\archivo.txt", True))
                Escritor.WriteLine(Me.ToString())
                Escritor.Close()
            End Using
        Catch ex As Exception
            Return False
        End Try
        
        Return True

    End Function

    Public Function SerializarListaMascota(ByVal ruta As String) As Boolean _
        Implements IGuardar.SerializarListaMascota

        Try

            Using XMLSerializar As New StreamWriter("C:\Product.xml")
                Dim x As New XmlSerializer(Me._listaDeMascota.GetType)
                x.Serialize(XMLSerializar, Me._listaDeMascota)
                XMLSerializar.Close()
            End Using


        Catch ex As Exception
            Return False
        End Try

        Return True


    End Function

    Public Function TraerDatosMascota() As Boolean _
        Implements ICargar.TraerDatosMascota
        Dim linea As String
        Try
            Using Lector As StreamReader = New StreamReader("@C:\archivo.txt")

                linea = Lector.ReadLine
                Do While (Not linea Is Nothing)
                    Lector.ReadLine()
                Loop
                Console.WriteLine(Lector)
                Lector.Close()
            End Using
        Catch ex As Exception
            Return False
        End Try

        Return True


    End Function

    Public Function DeserealizarListaMascota() As Boolean _
        Implements ICargar.DeserealizarListaMascota

        Try
            
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

End Class
