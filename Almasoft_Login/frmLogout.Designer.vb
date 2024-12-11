<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogout))
        pnArriba = New Panel()
        lblTarea = New Label()
        btnCerrar = New Button()
        imgLogoAlmasoft = New PictureBox()
        lbl5 = New Label()
        btnAceptar = New Button()
        btnCancelar = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        pnAbajo = New Panel()
        pnArriba.SuspendLayout()
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnArriba
        ' 
        pnArriba.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Location = New Point(-1, -2)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(416, 41)
        pnArriba.TabIndex = 36
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(103, 18)
        lblTarea.TabIndex = 44
        lblTarea.Text = "Cerrar sesión"
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
        btnCerrar.TabIndex = 43
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' imgLogoAlmasoft
        ' 
        imgLogoAlmasoft.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        imgLogoAlmasoft.Image = CType(resources.GetObject("imgLogoAlmasoft.Image"), Image)
        imgLogoAlmasoft.Location = New Point(180, 53)
        imgLogoAlmasoft.Name = "imgLogoAlmasoft"
        imgLogoAlmasoft.Size = New Size(301, 300)
        imgLogoAlmasoft.SizeMode = PictureBoxSizeMode.Zoom
        imgLogoAlmasoft.TabIndex = 43
        imgLogoAlmasoft.TabStop = False
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl5.ForeColor = Color.White
        lbl5.Location = New Point(16, 111)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(372, 22)
        lbl5.TabIndex = 44
        lbl5.Text = "¿Está seguro de que quiere cerrar sesión?"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAceptar.BackColor = Color.FromArgb(CByte(0), CByte(117), CByte(255))
        btnAceptar.Cursor = Cursors.Hand
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(12, 208)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(173, 30)
        btnAceptar.TabIndex = 45
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancelar.BackColor = Color.FromArgb(CByte(0), CByte(117), CByte(255))
        btnCancelar.Cursor = Cursors.Hand
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.White
        btnCancelar.Location = New Point(215, 208)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(173, 30)
        btnCancelar.TabIndex = 46
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightGray
        Label1.Location = New Point(46, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 16)
        Label1.TabIndex = 47
        Label1.Text = "Puedes volver a iniciar sesión en cualquier momento."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(175, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 285)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(434, 20)
        pnAbajo.TabIndex = 49
        ' 
        ' frmLogout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        ClientSize = New Size(400, 300)
        Controls.Add(pnAbajo)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(lbl5)
        Controls.Add(imgLogoAlmasoft)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cerrar sesión - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnArriba As Panel
    Friend WithEvents lblTarea As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents imgLogoAlmasoft As PictureBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnAbajo As Panel
End Class
