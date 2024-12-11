<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrillaUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrillaUsuarios))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnCerrar = New Button()
        lblTitulo = New Label()
        btnInactivos = New Button()
        btnActivos = New Button()
        btnTodos = New Button()
        btnActualizar = New Button()
        btnVer = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnNuevo = New Button()
        btnFiltro = New Button()
        dgvUsuarios = New DataGridView()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(511, 12)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(20, 20)
        btnCerrar.TabIndex = 10
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.Black
        lblTitulo.Location = New Point(13, 30)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(78, 19)
        lblTitulo.TabIndex = 15
        lblTitulo.Text = "Usuarios"
        ' 
        ' btnInactivos
        ' 
        btnInactivos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnInactivos.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnInactivos.Cursor = Cursors.Hand
        btnInactivos.FlatAppearance.BorderSize = 0
        btnInactivos.FlatStyle = FlatStyle.Flat
        btnInactivos.Font = New Font("Arial", 9.75F)
        btnInactivos.ForeColor = Color.White
        btnInactivos.Location = New Point(327, 25)
        btnInactivos.Name = "btnInactivos"
        btnInactivos.Size = New Size(80, 30)
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
        btnActivos.Font = New Font("Arial", 9.75F)
        btnActivos.ForeColor = Color.White
        btnActivos.Location = New Point(241, 25)
        btnActivos.Name = "btnActivos"
        btnActivos.Size = New Size(80, 30)
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
        btnTodos.Font = New Font("Arial", 9.75F)
        btnTodos.ForeColor = Color.White
        btnTodos.Location = New Point(158, 25)
        btnTodos.Name = "btnTodos"
        btnTodos.Size = New Size(80, 30)
        btnTodos.TabIndex = 12
        btnTodos.Text = "Todos"
        btnTodos.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnActualizar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.FlatAppearance.BorderSize = 0
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Arial", 9.75F)
        btnActualizar.ForeColor = Color.White
        btnActualizar.Location = New Point(413, 205)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(80, 30)
        btnActualizar.TabIndex = 20
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
        btnVer.Font = New Font("Arial", 9.75F)
        btnVer.ForeColor = Color.White
        btnVer.Location = New Point(413, 169)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(80, 30)
        btnVer.TabIndex = 19
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
        btnEliminar.Font = New Font("Arial", 9.75F)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(413, 133)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(80, 30)
        btnEliminar.TabIndex = 18
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
        btnEditar.Font = New Font("Arial", 9.75F)
        btnEditar.ForeColor = Color.White
        btnEditar.Location = New Point(413, 97)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(80, 30)
        btnEditar.TabIndex = 17
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
        btnNuevo.Font = New Font("Arial", 9.75F)
        btnNuevo.ForeColor = Color.White
        btnNuevo.Location = New Point(413, 61)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(80, 30)
        btnNuevo.TabIndex = 16
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnFiltro
        ' 
        btnFiltro.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnFiltro.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnFiltro.Cursor = Cursors.Hand
        btnFiltro.FlatAppearance.BorderSize = 0
        btnFiltro.FlatStyle = FlatStyle.Flat
        btnFiltro.Font = New Font("Arial", 9.75F)
        btnFiltro.ForeColor = Color.White
        btnFiltro.Location = New Point(413, 241)
        btnFiltro.Name = "btnFiltro"
        btnFiltro.Size = New Size(80, 30)
        btnFiltro.TabIndex = 21
        btnFiltro.Text = "Filtro"
        btnFiltro.UseVisualStyleBackColor = False
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.AllowUserToResizeColumns = False
        dgvUsuarios.AllowUserToResizeRows = False
        dgvUsuarios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuarios.BackgroundColor = Color.White
        dgvUsuarios.BorderStyle = BorderStyle.None
        dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsuarios.ColumnHeadersHeight = 40
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvUsuarios.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsuarios.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvUsuarios.EnableHeadersVisualStyles = False
        dgvUsuarios.GridColor = SystemColors.ControlDark
        dgvUsuarios.Location = New Point(13, 61)
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvUsuarios.RowHeadersVisible = False
        dgvUsuarios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.ShowCellErrors = False
        dgvUsuarios.ShowCellToolTips = False
        dgvUsuarios.ShowEditingIcon = False
        dgvUsuarios.ShowRowErrors = False
        dgvUsuarios.Size = New Size(394, 382)
        dgvUsuarios.TabIndex = 22
        dgvUsuarios.TabStop = False
        ' 
        ' frmGrillaUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        ClientSize = New Size(543, 450)
        Controls.Add(dgvUsuarios)
        Controls.Add(btnFiltro)
        Controls.Add(btnActualizar)
        Controls.Add(btnVer)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnNuevo)
        Controls.Add(lblTitulo)
        Controls.Add(btnInactivos)
        Controls.Add(btnActivos)
        Controls.Add(btnTodos)
        Controls.Add(btnCerrar)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmGrillaUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Datos de Usuarios - Almasoft"
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnInactivos As Button
    Friend WithEvents btnActivos As Button
    Friend WithEvents btnTodos As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnFiltro As Button
    Friend WithEvents dgvUsuarios As DataGridView
End Class
