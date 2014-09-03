Module Main
    Public Sub Main()

        Try
            Dim frmInicio As New FrmCadenas
            Application.Run(frmInicio)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Desconocido")
        Finally
        End Try
    End Sub
End Module
