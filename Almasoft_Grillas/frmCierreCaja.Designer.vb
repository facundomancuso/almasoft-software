<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreCaja))
        pnArriba = New Panel()
        btnMin = New Button()
        lblCierre = New Label()
        btnClose = New Button()
        btnMinimizar = New Button()
        btnCerrar = New Button()
        btnCierre = New Button()
        imgLogoAlmasoft = New PictureBox()
        pnAbajo = New Panel()
        lbl5 = New Label()
        dtpCierre = New DateTimePicker()
        pnArriba.SuspendLayout()
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(btnMin)
        pnArriba.Controls.Add(lblCierre)
        pnArriba.Controls.Add(btnClose)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Dock = DockStyle.Top
        pnArriba.Location = New Point(0, 0)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(400, 41)
        pnArriba.TabIndex = 35
        ' 
        ' btnMin
        ' 
        btnMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMin.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), Image)
        btnMin.BackgroundImageLayout = ImageLayout.Zoom
        btnMin.FlatAppearance.BorderSize = 0
        btnMin.FlatStyle = FlatStyle.Flat
        btnMin.Location = New Point(331, 5)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(30, 29)
        btnMin.TabIndex = 47
        btnMin.UseVisualStyleBackColor = False
        ' 
        ' lblCierre
        ' 
        lblCierre.AutoSize = True
        lblCierre.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        lblCierre.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCierre.ForeColor = Color.White
        lblCierre.Location = New Point(12, 11)
        lblCierre.Name = "lblCierre"
        lblCierre.Size = New Size(107, 18)
        lblCierre.TabIndex = 42
        lblCierre.Text = "Cierre de caja"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), Image)
        btnClose.BackgroundImageLayout = ImageLayout.Zoom
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Location = New Point(367, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 29)
        btnClose.TabIndex = 48
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(532, 6)
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
        btnCerrar.Location = New Point(568, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 6
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnCierre
        ' 
        btnCierre.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCierre.BackColor = Color.FromArgb(CByte(0), CByte(117), CByte(255))
        btnCierre.Cursor = Cursors.Hand
        btnCierre.FlatAppearance.BorderSize = 0
        btnCierre.FlatStyle = FlatStyle.Flat
        btnCierre.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCierre.ForeColor = Color.White
        btnCierre.Location = New Point(117, 208)
        btnCierre.Name = "btnCierre"
        btnCierre.Size = New Size(173, 30)
        btnCierre.TabIndex = 36
        btnCierre.Text = "Emitir"
        btnCierre.UseVisualStyleBackColor = False
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
        ' pnAbajo
        ' 
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Dock = DockStyle.Bottom
        pnAbajo.Location = New Point(0, 280)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(400, 20)
        pnAbajo.TabIndex = 44
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Font = New Font("Arial", 12F)
        lbl5.ForeColor = Color.White
        lbl5.Location = New Point(143, 116)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(122, 18)
        lbl5.TabIndex = 45
        lbl5.Text = "Fecha de cierre:"
        ' 
        ' dtpCierre
        ' 
        dtpCierre.Font = New Font("Arial", 12F)
        dtpCierre.Format = DateTimePickerFormat.Short
        dtpCierre.Location = New Point(117, 137)
        dtpCierre.Name = "dtpCierre"
        dtpCierre.Size = New Size(173, 26)
        dtpCierre.TabIndex = 47
        ' 
        ' frmCierreCaja
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(78), CByte(123))
        CausesValidation = False
        ClientSize = New Size(400, 300)
        ControlBox = False
        Controls.Add(dtpCierre)
        Controls.Add(lbl5)
        Controls.Add(pnAbajo)
        Controls.Add(btnCierre)
        Controls.Add(pnArriba)
        Controls.Add(imgLogoAlmasoft)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "frmCierreCaja"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cierre de caja - Almasoft"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        CType(imgLogoAlmasoft, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnArriba As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblCierre As Label
    Friend WithEvents btnCierre As Button
    Friend WithEvents imgLogoAlmasoft As PictureBox
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents lbl5 As Label
    Friend WithEvents btnMin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dtpCierre As DateTimePicker
End Class
