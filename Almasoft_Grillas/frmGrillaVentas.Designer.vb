<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrillaVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrillaVentas))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnCerrar = New Button()
        lblTitulo = New Label()
        dgvVentas = New DataGridView()
        btnFacturadas = New Button()
        btnPendientes = New Button()
        btnTodas = New Button()
        btnActualizar = New Button()
        btnVer = New Button()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnNueva = New Button()
        CType(dgvVentas, ComponentModel.ISupportInitialize).BeginInit()
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
        btnCerrar.TabIndex = 10
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.Black
        lblTitulo.Location = New Point(13, 28)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(68, 22)
        lblTitulo.TabIndex = 11
        lblTitulo.Text = "Ventas"
        ' 
        ' dgvVentas
        ' 
        dgvVentas.AllowUserToAddRows = False
        dgvVentas.AllowUserToDeleteRows = False
        dgvVentas.AllowUserToResizeColumns = False
        dgvVentas.AllowUserToResizeRows = False
        dgvVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVentas.BackgroundColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dgvVentas.BorderStyle = BorderStyle.None
        dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvVentas.ColumnHeadersHeight = 40
        dgvVentas.Cursor = Cursors.Hand
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvVentas.DefaultCellStyle = DataGridViewCellStyle2
        dgvVentas.EnableHeadersVisualStyles = False
        dgvVentas.GridColor = SystemColors.ControlDark
        dgvVentas.Location = New Point(13, 61)
        dgvVentas.MultiSelect = False
        dgvVentas.Name = "dgvVentas"
        dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVentas.Size = New Size(651, 382)
        dgvVentas.TabIndex = 12
        ' 
        ' btnFacturadas
        ' 
        btnFacturadas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnFacturadas.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnFacturadas.Cursor = Cursors.Hand
        btnFacturadas.FlatAppearance.BorderSize = 0
        btnFacturadas.FlatStyle = FlatStyle.Flat
        btnFacturadas.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFacturadas.ForeColor = Color.White
        btnFacturadas.Location = New Point(458, 25)
        btnFacturadas.Name = "btnFacturadas"
        btnFacturadas.Size = New Size(100, 30)
        btnFacturadas.TabIndex = 15
        btnFacturadas.Text = "Facturadas"
        btnFacturadas.UseVisualStyleBackColor = False
        ' 
        ' btnPendientes
        ' 
        btnPendientes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPendientes.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnPendientes.Cursor = Cursors.Hand
        btnPendientes.FlatAppearance.BorderSize = 0
        btnPendientes.FlatStyle = FlatStyle.Flat
        btnPendientes.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPendientes.ForeColor = Color.White
        btnPendientes.Location = New Point(564, 25)
        btnPendientes.Name = "btnPendientes"
        btnPendientes.Size = New Size(100, 30)
        btnPendientes.TabIndex = 14
        btnPendientes.Text = "Pendientes"
        btnPendientes.UseVisualStyleBackColor = False
        ' 
        ' btnTodas
        ' 
        btnTodas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTodas.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnTodas.Cursor = Cursors.Hand
        btnTodas.FlatAppearance.BorderSize = 0
        btnTodas.FlatStyle = FlatStyle.Flat
        btnTodas.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTodas.ForeColor = Color.White
        btnTodas.Location = New Point(352, 25)
        btnTodas.Name = "btnTodas"
        btnTodas.Size = New Size(100, 30)
        btnTodas.TabIndex = 13
        btnTodas.Text = "Todas"
        btnTodas.UseVisualStyleBackColor = False
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
        btnVer.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVer.ForeColor = Color.White
        btnVer.Location = New Point(670, 169)
        btnVer.Name = "btnVer"
        btnVer.Size = New Size(100, 30)
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
        btnEliminar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(670, 133)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(100, 30)
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
        btnEditar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.ForeColor = Color.White
        btnEditar.Location = New Point(670, 97)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(100, 30)
        btnEditar.TabIndex = 17
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnNueva
        ' 
        btnNueva.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNueva.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnNueva.Cursor = Cursors.Hand
        btnNueva.FlatAppearance.BorderSize = 0
        btnNueva.FlatStyle = FlatStyle.Flat
        btnNueva.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNueva.ForeColor = Color.White
        btnNueva.Location = New Point(670, 61)
        btnNueva.Name = "btnNueva"
        btnNueva.Size = New Size(100, 30)
        btnNueva.TabIndex = 16
        btnNueva.Text = "Nueva"
        btnNueva.UseVisualStyleBackColor = False
        ' 
        ' frmGrillaVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        ClientSize = New Size(800, 450)
        Controls.Add(btnActualizar)
        Controls.Add(btnVer)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnNueva)
        Controls.Add(btnFacturadas)
        Controls.Add(btnPendientes)
        Controls.Add(btnTodas)
        Controls.Add(dgvVentas)
        Controls.Add(lblTitulo)
        Controls.Add(btnCerrar)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmGrillaVentas"
        Text = "Datos de Ventas - Almasoft"
        CType(dgvVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnFacturadas As Button
    Friend WithEvents btnPendientes As Button
    Friend WithEvents btnTodas As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNueva As Button
End Class
