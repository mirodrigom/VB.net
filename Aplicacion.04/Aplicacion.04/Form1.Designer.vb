<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTabla
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
        Me.btnLista = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lstTabla = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(197, 114)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(81, 49)
        Me.btnLista.TabIndex = 0
        Me.btnLista.Text = "Limpiar"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(29, 24)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(97, 13)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "Ingrese un Numero"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(129, 21)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(27, 20)
        Me.txtNumero.TabIndex = 2
        '
        'lstTabla
        '
        Me.lstTabla.FormattingEnabled = True
        Me.lstTabla.Location = New System.Drawing.Point(32, 89)
        Me.lstTabla.Name = "lstTabla"
        Me.lstTabla.Size = New System.Drawing.Size(124, 160)
        Me.lstTabla.TabIndex = 3
        '
        'FrmTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lstTabla)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnLista)
        Me.Name = "FrmTabla"
        Me.Text = "Tabla de Multiplicar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lstTabla As System.Windows.Forms.ListBox

End Class
