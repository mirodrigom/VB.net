Module Main
    Public Sub Main()

        Try
            Dim frmInicio As New FrmTabla
            Application.Run(frmInicio)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error Desconocido")
        Finally
        End Try
    End Sub
End Module
