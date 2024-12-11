<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        pnAbajo = New Panel()
        pnArriba = New Panel()
        lblTarea = New Label()
        btnCerrar = New Button()
        btnMinimizar = New Button()
        lblID = New Label()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl12 = New Label()
        txtApellido = New TextBox()
        lbl4 = New Label()
        txtPass = New TextBox()
        lbl3 = New Label()
        txtNombre = New TextBox()
        btnAceptar = New Button()
        btnCancelar = New Button()
        txtUsuario = New TextBox()
        Label1 = New Label()
        cbNivel = New ComboBox()
        chActivo = New CheckBox()
        lblAvisoActivo = New Label()
        checkMostrarPass = New CheckBox()
        pnArriba.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 456)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(790, 20)
        pnAbajo.TabIndex = 34
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(790, 41)
        pnArriba.TabIndex = 35
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(117, 18)
        lblTarea.TabIndex = 7
        lblTarea.Text = "Tarea corriendo"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(386, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 11
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
        btnMinimizar.Location = New Point(350, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 10
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Arial", 12F)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(102, 53)
        lblID.Name = "lblID"
        lblID.Size = New Size(23, 18)
        lblID.TabIndex = 39
        lblID.Text = "ID"
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Arial", 12F)
        lbl1.ForeColor = Color.White
        lbl1.Location = New Point(32, 53)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(64, 18)
        lbl1.TabIndex = 38
        lbl1.Text = "Código:"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Arial", 12F)
        lbl2.ForeColor = Color.White
        lbl2.Location = New Point(32, 82)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(68, 18)
        lbl2.TabIndex = 40
        lbl2.Text = "Nombre:"
        ' 
        ' lbl12
        ' 
        lbl12.AutoSize = True
        lbl12.Font = New Font("Arial", 12F)
        lbl12.ForeColor = Color.White
        lbl12.Location = New Point(32, 307)
        lbl12.Name = "lbl12"
        lbl12.Size = New Size(46, 18)
        lbl12.TabIndex = 47
        lbl12.Text = "Nivel:"
        ' 
        ' txtApellido
        ' 
        txtApellido.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtApellido.Font = New Font("Arial", 12F)
        txtApellido.Location = New Point(32, 153)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(340, 26)
        txtApellido.TabIndex = 2
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Font = New Font("Arial", 12F)
        lbl4.ForeColor = Color.White
        lbl4.Location = New Point(32, 132)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(69, 18)
        lbl4.TabIndex = 46
        lbl4.Text = "Apellido:"
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtPass.Font = New Font("Arial", 12F)
        txtPass.Location = New Point(32, 253)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(340, 26)
        txtPass.TabIndex = 4
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Font = New Font("Arial", 12F)
        lbl3.ForeColor = Color.White
        lbl3.Location = New Point(32, 232)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(93, 18)
        lbl3.TabIndex = 45
        lbl3.Text = "Contraseña:"
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtNombre.Font = New Font("Arial", 12F)
        txtNombre.Location = New Point(32, 103)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(340, 26)
        txtNombre.TabIndex = 1
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
        btnAceptar.Location = New Point(32, 409)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(100, 30)
        btnAceptar.TabIndex = 7
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
        btnCancelar.Location = New Point(138, 409)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(100, 30)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtUsuario.Font = New Font("Arial", 12F)
        txtUsuario.Location = New Point(32, 203)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(340, 26)
        txtUsuario.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(32, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 18)
        Label1.TabIndex = 53
        Label1.Text = "Usuario:"
        ' 
        ' cbNivel
        ' 
        cbNivel.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbNivel.DropDownStyle = ComboBoxStyle.DropDownList
        cbNivel.Font = New Font("Arial", 12F)
        cbNivel.FormattingEnabled = True
        cbNivel.Location = New Point(32, 328)
        cbNivel.Name = "cbNivel"
        cbNivel.Size = New Size(340, 26)
        cbNivel.TabIndex = 6
        ' 
        ' chActivo
        ' 
        chActivo.AutoSize = True
        chActivo.Font = New Font("Arial", 12F)
        chActivo.ForeColor = Color.White
        chActivo.Location = New Point(302, 45)
        chActivo.Name = "chActivo"
        chActivo.Size = New Size(70, 22)
        chActivo.TabIndex = 9
        chActivo.Text = "Activo"
        chActivo.UseVisualStyleBackColor = True
        ' 
        ' lblAvisoActivo
        ' 
        lblAvisoActivo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblAvisoActivo.AutoSize = True
        lblAvisoActivo.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvisoActivo.ForeColor = Color.White
        lblAvisoActivo.Location = New Point(32, 373)
        lblAvisoActivo.Name = "lblAvisoActivo"
        lblAvisoActivo.Size = New Size(63, 19)
        lblAvisoActivo.TabIndex = 56
        lblAvisoActivo.Text = "Estado"
        lblAvisoActivo.Visible = False
        ' 
        ' checkMostrarPass
        ' 
        checkMostrarPass.AutoSize = True
        checkMostrarPass.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkMostrarPass.ForeColor = Color.White
        checkMostrarPass.Location = New Point(32, 285)
        checkMostrarPass.Name = "checkMostrarPass"
        checkMostrarPass.Size = New Size(132, 19)
        checkMostrarPass.TabIndex = 5
        checkMostrarPass.Text = "Mostrar contraseña"
        checkMostrarPass.UseVisualStyleBackColor = True
        ' 
        ' frmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(418, 471)
        Controls.Add(checkMostrarPass)
        Controls.Add(lblAvisoActivo)
        Controls.Add(chActivo)
        Controls.Add(cbNivel)
        Controls.Add(txtUsuario)
        Controls.Add(Label1)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(lbl12)
        Controls.Add(txtApellido)
        Controls.Add(lbl4)
        Controls.Add(txtPass)
        Controls.Add(lbl3)
        Controls.Add(txtNombre)
        Controls.Add(lbl2)
        Controls.Add(lblID)
        Controls.Add(lbl1)
        Controls.Add(btnMinimizar)
        Controls.Add(btnCerrar)
        Controls.Add(pnArriba)
        Controls.Add(pnAbajo)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmUsuarios"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Usuarios - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnAbajo As Panel
    Friend WithEvents pnArriba As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents lblTarea As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents dtFechaDeNacimiento As DateTimePicker
    Friend WithEvents lbl12 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbNivel As ComboBox
    Friend WithEvents chActivo As CheckBox
    Friend WithEvents lblAvisoActivo As Label
    Friend WithEvents checkMostrarPass As CheckBox
End Class
