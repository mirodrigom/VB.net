Public Class FrmCadenas

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        For Each box As Control In Me.Controls
            If TypeOf box Is TextBox Then
                box.Text = ""
            End If
        Next
    End Sub

    Private Sub BtnOperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOperar.Click
        TxtInvertida.Text = DevolverCadenaInvertida(TxtCadena.Text)
        TxtAlfabetico.Text = DevolverCadenaAlfabeticamente(TxtCadena.Text)
    End Sub

    Private Function DevolverCadenaInvertida(ByVal Cadena As String) As String

        Return StrReverse(Cadena)

    End Function

    Private Function DevolverCadenaAlfabeticamente(ByVal Cadena As String) As String
        REM Tengo que hacer 2 for y recorrer?
        Dim aux As String
        Dim Vector As String()
        Vector = New String(Cadena.Length) {}


        For contador = 0 To Cadena.Length - 1
            If Not Cadena.Substring(contador, 1) = " " Then
                Vector(contador) = Cadena.Substring(contador, 1)
            End If
        Next

        For i = 0 To Cadena.Length - 1
            For j = 0 To Cadena.Length - 1
                If Vector(j) >= Vector(i) Then
                    aux = Vector(j)
                    Vector(j) = Vector(i)
                    Vector(i) = aux

                End If
            Next
        Next

        Return String.Join("", Vector)

    End Function
End Class


