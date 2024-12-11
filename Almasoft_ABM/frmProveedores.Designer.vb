<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        pnAbajo = New Panel()
        btnAceptar = New Button()
        btnCancelar = New Button()
        lbl11 = New Label()
        txtTelefono = New TextBox()
        lbl10 = New Label()
        txtEmail = New TextBox()
        lbl8 = New Label()
        txtCp = New TextBox()
        txtLocalidad = New TextBox()
        lbl6 = New Label()
        txtDireccion = New TextBox()
        lbl5 = New Label()
        lbl3 = New Label()
        txtEmpresa = New TextBox()
        lbl2 = New Label()
        lbl1 = New Label()
        pnArriba = New Panel()
        lblID = New Label()
        Button1 = New Button()
        lbl13 = New Label()
        lblTarea = New Label()
        Button2 = New Button()
        lbl9 = New Label()
        lbl4 = New Label()
        lbl7 = New Label()
        txtFirma = New TextBox()
        txtCuit = New TextBox()
        txtCodigo = New TextBox()
        chActivo = New CheckBox()
        lblAvisoActivo = New Label()
        btnVerProductos = New Button()
        cbProvincia = New ComboBox()
        cbCondicionIva = New ComboBox()
        pnArriba.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 515)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(790, 20)
        pnAbajo.TabIndex = 58
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
        btnAceptar.TabIndex = 13
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
        btnCancelar.TabIndex = 14
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' lbl11
        ' 
        lbl11.AutoSize = True
        lbl11.Font = New Font("Arial", 12F)
        lbl11.ForeColor = Color.White
        lbl11.Location = New Point(401, 261)
        lbl11.Name = "lbl11"
        lbl11.Size = New Size(57, 18)
        lbl11.TabIndex = 54
        lbl11.Text = "E-mail:"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtTelefono.Font = New Font("Arial", 12F)
        txtTelefono.Location = New Point(401, 232)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(340, 26)
        txtTelefono.TabIndex = 10
        ' 
        ' lbl10
        ' 
        lbl10.AutoSize = True
        lbl10.Font = New Font("Arial", 12F)
        lbl10.ForeColor = Color.White
        lbl10.Location = New Point(401, 211)
        lbl10.Name = "lbl10"
        lbl10.Size = New Size(70, 18)
        lbl10.TabIndex = 52
        lbl10.Text = "Teléfono:"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtEmail.Font = New Font("Arial", 12F)
        txtEmail.Location = New Point(401, 282)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(340, 26)
        txtEmail.TabIndex = 11
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.Font = New Font("Arial", 12F)
        lbl8.ForeColor = Color.White
        lbl8.Location = New Point(401, 161)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(77, 18)
        lbl8.TabIndex = 50
        lbl8.Text = "Provincia:"
        ' 
        ' txtCp
        ' 
        txtCp.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCp.Font = New Font("Arial", 12F)
        txtCp.Location = New Point(401, 82)
        txtCp.Name = "txtCp"
        txtCp.Size = New Size(340, 26)
        txtCp.TabIndex = 7
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtLocalidad.Font = New Font("Arial", 12F)
        txtLocalidad.Location = New Point(401, 132)
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.Size = New Size(340, 26)
        txtLocalidad.TabIndex = 8
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.Font = New Font("Arial", 12F)
        lbl6.ForeColor = Color.White
        lbl6.Location = New Point(401, 111)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(81, 18)
        lbl6.TabIndex = 47
        lbl6.Text = "Localidad:"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtDireccion.Font = New Font("Arial", 12F)
        txtDireccion.Location = New Point(32, 282)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(340, 26)
        txtDireccion.TabIndex = 5
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Arial", 12F)
        lbl5.ForeColor = Color.White
        lbl5.Location = New Point(32, 261)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(79, 18)
        lbl5.TabIndex = 45
        lbl5.Text = "Dirección:"
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Font = New Font("Arial", 12F)
        lbl3.ForeColor = Color.White
        lbl3.Location = New Point(32, 161)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(53, 18)
        lbl3.TabIndex = 42
        lbl3.Text = "Firma:"
        ' 
        ' txtEmpresa
        ' 
        txtEmpresa.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtEmpresa.Font = New Font("Arial", 12F)
        txtEmpresa.Location = New Point(32, 132)
        txtEmpresa.Name = "txtEmpresa"
        txtEmpresa.Size = New Size(340, 26)
        txtEmpresa.TabIndex = 2
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Arial", 12F)
        lbl2.ForeColor = Color.White
        lbl2.Location = New Point(32, 111)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(76, 18)
        lbl2.TabIndex = 40
        lbl2.Text = "Empresa:"
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Arial", 12F)
        lbl1.ForeColor = Color.White
        lbl1.Location = New Point(32, 61)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(64, 18)
        lbl1.TabIndex = 38
        lbl1.Text = "Código:"
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(lblID)
        pnArriba.Controls.Add(Button1)
        pnArriba.Controls.Add(lbl13)
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(Button2)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(790, 41)
        pnArriba.TabIndex = 37
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Arial", 12F)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(379, 11)
        lblID.Name = "lblID"
        lblID.Size = New Size(17, 18)
        lblID.TabIndex = 69
        lblID.Text = "1"
        lblID.Visible = False
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
        Button1.TabIndex = 16
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lbl13
        ' 
        lbl13.AutoSize = True
        lbl13.Font = New Font("Arial", 12F)
        lbl13.ForeColor = Color.White
        lbl13.Location = New Point(346, 11)
        lbl13.Name = "lbl13"
        lbl13.Size = New Size(27, 18)
        lbl13.TabIndex = 68
        lbl13.Text = "ID:"
        lbl13.Visible = False
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
        Button2.TabIndex = 17
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.Font = New Font("Arial", 12F)
        lbl9.ForeColor = Color.White
        lbl9.Location = New Point(401, 311)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(36, 18)
        lbl9.TabIndex = 63
        lbl9.Text = "IVA:"
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Font = New Font("Arial", 12F)
        lbl4.ForeColor = Color.White
        lbl4.Location = New Point(32, 211)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(45, 18)
        lbl4.TabIndex = 62
        lbl4.Text = "CUIT:"
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.Font = New Font("Arial", 12F)
        lbl7.ForeColor = Color.White
        lbl7.Location = New Point(401, 61)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(41, 18)
        lbl7.TabIndex = 64
        lbl7.Text = "C.P.:"
        ' 
        ' txtFirma
        ' 
        txtFirma.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtFirma.Font = New Font("Arial", 12F)
        txtFirma.Location = New Point(32, 182)
        txtFirma.Name = "txtFirma"
        txtFirma.Size = New Size(340, 26)
        txtFirma.TabIndex = 3
        ' 
        ' txtCuit
        ' 
        txtCuit.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCuit.Font = New Font("Arial", 12F)
        txtCuit.Location = New Point(32, 232)
        txtCuit.Name = "txtCuit"
        txtCuit.Size = New Size(340, 26)
        txtCuit.TabIndex = 4
        ' 
        ' txtCodigo
        ' 
        txtCodigo.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCodigo.Font = New Font("Arial", 12F)
        txtCodigo.Location = New Point(32, 82)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(340, 26)
        txtCodigo.TabIndex = 1
        ' 
        ' chActivo
        ' 
        chActivo.AutoSize = True
        chActivo.Font = New Font("Arial", 12F)
        chActivo.ForeColor = Color.White
        chActivo.Location = New Point(671, 45)
        chActivo.Name = "chActivo"
        chActivo.Size = New Size(70, 22)
        chActivo.TabIndex = 6
        chActivo.Text = "Activo"
        chActivo.UseVisualStyleBackColor = True
        ' 
        ' lblAvisoActivo
        ' 
        lblAvisoActivo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblAvisoActivo.AutoSize = True
        lblAvisoActivo.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvisoActivo.ForeColor = Color.White
        lblAvisoActivo.Location = New Point(478, 479)
        lblAvisoActivo.Name = "lblAvisoActivo"
        lblAvisoActivo.Size = New Size(290, 19)
        lblAvisoActivo.TabIndex = 67
        lblAvisoActivo.Text = "El proveedor se encuentra INACTIVO"
        ' 
        ' btnVerProductos
        ' 
        btnVerProductos.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnVerProductos.BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        btnVerProductos.Cursor = Cursors.Hand
        btnVerProductos.FlatAppearance.BorderSize = 0
        btnVerProductos.FlatStyle = FlatStyle.Flat
        btnVerProductos.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerProductos.ForeColor = Color.White
        btnVerProductos.Location = New Point(244, 468)
        btnVerProductos.Name = "btnVerProductos"
        btnVerProductos.Size = New Size(100, 30)
        btnVerProductos.TabIndex = 15
        btnVerProductos.Text = "Ver prod."
        btnVerProductos.UseVisualStyleBackColor = False
        ' 
        ' cbProvincia
        ' 
        cbProvincia.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbProvincia.DropDownStyle = ComboBoxStyle.DropDownList
        cbProvincia.Font = New Font("Arial", 12F)
        cbProvincia.FormattingEnabled = True
        cbProvincia.Location = New Point(401, 182)
        cbProvincia.Name = "cbProvincia"
        cbProvincia.Size = New Size(340, 26)
        cbProvincia.TabIndex = 9
        ' 
        ' cbCondicionIva
        ' 
        cbCondicionIva.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        cbCondicionIva.DropDownStyle = ComboBoxStyle.DropDownList
        cbCondicionIva.Font = New Font("Arial", 12F)
        cbCondicionIva.FormattingEnabled = True
        cbCondicionIva.Location = New Point(401, 332)
        cbCondicionIva.Name = "cbCondicionIva"
        cbCondicionIva.Size = New Size(340, 26)
        cbCondicionIva.TabIndex = 12
        ' 
        ' frmProveedores
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(780, 530)
        Controls.Add(cbCondicionIva)
        Controls.Add(cbProvincia)
        Controls.Add(btnVerProductos)
        Controls.Add(lblAvisoActivo)
        Controls.Add(chActivo)
        Controls.Add(txtCodigo)
        Controls.Add(txtCuit)
        Controls.Add(txtFirma)
        Controls.Add(lbl7)
        Controls.Add(lbl9)
        Controls.Add(lbl4)
        Controls.Add(pnAbajo)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(lbl11)
        Controls.Add(txtTelefono)
        Controls.Add(lbl10)
        Controls.Add(txtEmail)
        Controls.Add(lbl8)
        Controls.Add(txtCp)
        Controls.Add(txtLocalidad)
        Controls.Add(lbl6)
        Controls.Add(txtDireccion)
        Controls.Add(lbl5)
        Controls.Add(lbl3)
        Controls.Add(txtEmpresa)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Controls.Add(pnArriba)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "frmProveedores"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Proveedores - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtFechaDeNacimiento As DateTimePicker
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lbl10 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents txtCp As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents pnArriba As Panel
    Friend WithEvents lblTarea As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents txtFirma As TextBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents chActivo As CheckBox
    Friend WithEvents lblAvisoActivo As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lbl13 As Label
    Friend WithEvents btnVerProductos As Button
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbCondicionIva As ComboBox
End Class
