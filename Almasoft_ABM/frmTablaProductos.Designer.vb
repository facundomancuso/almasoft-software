<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablaProductos
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
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lbl1 = New Label()
        Label1 = New Label()
        dgvProductos = New DataGridView()
        dgvProductosRelacionados = New DataGridView()
        Label2 = New Label()
        txtPrecioUnitario = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProductosRelacionados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Arial", 12F)
        lbl1.ForeColor = Color.White
        lbl1.Location = New Point(25, 18)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(72, 18)
        lbl1.TabIndex = 10
        lbl1.Text = "Familias:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(387, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 18)
        Label1.TabIndex = 11
        Label1.Text = "Sub-familias:"
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeColumns = False
        dgvProductos.AllowUserToResizeRows = False
        dgvProductos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProductos.BackgroundColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dgvProductos.BorderStyle = BorderStyle.None
        dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = Color.Gray
        DataGridViewCellStyle19.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle19.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = DataGridViewTriState.True
        dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        dgvProductos.ColumnHeadersHeight = 40
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductos.Cursor = Cursors.Hand
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = SystemColors.Control
        DataGridViewCellStyle20.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle20.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.False
        dgvProductos.DefaultCellStyle = DataGridViewCellStyle20
        dgvProductos.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvProductos.EnableHeadersVisualStyles = False
        dgvProductos.GridColor = SystemColors.ControlDark
        dgvProductos.Location = New Point(25, 50)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = SystemColors.Control
        DataGridViewCellStyle21.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle21.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = DataGridViewTriState.True
        dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        dgvProductos.RowHeadersVisible = False
        dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.ShowCellErrors = False
        dgvProductos.ShowCellToolTips = False
        dgvProductos.ShowEditingIcon = False
        dgvProductos.ShowRowErrors = False
        dgvProductos.Size = New Size(313, 205)
        dgvProductos.TabIndex = 98
        dgvProductos.TabStop = False
        ' 
        ' dgvProductosRelacionados
        ' 
        dgvProductosRelacionados.AllowUserToAddRows = False
        dgvProductosRelacionados.AllowUserToDeleteRows = False
        dgvProductosRelacionados.AllowUserToResizeColumns = False
        dgvProductosRelacionados.AllowUserToResizeRows = False
        dgvProductosRelacionados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProductosRelacionados.BackgroundColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        dgvProductosRelacionados.BorderStyle = BorderStyle.None
        dgvProductosRelacionados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = Color.Gray
        DataGridViewCellStyle22.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle22.ForeColor = Color.WhiteSmoke
        DataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = DataGridViewTriState.True
        dgvProductosRelacionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        dgvProductosRelacionados.ColumnHeadersHeight = 40
        dgvProductosRelacionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProductosRelacionados.Cursor = Cursors.Hand
        DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = SystemColors.Control
        DataGridViewCellStyle23.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle23.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = DataGridViewTriState.False
        dgvProductosRelacionados.DefaultCellStyle = DataGridViewCellStyle23
        dgvProductosRelacionados.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvProductosRelacionados.EnableHeadersVisualStyles = False
        dgvProductosRelacionados.GridColor = SystemColors.ControlDark
        dgvProductosRelacionados.Location = New Point(387, 50)
        dgvProductosRelacionados.MultiSelect = False
        dgvProductosRelacionados.Name = "dgvProductosRelacionados"
        dgvProductosRelacionados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = SystemColors.Control
        DataGridViewCellStyle24.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle24.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True
        dgvProductosRelacionados.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        dgvProductosRelacionados.RowHeadersVisible = False
        dgvProductosRelacionados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvProductosRelacionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductosRelacionados.ShowCellErrors = False
        dgvProductosRelacionados.ShowCellToolTips = False
        dgvProductosRelacionados.ShowEditingIcon = False
        dgvProductosRelacionados.ShowRowErrors = False
        dgvProductosRelacionados.Size = New Size(313, 205)
        dgvProductosRelacionados.TabIndex = 109
        dgvProductosRelacionados.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(25, 269)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 18)
        Label2.TabIndex = 110
        Label2.Text = "Codigo"
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        txtPrecioUnitario.Enabled = False
        txtPrecioUnitario.Font = New Font("Arial", 12F)
        txtPrecioUnitario.Location = New Point(25, 290)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(72, 26)
        txtPrecioUnitario.TabIndex = 111
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Arial", 12F)
        TextBox1.Location = New Point(25, 345)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(313, 26)
        TextBox1.TabIndex = 112
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(25, 324)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 18)
        Label3.TabIndex = 113
        Label3.Text = "Familia"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(387, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 18)
        Label4.TabIndex = 117
        Label4.Text = "Sub familia"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        TextBox2.Enabled = False
        TextBox2.Font = New Font("Arial", 12F)
        TextBox2.Location = New Point(387, 345)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(313, 26)
        TextBox2.TabIndex = 116
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(218), CByte(218), CByte(218))
        TextBox3.Enabled = False
        TextBox3.Font = New Font("Arial", 12F)
        TextBox3.Location = New Point(387, 290)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(72, 26)
        TextBox3.TabIndex = 115
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(387, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 18)
        Label5.TabIndex = 114
        Label5.Text = "Codigo"
        ' 
        ' frmTablaProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(36), CByte(53))
        ClientSize = New Size(728, 390)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(Label2)
        Controls.Add(dgvProductosRelacionados)
        Controls.Add(dgvProductos)
        Controls.Add(Label1)
        Controls.Add(lbl1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmTablaProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmFamilias"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProductosRelacionados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvProductosRelacionados As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
End Class
