<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaludo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnSaludo = New System.Windows.Forms.Button
        Me.LblSaludo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnSaludo
        '
        Me.BtnSaludo.Location = New System.Drawing.Point(90, 174)
        Me.BtnSaludo.Name = "BtnSaludo"
        Me.BtnSaludo.Size = New System.Drawing.Size(126, 33)
        Me.BtnSaludo.TabIndex = 0
        Me.BtnSaludo.Text = "Haga click aqui"
        Me.BtnSaludo.UseVisualStyleBackColor = True
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaludo.Location = New System.Drawing.Point(48, 36)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(0, 24)
        Me.LblSaludo.TabIndex = 1
        '
        'FrmSaludo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.BtnSaludo)
        Me.Name = "FrmSaludo"
        Me.Text = "Saludo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSaludo As System.Windows.Forms.Button
    Friend WithEvents LblSaludo As System.Windows.Forms.Label

End Class
