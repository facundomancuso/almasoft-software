<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculadora))
        Label1 = New Label()
        txtRecibido = New TextBox()
        pnArriba = New Panel()
        lblTarea = New Label()
        btnMinimizar = New Button()
        btnSalir = New Button()
        btnCerrar = New Button()
        pnAbajo = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        lblTotal = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        lblCambio = New Label()
        btnAceptar = New Button()
        Panel2 = New Panel()
        pnArriba.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 37)
        Label1.TabIndex = 45
        Label1.Text = "Recibido:"
        ' 
        ' txtRecibido
        ' 
        txtRecibido.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtRecibido.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtRecibido.Location = New Point(217, 71)
        txtRecibido.Name = "txtRecibido"
        txtRecibido.Size = New Size(234, 44)
        txtRecibido.TabIndex = 57
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnSalir)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Location = New Point(0, 0)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(466, 41)
        pnArriba.TabIndex = 58
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(121, 18)
        lblTarea.TabIndex = 70
        lblTarea.Text = "Calcular cambio"
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(598, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 5
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), Image)
        btnSalir.BackgroundImageLayout = ImageLayout.Zoom
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Location = New Point(433, 6)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(30, 30)
        btnSalir.TabIndex = 61
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerrar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Zoom
        btnCerrar.FlatAppearance.BorderSize = 0
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.Location = New Point(634, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 6
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' pnAbajo
        ' 
        pnAbajo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Location = New Point(-1, 462)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(467, 20)
        pnAbajo.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(71, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 37)
        Label2.TabIndex = 60
        Label2.Text = "Total:"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel1.Location = New Point(12, 212)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 10)
        Panel1.TabIndex = 61
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 37)
        Label3.TabIndex = 62
        Label3.Text = "Cambio:"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.White
        lblTotal.Location = New Point(217, 154)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(170, 37)
        lblTotal.TabIndex = 63
        lblTotal.Text = "000000.00"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(176, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 37)
        Label5.TabIndex = 64
        Label5.Text = "$"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(176, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 37)
        Label6.TabIndex = 65
        Label6.Text = "$"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(176, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 37)
        Label4.TabIndex = 66
        Label4.Text = "$"
        ' 
        ' lblCambio
        ' 
        lblCambio.AutoSize = True
        lblCambio.Font = New Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCambio.ForeColor = Color.Yellow
        lblCambio.Location = New Point(217, 240)
        lblCambio.Name = "lblCambio"
        lblCambio.Size = New Size(170, 37)
        lblCambio.TabIndex = 67
        lblCambio.Text = "000000.00"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAceptar.BackColor = Color.FromArgb(CByte(0), CByte(117), CByte(255))
        btnAceptar.Cursor = Cursors.Hand
        btnAceptar.FlatAppearance.BorderSize = 0
        btnAceptar.FlatStyle = FlatStyle.Flat
        btnAceptar.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAceptar.ForeColor = Color.White
        btnAceptar.Location = New Point(145, 345)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(173, 60)
        btnAceptar.TabIndex = 68
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Panel2.Location = New Point(0, 421)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(466, 20)
        Panel2.TabIndex = 69
        ' 
        ' frmCalculadora
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        ClientSize = New Size(464, 441)
        Controls.Add(Panel2)
        Controls.Add(btnAceptar)
        Controls.Add(lblCambio)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblTotal)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(pnAbajo)
        Controls.Add(pnArriba)
        Controls.Add(txtRecibido)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmCalculadora"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculadora - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRecibido As TextBox
    Friend WithEvents pnArriba As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCambio As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTarea As Label
End Class
