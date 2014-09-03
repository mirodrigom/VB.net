<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescuento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.TxtPagar = New System.Windows.Forms.TextBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.GrpInformacion = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblDescuento = New System.Windows.Forms.Label()
        Me.GrpInformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(286, 163)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(97, 25)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(164, 163)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(97, 25)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(38, 163)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(97, 25)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(207, 28)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(73, 20)
        Me.TxtMonto.TabIndex = 3
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Location = New System.Drawing.Point(238, 71)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(73, 20)
        Me.TxtDescuento.TabIndex = 4
        '
        'TxtPagar
        '
        Me.TxtPagar.Location = New System.Drawing.Point(238, 102)
        Me.TxtPagar.Name = "TxtPagar"
        Me.TxtPagar.ReadOnly = True
        Me.TxtPagar.Size = New System.Drawing.Size(73, 20)
        Me.TxtPagar.TabIndex = 5
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.ForeColor = System.Drawing.Color.Black
        Me.LblMonto.Location = New System.Drawing.Point(45, 31)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(156, 13)
        Me.LblMonto.TabIndex = 6
        Me.LblMonto.Text = "Ingrese el monto a cobrar:"
        '
        'GrpInformacion
        '
        Me.GrpInformacion.Controls.Add(Me.LblTotal)
        Me.GrpInformacion.Controls.Add(Me.LblDescuento)
        Me.GrpInformacion.Controls.Add(Me.LblMonto)
        Me.GrpInformacion.Controls.Add(Me.TxtPagar)
        Me.GrpInformacion.Controls.Add(Me.TxtDescuento)
        Me.GrpInformacion.Controls.Add(Me.TxtMonto)
        Me.GrpInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpInformacion.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GrpInformacion.Location = New System.Drawing.Point(28, 16)
        Me.GrpInformacion.Name = "GrpInformacion"
        Me.GrpInformacion.Size = New System.Drawing.Size(374, 141)
        Me.GrpInformacion.TabIndex = 7
        Me.GrpInformacion.TabStop = False
        Me.GrpInformacion.Text = "Informacion"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.ForeColor = System.Drawing.Color.Black
        Me.LblTotal.Location = New System.Drawing.Point(159, 105)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(73, 13)
        Me.LblTotal.TabIndex = 8
        Me.LblTotal.Text = "Total a pagar:"
        '
        'LblDescuento
        '
        Me.LblDescuento.AutoSize = True
        Me.LblDescuento.ForeColor = System.Drawing.Color.Black
        Me.LblDescuento.Location = New System.Drawing.Point(130, 74)
        Me.LblDescuento.Name = "LblDescuento"
        Me.LblDescuento.Size = New System.Drawing.Size(102, 13)
        Me.LblDescuento.TabIndex = 7
        Me.LblDescuento.Text = "Descuento recibido:"
        '
        'FrmDescuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 205)
        Me.Controls.Add(Me.GrpInformacion)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmDescuento"
        Me.Text = "Descuento"
        Me.GrpInformacion.ResumeLayout(False)
        Me.GrpInformacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents TxtPagar As System.Windows.Forms.TextBox
    Friend WithEvents LblMonto As System.Windows.Forms.Label
    Friend WithEvents GrpInformacion As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblDescuento As System.Windows.Forms.Label

End Class
