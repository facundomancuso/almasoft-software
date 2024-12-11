<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTablas))
        pnArriba = New Panel()
        btnMin = New Button()
        Button1 = New Button()
        btnCerr = New Button()
        lblTarea = New Label()
        Button2 = New Button()
        btnMinimizar = New Button()
        btnCerrar = New Button()
        pnAbajo = New Panel()
        btnConfiguracion = New Button()
        btnProductos = New Button()
        pnlTablas = New Panel()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        btnVentas = New Button()
        pnArriba.SuspendLayout()
        pnlTablas.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnArriba
        ' 
        pnArriba.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnArriba.Controls.Add(btnMin)
        pnArriba.Controls.Add(Button1)
        pnArriba.Controls.Add(btnCerr)
        pnArriba.Controls.Add(lblTarea)
        pnArriba.Controls.Add(Button2)
        pnArriba.Controls.Add(btnMinimizar)
        pnArriba.Controls.Add(btnCerrar)
        pnArriba.Dock = DockStyle.Top
        pnArriba.Location = New Point(0, 0)
        pnArriba.Name = "pnArriba"
        pnArriba.Size = New Size(777, 41)
        pnArriba.TabIndex = 7
        ' 
        ' btnMin
        ' 
        btnMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMin.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), Image)
        btnMin.BackgroundImageLayout = ImageLayout.Zoom
        btnMin.FlatAppearance.BorderSize = 0
        btnMin.FlatStyle = FlatStyle.Flat
        btnMin.Location = New Point(708, 6)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(30, 30)
        btnMin.TabIndex = 36
        btnMin.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(1289, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(30, 30)
        Button1.TabIndex = 11
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnCerr
        ' 
        btnCerr.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCerr.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnCerr.BackgroundImage = CType(resources.GetObject("btnCerr.BackgroundImage"), Image)
        btnCerr.BackgroundImageLayout = ImageLayout.Zoom
        btnCerr.FlatAppearance.BorderSize = 0
        btnCerr.FlatStyle = FlatStyle.Flat
        btnCerr.Location = New Point(744, 6)
        btnCerr.Name = "btnCerr"
        btnCerr.Size = New Size(30, 30)
        btnCerr.TabIndex = 37
        btnCerr.UseVisualStyleBackColor = False
        ' 
        ' lblTarea
        ' 
        lblTarea.AutoSize = True
        lblTarea.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTarea.ForeColor = Color.White
        lblTarea.Location = New Point(13, 11)
        lblTarea.Name = "lblTarea"
        lblTarea.Size = New Size(53, 18)
        lblTarea.TabIndex = 6
        lblTarea.Text = "Tablas"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(1325, 6)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 30)
        Button2.TabIndex = 12
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), Image)
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.Location = New Point(1879, 6)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 30)
        btnMinimizar.TabIndex = 6
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
        btnCerrar.Location = New Point(1915, 6)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(30, 30)
        btnCerrar.TabIndex = 6
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' pnAbajo
        ' 
        pnAbajo.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnAbajo.Dock = DockStyle.Bottom
        pnAbajo.Location = New Point(0, 509)
        pnAbajo.Name = "pnAbajo"
        pnAbajo.Size = New Size(777, 20)
        pnAbajo.TabIndex = 35
        ' 
        ' btnConfiguracion
        ' 
        btnConfiguracion.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        btnConfiguracion.BackgroundImageLayout = ImageLayout.Zoom
        btnConfiguracion.Cursor = Cursors.Hand
        btnConfiguracion.FlatAppearance.BorderSize = 0
        btnConfiguracion.FlatStyle = FlatStyle.Flat
        btnConfiguracion.Font = New Font("Arial", 16F)
        btnConfiguracion.ForeColor = Color.White
        btnConfiguracion.Image = CType(resources.GetObject("btnConfiguracion.Image"), Image)
        btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft
        btnConfiguracion.Location = New Point(581, 55)
        btnConfiguracion.Name = "btnConfiguracion"
        btnConfiguracion.Padding = New Padding(6, 0, 0, 0)
        btnConfiguracion.Size = New Size(172, 40)
        btnConfiguracion.TabIndex = 36
        btnConfiguracion.Text = "Config."
        btnConfiguracion.UseVisualStyleBackColor = False
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
        btnProductos.Location = New Point(25, 55)
        btnProductos.Name = "btnProductos"
        btnProductos.Padding = New Padding(6, 0, 0, 0)
        btnProductos.Size = New Size(172, 40)
        btnProductos.TabIndex = 37
        btnProductos.Text = "       Productos"
        btnProductos.UseVisualStyleBackColor = False
        ' 
        ' pnlTablas
        ' 
        pnlTablas.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        pnlTablas.Controls.Add(Button3)
        pnlTablas.Controls.Add(Button4)
        pnlTablas.Controls.Add(Button5)
        pnlTablas.Controls.Add(Button6)
        pnlTablas.Controls.Add(Button7)
        pnlTablas.Controls.Add(Button8)
        pnlTablas.Location = New Point(25, 101)
        pnlTablas.Name = "pnlTablas"
        pnlTablas.Size = New Size(728, 390)
        pnlTablas.TabIndex = 38
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(1236, 6)
        Button3.Name = "Button3"
        Button3.Size = New Size(30, 30)
        Button3.TabIndex = 36
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button4.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(1817, 6)
        Button4.Name = "Button4"
        Button4.Size = New Size(30, 30)
        Button4.TabIndex = 11
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button5.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(1272, 6)
        Button5.Name = "Button5"
        Button5.Size = New Size(30, 30)
        Button5.TabIndex = 37
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button6.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Zoom
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(1853, 6)
        Button6.Name = "Button6"
        Button6.Size = New Size(30, 30)
        Button6.TabIndex = 12
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button7.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Zoom
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(2407, 6)
        Button7.Name = "Button7"
        Button7.Size = New Size(30, 30)
        Button7.TabIndex = 6
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button8.BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), Image)
        Button8.BackgroundImageLayout = ImageLayout.Zoom
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(2443, 6)
        Button8.Name = "Button8"
        Button8.Size = New Size(30, 30)
        Button8.TabIndex = 6
        Button8.UseVisualStyleBackColor = False
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
        btnVentas.Location = New Point(203, 55)
        btnVentas.Name = "btnVentas"
        btnVentas.Padding = New Padding(6, 0, 0, 0)
        btnVentas.Size = New Size(172, 40)
        btnVentas.TabIndex = 39
        btnVentas.Text = "  Ventas"
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' frmTablas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(59), CByte(92))
        ClientSize = New Size(777, 529)
        ControlBox = False
        Controls.Add(btnVentas)
        Controls.Add(pnlTablas)
        Controls.Add(btnProductos)
        Controls.Add(btnConfiguracion)
        Controls.Add(pnAbajo)
        Controls.Add(pnArriba)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTablas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmTablas"
        pnArriba.ResumeLayout(False)
        pnArriba.PerformLayout()
        pnlTablas.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnArriba As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTarea As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents pnAbajo As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnCerr As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents pnlTablas As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnVentas As Button
End Class
