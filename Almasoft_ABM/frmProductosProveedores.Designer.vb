<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductosProveedores))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTarea = New Label()
        lblID = New Label()
        lbl13 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        pnArriba = New Panel()
        Button3 = New Button()
        Button4 = New Button()
        cbProveedores = New ComboBox()
        lbl9 = New Label()
        pnAbajo = New Panel()
        btnAceptar = New Button()
        btnCancelar = New Button()
        dgvProductos = New DataGridView()
        Label2 = New Label()
        pnLineaMenu1 = New Panel()
        Label3 = New Label()
        btnDerecha = New Button()
        btnEliminar = New Button()
        Panel1 = New Panel()
        txtPrecioUnitario = New TextBox()
        Label4 = New Label()
        dgvProductosRelacionados = New DataGridView()
        cbProductosProveedor = New ComboBox()
        Label1 = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        btnEditar = New Button()
        Panel3 = New Panel()
        btnActualizar = New Button()
        pnArriba.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProductosRelacionados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(256, 18)
        lblTarea.TabIndex = 7
        lblTarea.Text = "Relaciones Productos-Proveedores"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Arial", 12F)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(366, 11)
        lblID.Name = "lblID"
        lblID.Size = New Size(17, 18)
        lblID.TabIndex = 71
        lblID.Text = "1"
        lblID.Visible = False
        ' 
        ' lbl13
        ' 
        lbl13.AutoSize = True
        lbl13.Font = New Font("Arial", 12F)
        lbl13.ForeColor = Color.White
        lbl13.Location = New Point(333, 11)
        lbl13.Name = "lbl13"
        lbl13.Size = New Size(27, 18)
        lbl13.TabIndex = 70
        lbl13.Text = "ID:"
        lbl13.Visible = False
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
        Button1.TabIndex = 72
        Button1.UseVisualStyleBackColor = False
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
        Button2.TabIndex = 73
        Button2.UseVisualStyleBackColor = False
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(Button3)
        pnArriba.Controls.Add(Button1)
        pnArriba.Controls.Add(Button4)
        pnArriba.Controls.Add(Button2)
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(lblID)
        pnArriba.Controls.Add(lbl13)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(790, 41)
        pnArriba.TabIndex = 74
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(1302, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(30, 30)
        Button3.TabIndex = 16
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(1338, 6)
        Button4.Name = "Button4"
        Button4.Size = New Size(30, 30)
        Button4.TabIndex = 17
        Button4.UseVisualStyleBackColor = False
        ' 
        ' cbProveedores
        ' 
        cbProveedores.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbProveedores.DropDownStyle = ComboBoxStyle.DropDownList
        cbProveedores.Font = New Font("Arial", 12F)
        cbProveedores.FormattingEnabled = True
        cbProveedores.Location = New Point(32, 82)
        cbProveedores.Name = "cbProveedores"
        cbProveedores.Size = New Size(706, 26)
        cbProveedores.TabIndex = 75
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.Font = New Font("Arial", 12F)
        lbl9.ForeColor = Color.White
        lbl9.Location = New Point(32, 61)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(85, 18)
        lbl9.TabIndex = 76
        lbl9.Text = "Proveedor:"
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 494)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(790, 20)
        pnAbajo.TabIndex = 93
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
        btnAceptar.Location = New Point(32, 449)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(206, 30)
        btnAceptar.TabIndex = 94
        btnAceptar.Text = "Actualizar precio"
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
        btnCancelar.Location = New Point(530, 449)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(206, 30)
        btnCancelar.TabIndex = 95
        btnCancelar.Text = "Regresar al menú"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeColumns = False
        dgvProductos.AllowUserToResizeRows = False
        dgvProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
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
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductos.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvProductos.EnableHeadersVisualStyles = False
        dgvProductos.GridColor = SystemColors.ControlDark
        dgvProductos.Location = New Point(32, 142)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
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
        dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.ShowCellErrors = False
        dgvProductos.ShowCellToolTips = False
        dgvProductos.ShowEditingIcon = False
        dgvProductos.ShowRowErrors = False
        dgvProductos.Size = New Size(327, 167)
        dgvProductos.TabIndex = 97
        dgvProductos.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(32, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 18)
        Label2.TabIndex = 98
        Label2.Text = "Productos:"
        ' 
        ' pnLineaMenu1
        ' 
        pnLineaMenu1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnLineaMenu1.Location = New Point(-1, 114)
        pnLineaMenu1.Name = "pnLineaMenu1"
        pnLineaMenu1.Size = New Size(811, 6)
        pnLineaMenu1.TabIndex = 99
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(418, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 18)
        Label3.TabIndex = 101
        Label3.Text = "Productos Relacionados:"
        ' 
        ' btnDerecha
        ' 
        btnDerecha.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnDerecha.BackgroundImage = CType(resources.GetObject("btnDerecha.BackgroundImage"), Image)
        btnDerecha.BackgroundImageLayout = ImageLayout.Zoom
        btnDerecha.Cursor = Cursors.Hand
        btnDerecha.FlatAppearance.BorderSize = 0
        btnDerecha.FlatStyle = FlatStyle.Flat
        btnDerecha.Location = New Point(365, 142)
        btnDerecha.Name = "btnDerecha"
        btnDerecha.Size = New Size(40, 40)
        btnDerecha.TabIndex = 103
        btnDerecha.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), Image)
        btnEliminar.BackgroundImageLayout = ImageLayout.Zoom
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Location = New Point(365, 269)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(40, 40)
        btnEliminar.TabIndex = 104
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel1.Location = New Point(-1, 315)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(830, 6)
        Panel1.TabIndex = 105
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtPrecioUnitario.Enabled = False
        txtPrecioUnitario.Font = New Font("Arial", 12F)
        txtPrecioUnitario.Location = New Point(32, 395)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(340, 26)
        txtPrecioUnitario.TabIndex = 106
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(30, 374)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 18)
        Label4.TabIndex = 107
        Label4.Text = "Precio Unit. Compra:"
        ' 
        ' dgvProductosRelacionados
        ' 
        dgvProductosRelacionados.AllowUserToAddRows = False
        dgvProductosRelacionados.AllowUserToDeleteRows = False
        dgvProductosRelacionados.AllowUserToResizeColumns = False
        dgvProductosRelacionados.AllowUserToResizeRows = False
        dgvProductosRelacionados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProductosRelacionados.BackgroundColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dgvProductosRelacionados.BorderStyle = BorderStyle.None
        dgvProductosRelacionados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Gray
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvProductosRelacionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvProductosRelacionados.ColumnHeadersHeight = 40
        dgvProductosRelacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductosRelacionados.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvProductosRelacionados.DefaultCellStyle = DataGridViewCellStyle5
        dgvProductosRelacionados.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvProductosRelacionados.EnableHeadersVisualStyles = False
        dgvProductosRelacionados.GridColor = SystemColors.ControlDark
        dgvProductosRelacionados.Location = New Point(411, 142)
        dgvProductosRelacionados.MultiSelect = False
        dgvProductosRelacionados.Name = "dgvProductosRelacionados"
        dgvProductosRelacionados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvProductosRelacionados.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvProductosRelacionados.RowHeadersVisible = False
        dgvProductosRelacionados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvProductosRelacionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductosRelacionados.ShowCellErrors = False
        dgvProductosRelacionados.ShowCellToolTips = False
        dgvProductosRelacionados.ShowEditingIcon = False
        dgvProductosRelacionados.ShowRowErrors = False
        dgvProductosRelacionados.Size = New Size(327, 167)
        dgvProductosRelacionados.TabIndex = 108
        dgvProductosRelacionados.TabStop = False
        ' 
        ' cbProductosProveedor
        ' 
        cbProductosProveedor.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbProductosProveedor.DropDownStyle = ComboBoxStyle.DropDownList
        cbProductosProveedor.Font = New Font("Arial", 12F)
        cbProductosProveedor.FormattingEnabled = True
        cbProductosProveedor.Location = New Point(32, 345)
        cbProductosProveedor.Name = "cbProductosProveedor"
        cbProductosProveedor.Size = New Size(706, 26)
        cbProductosProveedor.TabIndex = 109
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 324)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 18)
        Label1.TabIndex = 110
        Label1.Text = "Producto Relacionado:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(8, 398)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 19)
        Label5.TabIndex = 112
        Label5.Text = "$"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel2.Location = New Point(-1, 427)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(830, 6)
        Panel2.TabIndex = 113
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnEditar.BackgroundImage = CType(resources.GetObject("btnEditar.BackgroundImage"), Image)
        btnEditar.BackgroundImageLayout = ImageLayout.Zoom
        btnEditar.Cursor = Cursors.Hand
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Location = New Point(378, 391)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(30, 30)
        btnEditar.TabIndex = 114
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel3.Location = New Point(-1, 52)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(811, 6)
        Panel3.TabIndex = 115
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnActualizar.BackgroundImage = CType(resources.GetObject("btnActualizar.BackgroundImage"), Image)
        btnActualizar.BackgroundImageLayout = ImageLayout.Zoom
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.FlatAppearance.BorderSize = 0
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Location = New Point(365, 188)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(40, 40)
        btnActualizar.TabIndex = 116
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' frmProductosProveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(780, 509)
        Controls.Add(btnActualizar)
        Controls.Add(Panel3)
        Controls.Add(btnEditar)
        Controls.Add(Panel2)
        Controls.Add(Label5)
        Controls.Add(cbProductosProveedor)
        Controls.Add(Label1)
        Controls.Add(dgvProductosRelacionados)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        Controls.Add(btnEliminar)
        Controls.Add(btnDerecha)
        Controls.Add(Label3)
        Controls.Add(pnLineaMenu1)
        Controls.Add(Label2)
        Controls.Add(dgvProductos)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(pnAbajo)
        Controls.Add(cbProveedores)
        Controls.Add(lbl9)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmProductosProveedores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relaciones - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProductosRelacionados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTarea As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pnArriba As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cbProveedores As ComboBox
    Friend WithEvents lbl9 As Label
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents pnLineaMenu1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDerecha As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvProductosRelacionados As DataGridView
    Friend WithEvents cbProductosProveedor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEditar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnActualizar As Button
End Class
