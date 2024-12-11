<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        pnArriba = New Panel()
        lblTarea = New Label()
        lblID = New Label()
        btnMinimizar = New Button()
        lbl13 = New Label()
        btnCerrar = New Button()
        lbl1 = New Label()
        lbl2 = New Label()
        txtNombre = New TextBox()
        lbl3 = New Label()
        txtApellido = New TextBox()
        lbl4 = New Label()
        txtDni = New TextBox()
        lbl5 = New Label()
        txtDireccion = New TextBox()
        lbl6 = New Label()
        txtLocalidad = New TextBox()
        lbl7 = New Label()
        txtCp = New TextBox()
        lbl8 = New Label()
        lbl9 = New Label()
        txtEmail = New TextBox()
        lbl10 = New Label()
        txtTelefono = New TextBox()
        lbl11 = New Label()
        lbl12 = New Label()
        btnCancelar = New Button()
        btnAceptar = New Button()
        pnAbajo = New Panel()
        cbProvincia = New ComboBox()
        cbCondicionIva = New ComboBox()
        dtFechaDeNacimiento = New DateTimePicker()
        chActivo = New CheckBox()
        txtCodigo = New TextBox()
        lblAvisoActivo = New Label()
        btnGenerarPdf = New Button()
        pnArriba.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(lblID)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(lbl13)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(790, 41)
        pnArriba.TabIndex = 5
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
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Arial", 12F)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(379, 11)
        lblID.Name = "lblID"
        lblID.Size = New Size(17, 18)
        lblID.TabIndex = 36
        lblID.Text = "1"
        lblID.Visible = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(712, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 16
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' lbl13
        ' 
        lbl13.AutoSize = True
        lbl13.Font = New Font("Arial", 12F)
        lbl13.ForeColor = Color.White
        lbl13.Location = New Point(346, 11)
        lbl13.Name = "lbl13"
        lbl13.Size = New Size(27, 18)
        lbl13.TabIndex = 35
        lbl13.Text = "ID:"
        lbl13.Visible = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(748, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 17
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Arial", 12F)
        lbl1.ForeColor = Color.White
        lbl1.Location = New Point(32, 61)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(64, 18)
        lbl1.TabIndex = 7
        lbl1.Text = "Código:"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Font = New Font("Arial", 12F)
        lbl2.ForeColor = Color.White
        lbl2.Location = New Point(32, 111)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(68, 18)
        lbl2.TabIndex = 9
        lbl2.Text = "Nombre:"
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtNombre.Font = New Font("Arial", 12F)
        txtNombre.Location = New Point(32, 132)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(340, 26)
        txtNombre.TabIndex = 2
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Font = New Font("Arial", 12F)
        lbl3.ForeColor = Color.White
        lbl3.Location = New Point(32, 161)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(69, 18)
        lbl3.TabIndex = 11
        lbl3.Text = "Apellido:"
        ' 
        ' txtApellido
        ' 
        txtApellido.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtApellido.Font = New Font("Arial", 12F)
        txtApellido.Location = New Point(32, 182)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(340, 26)
        txtApellido.TabIndex = 3
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Font = New Font("Arial", 12F)
        lbl4.ForeColor = Color.White
        lbl4.Location = New Point(32, 211)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(38, 18)
        lbl4.TabIndex = 13
        lbl4.Text = "DNI:"
        ' 
        ' txtDni
        ' 
        txtDni.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtDni.Font = New Font("Arial", 12F)
        txtDni.Location = New Point(32, 232)
        txtDni.Name = "txtDni"
        txtDni.Size = New Size(340, 26)
        txtDni.TabIndex = 4
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Arial", 12F)
        lbl5.ForeColor = Color.White
        lbl5.Location = New Point(32, 311)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(79, 18)
        lbl5.TabIndex = 15
        lbl5.Text = "Dirección:"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtDireccion.Font = New Font("Arial", 12F)
        txtDireccion.Location = New Point(32, 332)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(340, 26)
        txtDireccion.TabIndex = 6
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.Font = New Font("Arial", 12F)
        lbl6.ForeColor = Color.White
        lbl6.Location = New Point(401, 111)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(81, 18)
        lbl6.TabIndex = 17
        lbl6.Text = "Localidad:"
        ' 
        ' txtLocalidad
        ' 
        txtLocalidad.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtLocalidad.Font = New Font("Arial", 12F)
        txtLocalidad.Location = New Point(401, 132)
        txtLocalidad.Name = "txtLocalidad"
        txtLocalidad.Size = New Size(340, 26)
        txtLocalidad.TabIndex = 9
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.Font = New Font("Arial", 12F)
        lbl7.ForeColor = Color.White
        lbl7.Location = New Point(401, 61)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(41, 18)
        lbl7.TabIndex = 19
        lbl7.Text = "C.P.:"
        ' 
        ' txtCp
        ' 
        txtCp.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtCp.Font = New Font("Arial", 12F)
        txtCp.Location = New Point(401, 82)
        txtCp.Name = "txtCp"
        txtCp.Size = New Size(340, 26)
        txtCp.TabIndex = 8
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.Font = New Font("Arial", 12F)
        lbl8.ForeColor = Color.White
        lbl8.Location = New Point(401, 161)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(77, 18)
        lbl8.TabIndex = 21
        lbl8.Text = "Provincia:"
        ' 
        ' lbl9
        ' 
        lbl9.AutoSize = True
        lbl9.Font = New Font("Arial", 12F)
        lbl9.ForeColor = Color.White
        lbl9.Location = New Point(401, 311)
        lbl9.Name = "lbl9"
        lbl9.Size = New Size(36, 18)
        lbl9.TabIndex = 23
        lbl9.Text = "IVA:"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtEmail.Font = New Font("Arial", 12F)
        txtEmail.Location = New Point(401, 282)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(340, 26)
        txtEmail.TabIndex = 12
        ' 
        ' lbl10
        ' 
        lbl10.AutoSize = True
        lbl10.Font = New Font("Arial", 12F)
        lbl10.ForeColor = Color.White
        lbl10.Location = New Point(401, 211)
        lbl10.Name = "lbl10"
        lbl10.Size = New Size(70, 18)
        lbl10.TabIndex = 25
        lbl10.Text = "Teléfono:"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtTelefono.Font = New Font("Arial", 12F)
        txtTelefono.Location = New Point(401, 232)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(340, 26)
        txtTelefono.TabIndex = 11
        ' 
        ' lbl11
        ' 
        lbl11.AutoSize = True
        lbl11.Font = New Font("Arial", 12F)
        lbl11.ForeColor = Color.White
        lbl11.Location = New Point(401, 261)
        lbl11.Name = "lbl11"
        lbl11.Size = New Size(57, 18)
        lbl11.TabIndex = 27
        lbl11.Text = "E-mail:"
        ' 
        ' lbl12
        ' 
        lbl12.AutoSize = True
        lbl12.Font = New Font("Arial", 12F)
        lbl12.ForeColor = Color.White
        lbl12.Location = New Point(32, 261)
        lbl12.Name = "lbl12"
        lbl12.Size = New Size(128, 18)
        lbl12.TabIndex = 29
        lbl12.Text = "Fecha de nacim.:"
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
        btnCancelar.TabIndex = 15
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
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
        btnAceptar.TabIndex = 14
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 515)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(790, 20)
        pnAbajo.TabIndex = 33
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
        cbProvincia.TabIndex = 10
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
        cbCondicionIva.TabIndex = 13
        ' 
        ' dtFechaDeNacimiento
        ' 
        dtFechaDeNacimiento.CalendarFont = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtFechaDeNacimiento.CalendarMonthBackground = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dtFechaDeNacimiento.Cursor = Cursors.Hand
        dtFechaDeNacimiento.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtFechaDeNacimiento.Format = DateTimePickerFormat.Short
        dtFechaDeNacimiento.Location = New Point(32, 282)
        dtFechaDeNacimiento.Name = "dtFechaDeNacimiento"
        dtFechaDeNacimiento.Size = New Size(340, 26)
        dtFechaDeNacimiento.TabIndex = 5
        ' 
        ' chActivo
        ' 
        chActivo.AutoSize = True
        chActivo.Font = New Font("Arial", 12F)
        chActivo.ForeColor = Color.White
        chActivo.Location = New Point(671, 45)
        chActivo.Name = "chActivo"
        chActivo.Size = New Size(70, 22)
        chActivo.TabIndex = 7
        chActivo.Text = "Activo"
        chActivo.UseVisualStyleBackColor = True
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
        ' lblAvisoActivo
        ' 
        lblAvisoActivo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblAvisoActivo.AutoSize = True
        lblAvisoActivo.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAvisoActivo.ForeColor = Color.White
        lblAvisoActivo.Location = New Point(401, 361)
        lblAvisoActivo.Name = "lblAvisoActivo"
        lblAvisoActivo.Size = New Size(63, 19)
        lblAvisoActivo.TabIndex = 38
        lblAvisoActivo.Text = "Estado"
        lblAvisoActivo.Visible = False
        ' 
        ' btnGenerarPdf
        ' 
        btnGenerarPdf.BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        btnGenerarPdf.BackgroundImage = CType(resources.GetObject("btnGenerarPdf.BackgroundImage"), Image)
        btnGenerarPdf.BackgroundImageLayout = ImageLayout.Zoom
        btnGenerarPdf.Cursor = Cursors.Hand
        btnGenerarPdf.FlatAppearance.BorderSize = 0
        btnGenerarPdf.FlatStyle = FlatStyle.Flat
        btnGenerarPdf.Location = New Point(711, 468)
        btnGenerarPdf.Name = "btnGenerarPdf"
        btnGenerarPdf.Size = New Size(30, 30)
        btnGenerarPdf.TabIndex = 67
        btnGenerarPdf.UseVisualStyleBackColor = False
        ' 
        ' frmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(780, 530)
        Controls.Add(btnGenerarPdf)
        Controls.Add(lblAvisoActivo)
        Controls.Add(txtCodigo)
        Controls.Add(chActivo)
        Controls.Add(dtFechaDeNacimiento)
        Controls.Add(cbCondicionIva)
        Controls.Add(cbProvincia)
        Controls.Add(pnAbajo)
        Controls.Add(btnAceptar)
        Controls.Add(btnCancelar)
        Controls.Add(lbl12)
        Controls.Add(lbl11)
        Controls.Add(txtTelefono)
        Controls.Add(lbl10)
        Controls.Add(txtEmail)
        Controls.Add(lbl9)
        Controls.Add(lbl8)
        Controls.Add(txtCp)
        Controls.Add(lbl7)
        Controls.Add(txtLocalidad)
        Controls.Add(lbl6)
        Controls.Add(txtDireccion)
        Controls.Add(lbl5)
        Controls.Add(txtDni)
        Controls.Add(lbl4)
        Controls.Add(txtApellido)
        Controls.Add(lbl3)
        Controls.Add(txtNombre)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmClientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Clientes - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnArriba As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents lblTarea As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents lbl7 As Label
    Friend WithEvents txtCp As TextBox
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lbl10 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbCondicionIva As ComboBox
    Friend WithEvents dtFechaDeNacimiento As DateTimePicker
    Friend WithEvents chActivo As CheckBox
    Friend WithEvents lbl13 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblAvisoActivo As Label
    Friend WithEvents btnGenerarPdf As Button
End Class
