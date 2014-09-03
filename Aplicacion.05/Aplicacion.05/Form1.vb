Public Class FrmDescuento

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TxtDescuento.Clear()
        TxtMonto.Clear()
        TxtPagar.Clear()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim valor As Boolean
        Dim monto As Double
        Dim valorTotal As Double
        Dim Descuento As Double

        Descuento = 0
        valor = Double.TryParse(TxtMonto.Text(), monto)

        If valor = True Then
            monto = CType(TxtMonto.Text, Double)
            If monto >= 30 AndAlso monto <= 50 Then

                Descuento = monto * 0.1

            ElseIf monto > 50 Then

                Descuento = monto * 0.2

            End If
            valorTotal = monto - Descuento

            TxtDescuento.Text = CType(Descuento, String)
            TxtPagar.Text = CType(valorTotal, String)
        Else
            MessageBox.Show("No se puede ingresar letras")
            TxtMonto.Clear()
        End If



    End Sub
End Class
