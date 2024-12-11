<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        pnArriba = New Panel()
        btnMinimizar = New Button()
        btnCerrar = New Button()
        pnAbajo = New Panel()
        txtPass = New TextBox()
        lbl7 = New Label()
        txtUsuario = New TextBox()
        lbl5 = New Label()
        checkMostrarPass = New CheckBox()
        btnIngresar = New Button()
        lblTarea = New Label()
        imgLogoAlmasoft = New PictureBox()
        lblError = New Label()
        pnArriba.SuspendLayout()
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(416, 41)
        pnArriba.TabIndex = 34
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(332, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 5
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
        btnCerrar.Location = New Point(368, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 6
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 285)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(434, 20)
        pnAbajo.TabIndex = 35
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtPass.Font = New Font("Arial", 12F)
        txtPass.ForeColor = Color.Black
        txtPass.Location = New Point(32, 124)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(340, 26)
        txtPass.TabIndex = 2
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.Font = New Font("Arial", 12F)
        lbl7.ForeColor = Color.White
        lbl7.Location = New Point(32, 103)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(93, 18)
        lbl7.TabIndex = 39
        lbl7.Text = "Contraseña:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtUsuario.Font = New Font("Arial", 12F)
        txtUsuario.ForeColor = Color.Black
        txtUsuario.Location = New Point(32, 74)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(340, 26)
        txtUsuario.TabIndex = 1
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Arial", 12F)
        lbl5.ForeColor = Color.White
        lbl5.Location = New Point(32, 53)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(66, 18)
        lbl5.TabIndex = 38
        lbl5.Text = "Usuario:"
        ' 
        ' checkMostrarPass
        ' 
        checkMostrarPass.AutoSize = True
        checkMostrarPass.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        checkMostrarPass.ForeColor = Color.White
        checkMostrarPass.Location = New Point(32, 156)
        checkMostrarPass.Name = "checkMostrarPass"
        checkMostrarPass.Size = New Size(132, 19)
        checkMostrarPass.TabIndex = 3
        checkMostrarPass.Text = "Mostrar contraseña"
        checkMostrarPass.UseVisualStyleBackColor = True
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnIngresar.BackColor = Color.FromArgb(CByte(0), CByte(117), CByte(255))
        btnIngresar.Cursor = Cursors.Hand
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(117, 208)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(173, 30)
        btnIngresar.TabIndex = 4
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(99, 18)
        lblTarea.TabIndex = 41
        lblTarea.Text = "Iniciar sesión"
        ' 
        ' imgLogoAlmasoft
        ' 
        imgLogoAlmasoft.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        imgLogoAlmasoft.Image = CType(resources.GetObject("imgLogoAlmasoft.Image"), Image)
        imgLogoAlmasoft.Location = New Point(180, 53)
        imgLogoAlmasoft.Name = "imgLogoAlmasoft"
        imgLogoAlmasoft.Size = New Size(301, 300)
        imgLogoAlmasoft.SizeMode = PictureBoxSizeMode.Zoom
        imgLogoAlmasoft.TabIndex = 42
        imgLogoAlmasoft.TabStop = False
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblError.ForeColor = Color.Red
        lblError.Location = New Point(107, 241)
        lblError.Name = "lblError"
        lblError.Size = New Size(194, 15)
        lblError.TabIndex = 43
        lblError.Text = "Usuario y/o contraseña incorrecta."
        lblError.Visible = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        ClientSize = New Size(400, 300)
        Controls.Add(lblError)
        Controls.Add(lblTarea)
        Controls.Add(btnIngresar)
        Controls.Add(checkMostrarPass)
        Controls.Add(txtPass)
        Controls.Add(lbl7)
        Controls.Add(txtUsuario)
        Controls.Add(lbl5)
        Controls.Add(pnAbajo)
        Controls.Add(pnArriba)
        Controls.Add(imgLogoAlmasoft)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar sesión - Almasoft"
        pnArriba.ResumeLayout(False)
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnArriba As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lbl7 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents checkMostrarPass As CheckBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lblTarea As Label
    Friend WithEvents imgLogoAlmasoft As PictureBox
    Friend WithEvents lblError As Label
End Class
