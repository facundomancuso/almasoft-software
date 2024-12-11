Imports Microsoft.Data.SqlClient
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.Diagnostics

Public Class frmGrillaProveedores


    ' ESTADO DEL FILTRO EN GRILLA
    Private estadoFiltro As String = ""
    Private Sub frmGrillaProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        'CARGA A TODOS LOS PROVEEDORES ACTIVOS
        estadoFiltro = "PR.Activo = 1"
        txtBuscador.Text = ""
        CargarDatosProveedores(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProveedores = 2
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'TRAE EL FORMULARIO PARA AGREGAR UN NUEVO PROVEEDOR
        frmProveedores.lblTarea.Text = "Nuevo proveedor"
        frmProveedores.Show()
        frmProveedores.chActivo.Checked = True
        frmProveedores.lblAvisoActivo.Visible = False
        frmProveedores.Provincias()
        frmProveedores.CondicionesIva()
    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'TRAE EL FORMULARIO PARA EDITAR UN PROVEEDOR
        'CAMBIA LA TAREA DEL FORMULARIO
        frmProveedores.lblTarea.Text = "Editar proveedor"
        'ACTIVO
        Dim activo As Integer = dgvProveedores.CurrentRow.Cells(14).Value
        Dim activoSecundario As Boolean = dgvProveedores.CurrentRow.Cells(14).Value
        frmProveedores.chActivo.Checked = (activo = 1)
        If activoSecundario = True Then
            frmProveedores.lblAvisoActivo.Text = "El proveedor se encuentra ACTIVO"
        Else
            frmProveedores.lblAvisoActivo.Text = "El proveedor se encuentra INACTIVO"
        End If
        'CARGAR COMBOBOX
        frmProveedores.Provincias()
        frmProveedores.CondicionesIva()
        'LLEVAR DATOS AL FORM Y ABRIRLO
        frmProveedores.lblID.Text = dgvProveedores.CurrentRow.Cells(0).Value
        frmProveedores.txtCodigo.Text = dgvProveedores.CurrentRow.Cells(1).Value
        frmProveedores.txtEmpresa.Text = dgvProveedores.CurrentRow.Cells(2).Value
        frmProveedores.txtFirma.Text = dgvProveedores.CurrentRow.Cells(3).Value
        frmProveedores.txtCuit.Text = dgvProveedores.CurrentRow.Cells(4).Value
        frmProveedores.txtTelefono.Text = dgvProveedores.CurrentRow.Cells(5).Value
        frmProveedores.txtEmail.Text = dgvProveedores.CurrentRow.Cells(6).Value
        frmProveedores.txtDireccion.Text = dgvProveedores.CurrentRow.Cells(7).Value
        frmProveedores.txtLocalidad.Text = dgvProveedores.CurrentRow.Cells(8).Value
        frmProveedores.txtCp.Text = dgvProveedores.CurrentRow.Cells(9).Value
        frmProveedores.cbProvincia.SelectedValue = dgvProveedores.CurrentRow.Cells(10).Value
        frmProveedores.cbCondicionIva.SelectedValue = dgvProveedores.CurrentRow.Cells(12).Value
        frmProveedores.chActivo.Checked = activo

        ' ASIGNA EL ID DEL CLIENTE A LA VARIABLE
        frmProveedores.idProveedorActual = Convert.ToInt32(dgvProveedores.CurrentRow.Cells(0).Value)

        'MUESTRA EL FORMULARIO
        frmProveedores.Show()

    End Sub

    'FUNCIÓN PARA CARGAR A TODOS LOS PROVEEDORES EXISTENTES
    Private Sub CargarDatosProveedores(ByVal filtro As String, ByVal filtroTexto As String)
        Conexion.CargarCadenaConexion()
        'LLENAR GRILLA
        Dim consultaSQL As String = "SELECT 
                                    PR.ID as 'ID',
                                    PR.Codigo as 'CÓDIGO', 
                                    PR.Empresa as 'EMPRESA', 
                                    PR.Firma as 'FIRMA', 
                                    PR.CUIT as 'CUIT', 
                                    PR.Telefono as 'TELÉFONO', 
                                    PR.Email as 'E-MAIL', 
                                    PR.Direccion as 'DIRECCIÓN', 
                                    PR.Localidad as 'LOCALIDAD', 
                                    PR.CodPostal as 'C.P.', 
                                    PR.IDProvincia,
                                    P.Provincia as 'PROVINCIA',
                                    PR.IDCondicionIva,
                                    CI.Condicion as 'IVA',
                                    PR.Activo as 'ACTIVO'
                                    FROM prProveedores PR
                                    INNER JOIN adProvincias P ON PR.IDProvincia = P.ID
                                    INNER JOIN adCondicionesIva CI ON PR.IDCondicionIVA = CI.ID"

        'AGREGAR EL FILTRO DEL BUSCADOR SI SE PROPORCIONA
        If Not String.IsNullOrEmpty(filtroTexto) Then
            consultaSQL &= " WHERE (PR.Empresa LIKE @filtroTexto OR PR.Firma LIKE @filtroTexto OR PR.Codigo LIKE @filtroTexto OR PR.CUIT LIKE @filtroTexto"
            consultaSQL &= " OR (PR.Empresa + ' ' + PR.Firma LIKE @filtroTexto) OR (PR.Firma + ' ' + PR.Empresa LIKE @filtroTexto))"
        End If

        If Not String.IsNullOrEmpty(filtro) Then
            If String.IsNullOrEmpty(filtroTexto) Then
                consultaSQL &= " WHERE " & filtro
            Else
                consultaSQL &= " AND " & filtro
            End If
        End If

        'ADAPTADOR Y DATASET PARA OBTENER LOS DATOS DE LA BASE
        Dim adaptador As New SqlDataAdapter(consultaSQL, Conexion.conexionSql)
        ' AGREGAR EL PARAMETRO filtroTexto Y SU VALOR
        adaptador.SelectCommand.Parameters.AddWithValue("@filtroTexto", "%" & filtroTexto & "%")
        Dim dsProveedores As New DataSet()
        adaptador.Fill(dsProveedores, "prProveedores")

        'ASIGNAR EL DATATABLE AL DATAGRIDVIEW
        dgvProveedores.DataSource = dsProveedores.Tables("prProveedores")

        ' HACER NO VISIBLE LAS COLUMNAS = 0 (ID), 10 (ID PROVINCIA), 12 (ID CONDICION IVA), 14 (ACTIVO)
        dgvProveedores.Columns(0).Visible = False
        dgvProveedores.Columns(10).Visible = False
        dgvProveedores.Columns(12).Visible = False
        dgvProveedores.Columns(14).Visible = False

        If filtroActivoProveedores Then
            'SI EL FILTRO ESTA ACTIVO
            aplicarFiltrosDgvProveedores()
            filtroActivoProveedores = True
        Else
            'SI EL FILTRO ESTA DESACTIVADO
            filtroActivoProveedores = False
        End If
        '
        '
        '
    End Sub


    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = ""
        CargarDatosProveedores(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProveedores = 1
    End Sub

    Private Sub btnActivos_Click(sender As Object, e As EventArgs) Handles btnActivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = "PR.Activo = 1"
        CargarDatosProveedores(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProveedores = 2
    End Sub

    Private Sub btnInactivos_Click(sender As Object, e As EventArgs) Handles btnInactivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnInactivos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = "PR.Activo = 0"
        CargarDatosProveedores(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProveedores = 3
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'RECARGAMOS LA GRILLA
        'frmMenu.abrirFrm(Of frmGrillaProveedores)()
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = ""
        txtBuscador.Text = ""
        CargarDatosProveedores(estadoFiltro, txtBuscador.Text)
    End Sub

    'FRONT
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        If filtroActivoProveedores Then
            ' Si el filtro está activo, desactivarlo
            quitarFiltrosDgvProveedores()
            filtroActivoProveedores = False
        Else
            ' Si el filtro está desactivado, activarlo
            aplicarFiltrosDgvProveedores()
            filtroActivoProveedores = True
        End If
    End Sub


    'FRONT
    Private Sub aplicarFiltrosDgvProveedores()
        'ME CAMBIA EL COLOR DEPENDIENDO DE LOS ESTADOS DE LOS CLIENTES
        For Each row As DataGridViewRow In dgvProveedores.Rows
            Dim activo As Boolean = Convert.ToBoolean(row.Cells("ACTIVO").Value)
            If activo = True Then
                row.DefaultCellStyle.BackColor = Color.FromArgb(148, 255, 136) ' Verde claro
            Else
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Next
    End Sub

    'FRONT
    Private Sub quitarFiltrosDgvProveedores()
        'QUITA LOS COLORES DE LOS FILTROS DE LA GRILLA
        For Each row As DataGridViewRow In dgvProveedores.Rows
            row.DefaultCellStyle.BackColor = SystemColors.Control
        Next
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        'TRAE EL FORMULARIO PARA VER UN PROVEEDOR
        'CAMBIA LA TAREA DEL FORMULARIO
        frmProveedores.lblTarea.Text = "Ver proveedor"
        'ACTIVO
        Dim activo As Integer = dgvProveedores.CurrentRow.Cells(14).Value
        Dim activoSecundario As Boolean = dgvProveedores.CurrentRow.Cells(14).Value
        frmProveedores.chActivo.Checked = (activo = 1)
        If activoSecundario = True Then
            frmProveedores.lblAvisoActivo.Text = "El proveedor se encuentra ACTIVO"
        Else
            frmProveedores.lblAvisoActivo.Text = "El proveedor se encuentra INACTIVO"
        End If
        'CARGAR COMBOBOX
        frmProveedores.Provincias()
        frmProveedores.CondicionesIva()
        'LLEVAR DATOS AL FORM Y ABRIRLO
        frmProveedores.lblID.Text = dgvProveedores.CurrentRow.Cells(0).Value
        frmProveedores.txtCodigo.Text = dgvProveedores.CurrentRow.Cells(1).Value
        frmProveedores.txtEmpresa.Text = dgvProveedores.CurrentRow.Cells(2).Value
        frmProveedores.txtFirma.Text = dgvProveedores.CurrentRow.Cells(3).Value
        frmProveedores.txtCuit.Text = dgvProveedores.CurrentRow.Cells(4).Value
        frmProveedores.txtTelefono.Text = dgvProveedores.CurrentRow.Cells(5).Value
        frmProveedores.txtEmail.Text = dgvProveedores.CurrentRow.Cells(6).Value
        frmProveedores.txtDireccion.Text = dgvProveedores.CurrentRow.Cells(7).Value
        frmProveedores.txtLocalidad.Text = dgvProveedores.CurrentRow.Cells(8).Value
        frmProveedores.txtCp.Text = dgvProveedores.CurrentRow.Cells(9).Value
        frmProveedores.cbProvincia.SelectedValue = dgvProveedores.CurrentRow.Cells(10).Value
        frmProveedores.cbCondicionIva.SelectedValue = dgvProveedores.CurrentRow.Cells(12).Value
        frmProveedores.chActivo.Checked = activo
        'MUESTRA EL FORMULARIO
        frmProveedores.Show()
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'VERIFICAR QUE LA GRILLA NO ESTE VACIA
        If dgvProveedores.SelectedRows.Count > 0 Then
            'SE OBTIENE EL ID DEL PROVEEDOR
            Dim proveedorID As Integer = dgvProveedores.CurrentRow.Cells("ID").Value

            'VERIFICAR SI EL PROVEEDOR TIENE RELACIONES EN prCompras
            Conexion.CargarCadenaConexion()
            Dim consultaRelacionCompras As String = "SELECT COUNT(*) FROM prCompras WHERE IDProveedor = @IDProveedor"
            Dim tieneCompras As Boolean

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using comandoVerificacionCompras As New SqlCommand(consultaRelacionCompras, conexion)
                    comandoVerificacionCompras.Parameters.AddWithValue("@IDProveedor", proveedorID)

                    conexion.Open()
                    Dim countCompras As Integer = Convert.ToInt32(comandoVerificacionCompras.ExecuteScalar())
                    tieneCompras = (countCompras > 0)
                End Using
            End Using

            'VERIFICAR SI EL PROVEEDOR TIENE RELACIONES EN stProductosProveedor
            Dim consultaRelacionProductos As String = "SELECT COUNT(*) FROM stProductosProveedor WHERE IDProveedor = @IDProveedor"
            Dim tieneProductos As Boolean

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using comandoVerificacionProductos As New SqlCommand(consultaRelacionProductos, conexion)
                    comandoVerificacionProductos.Parameters.AddWithValue("@IDProveedor", proveedorID)

                    conexion.Open()
                    Dim countProductos As Integer = Convert.ToInt32(comandoVerificacionProductos.ExecuteScalar())
                    tieneProductos = (countProductos > 0)
                End Using
            End Using

            'SI TIENE RELACIONES EN AMBAS TABLAS, MOSTRAR MENSAJE Y CANCELAR ELIMINACIÓN
            If tieneCompras OrElse tieneProductos Then
                MessageBox.Show("No se puede eliminar el proveedor porque tiene compras o productos asociados.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'CONFIRMAR DELETE, POR SEGURIDAD
            Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim consultaSQL As String = "DELETE FROM prProveedores WHERE ID = @ID"

                Using conexion As New SqlConnection(conexionSql.ConnectionString)
                    Using comando As New SqlCommand(consultaSQL, conexion)
                        comando.Parameters.AddWithValue("@ID", proveedorID)

                        conexion.Open()
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                'LIMPIO LOS BOTONES DEL FORMULARIO
                limpiarBotones()
                'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
                btnActivos.BackColor = Color.FromArgb(49, 130, 255)
                'RECARGAR LA GRILLA
                estadoFiltro = "PR.Activo = 1"
                txtBuscador.Text = ""
                CargarDatosProveedores(estadoFiltro, txtBuscador.Text)
                MessageBox.Show("Proveedor eliminado exitosamente.", "Eliminación completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un proveedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'FUNCIÓN PARA LIMPIAR LOS BOTONES DEL GRILLA PROVEEDORES (FRONT)
    Public Sub limpiarBotones()
        'BOTONES DEl GRILLA PROVEEDORES
        btnTodos.BackColor = Color.FromArgb(0, 59, 92)
        btnActivos.BackColor = Color.FromArgb(0, 59, 92)
        btnInactivos.BackColor = Color.FromArgb(0, 59, 92)
    End Sub

    'METODO PARA GENERAR PDF DE CLIENTES
    Public Sub GenerarPDFProveedores()
        ' FORMATO FECHA Y HORA PARA GUARDAR EL PDF
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ' DONDE LO VA A GUARDAR
        Dim pdfPath As String = $"C:\Almasoft\captures\proveedores_{timestamp}.pdf"
        Using writer As New PdfWriter(pdfPath)
            Using pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)
                Dim title As New Paragraph
                'TITULO DEL PDF
                If pdfProveedores = 1 Then
                    title = New Paragraph("Datos de Proveedores")
                ElseIf pdfProveedores = 2 Then
                    title = New Paragraph("Datos de Proveedores Activos")
                ElseIf pdfProveedores = 3 Then
                    title = New Paragraph("Datos de Proveedores Inactivos")
                End If
                title.SetFontSize(12)
                title.SetBold()
                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                document.Add(title)
                'CREAR LA TABLA
                Dim table As New Table(dgvProveedores.Columns.Count - 8) ' Reducimos el número de columnas
                'AGREGA LOS ENCABEZADOS (omitir columnas 0, 6, 8, 9, 10, 11, 12, 14)
                For i As Integer = 0 To dgvProveedores.Columns.Count - 1
                    If i <> 0 AndAlso i <> 6 AndAlso i <> 8 AndAlso i <> 9 AndAlso i <> 10 AndAlso i <> 11 AndAlso i <> 12 AndAlso i <> 14 Then
                        Dim headerCell As Cell = New Cell().Add(New Paragraph(dgvProveedores.Columns(i).HeaderText)).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                        table.AddHeaderCell(headerCell)
                    End If
                Next
                'AGREGA LAS FILAS (omitir columnas 0, 6, 8, 9, 10, 11, 12, 14)
                For Each row As DataGridViewRow In dgvProveedores.Rows
                    If Not row.IsNewRow Then
                        For i As Integer = 0 To dgvProveedores.Columns.Count - 1
                            If i <> 0 AndAlso i <> 6 AndAlso i <> 8 AndAlso i <> 9 AndAlso i <> 10 AndAlso i <> 11 AndAlso i <> 12 AndAlso i <> 14 Then
                                Dim cellValue As String = If(row.Cells(i).Value IsNot Nothing, row.Cells(i).Value.ToString(), "")
                                Dim cellParagraph As New Paragraph(cellValue)
                                cellParagraph.SetFontSize(10) 'Fuente más pequeña
                                Dim cell As New Cell()
                                cell.Add(cellParagraph) 'Separar en dos líneas
                                'AJUSTAR ANCHO DE DIRECCION
                                If i = 7 Or i = 4 Then
                                    'LA HACEMOS UN POCO MAS ANCHA PARA QUE ENTRE BIEN LA DIRECCIÓN
                                    cell.SetWidth(80)
                                End If

                                table.AddCell(cell)
                            End If
                        Next
                    End If
                Next
                'ESTABLECER ANCHO DE TABLA
                table.SetWidth(UnitValue.CreatePercentValue(100))
                'AGREGAR TABLA AL DOCUMENTO
                document.Add(table)
            End Using
        End Using
        MessageBox.Show("PDF generado correctamente en: " & pdfPath)
        'ABRE EL PDF AUTOMÁTICAMENTE
        Try
            Process.Start(New ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        'OBTENEMOS EL TEXTO INGRESADO POR EL USUARIO
        Dim filtroTexto As String = txtBuscador.Text.Trim()
        'LE PASAMOS EL FILTRO A LA FUNCIÓN
        CargarDatosProveedores(estadoFiltro, filtroTexto)
    End Sub

    Private Sub btnRelaciones_Click(sender As Object, e As EventArgs) Handles btnRelaciones.Click
        frmProductosProveedores.Show()
        frmProductosProveedores.CargarCBProveedores()
    End Sub

    Private Sub btnGenerarPdf_Click(sender As Object, e As EventArgs) Handles btnGenerarPdf.Click
        'GENERO PDF
        GenerarPDFProveedores()
    End Sub

    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnLimpiarImagen.Click
        'LIMPIO EL BUSCADOR
        txtBuscador.Clear()
    End Sub
End Class