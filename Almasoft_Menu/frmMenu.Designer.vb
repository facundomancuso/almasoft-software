<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        pnArriba = New Panel()
        btnRestaurar = New Button()
        btnCerrar = New Button()
        btnMaximizar = New Button()
        btnMinimizar = New Button()
        btnUsuarios = New Button()
        btnListados = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ActivosToolStripMenuItem = New ToolStripMenuItem()
        InactivosToolStripMenuItem = New ToolStripMenuItem()
        TodosToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ActivosToolStripMenuItem1 = New ToolStripMenuItem()
        InactivosToolStripMenuItem1 = New ToolStripMenuItem()
        TodosToolStripMenuItem1 = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        ActivosToolStripMenuItem2 = New ToolStripMenuItem()
        InactivosToolStripMenuItem2 = New ToolStripMenuItem()
        TodosToolStripMenuItem2 = New ToolStripMenuItem()
        btnCobros = New Button()
        lblUsuario = New Label()
        lblU = New Label()
        pnMenu = New Panel()
        pnSalir = New Panel()
        btnSalir = New Button()
        pnLineaMenu2 = New Panel()
        pnVentas = New Panel()
        pnProductos = New Panel()
        pnProveedores = New Panel()
        pnClientes = New Panel()
        btnVentas = New Button()
        btnProductos = New Button()
        btnProveedores = New Button()
        btnClientes = New Button()
        pnInicio = New Panel()
        btnInicio = New Button()
        pnLineaMenu1 = New Panel()
        btnMenu = New Button()
        pnPrincipal = New Panel()
        imgLogoAlmasoft = New PictureBox()
        pnAbajo = New Panel()
        tmOcultarMenu = New Timer(components)
        tmMostrarMenu = New Timer(components)
        pnArriba.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        pnMenu.SuspendLayout()
        pnPrincipal.SuspendLayout()
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnArriba
        ' 
        pnArriba.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnArriba.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnArriba.Controls.Add(btnRestaurar)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Controls.Add(btnMaximizar)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnUsuarios)
        pnArriba.Controls.Add(btnListados)
        pnArriba.Controls.Add(btnCobros)
        pnArriba.Controls.Add(lblUsuario)
        pnArriba.Controls.Add(lblU)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(1104, 58)
        pnArriba.TabIndex = 0
        ' 
        ' btnRestaurar
        ' 
        btnRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRestaurar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), Image)
        btnRestaurar.BackgroundImageLayout = ImageLayout.Zoom
        btnRestaurar.FlatAppearance.BorderSize = 0
        btnRestaurar.FlatStyle = FlatStyle.Flat
        btnRestaurar.Location = New Point(1017, 14)
        btnRestaurar.Name = "btnRestaurar"
        btnRestaurar.Size = New Size(30, 30)
        btnRestaurar.TabIndex = 6
        btnRestaurar.UseVisualStyleBackColor = False
        btnRestaurar.Visible = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(1053, 14)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 3
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), Image)
        btnMaximizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMaximizar.FlatAppearance.BorderSize = 0
        btnMaximizar.FlatStyle = FlatStyle.Flat
        btnMaximizar.Location = New Point(1017, 14)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(30, 30)
        btnMaximizar.TabIndex = 3
        btnMaximizar.UseVisualStyleBackColor = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(981, 14)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 3
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnUsuarios.BackgroundImage = CType(resources.GetObject("btnUsuarios.BackgroundImage"), Image)
        btnUsuarios.BackgroundImageLayout = ImageLayout.Zoom
        btnUsuarios.Cursor = Cursors.Hand
        btnUsuarios.FlatAppearance.BorderSize = 0
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.Location = New Point(101, 9)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(40, 40)
        btnUsuarios.TabIndex = 3
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btnListados
        ' 
        btnListados.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnListados.BackgroundImage = CType(resources.GetObject("btnListados.BackgroundImage"), Image)
        btnListados.BackgroundImageLayout = ImageLayout.Zoom
        btnListados.ContextMenuStrip = ContextMenuStrip1
        btnListados.Cursor = Cursors.Hand
        btnListados.FlatAppearance.BorderSize = 0
        btnListados.FlatStyle = FlatStyle.Flat
        btnListados.Location = New Point(55, 9)
        btnListados.Name = "btnListados"
        btnListados.Size = New Size(40, 40)
        btnListados.TabIndex = 3
        btnListados.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ProveedoresToolStripMenuItem, ProductosToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(140, 70)
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActivosToolStripMenuItem, InactivosToolStripMenuItem, TodosToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(139, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ActivosToolStripMenuItem
        ' 
        ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        ActivosToolStripMenuItem.Size = New Size(121, 22)
        ActivosToolStripMenuItem.Text = "Activos"
        ' 
        ' InactivosToolStripMenuItem
        ' 
        InactivosToolStripMenuItem.Name = "InactivosToolStripMenuItem"
        InactivosToolStripMenuItem.Size = New Size(121, 22)
        InactivosToolStripMenuItem.Text = "Inactivos"
        ' 
        ' TodosToolStripMenuItem
        ' 
        TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        TodosToolStripMenuItem.Size = New Size(121, 22)
        TodosToolStripMenuItem.Text = "Todos"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActivosToolStripMenuItem1, InactivosToolStripMenuItem1, TodosToolStripMenuItem1})
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(139, 22)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' ActivosToolStripMenuItem1
        ' 
        ActivosToolStripMenuItem1.Name = "ActivosToolStripMenuItem1"
        ActivosToolStripMenuItem1.Size = New Size(121, 22)
        ActivosToolStripMenuItem1.Text = "Activos"
        ' 
        ' InactivosToolStripMenuItem1
        ' 
        InactivosToolStripMenuItem1.Name = "InactivosToolStripMenuItem1"
        InactivosToolStripMenuItem1.Size = New Size(121, 22)
        InactivosToolStripMenuItem1.Text = "Inactivos"
        ' 
        ' TodosToolStripMenuItem1
        ' 
        TodosToolStripMenuItem1.Name = "TodosToolStripMenuItem1"
        TodosToolStripMenuItem1.Size = New Size(121, 22)
        TodosToolStripMenuItem1.Text = "Todos"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActivosToolStripMenuItem2, InactivosToolStripMenuItem2, TodosToolStripMenuItem2})
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(139, 22)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' ActivosToolStripMenuItem2
        ' 
        ActivosToolStripMenuItem2.Name = "ActivosToolStripMenuItem2"
        ActivosToolStripMenuItem2.Size = New Size(121, 22)
        ActivosToolStripMenuItem2.Text = "Activos"
        ' 
        ' InactivosToolStripMenuItem2
        ' 
        InactivosToolStripMenuItem2.Name = "InactivosToolStripMenuItem2"
        InactivosToolStripMenuItem2.Size = New Size(121, 22)
        InactivosToolStripMenuItem2.Text = "Inactivos"
        ' 
        ' TodosToolStripMenuItem2
        ' 
        TodosToolStripMenuItem2.Name = "TodosToolStripMenuItem2"
        TodosToolStripMenuItem2.Size = New Size(121, 22)
        TodosToolStripMenuItem2.Text = "Todos"
        ' 
        ' btnCobros
        ' 
        btnCobros.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        btnCobros.BackgroundImage = CType(resources.GetObject("btnCobros.BackgroundImage"), Image)
        btnCobros.BackgroundImageLayout = ImageLayout.Zoom
        btnCobros.Cursor = Cursors.Hand
        btnCobros.FlatAppearance.BorderSize = 0
        btnCobros.FlatStyle = FlatStyle.Flat
        btnCobros.Location = New Point(9, 9)
        btnCobros.Name = "btnCobros"
        btnCobros.Size = New Size(40, 40)
        btnCobros.TabIndex = 0
        btnCobros.UseVisualStyleBackColor = False
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = Color.White
        lblUsuario.Location = New Point(220, 21)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(151, 18)
        lblUsuario.TabIndex = 4
        lblUsuario.Text = "Aqui el user logeado"
        ' 
        ' lblU
        ' 
        lblU.AutoSize = True
        lblU.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblU.ForeColor = Color.White
        lblU.Location = New Point(157, 21)
        lblU.Name = "lblU"
        lblU.Size = New Size(66, 18)
        lblU.TabIndex = 3
        lblU.Text = "Usuario:"
        ' 
        ' pnMenu
        ' 
        pnMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnMenu.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnMenu.Controls.Add(pnSalir)
        pnMenu.Controls.Add(btnSalir)
        pnMenu.Controls.Add(pnLineaMenu2)
        pnMenu.Controls.Add(pnVentas)
        pnMenu.Controls.Add(pnProductos)
        pnMenu.Controls.Add(pnProveedores)
        pnMenu.Controls.Add(pnClientes)
        pnMenu.Controls.Add(btnVentas)
        pnMenu.Controls.Add(btnProductos)
        pnMenu.Controls.Add(btnProveedores)
        pnMenu.Controls.Add(btnClientes)
        pnMenu.Controls.Add(pnInicio)
        pnMenu.Controls.Add(btnInicio)
        pnMenu.Controls.Add(pnLineaMenu1)
        pnMenu.Controls.Add(btnMenu)
        pnMenu.Location = New Point(-1, 53)
        pnMenu.Name = "pnMenu"
        pnMenu.Size = New Size(240, 559)
        pnMenu.TabIndex = 1
        ' 
        ' pnSalir
        ' 
        pnSalir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnSalir.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnSalir.Location = New Point(0, 510)
        pnSalir.Name = "pnSalir"
        pnSalir.Size = New Size(3, 40)
        pnSalir.TabIndex = 7
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSalir.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnSalir.BackgroundImageLayout = ImageLayout.Zoom
        btnSalir.Cursor = Cursors.Hand
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Arial", 16F)
        btnSalir.ForeColor = Color.White
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.ImageAlign = ContentAlignment.MiddleLeft
        btnSalir.Location = New Point(0, 510)
        btnSalir.Name = "btnSalir"
        btnSalir.Padding = New Padding(6, 0, 0, 0)
        btnSalir.Size = New Size(240, 40)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' pnLineaMenu2
        ' 
        pnLineaMenu2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnLineaMenu2.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnLineaMenu2.Location = New Point(9, 490)
        pnLineaMenu2.Name = "pnLineaMenu2"
        pnLineaMenu2.Size = New Size(222, 6)
        pnLineaMenu2.TabIndex = 5
        ' 
        ' pnVentas
        ' 
        pnVentas.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnVentas.Location = New Point(0, 259)
        pnVentas.Name = "pnVentas"
        pnVentas.Size = New Size(3, 40)
        pnVentas.TabIndex = 6
        ' 
        ' pnProductos
        ' 
        pnProductos.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnProductos.Location = New Point(0, 213)
        pnProductos.Name = "pnProductos"
        pnProductos.Size = New Size(3, 40)
        pnProductos.TabIndex = 6
        ' 
        ' pnProveedores
        ' 
        pnProveedores.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnProveedores.Location = New Point(0, 167)
        pnProveedores.Name = "pnProveedores"
        pnProveedores.Size = New Size(3, 40)
        pnProveedores.TabIndex = 6
        ' 
        ' pnClientes
        ' 
        pnClientes.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnClientes.Location = New Point(0, 121)
        pnClientes.Name = "pnClientes"
        pnClientes.Size = New Size(3, 40)
        pnClientes.TabIndex = 6
        ' 
        ' btnVentas
        ' 
        btnVentas.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnVentas.BackgroundImageLayout = ImageLayout.Zoom
        btnVentas.Cursor = Cursors.Hand
        btnVentas.FlatAppearance.BorderSize = 0
        btnVentas.FlatStyle = FlatStyle.Flat
        btnVentas.Font = New Font("Arial", 16F)
        btnVentas.ForeColor = Color.White
        btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), Image)
        btnVentas.ImageAlign = ContentAlignment.MiddleLeft
        btnVentas.Location = New Point(0, 259)
        btnVentas.Name = "btnVentas"
        btnVentas.Padding = New Padding(6, 0, 0, 0)
        btnVentas.Size = New Size(240, 40)
        btnVentas.TabIndex = 4
        btnVentas.Text = "  Ventas"
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' btnProductos
        ' 
        btnProductos.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnProductos.BackgroundImageLayout = ImageLayout.Zoom
        btnProductos.Cursor = Cursors.Hand
        btnProductos.FlatAppearance.BorderSize = 0
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.Font = New Font("Arial", 16F)
        btnProductos.ForeColor = Color.White
        btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), Image)
        btnProductos.ImageAlign = ContentAlignment.MiddleLeft
        btnProductos.Location = New Point(0, 213)
        btnProductos.Name = "btnProductos"
        btnProductos.Padding = New Padding(6, 0, 0, 0)
        btnProductos.Size = New Size(240, 40)
        btnProductos.TabIndex = 4
        btnProductos.Text = "       Productos"
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' btnProveedores
        ' 
        btnProveedores.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnProveedores.BackgroundImageLayout = ImageLayout.Zoom
        btnProveedores.Cursor = Cursors.Hand
        btnProveedores.FlatAppearance.BorderSize = 0
        btnProveedores.FlatStyle = FlatStyle.Flat
        btnProveedores.Font = New Font("Arial", 16F)
        btnProveedores.ForeColor = Color.White
        btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"), Image)
        btnProveedores.ImageAlign = ContentAlignment.MiddleLeft
        btnProveedores.Location = New Point(0, 167)
        btnProveedores.Name = "btnProveedores"
        btnProveedores.Padding = New Padding(6, 0, 0, 0)
        btnProveedores.Size = New Size(240, 40)
        btnProveedores.TabIndex = 4
        btnProveedores.Text = "           Proveedores"
        btnProveedores.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnClientes.BackgroundImageLayout = ImageLayout.Zoom
        btnClientes.Cursor = Cursors.Hand
        btnClientes.FlatAppearance.BorderSize = 0
        btnClientes.FlatStyle = FlatStyle.Flat
        btnClientes.Font = New Font("Arial", 16F)
        btnClientes.ForeColor = Color.White
        btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), Image)
        btnClientes.ImageAlign = ContentAlignment.MiddleLeft
        btnClientes.Location = New Point(0, 121)
        btnClientes.Name = "btnClientes"
        btnClientes.Padding = New Padding(6, 0, 0, 0)
        btnClientes.Size = New Size(240, 40)
        btnClientes.TabIndex = 6
        btnClientes.Text = "    Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' pnInicio
        ' 
        pnInicio.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnInicio.Location = New Point(0, 75)
        pnInicio.Name = "pnInicio"
        pnInicio.Size = New Size(3, 40)
        pnInicio.TabIndex = 5
        ' 
        ' btnInicio
        ' 
        btnInicio.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnInicio.BackgroundImageLayout = ImageLayout.Zoom
        btnInicio.Cursor = Cursors.Hand
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.Font = New Font("Arial", 16F)
        btnInicio.ForeColor = Color.White
        btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), Image)
        btnInicio.ImageAlign = ContentAlignment.MiddleLeft
        btnInicio.Location = New Point(0, 75)
        btnInicio.Name = "btnInicio"
        btnInicio.Padding = New Padding(6, 0, 0, 0)
        btnInicio.Size = New Size(240, 40)
        btnInicio.TabIndex = 3
        btnInicio.Text = "Inicio"
        btnInicio.UseVisualStyleBackColor = False
        ' 
        ' pnLineaMenu1
        ' 
        pnLineaMenu1.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnLineaMenu1.Location = New Point(9, 49)
        pnLineaMenu1.Name = "pnLineaMenu1"
        pnLineaMenu1.Size = New Size(222, 6)
        pnLineaMenu1.TabIndex = 4
        ' 
        ' btnMenu
        ' 
        btnMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMenu.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), Image)
        btnMenu.BackgroundImageLayout = ImageLayout.Zoom
        btnMenu.Cursor = Cursors.Hand
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Location = New Point(191, 5)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(40, 40)
        btnMenu.TabIndex = 3
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' pnPrincipal
        ' 
        pnPrincipal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnPrincipal.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        pnPrincipal.Controls.Add(imgLogoAlmasoft)
        pnPrincipal.Location = New Point(266, 102)
        pnPrincipal.Name = "pnPrincipal"
        pnPrincipal.Size = New Size(800, 467)
        pnPrincipal.TabIndex = 2
        ' 
        ' imgLogoAlmasoft
        ' 
        imgLogoAlmasoft.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        imgLogoAlmasoft.Image = CType(resources.GetObject("imgLogoAlmasoft.Image"), Image)
        imgLogoAlmasoft.Location = New Point(600, 267)
        imgLogoAlmasoft.Name = "imgLogoAlmasoft"
        imgLogoAlmasoft.Size = New Size(200, 200)
        imgLogoAlmasoft.SizeMode = PictureBoxSizeMode.Zoom
        imgLogoAlmasoft.TabIndex = 0
        imgLogoAlmasoft.TabStop = False
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnAbajo.BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        pnAbajo.Location = New Point(239, 585)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(864, 27)
        pnAbajo.TabIndex = 3
        ' 
        ' tmOcultarMenu
        ' 
        tmOcultarMenu.Interval = 1
        ' 
        ' tmMostrarMenu
        ' 
        tmMostrarMenu.Interval = 1
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        ClientSize = New Size(1094, 607)
        Controls.Add(pnAbajo)
        Controls.Add(pnPrincipal)
        Controls.Add(pnMenu)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        pnMenu.ResumeLayout(False)
        pnPrincipal.ResumeLayout(False)
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnArriba As Panel
    Friend WithEvents pnMenu As Panel
    Friend WithEvents pnPrincipal As Panel
    Friend WithEvents imgLogoAlmasoft As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblU As Label
    Friend WithEvents btnCobros As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnListados As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents pnLineaMenu1 As Panel
    Friend WithEvents pnInicio As Panel
    Friend WithEvents pnVentas As Panel
    Friend WithEvents pnProductos As Panel
    Friend WithEvents pnProveedores As Panel
    Friend WithEvents pnClientes As Panel
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents pnSalir As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents pnLineaMenu2 As Panel
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InactivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InactivosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InactivosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem2 As ToolStripMenuItem

End Class
