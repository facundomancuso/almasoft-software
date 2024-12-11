<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrillaProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrillaProveedores))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnCerrar = New Button()
        btnActualizar = New Button()
        btnVer = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnNuevo = New Button()
        btnInactivos = New Button()
        btnActivos = New Button()
        btnTodos = New Button()
        dgvProveedores = New DataGridView()
        btnFiltro = New Button()
        btnRelaciones = New Button()
        btnLimpiarImagen = New Button()
        txtBuscador = New TextBox()
        lblTitulo = New Label()
        btnGenerarPdf = New Button()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(768, 12)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(20, 20)
        btnCerrar.TabIndex = 20
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnActualizar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.FlatAppearance.BorderSize = 0
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActualizar.ForeColor = Color.White
        btnActualizar.Location = New Point(670, 205)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(100, 30)
        btnActualizar.TabIndex = 19
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnVer
        ' 
        btnVer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnVer.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnVer.Cursor = Cursors.Hand
        btnVer.FlatAppearance.BorderSize = 0
        btnVer.FlatStyle = FlatStyle.Flat
        btnVer.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVer.ForeColor = Color.White
        btnVer.Location = New Point(670, 169)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(100, 30)
        btnVer.TabIndex = 18
        btnVer.Text = "Ver"
        btnVer.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEliminar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(670, 133)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(100, 30)
        btnEliminar.TabIndex = 17
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEditar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnEditar.Cursor = Cursors.Hand
        btnEditar.FlatAppearance.BorderSize = 0
        btnEditar.FlatStyle = FlatStyle.Flat
        btnEditar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.ForeColor = Color.White
        btnEditar.Location = New Point(670, 97)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(100, 30)
        btnEditar.TabIndex = 16
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNuevo.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnNuevo.Cursor = Cursors.Hand
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.White
        btnNuevo.Location = New Point(670, 61)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(100, 30)
        btnNuevo.TabIndex = 15
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnInactivos
        ' 
        btnInactivos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnInactivos.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnInactivos.Cursor = Cursors.Hand
        btnInactivos.FlatAppearance.BorderSize = 0
        btnInactivos.FlatStyle = FlatStyle.Flat
        btnInactivos.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnInactivos.ForeColor = Color.White
        btnInactivos.Location = New Point(564, 25)
        btnInactivos.Name = "btnInactivos"
        btnInactivos.Size = New Size(100, 30)
        btnInactivos.TabIndex = 14
        btnInactivos.Text = "Inactivos"
        btnInactivos.UseVisualStyleBackColor = False
        ' 
        ' btnActivos
        ' 
        btnActivos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnActivos.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnActivos.Cursor = Cursors.Hand
        btnActivos.FlatAppearance.BorderSize = 0
        btnActivos.FlatStyle = FlatStyle.Flat
        btnActivos.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnActivos.ForeColor = Color.White
        btnActivos.Location = New Point(458, 25)
        btnActivos.Name = "btnActivos"
        btnActivos.Size = New Size(100, 30)
        btnActivos.TabIndex = 13
        btnActivos.Text = "Activos"
        btnActivos.UseVisualStyleBackColor = False
        ' 
        ' btnTodos
        ' 
        btnTodos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTodos.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnTodos.Cursor = Cursors.Hand
        btnTodos.FlatAppearance.BorderSize = 0
        btnTodos.FlatStyle = FlatStyle.Flat
        btnTodos.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTodos.ForeColor = Color.White
        btnTodos.Location = New Point(352, 25)
        btnTodos.Name = "btnTodos"
        btnTodos.Size = New Size(100, 30)
        btnTodos.TabIndex = 12
        btnTodos.Text = "Todos"
        btnTodos.UseVisualStyleBackColor = False
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.AllowUserToAddRows = False
        dgvProveedores.AllowUserToDeleteRows = False
        dgvProveedores.AllowUserToResizeColumns = False
        dgvProveedores.AllowUserToResizeRows = False
        dgvProveedores.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvProveedores.BackgroundColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dgvProveedores.BorderStyle = BorderStyle.None
        dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProveedores.ColumnHeadersHeight = 40
        dgvProveedores.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProveedores.DefaultCellStyle = DataGridViewCellStyle2
        dgvProveedores.EnableHeadersVisualStyles = False
        dgvProveedores.GridColor = SystemColors.ControlDark
        dgvProveedores.Location = New Point(13, 61)
        dgvProveedores.MultiSelect = False
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.ReadOnly = True
        dgvProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvProveedores.RowHeadersVisible = False
        dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProveedores.ShowCellErrors = False
        dgvProveedores.ShowCellToolTips = False
        dgvProveedores.ShowEditingIcon = False
        dgvProveedores.ShowRowErrors = False
        dgvProveedores.Size = New Size(651, 382)
        dgvProveedores.TabIndex = 22
        ' 
        ' btnFiltro
        ' 
        btnFiltro.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnFiltro.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnFiltro.Cursor = Cursors.Hand
        btnFiltro.FlatAppearance.BorderSize = 0
        btnFiltro.FlatStyle = FlatStyle.Flat
        btnFiltro.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFiltro.ForeColor = Color.White
        btnFiltro.Location = New Point(670, 277)
        btnFiltro.Name = "btnFiltro"
        btnFiltro.Size = New Size(100, 30)
        btnFiltro.TabIndex = 23
        btnFiltro.Text = "Filtro"
        btnFiltro.UseVisualStyleBackColor = False
        ' 
        ' btnRelaciones
        ' 
        btnRelaciones.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRelaciones.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnRelaciones.Cursor = Cursors.Hand
        btnRelaciones.FlatAppearance.BorderSize = 0
        btnRelaciones.FlatStyle = FlatStyle.Flat
        btnRelaciones.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRelaciones.ForeColor = Color.White
        btnRelaciones.Location = New Point(670, 313)
        btnRelaciones.Name = "btnRelaciones"
        btnRelaciones.Size = New Size(100, 30)
        btnRelaciones.TabIndex = 65
        btnRelaciones.Text = "Relaciones"
        btnRelaciones.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiarImagen
        ' 
        btnLimpiarImagen.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        btnLimpiarImagen.BackgroundImage = CType(resources.GetObject("btnLimpiarImagen.BackgroundImage"), Image)
        btnLimpiarImagen.BackgroundImageLayout = ImageLayout.Zoom
        btnLimpiarImagen.Cursor = Cursors.Hand
        btnLimpiarImagen.FlatAppearance.BorderSize = 0
        btnLimpiarImagen.FlatStyle = FlatStyle.Flat
        btnLimpiarImagen.Location = New Point(316, 25)
        btnLimpiarImagen.Name = "btnLimpiarImagen"
        btnLimpiarImagen.Size = New Size(30, 30)
        btnLimpiarImagen.TabIndex = 69
        btnLimpiarImagen.UseVisualStyleBackColor = False
        ' 
        ' txtBuscador
        ' 
        txtBuscador.BackColor = Color.White
        txtBuscador.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuscador.Location = New Point(13, 29)
        txtBuscador.Name = "txtBuscador"
        txtBuscador.Size = New Size(297, 26)
        txtBuscador.TabIndex = 68
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.Black
        lblTitulo.Location = New Point(13, 8)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(61, 18)
        lblTitulo.TabIndex = 67
        lblTitulo.Text = "Buscar:"
        ' 
        ' btnGenerarPdf
        ' 
        btnGenerarPdf.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnGenerarPdf.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnGenerarPdf.Cursor = Cursors.Hand
        btnGenerarPdf.FlatAppearance.BorderSize = 0
        btnGenerarPdf.FlatStyle = FlatStyle.Flat
        btnGenerarPdf.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenerarPdf.ForeColor = Color.White
        btnGenerarPdf.Location = New Point(670, 241)
        btnGenerarPdf.Name = "btnGenerarPdf"
        btnGenerarPdf.Size = New Size(100, 30)
        btnGenerarPdf.TabIndex = 70
        btnGenerarPdf.Text = "Imprimir"
        btnGenerarPdf.UseVisualStyleBackColor = False
        ' 
        ' frmGrillaProveedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        ClientSize = New Size(800, 450)
        Controls.Add(btnGenerarPdf)
        Controls.Add(btnLimpiarImagen)
        Controls.Add(txtBuscador)
        Controls.Add(lblTitulo)
        Controls.Add(btnRelaciones)
        Controls.Add(btnFiltro)
        Controls.Add(dgvProveedores)
        Controls.Add(btnCerrar)
        Controls.Add(btnActualizar)
        Controls.Add(btnVer)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnNuevo)
        Controls.Add(btnInactivos)
        Controls.Add(btnActivos)
        Controls.Add(btnTodos)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmGrillaProveedores"
        Text = "frmGrillaProveedores"
        CType(dgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnInactivos As Button
    Friend WithEvents btnActivos As Button
    Friend WithEvents btnTodos As Button
    Friend WithEvents dgvProveedores As DataGridView
    Friend WithEvents btnFiltro As Button
    Friend WithEvents btnRelaciones As Button
    Friend WithEvents btnLimpiarImagen As Button
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnGenerarPdf As Button
End Class
