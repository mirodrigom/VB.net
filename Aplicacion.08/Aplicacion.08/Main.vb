Module Main
    Public Sub Main()

        Try
            Dim frmInicio As New FrmInformacion
            Application.Run(frmInicio)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Desconocido")
        Finally
        End Try
    End Sub
End Module
