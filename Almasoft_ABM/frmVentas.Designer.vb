<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnAbajo = New Panel()
        Panel1 = New Panel()
        lblTarea = New Label()
        btnMinimizar = New Button()
        btnCerrar = New Button()
        lbl1 = New Label()
        lblCodigo = New Label()
        lbl2 = New Label()
        btnBuscarCliente = New Button()
        Label1 = New Label()
        dgvProductos = New DataGridView()
        cbTipoDeCobro = New ComboBox()
        lbl9 = New Label()
        lbl11 = New Label()
        txtTotal = New TextBox()
        btnAceptar = New Button()
        btnCancelar = New Button()
        btnBuscarProductos = New Button()
        Label2 = New Label()
        txtSubTotal = New TextBox()
        btnLimpiarProducto = New Button()
        txtDni = New TextBox()
        lbl4 = New Label()
        txtNombreApellido = New TextBox()
        lbl3 = New Label()
        txtCodigo = New TextBox()
        Label3 = New Label()
        cbCondicionIva = New ComboBox()
        Label4 = New Label()
        lblIdCliente = New Label()
        lblIVA = New Label()
        txtIVA = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 628)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(1049, 20)
        pnAbajo.TabIndex = 34
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel1.Controls.Add(lblTarea)
        Panel1.Controls.Add(btnMinimizar)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Controls.Add(lbl1)
        Panel1.Controls.Add(lblCodigo)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1049, 41)
        Panel1.TabIndex = 35
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(117, 18)
        lblTarea.TabIndex = 37
        lblTarea.Text = "Tarea corriendo"
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(971, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 36
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(1007, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 36
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Arial", 12F)
        lbl1.ForeColor = Color.White
        lbl1.Location = New Point(184, 11)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(64, 18)
        lbl1.TabIndex = 38
        lbl1.Text = "Código:"
        lbl1.Visible = False
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Font = New Font("Arial", 12F)
        lblCodigo.ForeColor = Color.White
        lblCodigo.Location = New Point(254, 11)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(71, 18)
        lblCodigo.TabIndex = 39
        lblCodigo.Text = "0000000"
        lblCodigo.Visible = False
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Arial", 12F)
        lbl2.ForeColor = Color.White
        lbl2.Location = New Point(32, 42)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(61, 18)
        lbl2.TabIndex = 40
        lbl2.Text = "Cliente:"
        lbl2.Visible = False
        ' 
        ' btnBuscarCliente
        ' 
        btnBuscarCliente.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscarCliente.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnBuscarCliente.BackgroundImage = CType(resources.GetObject("btnBuscarCliente.BackgroundImage"), Image)
        btnBuscarCliente.BackgroundImageLayout = ImageLayout.Zoom
        btnBuscarCliente.Cursor = Cursors.Hand
        btnBuscarCliente.FlatAppearance.BorderSize = 0
        btnBuscarCliente.FlatStyle = FlatStyle.Flat
        btnBuscarCliente.Location = New Point(987, 67)
        btnBuscarCliente.Name = "btnBuscarCliente"
        btnBuscarCliente.Size = New Size(40, 40)
        btnBuscarCliente.TabIndex = 1
        btnBuscarCliente.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 18)
        Label1.TabIndex = 44
        Label1.Text = "Productos:"
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeColumns = False
        dgvProductos.AllowUserToResizeRows = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvProductos.BackgroundColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dgvProductos.BorderStyle = BorderStyle.None
        dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProductos.ColumnHeadersHeight = 40
        dgvProductos.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        dgvProductos.EnableHeadersVisualStyles = False
        dgvProductos.GridColor = SystemColors.ControlDark
        dgvProductos.Location = New Point(32, 143)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.ReadOnly = True
        dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvProductos.RowHeadersVisible = False
        dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.ShowCellErrors = False
        dgvProductos.ShowCellToolTips = False
        dgvProductos.ShowEditingIcon = False
        dgvProductos.ShowRowErrors = False
        dgvProductos.Size = New Size(931, 259)
        dgvProductos.TabIndex = 45
        ' 
        ' cbTipoDeCobro
        ' 
        cbTipoDeCobro.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbTipoDeCobro.DropDownStyle = ComboBoxStyle.DropDownList
        cbTipoDeCobro.Font = New Font("Arial", 12F)
        cbTipoDeCobro.FormattingEnabled = True
        cbTipoDeCobro.Location = New Point(32, 433)
        cbTipoDeCobro.Name = "cbTipoDeCobro"
        cbTipoDeCobro.Size = New Size(256, 26)
        cbTipoDeCobro.TabIndex = 3
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.Font = New Font("Arial", 12F)
        lbl9.ForeColor = Color.White
        lbl9.Location = New Point(32, 412)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(122, 18)
        lbl9.TabIndex = 47
        lbl9.Text = "Forma de Pago:"
        ' 
        ' lbl11
        ' 
        lbl11.AutoSize = True
        lbl11.Font = New Font("Arial", 12F)
        lbl11.ForeColor = Color.White
        lbl11.Location = New Point(902, 551)
        lbl11.Name = "lbl11"
        lbl11.Size = New Size(61, 18)
        lbl11.TabIndex = 49
        lbl11.Text = "TOTAL:"
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtTotal.Enabled = False
        txtTotal.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.Location = New Point(707, 572)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(256, 39)
        txtTotal.TabIndex = 48
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
        btnAceptar.Location = New Point(32, 581)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(100, 30)
        btnAceptar.TabIndex = 50
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
        btnCancelar.Location = New Point(138, 581)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(100, 30)
        btnCancelar.TabIndex = 51
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscarProductos
        ' 
        btnBuscarProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBuscarProductos.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnBuscarProductos.BackgroundImage = CType(resources.GetObject("btnBuscarProductos.BackgroundImage"), Image)
        btnBuscarProductos.BackgroundImageLayout = ImageLayout.Zoom
        btnBuscarProductos.Cursor = Cursors.Hand
        btnBuscarProductos.FlatAppearance.BorderSize = 0
        btnBuscarProductos.FlatStyle = FlatStyle.Flat
        btnBuscarProductos.Location = New Point(987, 178)
        btnBuscarProductos.Name = "btnBuscarProductos"
        btnBuscarProductos.Size = New Size(40, 40)
        btnBuscarProductos.TabIndex = 2
        btnBuscarProductos.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(891, 412)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 18)
        Label2.TabIndex = 54
        Label2.Text = "SubTotal:"
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtSubTotal.Enabled = False
        txtSubTotal.Font = New Font("Arial", 12F)
        txtSubTotal.Location = New Point(817, 433)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.Size = New Size(146, 26)
        txtSubTotal.TabIndex = 53
        ' 
        ' btnLimpiarProducto
        ' 
        btnLimpiarProducto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLimpiarProducto.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnLimpiarProducto.BackgroundImage = CType(resources.GetObject("btnLimpiarProducto.BackgroundImage"), Image)
        btnLimpiarProducto.BackgroundImageLayout = ImageLayout.Zoom
        btnLimpiarProducto.Cursor = Cursors.Hand
        btnLimpiarProducto.FlatAppearance.BorderSize = 0
        btnLimpiarProducto.FlatStyle = FlatStyle.Flat
        btnLimpiarProducto.Location = New Point(987, 241)
        btnLimpiarProducto.Name = "btnLimpiarProducto"
        btnLimpiarProducto.Size = New Size(40, 40)
        btnLimpiarProducto.TabIndex = 55
        btnLimpiarProducto.UseVisualStyleBackColor = False
        ' 
        ' txtDni
        ' 
        txtDni.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtDni.Enabled = False
        txtDni.Font = New Font("Arial", 12F)
        txtDni.Location = New Point(445, 81)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(256, 26)
        txtDni.TabIndex = 58
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Font = New Font("Arial", 12F)
        lbl4.ForeColor = Color.White
        lbl4.Location = New Point(445, 60)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(38, 18)
        lbl4.TabIndex = 61
        lbl4.Text = "DNI:"
        ' 
        ' txtNombreApellido
        ' 
        txtNombreApellido.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtNombreApellido.Enabled = False
        txtNombreApellido.Font = New Font("Arial", 12F)
        txtNombreApellido.Location = New Point(183, 81)
        txtNombreApellido.Name = "txtNombreApellido"
        txtNombreApellido.Size = New Size(256, 26)
        txtNombreApellido.TabIndex = 57
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Font = New Font("Arial", 12F)
        lbl3.ForeColor = Color.White
        lbl3.Location = New Point(183, 60)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(68, 18)
        lbl3.TabIndex = 60
        lbl3.Text = "Nombre:"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCodigo.Enabled = False
        txtCodigo.Font = New Font("Arial", 12F)
        txtCodigo.Location = New Point(32, 81)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(145, 26)
        txtCodigo.TabIndex = 56
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(32, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 18)
        Label3.TabIndex = 59
        Label3.Text = "Código:"
        ' 
        ' cbCondicionIva
        ' 
        cbCondicionIva.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbCondicionIva.DropDownStyle = ComboBoxStyle.DropDownList
        cbCondicionIva.Enabled = False
        cbCondicionIva.Font = New Font("Arial", 12F)
        cbCondicionIva.FormattingEnabled = True
        cbCondicionIva.Location = New Point(707, 81)
        cbCondicionIva.Name = "cbCondicionIva"
        cbCondicionIva.Size = New Size(256, 26)
        cbCondicionIva.TabIndex = 62
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(707, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 18)
        Label4.TabIndex = 63
        Label4.Text = "IVA:"
        ' 
        ' lblIdCliente
        ' 
        lblIdCliente.AutoSize = True
        lblIdCliente.Font = New Font("Arial", 12F)
        lblIdCliente.ForeColor = Color.White
        lblIdCliente.Location = New Point(99, 42)
        lblIdCliente.Name = "lblIdCliente"
        lblIdCliente.Size = New Size(71, 18)
        lblIdCliente.TabIndex = 64
        lblIdCliente.Text = "0000000"
        lblIdCliente.Visible = False
        ' 
        ' lblIVA
        ' 
        lblIVA.AutoSize = True
        lblIVA.Font = New Font("Arial", 12F)
        lblIVA.ForeColor = Color.White
        lblIVA.Location = New Point(927, 475)
        lblIVA.Name = "lblIVA"
        lblIVA.Size = New Size(36, 18)
        lblIVA.TabIndex = 65
        lblIVA.Text = "IVA:"
        ' 
        ' txtIVA
        ' 
        txtIVA.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtIVA.Enabled = False
        txtIVA.Font = New Font("Arial", 12F)
        txtIVA.Location = New Point(818, 496)
        txtIVA.Name = "txtIVA"
        txtIVA.Size = New Size(145, 26)
        txtIVA.TabIndex = 66
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(793, 436)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 19)
        Label5.TabIndex = 113
        Label5.Text = "$"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(793, 499)
        Label6.Name = "Label6"
        Label6.Size = New Size(18, 19)
        Label6.TabIndex = 114
        Label6.Text = "$"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(672, 575)
        Label7.Name = "Label7"
        Label7.Size = New Size(29, 32)
        Label7.TabIndex = 115
        Label7.Text = "$"
        ' 
        ' frmVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(1039, 643)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtIVA)
        Controls.Add(lblIVA)
        Controls.Add(lblIdCliente)
        Controls.Add(cbCondicionIva)
        Controls.Add(Label4)
        Controls.Add(txtDni)
        Controls.Add(lbl4)
        Controls.Add(txtNombreApellido)
        Controls.Add(lbl3)
        Controls.Add(txtCodigo)
        Controls.Add(Label3)
        Controls.Add(btnLimpiarProducto)
        Controls.Add(Label2)
        Controls.Add(txtSubTotal)
        Controls.Add(btnBuscarProductos)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(lbl11)
        Controls.Add(txtTotal)
        Controls.Add(cbTipoDeCobro)
        Controls.Add(lbl9)
        Controls.Add(dgvProductos)
        Controls.Add(Label1)
        Controls.Add(btnBuscarCliente)
        Controls.Add(lbl2)
        Controls.Add(Panel1)
        Controls.Add(pnAbajo)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmVentas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Ventas - Almasoft"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnAbajo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents lblTarea As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents cbTipoDeCobro As ComboBox
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBuscarProductos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents btnLimpiarProducto As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtNombreApellido As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCondicionIva As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblIdCliente As Label
    Friend WithEvents lblIVA As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
