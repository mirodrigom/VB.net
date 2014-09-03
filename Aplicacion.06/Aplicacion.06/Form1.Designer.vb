<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadenas
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
        Me.BtnOperar = New System.Windows.Forms.Button()
        Me.TxtCadena = New System.Windows.Forms.TextBox()
        Me.TxtInvertida = New System.Windows.Forms.TextBox()
        Me.TxtAlfabetico = New System.Windows.Forms.TextBox()
        Me.LblCadena = New System.Windows.Forms.Label()
        Me.LblInvertida = New System.Windows.Forms.Label()
        Me.LblAlfabetico = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(297, 151)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(108, 32)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(157, 151)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(108, 32)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnOperar
        '
        Me.BtnOperar.Location = New System.Drawing.Point(12, 151)
        Me.BtnOperar.Name = "BtnOperar"
        Me.BtnOperar.Size = New System.Drawing.Size(108, 32)
        Me.BtnOperar.TabIndex = 2
        Me.BtnOperar.Text = "Operar"
        Me.BtnOperar.UseVisualStyleBackColor = True
        '
        'TxtCadena
        '
        Me.TxtCadena.Location = New System.Drawing.Point(234, 30)
        Me.TxtCadena.Name = "TxtCadena"
        Me.TxtCadena.Size = New System.Drawing.Size(153, 20)
        Me.TxtCadena.TabIndex = 3
        '
        'TxtInvertida
        '
        Me.TxtInvertida.Location = New System.Drawing.Point(234, 67)
        Me.TxtInvertida.Name = "TxtInvertida"
        Me.TxtInvertida.Size = New System.Drawing.Size(153, 20)
        Me.TxtInvertida.TabIndex = 4
        '
        'TxtAlfabetico
        '
        Me.TxtAlfabetico.Location = New System.Drawing.Point(234, 103)
        Me.TxtAlfabetico.Name = "TxtAlfabetico"
        Me.TxtAlfabetico.Size = New System.Drawing.Size(153, 20)
        Me.TxtAlfabetico.TabIndex = 5
        '
        'LblCadena
        '
        Me.LblCadena.AutoSize = True
        Me.LblCadena.Location = New System.Drawing.Point(72, 33)
        Me.LblCadena.Name = "LblCadena"
        Me.LblCadena.Size = New System.Drawing.Size(135, 13)
        Me.LblCadena.TabIndex = 6
        Me.LblCadena.Text = "Ingrese la cadena a invertir"
        '
        'LblInvertida
        '
        Me.LblInvertida.AutoSize = True
        Me.LblInvertida.Location = New System.Drawing.Point(120, 70)
        Me.LblInvertida.Name = "LblInvertida"
        Me.LblInvertida.Size = New System.Drawing.Size(87, 13)
        Me.LblInvertida.TabIndex = 7
        Me.LblInvertida.Text = "Cadena invertida"
        '
        'LblAlfabetico
        '
        Me.LblAlfabetico.AutoSize = True
        Me.LblAlfabetico.Location = New System.Drawing.Point(121, 106)
        Me.LblAlfabetico.Name = "LblAlfabetico"
        Me.LblAlfabetico.Size = New System.Drawing.Size(86, 13)
        Me.LblAlfabetico.TabIndex = 8
        Me.LblAlfabetico.Text = "Orden Alfabetico"
        '
        'FrmCadenas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 198)
        Me.Controls.Add(Me.LblAlfabetico)
        Me.Controls.Add(Me.LblInvertida)
        Me.Controls.Add(Me.LblCadena)
        Me.Controls.Add(Me.TxtAlfabetico)
        Me.Controls.Add(Me.TxtInvertida)
        Me.Controls.Add(Me.TxtCadena)
        Me.Controls.Add(Me.BtnOperar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmCadenas"
        Me.Text = "Manejo de Cadenas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnOperar As System.Windows.Forms.Button
    Friend WithEvents TxtCadena As System.Windows.Forms.TextBox
    Friend WithEvents TxtInvertida As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlfabetico As System.Windows.Forms.TextBox
    Friend WithEvents LblCadena As System.Windows.Forms.Label
    Friend WithEvents LblInvertida As System.Windows.Forms.Label
    Friend WithEvents LblAlfabetico As System.Windows.Forms.Label

End Class
