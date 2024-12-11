Imports Microsoft.Data.SqlClient
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.Diagnostics


Public Class frmGrillaClientes

    ' ESTADO DEL FILTRO EN GRILLA
    Private estadoFiltro As String = ""

    Private Sub frmGrillaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        'CARGA A TODOS LOS CLIENTES ACTIVOS
        'CargarDatosClientes("WHERE C.Activo = 1")
        estadoFiltro = "C.Activo = 1"
        txtBuscador.Text = ""
        CargarDatosClientes(estadoFiltro, txtBuscador.Text)
        'SI LO LLAMA VENTAS MUESTRA EL BOTON IMPORTAR, SINO LO DESHABILITA
        'DESHABILITO LOS DEMÁS BOTONES
        If lblTarea.Text = "Venta" Then
            btnImportar.Enabled = True
            btnTodos.Enabled = False
            btnInactivos.Enabled = False
            btnNuevo.Enabled = False
            btnEditar.Enabled = False
            btnEliminar.Enabled = False
            btnVer.Enabled = False
            btnActualizar.Enabled = False
            btnGenerarPdf.Enabled = False
            btnFiltro.Enabled = False
        Else
            'DESHABILITO EL BTN IMPORTAR
            btnImportar.Enabled = False
        End If
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfClientes = 2
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'TRAE EL FORMULARIO PARA AGREGAR UN NUEVO CLIENTE
        frmClientes.lblTarea.Text = "Nuevo cliente"
        frmClientes.Show()
        frmClientes.chActivo.Checked = True
        frmClientes.lblAvisoActivo.Visible = False
        frmClientes.Provincias()
        frmClientes.CondicionesIva()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'TRAE EL FORMULARIO PARA EDITAR UN CLIENTE
        'CAMBIA LA TAREA DEL FORMULARIO
        frmClientes.lblTarea.Text = "Editar cliente"
        'ACTIVO
        Dim activo As Integer = dgvClientes.CurrentRow.Cells(15).Value
        Dim activoSecundario As Boolean = dgvClientes.CurrentRow.Cells(15).Value
        frmClientes.chActivo.Checked = (activo = 1)
        If activoSecundario = True Then
            frmClientes.lblAvisoActivo.Text = "El cliente se encuentra ACTIVO"
        Else
            frmClientes.lblAvisoActivo.Text = "El cliente se encuentra INACTIVO"
        End If
        'CARGAR COMBOBOX
        frmClientes.Provincias()
        frmClientes.CondicionesIva()
        'LLEVAR DATOS AL FORM Y ABRIRLO
        frmClientes.lblID.Text = dgvClientes.CurrentRow.Cells(0).Value
        frmClientes.txtCodigo.Text = dgvClientes.CurrentRow.Cells(1).Value
        frmClientes.txtNombre.Text = dgvClientes.CurrentRow.Cells(2).Value
        frmClientes.txtApellido.Text = dgvClientes.CurrentRow.Cells(3).Value
        frmClientes.txtDni.Text = dgvClientes.CurrentRow.Cells(4).Value
        frmClientes.txtTelefono.Text = dgvClientes.CurrentRow.Cells(5).Value
        frmClientes.txtEmail.Text = dgvClientes.CurrentRow.Cells(6).Value
        frmClientes.txtDireccion.Text = dgvClientes.CurrentRow.Cells(7).Value
        frmClientes.txtLocalidad.Text = dgvClientes.CurrentRow.Cells(8).Value
        frmClientes.txtCp.Text = dgvClientes.CurrentRow.Cells(9).Value
        frmClientes.cbProvincia.SelectedValue = dgvClientes.CurrentRow.Cells(10).Value
        frmClientes.cbCondicionIva.SelectedValue = dgvClientes.CurrentRow.Cells(12).Value
        frmClientes.dtFechaDeNacimiento.Text = dgvClientes.CurrentRow.Cells(14).Value
        frmClientes.chActivo.Checked = activo

        ' ASIGNA EL ID DEL CLIENTE A LA VARIABLE
        frmClientes.idClienteActual = Convert.ToInt32(dgvClientes.CurrentRow.Cells(0).Value)

        'MUESTRA EL FORMULARIO
        frmClientes.Show()

    End Sub

    'FUNCIÓN PARA CARGAR A TODOS LOS CLIENTES EXISTENTES
    Public Sub CargarDatosClientes(ByVal filtro As String, ByVal filtroTexto As String)
        Conexion.CargarCadenaConexion()
        'LLENAR GRILLA
        Dim consultaSQL As String = "SELECT 
                                    C.ID as 'ID',
                                    C.Codigo as 'CÓDIGO', 
                                    C.Nombre as 'NOMBRE', 
                                    C.Apellido as 'APELLIDO',
                                    C.DNI as 'DNI',
                                    C.Telefono as 'TELÉFONO',
                                    C.Email as 'E-MAIL',
                                    C.Direccion as 'DIRECCIÓN',
                                    C.Localidad as 'LOCALIDAD',
                                    C.CodPostal as 'C.P.',
                                    C.IDProvincia,
                                    P.Provincia as 'PROVINCIA',
                                    C.IDCondicionIva,
                                    CI.Condicion as 'IVA',
                                    C.FechaNacimiento as 'FECHA DE NACIM.',
                                    C.Activo as 'ACTIVO'
                                    FROM vtClientes C
                                    INNER JOIN adProvincias P ON C.IDProvincia = P.ID
                                    INNER JOIN adCondicionesIva CI ON C.IDCondicionIVA = CI.ID"

        'AGREGAR EL FILTRO DEL BUSCADOR SI SE PROPORCIONA
        If Not String.IsNullOrEmpty(filtroTexto) Then
            'consultaSQL &= " WHERE (C.Nombre LIKE @filtroTexto OR C.Apellido LIKE @filtroTexto OR C.Codigo LIKE @filtroTexto)"
            consultaSQL &= " WHERE (C.Nombre LIKE @filtroTexto OR C.Apellido LIKE @filtroTexto OR C.Codigo LIKE @filtroTexto OR C.DNI LIKE @filtroTexto"
            consultaSQL &= " OR (C.Nombre + ' ' + C.Apellido LIKE @filtroTexto) OR (C.Apellido + ' ' + C.Nombre LIKE @filtroTexto))"
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
        Dim dsClientes As New DataSet()
        adaptador.Fill(dsClientes, "vtClientes")

        'ASIGNAR EL DATATABLE AL DATAGRIDVIEW
        dgvClientes.DataSource = dsClientes.Tables("vtClientes")

        ' HACER NO VISIBLE LAS COLUMNAS = 0 (ID), 10 (ID PROVINCIA), 12 (ID CONDICION IVA), 15 (ACTIVO)
        dgvClientes.Columns(0).Visible = False
        dgvClientes.Columns(10).Visible = False
        dgvClientes.Columns(12).Visible = False
        dgvClientes.Columns(15).Visible = False

        If filtroActivoClientes Then
            'SI EL FILTRO ESTA ACTIVO
            aplicarFiltrosDgvClientes()
            filtroActivoClientes = True
        Else
            'SI EL FILTRO ESTA DESACTIVADO
            filtroActivoClientes = False
        End If
    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        'CargarDatosClientes("")
        estadoFiltro = ""
        CargarDatosClientes(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DEL PDF
        pdfClientes = 1
    End Sub

    Private Sub btnActivos_Click(sender As Object, e As EventArgs) Handles btnActivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        'CargarDatosClientes("WHERE C.Activo = 1")
        estadoFiltro = "C.Activo = 1"
        CargarDatosClientes(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DEL PDF
        pdfClientes = 2
    End Sub

    Private Sub btnInactivos_Click(sender As Object, e As EventArgs) Handles btnInactivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnInactivos.BackColor = Color.FromArgb(49, 130, 255)
        'CargarDatosClientes("WHERE C.Activo = 0")
        estadoFiltro = "C.Activo = 0"
        CargarDatosClientes(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DEL PDF
        pdfClientes = 3
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'RECARGAMOS LA GRILLA
        'frmMenu.abrirFrm(Of frmGrillaClientes)()
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        'CargarDatosClientes("")
        estadoFiltro = ""
        txtBuscador.Text = ""
        CargarDatosClientes(estadoFiltro, txtBuscador.Text)
    End Sub

    'FRONT
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        If filtroActivoClientes Then
            ' Si el filtro está activo, desactivarlo
            quitarFiltrosDgvClientes()
            filtroActivoClientes = False
        Else
            ' Si el filtro está desactivado, activarlo
            aplicarFiltrosDgvClientes()
            filtroActivoClientes = True
        End If
        '' Recargar datos después de aplicar o quitar filtros
        'CargarDatosClientes(If(filtroActivoClientes, "WHERE C.Activo = 1", ""))
    End Sub

    'FRONT
    Private Sub aplicarFiltrosDgvClientes()
        'ME CAMBIA EL COLOR DEPENDIENDO DE LOS ESTADOS DE LOS CLIENTES
        For Each row As DataGridViewRow In dgvClientes.Rows
            Dim activo As Boolean = Convert.ToBoolean(row.Cells("ACTIVO").Value)
            If activo = True Then
                row.DefaultCellStyle.BackColor = Color.FromArgb(148, 255, 136) ' Verde claro
            Else
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Next
    End Sub

    'FRONT
    Private Sub quitarFiltrosDgvClientes()
        'QUITA LOS COLORES DE LOS FILTROS DE LA GRILLA
        For Each row As DataGridViewRow In dgvClientes.Rows
            row.DefaultCellStyle.BackColor = SystemColors.Control
        Next
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        'TRAE EL FORMULARIO PARA VER UN CLIENTE
        'CAMBIA LA TAREA DEL FORMULARIO
        frmClientes.lblTarea.Text = "Ver cliente"
        'ACTIVO
        Dim activo As Integer = dgvClientes.CurrentRow.Cells(15).Value
        Dim activoSecundario As Boolean = dgvClientes.CurrentRow.Cells(15).Value
        frmClientes.chActivo.Checked = (activo = 1)
        If activoSecundario = True Then
            frmClientes.lblAvisoActivo.Text = "El cliente se encuentra ACTIVO"
        Else
            frmClientes.lblAvisoActivo.Text = "El cliente se encuentra INACTIVO"
        End If
        'CARGAR COMBOBOX
        frmClientes.Provincias()
        frmClientes.CondicionesIva()
        'LLEVAR DATOS AL FORM Y ABRIRLO
        frmClientes.lblID.Text = dgvClientes.CurrentRow.Cells(0).Value
        frmClientes.txtCodigo.Text = dgvClientes.CurrentRow.Cells(1).Value
        frmClientes.txtNombre.Text = dgvClientes.CurrentRow.Cells(2).Value
        frmClientes.txtApellido.Text = dgvClientes.CurrentRow.Cells(3).Value
        frmClientes.txtDni.Text = dgvClientes.CurrentRow.Cells(4).Value
        frmClientes.txtTelefono.Text = dgvClientes.CurrentRow.Cells(5).Value
        frmClientes.txtEmail.Text = dgvClientes.CurrentRow.Cells(6).Value
        frmClientes.txtDireccion.Text = dgvClientes.CurrentRow.Cells(7).Value
        frmClientes.txtLocalidad.Text = dgvClientes.CurrentRow.Cells(8).Value
        frmClientes.txtCp.Text = dgvClientes.CurrentRow.Cells(9).Value
        frmClientes.cbProvincia.SelectedValue = dgvClientes.CurrentRow.Cells(10).Value
        frmClientes.cbCondicionIva.SelectedValue = dgvClientes.CurrentRow.Cells(12).Value
        frmClientes.dtFechaDeNacimiento.Text = dgvClientes.CurrentRow.Cells(14).Value
        frmClientes.chActivo.Checked = activo
        'MUESTRA EL FORMULARIO
        frmClientes.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'VERIFICAR QUE LA GRILLA NO ESTE VACIA
        If dgvClientes.SelectedRows.Count > 0 Then
            'SE OBTIENE EL ID DEL CLIENTE
            Dim clienteID As Integer = dgvClientes.CurrentRow.Cells("ID").Value

            'VERIFICAR SI EL CLIENTE TIENE FACTURAS RELACIONADAS
            Conexion.CargarCadenaConexion()
            Dim consultaRelacion As String = "SELECT COUNT(*) FROM vtFacturas WHERE IDCliente = @IDCliente"
            Dim tieneFacturas As Boolean

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using comandoVerificacion As New SqlCommand(consultaRelacion, conexion)
                    comandoVerificacion.Parameters.AddWithValue("@IDCliente", clienteID)

                    conexion.Open()
                    Dim count As Integer = Convert.ToInt32(comandoVerificacion.ExecuteScalar())
                    tieneFacturas = (count > 0)
                End Using
            End Using

            'SI TIENE FACTURAS RELACIONADAS, MOSTRAR MENSAJE Y CANCELAR ELIMINACIÓN
            If tieneFacturas Then
                MessageBox.Show("No se puede eliminar el cliente porque tiene facturas asociadas.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'CONFIRMAR DELETE, POR SEGURIDAD
            Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim consultaSQL As String = "DELETE FROM vtClientes WHERE ID = @ID"

                Using conexion As New SqlConnection(conexionSql.ConnectionString)
                    Using comando As New SqlCommand(consultaSQL, conexion)
                        comando.Parameters.AddWithValue("@ID", clienteID)

                        conexion.Open()
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                'LIMPIO LOS BOTONES DEL FORMULARIO
                limpiarBotones()
                'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
                btnActivos.BackColor = Color.FromArgb(49, 130, 255)
                'RECARGAR LA GRILLA
                estadoFiltro = "C.Activo = 1"
                txtBuscador.Text = ""
                CargarDatosClientes(estadoFiltro, txtBuscador.Text)
                MessageBox.Show("Cliente eliminado exitosamente.", "Eliminación completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    'FUNCIÓN PARA LIMPIAR LOS BOTONES DEL GRILLA CLIENTES (FRONT)
    Public Sub limpiarBotones()
        'BOTONES DEl GRILLA CLIENTES
        btnTodos.BackColor = Color.FromArgb(0, 59, 92)
        btnActivos.BackColor = Color.FromArgb(0, 59, 92)
        btnInactivos.BackColor = Color.FromArgb(0, 59, 92)
    End Sub

    'LLEVA LOS DATOS DEL CLIENTE AL FORMULARIO VENTA
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        'VERITIFA SI HAY UNA FILA SELECCIONADA
        If dgvClientes.CurrentRow IsNot Nothing Then
            'CARGAR COMBOBOX
            frmVentas.CondicionesIva()
            'LLEVAR DATOS AL FORM Y ABRIRLO
            frmVentas.lblIdCliente.Text = dgvClientes.CurrentRow.Cells(0).Value
            frmVentas.txtCodigo.Text = dgvClientes.CurrentRow.Cells(1).Value
            frmVentas.txtNombreApellido.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString & " " & dgvClientes.CurrentRow.Cells(3).Value.ToString
            frmVentas.txtDni.Text = dgvClientes.CurrentRow.Cells(4).Value
            frmVentas.cbCondicionIva.SelectedValue = dgvClientes.CurrentRow.Cells(12).Value
            'CIERRO LA GRILLA CLIENTES
            Close()
            'CAMBIO LA TAREA
            lblTarea.Text = "Nada"
        Else
            MessageBox.Show("Seleccione un cliente para importar.")
        End If
    End Sub

    'METODO PARA GENERAR PDF DE CLIENTES
    Public Sub GenerarPDFClientes()
        ' FORMATO FECHA Y HORA PARA GUARDAR EL PDF
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ' DONDE LO VA A GUARDAR
        Dim pdfPath As String = $"C:\Almasoft\captures\clientes_{timestamp}.pdf"

        Using writer As New PdfWriter(pdfPath)
            Using pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)
                Dim title As New Paragraph
                'TITULO DEL PDF
                If pdfClientes = 1 Then
                    title = New Paragraph("DATOS DE CLIENTES")
                ElseIf pdfClientes = 2 Then
                    title = New Paragraph("DATOS DE CLIENTES ACTIVOS")
                ElseIf pdfClientes = 3 Then
                    title = New Paragraph("DATOS DE CLIENTES INACTIVOS")
                End If
                title.SetFontSize(12)
                title.SetBold()
                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                document.Add(title)

                'CREAR LA TABLA
                Dim table As New Table(dgvClientes.Columns.Count - 8) ' REDUCIMOS EL NUMERO DE COLUMNAS

                'AGREGA LOS ENCABEZADOS (omitir columnas 0, 6, 8, 9, 10, 11, 12, 15)
                For i As Integer = 0 To dgvClientes.Columns.Count - 1
                    If i <> 0 AndAlso i <> 6 AndAlso i <> 8 AndAlso i <> 9 AndAlso i <> 10 AndAlso i <> 11 AndAlso i <> 12 AndAlso i <> 15 Then
                        Dim headerCell As Cell = New Cell().Add(New Paragraph(dgvClientes.Columns(i).HeaderText)).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                        table.AddHeaderCell(headerCell)
                    End If
                Next

                'AGREGA LAS FILAS  (omitir columnas 0, 6, 8, 9, 10, 11, 12, 15)
                For Each row As DataGridViewRow In dgvClientes.Rows
                    If Not row.IsNewRow Then
                        For i As Integer = 0 To dgvClientes.Columns.Count - 1
                            If i <> 0 AndAlso i <> 6 AndAlso i <> 8 AndAlso i <> 9 AndAlso i <> 10 AndAlso i <> 11 AndAlso i <> 12 AndAlso i <> 15 Then
                                Dim cellValue As String = If(row.Cells(i).Value IsNot Nothing, row.Cells(i).Value.ToString(), "")
                                Dim cellParagraph As New Paragraph(cellValue)
                                cellParagraph.SetFontSize(10) ' FUENTE
                                Dim cell As New Cell()
                                cell.Add(cellParagraph) 'SEPARAR EN DOS LINEAS
                                'AJUSTAR ANCHO DE DIRECCION
                                If i = 7 Then
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
        CargarDatosClientes(estadoFiltro, filtroTexto)
    End Sub

    Private Sub btnGenerarPdf_Click(sender As Object, e As EventArgs) Handles btnGenerarPdf.Click
        'GENERO PDF
        GenerarPDFClientes()
    End Sub

    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnLimpiarImagen.Click
        'LIMPIO EL BUSCADOR
        txtBuscador.Clear()
    End Sub
End Class


