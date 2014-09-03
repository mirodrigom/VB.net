<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdenamiento
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
        Me.GrpLista = New System.Windows.Forms.GroupBox()
        Me.LstNumeros = New System.Windows.Forms.ListBox()
        Me.GrpNumero = New System.Windows.Forms.GroupBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GrbOrden = New System.Windows.Forms.GroupBox()
        Me.RdoDescendente = New System.Windows.Forms.RadioButton()
        Me.RdoAscendente = New System.Windows.Forms.RadioButton()
        Me.BtnOrdenar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GrpLista.SuspendLayout()
        Me.GrpNumero.SuspendLayout()
        Me.GrbOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpLista
        '
        Me.GrpLista.Controls.Add(Me.LstNumeros)
        Me.GrpLista.ForeColor = System.Drawing.Color.SteelBlue
        Me.GrpLista.Location = New System.Drawing.Point(278, 42)
        Me.GrpLista.Name = "GrpLista"
        Me.GrpLista.Size = New System.Drawing.Size(221, 243)
        Me.GrpLista.TabIndex = 0
        Me.GrpLista.TabStop = False
        Me.GrpLista.Text = "Lista de Numeros"
        '
        'LstNumeros
        '
        Me.LstNumeros.FormattingEnabled = True
        Me.LstNumeros.Location = New System.Drawing.Point(6, 25)
        Me.LstNumeros.Name = "LstNumeros"
        Me.LstNumeros.Size = New System.Drawing.Size(209, 212)
        Me.LstNumeros.TabIndex = 0
        '
        'GrpNumero
        '
        Me.GrpNumero.Controls.Add(Me.TxtNumero)
        Me.GrpNumero.Controls.Add(Me.BtnAgregar)
        Me.GrpNumero.ForeColor = System.Drawing.Color.SteelBlue
        Me.GrpNumero.Location = New System.Drawing.Point(12, 42)
        Me.GrpNumero.Name = "GrpNumero"
        Me.GrpNumero.Size = New System.Drawing.Size(234, 89)
        Me.GrpNumero.TabIndex = 1
        Me.GrpNumero.TabStop = False
        Me.GrpNumero.Text = "Ingresar un nuevo numero"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(18, 41)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(108, 20)
        Me.TxtNumero.TabIndex = 1
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregar.Location = New System.Drawing.Point(137, 37)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(80, 27)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GrbOrden
        '
        Me.GrbOrden.Controls.Add(Me.RdoDescendente)
        Me.GrbOrden.Controls.Add(Me.RdoAscendente)
        Me.GrbOrden.Controls.Add(Me.BtnOrdenar)
        Me.GrbOrden.ForeColor = System.Drawing.Color.SteelBlue
        Me.GrbOrden.Location = New System.Drawing.Point(12, 153)
        Me.GrbOrden.Name = "GrbOrden"
        Me.GrbOrden.Size = New System.Drawing.Size(233, 131)
        Me.GrbOrden.TabIndex = 2
        Me.GrbOrden.TabStop = False
        Me.GrbOrden.Text = "Orden"
        '
        'RdoDescendente
        '
        Me.RdoDescendente.AutoSize = True
        Me.RdoDescendente.ForeColor = System.Drawing.Color.Black
        Me.RdoDescendente.Location = New System.Drawing.Point(18, 78)
        Me.RdoDescendente.Name = "RdoDescendente"
        Me.RdoDescendente.Size = New System.Drawing.Size(89, 17)
        Me.RdoDescendente.TabIndex = 3
        Me.RdoDescendente.TabStop = True
        Me.RdoDescendente.Text = "Descendente"
        Me.RdoDescendente.UseVisualStyleBackColor = True
        '
        'RdoAscendente
        '
        Me.RdoAscendente.AutoSize = True
        Me.RdoAscendente.ForeColor = System.Drawing.Color.Black
        Me.RdoAscendente.Location = New System.Drawing.Point(18, 38)
        Me.RdoAscendente.Name = "RdoAscendente"
        Me.RdoAscendente.Size = New System.Drawing.Size(82, 17)
        Me.RdoAscendente.TabIndex = 2
        Me.RdoAscendente.TabStop = True
        Me.RdoAscendente.Text = "Ascendente"
        Me.RdoAscendente.UseVisualStyleBackColor = True
        '
        'BtnOrdenar
        '
        Me.BtnOrdenar.ForeColor = System.Drawing.Color.Black
        Me.BtnOrdenar.Location = New System.Drawing.Point(117, 57)
        Me.BtnOrdenar.Name = "BtnOrdenar"
        Me.BtnOrdenar.Size = New System.Drawing.Size(100, 27)
        Me.BtnOrdenar.TabIndex = 1
        Me.BtnOrdenar.Text = "Ordenar"
        Me.BtnOrdenar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Aplicacion._07.My.Resources.Resources.unnamed
        Me.BtnSalir.Location = New System.Drawing.Point(518, 53)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(93, 77)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'FrmOrdenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 297)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GrbOrden)
        Me.Controls.Add(Me.GrpNumero)
        Me.Controls.Add(Me.GrpLista)
        Me.Name = "FrmOrdenamiento"
        Me.Text = "Ordenamiento por Burbujeo"
        Me.GrpLista.ResumeLayout(False)
        Me.GrpNumero.ResumeLayout(False)
        Me.GrpNumero.PerformLayout()
        Me.GrbOrden.ResumeLayout(False)
        Me.GrbOrden.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpLista As System.Windows.Forms.GroupBox
    Friend WithEvents LstNumeros As System.Windows.Forms.ListBox
    Friend WithEvents GrpNumero As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents GrbOrden As System.Windows.Forms.GroupBox
    Friend WithEvents RdoDescendente As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAscendente As System.Windows.Forms.RadioButton
    Friend WithEvents BtnOrdenar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox

End Class
