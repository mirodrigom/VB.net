Public Class FrmOrdenamiento

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim valor As Boolean
        Dim numero As Double
        valor = Double.TryParse(TxtNumero.Text, numero)
        If valor = True Then
            numero = CType(TxtNumero.Text, Double)
            LstNumeros.Items.Add(numero)
        Else
            MessageBox.Show("Debe ser un numero el que ingresa")
        End If

    End Sub

    Private Sub BtnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrdenar.Click
        Dim Aux As Double


        For i = 0 To LstNumeros.Items.Count - 1

            For j = 0 To LstNumeros.Items.Count - 1
                If RdoAscendente.Checked = True Then

                    If CType(LstNumeros.Items.Item(j), Double) > CType(LstNumeros.Items.Item(i), Double) Then

                        Aux = CType(LstNumeros.Items.Item(j), Double)
                        LstNumeros.Items.Item(j) = LstNumeros.Items.Item(i)
                        LstNumeros.Items.Item(i) = Aux
                    End If

                ElseIf RdoDescendente.Checked = True Then REM Lo unico que cambia es el signo de mayor o menor...

                    If CType(LstNumeros.Items.Item(j), Double) < CType(LstNumeros.Items.Item(i), Double) Then

                        Aux = CType(LstNumeros.Items.Item(j), Double)
                        LstNumeros.Items.Item(j) = LstNumeros.Items.Item(i)
                        LstNumeros.Items.Item(i) = Aux
                    End If

                End If

            Next

        Next




    End Sub
End Class
