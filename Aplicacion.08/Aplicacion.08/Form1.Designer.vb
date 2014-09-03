<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformacion
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
        Me.components = New System.ComponentModel.Container()
        Me.GrpNumero = New System.Windows.Forms.GroupBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.LblIngrese = New System.Windows.Forms.Label()
        Me.GrpInformacion = New System.Windows.Forms.GroupBox()
        Me.TxtCifra_Menor = New System.Windows.Forms.TextBox()
        Me.LblCifra_Menor = New System.Windows.Forms.Label()
        Me.TxtCifra_Mayor = New System.Windows.Forms.TextBox()
        Me.LblCifra_Mayor = New System.Windows.Forms.Label()
        Me.TxtSuma_Cifras = New System.Windows.Forms.TextBox()
        Me.LblSuma_Cifras = New System.Windows.Forms.Label()
        Me.TxtCifras_Impares = New System.Windows.Forms.TextBox()
        Me.LblCifras_Impares = New System.Windows.Forms.Label()
        Me.TxtCifrasPares = New System.Windows.Forms.TextBox()
        Me.LblCifras_Pares = New System.Windows.Forms.Label()
        Me.TxtCantidad_Cifras = New System.Windows.Forms.TextBox()
        Me.LblCantidad_Cifras = New System.Windows.Forms.Label()
        Me.GrpLista = New System.Windows.Forms.GroupBox()
        Me.LstDivisores = New System.Windows.Forms.ListBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GrpNumero.SuspendLayout()
        Me.GrpInformacion.SuspendLayout()
        Me.GrpLista.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpNumero
        '
        Me.GrpNumero.Controls.Add(Me.TxtNumero)
        Me.GrpNumero.Controls.Add(Me.LblIngrese)
        Me.GrpNumero.Location = New System.Drawing.Point(35, 19)
        Me.GrpNumero.Name = "GrpNumero"
        Me.GrpNumero.Size = New System.Drawing.Size(254, 68)
        Me.GrpNumero.TabIndex = 0
        Me.GrpNumero.TabStop = False
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(138, 28)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(101, 20)
        Me.TxtNumero.TabIndex = 3
        '
        'LblIngrese
        '
        Me.LblIngrese.AutoSize = True
        Me.LblIngrese.Location = New System.Drawing.Point(34, 31)
        Me.LblIngrese.Name = "LblIngrese"
        Me.LblIngrese.Size = New System.Drawing.Size(98, 13)
        Me.LblIngrese.TabIndex = 2
        Me.LblIngrese.Text = "Ingrese un numero:"
        '
        'GrpInformacion
        '
        Me.GrpInformacion.Controls.Add(Me.TxtCifra_Menor)
        Me.GrpInformacion.Controls.Add(Me.LblCifra_Menor)
        Me.GrpInformacion.Controls.Add(Me.TxtCifra_Mayor)
        Me.GrpInformacion.Controls.Add(Me.LblCifra_Mayor)
        Me.GrpInformacion.Controls.Add(Me.TxtSuma_Cifras)
        Me.GrpInformacion.Controls.Add(Me.LblSuma_Cifras)
        Me.GrpInformacion.Controls.Add(Me.TxtCifras_Impares)
        Me.GrpInformacion.Controls.Add(Me.LblCifras_Impares)
        Me.GrpInformacion.Controls.Add(Me.TxtCifrasPares)
        Me.GrpInformacion.Controls.Add(Me.LblCifras_Pares)
        Me.GrpInformacion.Controls.Add(Me.TxtCantidad_Cifras)
        Me.GrpInformacion.Controls.Add(Me.LblCantidad_Cifras)
        Me.GrpInformacion.Location = New System.Drawing.Point(35, 93)
        Me.GrpInformacion.Name = "GrpInformacion"
        Me.GrpInformacion.Size = New System.Drawing.Size(254, 251)
        Me.GrpInformacion.TabIndex = 1
        Me.GrpInformacion.TabStop = False
        '
        'TxtCifra_Menor
        '
        Me.TxtCifra_Menor.Location = New System.Drawing.Point(168, 199)
        Me.TxtCifra_Menor.Name = "TxtCifra_Menor"
        Me.TxtCifra_Menor.Size = New System.Drawing.Size(68, 20)
        Me.TxtCifra_Menor.TabIndex = 11
        '
        'LblCifra_Menor
        '
        Me.LblCifra_Menor.AutoSize = True
        Me.LblCifra_Menor.Location = New System.Drawing.Point(12, 199)
        Me.LblCifra_Menor.Name = "LblCifra_Menor"
        Me.LblCifra_Menor.Size = New System.Drawing.Size(61, 13)
        Me.LblCifra_Menor.TabIndex = 10
        Me.LblCifra_Menor.Text = "Cifra Menor"
        '
        'TxtCifra_Mayor
        '
        Me.TxtCifra_Mayor.Location = New System.Drawing.Point(168, 165)
        Me.TxtCifra_Mayor.Name = "TxtCifra_Mayor"
        Me.TxtCifra_Mayor.Size = New System.Drawing.Size(68, 20)
        Me.TxtCifra_Mayor.TabIndex = 9
        '
        'LblCifra_Mayor
        '
        Me.LblCifra_Mayor.AutoSize = True
        Me.LblCifra_Mayor.Location = New System.Drawing.Point(12, 165)
        Me.LblCifra_Mayor.Name = "LblCifra_Mayor"
        Me.LblCifra_Mayor.Size = New System.Drawing.Size(59, 13)
        Me.LblCifra_Mayor.TabIndex = 8
        Me.LblCifra_Mayor.Text = "Cifra mayor"
        '
        'TxtSuma_Cifras
        '
        Me.TxtSuma_Cifras.Location = New System.Drawing.Point(168, 130)
        Me.TxtSuma_Cifras.Name = "TxtSuma_Cifras"
        Me.TxtSuma_Cifras.Size = New System.Drawing.Size(68, 20)
        Me.TxtSuma_Cifras.TabIndex = 7
        '
        'LblSuma_Cifras
        '
        Me.LblSuma_Cifras.AutoSize = True
        Me.LblSuma_Cifras.Location = New System.Drawing.Point(12, 130)
        Me.LblSuma_Cifras.Name = "LblSuma_Cifras"
        Me.LblSuma_Cifras.Size = New System.Drawing.Size(100, 13)
        Me.LblSuma_Cifras.TabIndex = 6
        Me.LblSuma_Cifras.Text = "Suma total de cifras"
        '
        'TxtCifras_Impares
        '
        Me.TxtCifras_Impares.Location = New System.Drawing.Point(168, 60)
        Me.TxtCifras_Impares.Name = "TxtCifras_Impares"
        Me.TxtCifras_Impares.Size = New System.Drawing.Size(68, 20)
        Me.TxtCifras_Impares.TabIndex = 5
        '
        'LblCifras_Impares
        '
        Me.LblCifras_Impares.AutoSize = True
        Me.LblCifras_Impares.Location = New System.Drawing.Point(12, 60)
        Me.LblCifras_Impares.Name = "LblCifras_Impares"
        Me.LblCifras_Impares.Size = New System.Drawing.Size(116, 13)
        Me.LblCifras_Impares.TabIndex = 4
        Me.LblCifras_Impares.Text = "Suma de cifras impares"
        '
        'TxtCifrasPares
        '
        Me.TxtCifrasPares.Location = New System.Drawing.Point(168, 95)
        Me.TxtCifrasPares.Name = "TxtCifrasPares"
        Me.TxtCifrasPares.Size = New System.Drawing.Size(68, 20)
        Me.TxtCifrasPares.TabIndex = 3
        '
        'LblCifras_Pares
        '
        Me.LblCifras_Pares.AutoSize = True
        Me.LblCifras_Pares.Location = New System.Drawing.Point(12, 95)
        Me.LblCifras_Pares.Name = "LblCifras_Pares"
        Me.LblCifras_Pares.Size = New System.Drawing.Size(106, 13)
        Me.LblCifras_Pares.TabIndex = 2
        Me.LblCifras_Pares.Text = "Suma de cifras pares"
        '
        'TxtCantidad_Cifras
        '
        Me.TxtCantidad_Cifras.Location = New System.Drawing.Point(168, 25)
        Me.TxtCantidad_Cifras.Name = "TxtCantidad_Cifras"
        Me.TxtCantidad_Cifras.Size = New System.Drawing.Size(68, 20)
        Me.TxtCantidad_Cifras.TabIndex = 1
        '
        'LblCantidad_Cifras
        '
        Me.LblCantidad_Cifras.AutoSize = True
        Me.LblCantidad_Cifras.Location = New System.Drawing.Point(12, 25)
        Me.LblCantidad_Cifras.Name = "LblCantidad_Cifras"
        Me.LblCantidad_Cifras.Size = New System.Drawing.Size(92, 13)
        Me.LblCantidad_Cifras.TabIndex = 0
        Me.LblCantidad_Cifras.Text = "Cantidad de cifras"
        '
        'GrpLista
        '
        Me.GrpLista.Controls.Add(Me.LstDivisores)
        Me.GrpLista.ForeColor = System.Drawing.Color.SteelBlue
        Me.GrpLista.Location = New System.Drawing.Point(303, 93)
        Me.GrpLista.Name = "GrpLista"
        Me.GrpLista.Size = New System.Drawing.Size(254, 251)
        Me.GrpLista.TabIndex = 2
        Me.GrpLista.TabStop = False
        Me.GrpLista.Text = "Divisores"
        '
        'LstDivisores
        '
        Me.LstDivisores.FormattingEnabled = True
        Me.LstDivisores.Location = New System.Drawing.Point(8, 25)
        Me.LstDivisores.Name = "LstDivisores"
        Me.LstDivisores.Size = New System.Drawing.Size(238, 212)
        Me.LstDivisores.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(315, 32)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(112, 42)
        Me.BtnLimpiar.TabIndex = 3
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(433, 32)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(112, 42)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmInformacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 374)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GrpLista)
        Me.Controls.Add(Me.GrpInformacion)
        Me.Controls.Add(Me.GrpNumero)
        Me.Name = "FrmInformacion"
        Me.Text = "Informacion del Numero"
        Me.GrpNumero.ResumeLayout(False)
        Me.GrpNumero.PerformLayout()
        Me.GrpInformacion.ResumeLayout(False)
        Me.GrpInformacion.PerformLayout()
        Me.GrpLista.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpNumero As System.Windows.Forms.GroupBox
    Friend WithEvents GrpInformacion As System.Windows.Forms.GroupBox
    Friend WithEvents GrpLista As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents LblIngrese As System.Windows.Forms.Label
    Friend WithEvents TxtCifra_Menor As System.Windows.Forms.TextBox
    Friend WithEvents LblCifra_Menor As System.Windows.Forms.Label
    Friend WithEvents TxtCifra_Mayor As System.Windows.Forms.TextBox
    Friend WithEvents LblCifra_Mayor As System.Windows.Forms.Label
    Friend WithEvents TxtSuma_Cifras As System.Windows.Forms.TextBox
    Friend WithEvents LblSuma_Cifras As System.Windows.Forms.Label
    Friend WithEvents TxtCifras_Impares As System.Windows.Forms.TextBox
    Friend WithEvents LblCifras_Impares As System.Windows.Forms.Label
    Friend WithEvents TxtCifrasPares As System.Windows.Forms.TextBox
    Friend WithEvents LblCifras_Pares As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad_Cifras As System.Windows.Forms.TextBox
    Friend WithEvents LblCantidad_Cifras As System.Windows.Forms.Label
    Friend WithEvents LstDivisores As System.Windows.Forms.ListBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
