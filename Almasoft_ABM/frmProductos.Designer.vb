<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        lbl1 = New Label()
        pnAbajo = New Panel()
        btnAceptar = New Button()
        btnCancelar = New Button()
        lbl9 = New Label()
        lbl5 = New Label()
        lbl3 = New Label()
        lbl2 = New Label()
        lblAvisoActivo = New Label()
        txtDescripcion = New TextBox()
        lbl6 = New Label()
        lbl10 = New Label()
        txtPrecioUnitario = New TextBox()
        cbSubFamilia = New ComboBox()
        cbFamilia = New ComboBox()
        txtStock = New TextBox()
        txtCodigo = New TextBox()
        txtCodigoBarra = New TextBox()
        btnCargarImagen = New Button()
        btnLimpiarImagen = New Button()
        pbProducto = New PictureBox()
        txtPorcentajeIVA = New TextBox()
        lblPorcIva = New Label()
        Label1 = New Label()
        rbSi = New RadioButton()
        rbNo = New RadioButton()
        gpVentaPorPeso = New GroupBox()
        gpActivo = New GroupBox()
        rbSiActivo = New RadioButton()
        rbNoActivo = New RadioButton()
        Label5 = New Label()
        btnCerrar = New Button()
        btnMinimizar = New Button()
        Button2 = New Button()
        lblTarea = New Label()
        Button1 = New Button()
        lbl13 = New Label()
        lblID = New Label()
        pnArriba = New Panel()
        CType(pbProducto, ComponentModel.ISupportInitialize).BeginInit()
        gpVentaPorPeso.SuspendLayout()
        gpActivo.SuspendLayout()
        pnArriba.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Arial", 12F)
        lbl1.ForeColor = Color.White
        lbl1.Location = New Point(248, 148)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(64, 18)
        lbl1.TabIndex = 9
        lbl1.Text = "Código:"
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 515)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(790, 20)
        pnAbajo.TabIndex = 34
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAceptar.BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        btnAceptar.Cursor = Cursors.Hand
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(32, 468)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(100, 30)
        btnAceptar.TabIndex = 9
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancelar.BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        btnCancelar.Cursor = Cursors.Hand
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(138, 468)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(100, 30)
        btnCancelar.TabIndex = 10
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.Font = New Font("Arial", 12F)
        lbl9.ForeColor = Color.White
        lbl9.Location = New Point(32, 318)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(52, 18)
        lbl9.TabIndex = 50
        lbl9.Text = "Stock:"
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Arial", 12F)
        lbl5.ForeColor = Color.White
        lbl5.Location = New Point(32, 268)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(110, 18)
        lbl5.TabIndex = 43
        lbl5.Text = "Familia/Rubro:"
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Font = New Font("Arial", 12F)
        lbl3.ForeColor = Color.White
        lbl3.Location = New Point(248, 208)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(96, 18)
        lbl3.TabIndex = 39
        lbl3.Text = "Descripción:"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Arial", 12F)
        lbl2.ForeColor = Color.White
        lbl2.Location = New Point(505, 148)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(127, 18)
        lbl2.TabIndex = 37
        lbl2.Text = "Código de barra:"
        ' 
        ' lblAvisoActivo
        ' 
        lblAvisoActivo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblAvisoActivo.AutoSize = True
        lblAvisoActivo.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvisoActivo.ForeColor = Color.White
        lblAvisoActivo.Location = New Point(401, 373)
        lblAvisoActivo.Name = "lblAvisoActivo"
        lblAvisoActivo.Size = New Size(63, 19)
        lblAvisoActivo.TabIndex = 60
        lblAvisoActivo.Text = "Estado"
        lblAvisoActivo.Visible = False
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtDescripcion.Font = New Font("Arial", 12F)
        txtDescripcion.Location = New Point(248, 229)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(493, 26)
        txtDescripcion.TabIndex = 2
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.Font = New Font("Arial", 12F)
        lbl6.ForeColor = Color.White
        lbl6.Location = New Point(401, 268)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(92, 18)
        lbl6.TabIndex = 45
        lbl6.Text = "SubFamilia:"
        ' 
        ' lbl10
        ' 
        lbl10.AutoSize = True
        lbl10.Font = New Font("Arial", 12F)
        lbl10.ForeColor = Color.White
        lbl10.Location = New Point(401, 318)
        lbl10.Name = "lbl10"
        lbl10.Size = New Size(93, 18)
        lbl10.TabIndex = 52
        lbl10.Text = "Precio Unit.:"
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtPrecioUnitario.Font = New Font("Arial", 12F)
        txtPrecioUnitario.Location = New Point(401, 339)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(340, 26)
        txtPrecioUnitario.TabIndex = 6
        ' 
        ' cbSubFamilia
        ' 
        cbSubFamilia.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbSubFamilia.DropDownStyle = ComboBoxStyle.DropDownList
        cbSubFamilia.Font = New Font("Arial", 12F)
        cbSubFamilia.FormattingEnabled = True
        cbSubFamilia.Location = New Point(401, 289)
        cbSubFamilia.Name = "cbSubFamilia"
        cbSubFamilia.Size = New Size(340, 26)
        cbSubFamilia.TabIndex = 4
        ' 
        ' cbFamilia
        ' 
        cbFamilia.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbFamilia.DropDownStyle = ComboBoxStyle.DropDownList
        cbFamilia.Font = New Font("Arial", 12F)
        cbFamilia.FormattingEnabled = True
        cbFamilia.Location = New Point(32, 289)
        cbFamilia.Name = "cbFamilia"
        cbFamilia.Size = New Size(340, 26)
        cbFamilia.TabIndex = 3
        ' 
        ' txtStock
        ' 
        txtStock.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtStock.Font = New Font("Arial", 12F)
        txtStock.Location = New Point(32, 339)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(340, 26)
        txtStock.TabIndex = 5
        ' 
        ' txtCodigo
        ' 
        txtCodigo.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCodigo.Font = New Font("Arial", 12F)
        txtCodigo.Location = New Point(248, 169)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(230, 26)
        txtCodigo.TabIndex = 58
        ' 
        ' txtCodigoBarra
        ' 
        txtCodigoBarra.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCodigoBarra.Font = New Font("Arial", 12F)
        txtCodigoBarra.Location = New Point(505, 169)
        txtCodigoBarra.Name = "txtCodigoBarra"
        txtCodigoBarra.Size = New Size(236, 26)
        txtCodigoBarra.TabIndex = 1
        ' 
        ' btnCargarImagen
        ' 
        btnCargarImagen.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCargarImagen.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnCargarImagen.BackgroundImage = CType(resources.GetObject("btnCargarImagen.BackgroundImage"), Image)
        btnCargarImagen.BackgroundImageLayout = ImageLayout.Zoom
        btnCargarImagen.Cursor = Cursors.Hand
        btnCargarImagen.FlatAppearance.BorderSize = 0
        btnCargarImagen.FlatStyle = FlatStyle.Flat
        btnCargarImagen.Location = New Point(248, 55)
        btnCargarImagen.Name = "btnCargarImagen"
        btnCargarImagen.Size = New Size(40, 40)
        btnCargarImagen.TabIndex = 62
        btnCargarImagen.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiarImagen
        ' 
        btnLimpiarImagen.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLimpiarImagen.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnLimpiarImagen.BackgroundImage = CType(resources.GetObject("btnLimpiarImagen.BackgroundImage"), Image)
        btnLimpiarImagen.BackgroundImageLayout = ImageLayout.Zoom
        btnLimpiarImagen.Cursor = Cursors.Hand
        btnLimpiarImagen.FlatAppearance.BorderSize = 0
        btnLimpiarImagen.FlatStyle = FlatStyle.Flat
        btnLimpiarImagen.Location = New Point(304, 55)
        btnLimpiarImagen.Name = "btnLimpiarImagen"
        btnLimpiarImagen.Size = New Size(40, 40)
        btnLimpiarImagen.TabIndex = 63
        btnLimpiarImagen.UseVisualStyleBackColor = False
        ' 
        ' pbProducto
        ' 
        pbProducto.BorderStyle = BorderStyle.FixedSingle
        pbProducto.Location = New Point(32, 55)
        pbProducto.Name = "pbProducto"
        pbProducto.Size = New Size(200, 200)
        pbProducto.SizeMode = PictureBoxSizeMode.StretchImage
        pbProducto.TabIndex = 64
        pbProducto.TabStop = False
        ' 
        ' txtPorcentajeIVA
        ' 
        txtPorcentajeIVA.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtPorcentajeIVA.Font = New Font("Arial", 12F)
        txtPorcentajeIVA.Location = New Point(32, 394)
        txtPorcentajeIVA.Name = "txtPorcentajeIVA"
        txtPorcentajeIVA.Size = New Size(110, 26)
        txtPorcentajeIVA.TabIndex = 65
        ' 
        ' lblPorcIva
        ' 
        lblPorcIva.AutoSize = True
        lblPorcIva.Font = New Font("Arial", 12F)
        lblPorcIva.ForeColor = Color.White
        lblPorcIva.Location = New Point(32, 373)
        lblPorcIva.Name = "lblPorcIva"
        lblPorcIva.Size = New Size(115, 18)
        lblPorcIva.TabIndex = 66
        lblPorcIva.Text = "Porcentaje IVA:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(144, 398)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 18)
        Label1.TabIndex = 67
        Label1.Text = "%"
        ' 
        ' rbSi
        ' 
        rbSi.AutoSize = True
        rbSi.Cursor = Cursors.Hand
        rbSi.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbSi.ForeColor = Color.White
        rbSi.Location = New Point(18, 21)
        rbSi.Name = "rbSi"
        rbSi.Size = New Size(40, 22)
        rbSi.TabIndex = 70
        rbSi.TabStop = True
        rbSi.Text = "Sí"
        rbSi.UseVisualStyleBackColor = True
        ' 
        ' rbNo
        ' 
        rbNo.AutoSize = True
        rbNo.Cursor = Cursors.Hand
        rbNo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbNo.ForeColor = Color.White
        rbNo.Location = New Point(64, 21)
        rbNo.Name = "rbNo"
        rbNo.Size = New Size(46, 22)
        rbNo.TabIndex = 71
        rbNo.TabStop = True
        rbNo.Text = "No"
        rbNo.UseVisualStyleBackColor = True
        ' 
        ' gpVentaPorPeso
        ' 
        gpVentaPorPeso.Controls.Add(rbSi)
        gpVentaPorPeso.Controls.Add(rbNo)
        gpVentaPorPeso.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gpVentaPorPeso.ForeColor = Color.White
        gpVentaPorPeso.Location = New Point(623, 93)
        gpVentaPorPeso.Name = "gpVentaPorPeso"
        gpVentaPorPeso.Size = New Size(118, 47)
        gpVentaPorPeso.TabIndex = 72
        gpVentaPorPeso.TabStop = False
        gpVentaPorPeso.Text = "Venta p/peso:"
        ' 
        ' gpActivo
        ' 
        gpActivo.Controls.Add(rbSiActivo)
        gpActivo.Controls.Add(rbNoActivo)
        gpActivo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gpActivo.ForeColor = Color.White
        gpActivo.Location = New Point(623, 40)
        gpActivo.Name = "gpActivo"
        gpActivo.Size = New Size(118, 47)
        gpActivo.TabIndex = 73
        gpActivo.TabStop = False
        gpActivo.Text = "Activo:"
        ' 
        ' rbSiActivo
        ' 
        rbSiActivo.AutoSize = True
        rbSiActivo.Cursor = Cursors.Hand
        rbSiActivo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbSiActivo.ForeColor = Color.White
        rbSiActivo.Location = New Point(18, 21)
        rbSiActivo.Name = "rbSiActivo"
        rbSiActivo.Size = New Size(40, 22)
        rbSiActivo.TabIndex = 70
        rbSiActivo.TabStop = True
        rbSiActivo.Text = "Sí"
        rbSiActivo.UseVisualStyleBackColor = True
        ' 
        ' rbNoActivo
        ' 
        rbNoActivo.AutoSize = True
        rbNoActivo.Cursor = Cursors.Hand
        rbNoActivo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbNoActivo.ForeColor = Color.White
        rbNoActivo.Location = New Point(64, 21)
        rbNoActivo.Name = "rbNoActivo"
        rbNoActivo.Size = New Size(46, 22)
        rbNoActivo.TabIndex = 71
        rbNoActivo.TabStop = True
        rbNoActivo.Text = "No"
        rbNoActivo.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(382, 342)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 19)
        Label5.TabIndex = 113
        Label5.Text = "$"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(1338, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 6
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(1302, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 6
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(748, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 30)
        Button2.TabIndex = 12
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(117, 18)
        lblTarea.TabIndex = 6
        lblTarea.Text = "Tarea corriendo"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(712, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 30)
        Button1.TabIndex = 11
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lbl13
        ' 
        lbl13.AutoSize = True
        lbl13.Font = New Font("Arial", 12F)
        lbl13.ForeColor = Color.White
        lbl13.Location = New Point(370, 11)
        lbl13.Name = "lbl13"
        lbl13.Size = New Size(27, 18)
        lbl13.TabIndex = 37
        lbl13.Text = "ID:"
        lbl13.Visible = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Arial", 12F)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(403, 11)
        lblID.Name = "lblID"
        lblID.Size = New Size(17, 18)
        lblID.TabIndex = 38
        lblID.Text = "1"
        lblID.Visible = False
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(lblID)
        pnArriba.Controls.Add(lbl13)
        pnArriba.Controls.Add(Button1)
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(Button2)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(790, 41)
        pnArriba.TabIndex = 6
        ' 
        ' frmProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(780, 530)
        Controls.Add(Label5)
        Controls.Add(gpActivo)
        Controls.Add(gpVentaPorPeso)
        Controls.Add(Label1)
        Controls.Add(txtPorcentajeIVA)
        Controls.Add(lblPorcIva)
        Controls.Add(pbProducto)
        Controls.Add(btnLimpiarImagen)
        Controls.Add(btnCargarImagen)
        Controls.Add(lblAvisoActivo)
        Controls.Add(txtCodigo)
        Controls.Add(txtStock)
        Controls.Add(cbFamilia)
        Controls.Add(cbSubFamilia)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(lbl10)
        Controls.Add(lbl9)
        Controls.Add(lbl6)
        Controls.Add(lbl5)
        Controls.Add(txtDescripcion)
        Controls.Add(lbl3)
        Controls.Add(txtCodigoBarra)
        Controls.Add(lbl2)
        Controls.Add(pnAbajo)
        Controls.Add(lbl1)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Productos - Almasoft"
        CType(pbProducto, ComponentModel.ISupportInitialize).EndInit()
        gpVentaPorPeso.ResumeLayout(False)
        gpVentaPorPeso.PerformLayout()
        gpActivo.ResumeLayout(False)
        gpActivo.PerformLayout()
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl1 As Label
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents cbCondicionIva As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl3 As Label
    Public WithEvents chSi As CheckBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblAvisoActivo As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents cbSubFamilia As ComboBox
    Friend WithEvents cbFamilia As ComboBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents btnLimpiarImagen As Button
    Friend WithEvents pbProducto As PictureBox
    Friend WithEvents txtPorcentajeIVA As TextBox
    Friend WithEvents lblPorcIva As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents gpVentaPorPeso As GroupBox
    Friend WithEvents gpActivo As GroupBox
    Friend WithEvents rbSiActivo As RadioButton
    Friend WithEvents rbNoActivo As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTarea As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl13 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents pnArriba As Panel
End Class
