<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarPrecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultarPrecio))
        btnSalir = New Button()
        pnArriba = New Panel()
        Label1 = New Label()
        btnMinimizar = New Button()
        Button1 = New Button()
        btnCerrar = New Button()
        Panel2 = New Panel()
        btnRegresar = New Button()
        lblCosto = New Label()
        Label6 = New Label()
        Label5 = New Label()
        lblDescripcion = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Label7 = New Label()
        Panel3 = New Panel()
        Label8 = New Label()
        lblPorcentajeIva = New Label()
        lblPrecioUnitario = New Label()
        Label9 = New Label()
        lblCodigo = New Label()
        Label10 = New Label()
        Label11 = New Label()
        pbProducto = New PictureBox()
        lblFamilia = New Label()
        Label12 = New Label()
        lblSubFamilia = New Label()
        Label14 = New Label()
        Panel4 = New Panel()
        pnArriba.SuspendLayout()
        CType(pbProducto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), Image)
        btnSalir.BackgroundImageLayout = ImageLayout.Zoom
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Location = New Point(628, 6)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(30, 30)
        btnSalir.TabIndex = 71
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(Label1)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnSalir)
        pnArriba.Controls.Add(Button1)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Location = New Point(0, 0)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(661, 41)
        pnArriba.TabIndex = 73
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(13, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 18)
        Label1.TabIndex = 70
        Label1.Text = "Consultar precio"
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(1059, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 5
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(894, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 30)
        Button1.TabIndex = 61
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(1095, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 6
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel2.Location = New Point(0, 261)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(661, 20)
        Panel2.TabIndex = 74
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = Color.FromArgb(CByte(0), CByte(117), CByte(255))
        btnRegresar.Cursor = Cursors.Hand
        btnRegresar.FlatAppearance.BorderSize = 0
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegresar.ForeColor = Color.White
        btnRegresar.Location = New Point(582, 47)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(67, 38)
        btnRegresar.TabIndex = 85
        btnRegresar.Text = "Volver"
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' lblCosto
        ' 
        lblCosto.AutoSize = True
        lblCosto.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCosto.ForeColor = Color.Yellow
        lblCosto.Location = New Point(391, 205)
        lblCosto.Name = "lblCosto"
        lblCosto.Size = New Size(170, 37)
        lblCosto.TabIndex = 84
        lblCosto.Text = "000000.00"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(598, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 16)
        Label6.TabIndex = 82
        Label6.Text = "x Unid."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Yellow
        Label5.Location = New Point(360, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 37)
        Label5.TabIndex = 81
        Label5.Text = "$"
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblDescripcion.ForeColor = Color.White
        lblDescripcion.Location = New Point(391, 99)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(202, 19)
        lblDescripcion.TabIndex = 80
        lblDescripcion.Text = "Descripción del producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(219, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 37)
        Label3.TabIndex = 79
        Label3.Text = "Costo:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel1.Location = New Point(219, 197)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 5)
        Panel1.TabIndex = 78
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(219, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 77
        Label2.Text = "Descripción:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(219, 51)
        Label7.Name = "Label7"
        Label7.Size = New Size(165, 37)
        Label7.TabIndex = 75
        Label7.Text = "Producto:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel3.Location = New Point(219, 91)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(440, 5)
        Panel3.TabIndex = 86
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(219, 137)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 19)
        Label8.TabIndex = 87
        Label8.Text = "Porcentaje IVA:"
        ' 
        ' lblPorcentajeIva
        ' 
        lblPorcentajeIva.AutoSize = True
        lblPorcentajeIva.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblPorcentajeIva.ForeColor = Color.White
        lblPorcentajeIva.Location = New Point(391, 137)
        lblPorcentajeIva.Name = "lblPorcentajeIva"
        lblPorcentajeIva.Size = New Size(49, 19)
        lblPorcentajeIva.TabIndex = 88
        lblPorcentajeIva.Text = "00.00"
        ' 
        ' lblPrecioUnitario
        ' 
        lblPrecioUnitario.AutoSize = True
        lblPrecioUnitario.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblPrecioUnitario.ForeColor = Color.White
        lblPrecioUnitario.Location = New Point(405, 118)
        lblPrecioUnitario.Name = "lblPrecioUnitario"
        lblPrecioUnitario.Size = New Size(85, 19)
        lblPrecioUnitario.TabIndex = 89
        lblPrecioUnitario.Text = "000000.00"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(436, 137)
        Label9.Name = "Label9"
        Label9.Size = New Size(25, 19)
        Label9.TabIndex = 90
        Label9.Text = "%"
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCodigo.ForeColor = Color.Yellow
        lblCodigo.Location = New Point(391, 51)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(178, 37)
        lblCodigo.TabIndex = 91
        lblCodigo.Text = "PROD0000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(391, 118)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 19)
        Label10.TabIndex = 92
        Label10.Text = "$"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(219, 118)
        Label11.Name = "Label11"
        Label11.Size = New Size(128, 19)
        Label11.TabIndex = 93
        Label11.Text = "Precio Unitario:"
        ' 
        ' pbProducto
        ' 
        pbProducto.BorderStyle = BorderStyle.FixedSingle
        pbProducto.Location = New Point(13, 51)
        pbProducto.Name = "pbProducto"
        pbProducto.Size = New Size(200, 200)
        pbProducto.SizeMode = PictureBoxSizeMode.StretchImage
        pbProducto.TabIndex = 94
        pbProducto.TabStop = False
        ' 
        ' lblFamilia
        ' 
        lblFamilia.AutoSize = True
        lblFamilia.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblFamilia.ForeColor = Color.White
        lblFamilia.Location = New Point(391, 156)
        lblFamilia.Name = "lblFamilia"
        lblFamilia.Size = New Size(134, 19)
        lblFamilia.TabIndex = 96
        lblFamilia.Text = "Familia del prod."
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(219, 156)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 19)
        Label12.TabIndex = 95
        Label12.Text = "Familia:"
        ' 
        ' lblSubFamilia
        ' 
        lblSubFamilia.AutoSize = True
        lblSubFamilia.Font = New Font("Arial", 12F, FontStyle.Bold)
        lblSubFamilia.ForeColor = Color.White
        lblSubFamilia.Location = New Point(391, 175)
        lblSubFamilia.Name = "lblSubFamilia"
        lblSubFamilia.Size = New Size(165, 19)
        lblSubFamilia.TabIndex = 98
        lblSubFamilia.Text = "SubFamilia del prod."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(219, 175)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 19)
        Label14.TabIndex = 97
        Label14.Text = "SubFamilia:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel4.Location = New Point(219, 245)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(440, 5)
        Panel4.TabIndex = 99
        ' 
        ' frmConsultarPrecio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        ClientSize = New Size(661, 281)
        Controls.Add(Panel4)
        Controls.Add(lblSubFamilia)
        Controls.Add(Label14)
        Controls.Add(lblFamilia)
        Controls.Add(Label12)
        Controls.Add(pbProducto)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(lblCodigo)
        Controls.Add(Label9)
        Controls.Add(lblPrecioUnitario)
        Controls.Add(lblPorcentajeIva)
        Controls.Add(Label8)
        Controls.Add(Panel3)
        Controls.Add(btnRegresar)
        Controls.Add(lblCosto)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblDescripcion)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmConsultarPrecio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Consultar Precio - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        CType(pbProducto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnArriba As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblFamilia As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPorcentajeIva As Label
    Friend WithEvents lblPrecioUnitario As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents pbProducto As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblSubFamilia As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
End Class
