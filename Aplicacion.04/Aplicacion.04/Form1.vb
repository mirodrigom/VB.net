Public Class FrmTabla

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click
        lstTabla.Items.Clear()
    End Sub

    Private Sub txtNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown

    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress

        Dim numero As Integer
        Dim verdad As Boolean
        Dim devolver As Integer

        'Veo si puedo transofrmarlo
        verdad = Integer.TryParse(txtNumero.Text, numero)

        If e.KeyChar() = ChrW(Keys.Enter) AndAlso verdad = True Then REM o ChrW(13) equivale al enter

            numero = CType(txtNumero.Text, Integer) REM 144

            For i = 1 To 9

                devolver = numero * i
                lstTabla.Items.Add(txtNumero.Text & " * " & i & " = " & CType(devolver, String))

            Next
        End If

    End Sub

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub
End Class
