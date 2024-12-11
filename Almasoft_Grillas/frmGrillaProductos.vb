Imports Microsoft.Data.SqlClient
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.Diagnostics
Imports System.Globalization
Imports System.Threading

Public Class frmGrillaProductos

    ' ESTADO DEL FILTRO EN GRILLA
    Private estadoFiltro As String = ""

    Private Sub frmGrillaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTABLECE SEPARADORES DECIMALES POR PUNTO Y NO POR COMA
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        'CARGA A TODOS LOS CLIENTES ACTIVOS
        estadoFiltro = "P.Activo = 1"
        txtBuscador.Text = ""
        CargarDatosProductos(estadoFiltro, txtBuscador.Text)
        'SI LO LLAMA VENTAS MUESTRA EL BOTON IMPORTAR, SINO LO OCULTA
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
            btnConsultarPrecio.Enabled = False
        Else
            btnImportar.Enabled = False
        End If
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProductos = 2
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        Me.Close()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'TRAE EL FORMULARIO PARA AGREGAR UN NUEVO PRODUCTO
        frmProductos.lblTarea.Text = "Nuevo producto"
        frmProductos.Show()
        frmProductos.rbSiActivo.Checked = True
        frmProductos.rbNo.Checked = True
        frmProductos.lblAvisoActivo.Visible = False
        frmProductos.Familias()
        frmProductos.SubFamilias(dgvProductos.CurrentRow.Cells(4).Value)
    End Sub



    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' TRAE EL FORMULARIO PARA EDITAR UN PRODUCTO
        ' CAMBIA LA TAREA DEL FORMULARIO
        frmProductos.lblTarea.Text = "Editar producto"

        ' CARGAR COMBOBOX
        frmProductos.Familias()
        frmProductos.SubFamilias(dgvProductos.CurrentRow.Cells(4).Value)

        ' LLEVAR DATOS AL FORM Y ABRIRLO
        frmProductos.lblID.Text = dgvProductos.CurrentRow.Cells(0).Value
        frmProductos.txtCodigo.Text = dgvProductos.CurrentRow.Cells(1).Value
        frmProductos.txtCodigoBarra.Text = dgvProductos.CurrentRow.Cells(2).Value
        frmProductos.txtDescripcion.Text = dgvProductos.CurrentRow.Cells(3).Value
        frmProductos.cbFamilia.SelectedValue = dgvProductos.CurrentRow.Cells(4).Value
        frmProductos.cbSubFamilia.SelectedValue = dgvProductos.CurrentRow.Cells(6).Value

        ' OBTENER EL VALOR DE STOCK Y FORMATEARLO SEGÚN VENTA POR PESO
        Dim ventaPorPeso As Boolean = Convert.ToBoolean(dgvProductos.CurrentRow.Cells(13).Value)
        If Not ventaPorPeso Then
            ' SI NO SE VENDE POR PESO, EL STOCK DEBE SER UN VALOR ENTERO
            frmProductos.txtStock.Text = Math.Floor(Convert.ToDecimal(dgvProductos.CurrentRow.Cells(8).Value)).ToString()
        Else
            ' SI SE VENDE POR PESO, MOSTRAMOS TAL CUAL SIN REEMPLAZAR
            frmProductos.txtStock.Text = dgvProductos.CurrentRow.Cells(8).Value.ToString()
        End If

        ' PRECIO UNITARIO: NO ES NECESARIO REEMPLAZAR COMA POR PUNTO
        frmProductos.txtPrecioUnitario.Text = dgvProductos.CurrentRow.Cells(9).Value.ToString()

        ' PORCENTAJE IVA: NO ES NECESARIO REEMPLAZAR COMA POR PUNTO
        frmProductos.txtPorcentajeIVA.Text = dgvProductos.CurrentRow.Cells(12).Value.ToString()

        ' ESTÁ ACTIVO?
        If dgvProductos.CurrentRow.Cells(10).Value = True Then
            ' ACTIVO
            frmProductos.rbSiActivo.Checked = True
        ElseIf dgvProductos.CurrentRow.Cells(10).Value = False Then
            ' INACTIVO   
            frmProductos.rbNoActivo.Checked = True
        End If

        ' SE VENDE POR PESO?
        If dgvProductos.CurrentRow.Cells(13).Value = True Then
            ' SE VENDE POR PESO
            frmProductos.rbSi.Checked = True
        ElseIf dgvProductos.CurrentRow.Cells(13).Value = False Then
            ' NO SE VENDE POR PESO
            frmProductos.rbNo.Checked = True
        End If

        ' CARGAR LA IMAGEN DEL PRODUCTO DESDE LA BASE DE DATOS
        If dgvProductos.CurrentRow IsNot Nothing Then
            CargarImagenProducto(Convert.ToInt32(dgvProductos.CurrentRow.Cells(0).Value))
        End If

        ' ASIGNA EL ID DEL PRODUCTO A LA VARIABLE
        frmProductos.idProductoActual = Convert.ToInt32(dgvProductos.CurrentRow.Cells(0).Value)

        ' MUESTRA EL FORMULARIO
        frmProductos.Show()
    End Sub



    ' CARGAR DATOS DE PRODUCTOS EN EL DATAGRIDVIEW
    Private Sub CargarDatosProductos(ByVal filtro As String, ByVal filtroTexto As String)
        Conexion.CargarCadenaConexion()

        ' CONSULTA SQL PARA OBTENER LOS PRODUCTOS
        Dim consultaSQL As String = "SELECT 
                             P.ID as 'ID',
                             P.Codigo as 'CÓDIGO', 
                             P.CodigoBarra as 'CÓDIGO BARRA', 
                             P.Descripcion as 'DESCRIPCIÓN', 
                             P.IDFamilia,
                             F.Familia as 'FAMILIA/RUBRO', 
                             P.IDSubFamilia,
                             SF.Subfamilia as 'SUBFAMILIA/SUBRUBRO', 
                             P.Stock as 'STOCK', 
                             P.PrecioUnitario as 'PRECIO UNIT.',
                             P.Activo as 'ACTIVO',
                             P.Imagen as 'IMAGEN',
                             P.PorcentajeIVA as '% IVA',
                             P.VentaPorPeso
                             FROM stProductos P
                             INNER JOIN stFamilias F ON P.IDFamilia = F.ID
                             INNER JOIN stSubfamilias SF ON P.IDSubFamilia = SF.ID"

        'AGREGAR EL FILTRO DEL BUSCADOR SI SE PROPORCIONA
        If Not String.IsNullOrEmpty(filtroTexto) Then
            consultaSQL &= " WHERE (P.Descripcion LIKE @filtroTexto OR F.Familia LIKE @filtroTexto OR SF.Subfamilia LIKE @filtroTexto OR P.Codigo LIKE @filtroTexto"
            consultaSQL &= " OR (P.Descripcion + ' ' + F.Familia LIKE @filtroTexto) OR (F.Familia + ' ' + P.Descripcion LIKE @filtroTexto))"
        End If

        ' CONSULTA CON FILTRO SI EXISTE
        If Not String.IsNullOrEmpty(filtro) Then
            If String.IsNullOrEmpty(filtroTexto) Then
                consultaSQL &= " WHERE " & filtro
            Else
                consultaSQL &= " AND " & filtro
            End If
        End If

        ' ADAPTADOR Y DATASET PARA OBTENER LOS DATOS DE LA BASE
        Dim adaptador As New SqlDataAdapter(consultaSQL, Conexion.conexionSql)
        ' AGREGAR EL PARAMETRO filtroTexto Y SU VALOR
        adaptador.SelectCommand.Parameters.AddWithValue("@filtroTexto", "%" & filtroTexto & "%")
        Dim dsProductos As New DataSet()
        adaptador.Fill(dsProductos, "stProductos")

        ' ASIGNAR EL DATATABLE AL DATAGRIDVIEW
        dgvProductos.DataSource = dsProductos.Tables("stProductos")

        ' HACER NO VISIBLES LAS COLUMNAS INNECESARIAS
        dgvProductos.Columns(0).Visible = False
        dgvProductos.Columns(4).Visible = False
        dgvProductos.Columns(6).Visible = False
        dgvProductos.Columns(10).Visible = False
        dgvProductos.Columns(11).Visible = False
        dgvProductos.Columns(13).Visible = False

        ' APLICAR FILTRO SI ES NECESARIO
        If filtroActivoProductos Then
            aplicarFiltrosDgvProductos()
            filtroActivoProductos = True
        Else
            filtroActivoProductos = False
        End If
    End Sub


    Private Sub dgvProductos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProductos.CellFormatting
        ' VERIFICAR SI LA COLUMNA ES STOCK, PRECIOUNITARIO O PORCENTAJEIVA
        If e.RowIndex >= 0 Then
            ' OBTENER EL VALOR DE VENTAPORPESO EN LA FILA ACTUAL
            Dim ventaPorPeso As Boolean = Convert.ToBoolean(dgvProductos.Rows(e.RowIndex).Cells("VentaPorPeso").Value)

            ' STOCK: SI VENTAPORPESO ES 0, NO MOSTRAR DECIMALES
            If dgvProductos.Columns(e.ColumnIndex).Name = "STOCK" AndAlso e.Value IsNot Nothing Then
                ' SI EL VALOR ES DE TIPO DECIMAL Y VENTAPORPESO ES 0, MOSTRAMOS SOLO EL VALOR ENTERO
                If ventaPorPeso = False Then
                    ' AQUÍ TRANSFORMAMOS EL STOCK PARA QUE NO TENGA DECIMALES
                    e.Value = Math.Floor(Convert.ToDecimal(e.Value))
                Else
                    ' NO ES NECESARIO REEMPLAZAR COMA POR PUNTO
                    e.Value = e.Value.ToString()
                End If
            End If

            ' PRECIO UNITARIO
            If dgvProductos.Columns(e.ColumnIndex).Name = "PRECIO UNIT." AndAlso e.Value IsNot Nothing Then
                ' NO ES NECESARIO REEMPLAZAR COMA POR PUNTO
                e.Value = e.Value.ToString()
            End If

            ' PORCENTAJE IVA
            If dgvProductos.Columns(e.ColumnIndex).Name = "% IVA" AndAlso e.Value IsNot Nothing Then
                ' NO ES NECESARIO REEMPLAZAR COMA POR PUNTO
                e.Value = e.Value.ToString()
            End If
        End If
    End Sub


    Private Sub CargarImagenProducto(idProducto As Integer)
        Dim consultaSQL As String = "SELECT Imagen FROM stProductos WHERE ID = @IDProducto"

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString),
              command As New SqlCommand(consultaSQL, connection)
                command.Parameters.AddWithValue("@IDProducto", idProducto)
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim imageData As Byte() = If(reader("Imagen") IsNot DBNull.Value, CType(reader("Imagen"), Byte()), Nothing)
                        If imageData IsNot Nothing Then
                            Using ms As New IO.MemoryStream(imageData)
                                ' Asegúrate de utilizar System.Drawing.Image
                                frmProductos.pbProducto.Image = System.Drawing.Image.FromStream(ms)
                                frmConsultarPrecio.pbProducto.Image = System.Drawing.Image.FromStream(ms)
                            End Using
                        Else
                            frmProductos.pbProducto.Image = Nothing
                        End If
                    Else
                        frmProductos.pbProducto.Image = Nothing
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen del producto: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = ""
        CargarDatosProductos(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProductos = 1
    End Sub

    Private Sub btnActivos_Click(sender As Object, e As EventArgs) Handles btnActivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = "P.Activo = 1"
        CargarDatosProductos(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProductos = 2
    End Sub
    Private Sub btnInactivos_Click(sender As Object, e As EventArgs) Handles btnInactivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnInactivos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = "P.Activo = 0"
        CargarDatosProductos(estadoFiltro, txtBuscador.Text)
        'CAMBIO LA VARIABLE PARA LA GENERACIÓN DE PDF
        pdfProductos = 3
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'RECARGAMOS LA GRILLA
        'frmMenu.abrirFrm(Of frmGrillaClientes)()
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        estadoFiltro = ""
        txtBuscador.Text = ""
        CargarDatosProductos(estadoFiltro, txtBuscador.Text)
    End Sub

    'FRONT
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        If filtroActivoProductos Then
            ' Si el filtro está activo, desactivarlo
            quitarFiltrosDgvProductos()
            filtroActivoProductos = False
        Else
            ' Si el filtro está desactivado, activarlo
            aplicarFiltrosDgvProductos()
            filtroActivoProductos = True
        End If
    End Sub

    'FRONT
    Private Sub aplicarFiltrosDgvProductos()
        'ME CAMBIA EL COLOR DEPENDIENDO DE LOS ESTADOS DE LOS CLIENTES
        For Each row As DataGridViewRow In dgvProductos.Rows
            Dim activo As Boolean = Convert.ToBoolean(row.Cells("ACTIVO").Value)
            If activo = True Then
                row.DefaultCellStyle.BackColor = Color.FromArgb(148, 255, 136) ' Verde claro
            Else
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Next
    End Sub

    'FRONT
    Private Sub quitarFiltrosDgvProductos()
        'QUITA LOS COLORES DE LOS FILTROS DE LA GRILLA
        For Each row As DataGridViewRow In dgvProductos.Rows
            row.DefaultCellStyle.BackColor = SystemColors.Control
        Next
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        'TRAE EL FORMULARIO PARA VER UN PRODUCTO
        'CAMBIA LA TAREA DEL FORMULARIO
        frmProductos.lblTarea.Text = "Ver producto"
        ' CARGAR COMBOBOX
        frmProductos.Familias()
        frmProductos.SubFamilias(dgvProductos.CurrentRow.Cells(4).Value)
        ' LLEVAR DATOS AL FORM Y ABRIRLO
        frmProductos.lblID.Text = dgvProductos.CurrentRow.Cells(0).Value
        frmProductos.txtCodigo.Text = dgvProductos.CurrentRow.Cells(1).Value
        frmProductos.txtCodigoBarra.Text = dgvProductos.CurrentRow.Cells(2).Value
        frmProductos.txtDescripcion.Text = dgvProductos.CurrentRow.Cells(3).Value
        frmProductos.cbFamilia.SelectedValue = dgvProductos.CurrentRow.Cells(4).Value
        frmProductos.cbSubFamilia.SelectedValue = dgvProductos.CurrentRow.Cells(6).Value
        ' OBTENER EL VALOR DE STOCK Y FORMATEARLO SEGÚN VENTA POR PESO
        Dim ventaPorPeso As Boolean = Convert.ToBoolean(dgvProductos.CurrentRow.Cells(13).Value)
        If Not ventaPorPeso Then
            ' SI NO SE VENDE POR PESO, EL STOCK DEBE SER UN VALOR ENTERO
            frmProductos.txtStock.Text = Math.Floor(Convert.ToDecimal(dgvProductos.CurrentRow.Cells(8).Value)).ToString()
        Else
            ' SI SE VENDE POR PESO, REEMPLAZAR COMA POR PUNTO
            frmProductos.txtStock.Text = dgvProductos.CurrentRow.Cells(8).Value.ToString().Replace(",", ".")
        End If
        ' PRECIO UNITARIO: REEMPLAZAR COMA POR PUNTO
        frmProductos.txtPrecioUnitario.Text = dgvProductos.CurrentRow.Cells(9).Value.ToString().Replace(",", ".")
        ' PORCENTAJE IVA: REEMPLAZAR COMA POR PUNTO
        frmProductos.txtPorcentajeIVA.Text = dgvProductos.CurrentRow.Cells(12).Value.ToString().Replace(",", ".")
        ' ESTÁ ACTIVO?
        If dgvProductos.CurrentRow.Cells(10).Value = True Then
            ' ACTIVO
            frmProductos.rbSiActivo.Checked = True
        ElseIf dgvProductos.CurrentRow.Cells(10).Value = False Then
            ' INACTIVO   
            frmProductos.rbNoActivo.Checked = True
        End If
        ' SE VENDE POR PESO?
        If dgvProductos.CurrentRow.Cells(13).Value = True Then
            ' SE VENDE POR PESO
            frmProductos.rbSi.Checked = True
        ElseIf dgvProductos.CurrentRow.Cells(13).Value = False Then
            ' NO SE VENDE POR PESO
            frmProductos.rbNo.Checked = True
        End If
        ' CARGAR LA IMAGEN DEL PRODUCTO DESDE LA BASE DE DATOS
        If dgvProductos.CurrentRow IsNot Nothing Then
            CargarImagenProducto(Convert.ToInt32(dgvProductos.CurrentRow.Cells(0).Value))
        End If
        ' ASIGNA EL ID DEL PRODUCTO A LA VARIABLE
        frmProductos.idProductoActual = Convert.ToInt32(dgvProductos.CurrentRow.Cells(0).Value)
        ' MUESTRA EL FORMULARIO
        frmProductos.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'VERIFICAR QUE LA GRILLA NO ESTE VACIA
        If dgvProductos.SelectedRows.Count > 0 Then
            'SE OBTIENE EL ID DEL PRODUCTO
            Dim productoID As Integer = dgvProductos.CurrentRow.Cells("ID").Value

            'VERIFICAR SI EL PRODUCTO TIENE MOVIMIENTOS RELACIONADOS EN vtFacturasMov
            Conexion.CargarCadenaConexion()
            Dim consultaRelacionFacturas As String = "SELECT COUNT(*) FROM vtFacturasMov WHERE IDProducto = @IDProducto"
            Dim tieneMovimientos As Boolean

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using comandoVerificacionFacturas As New SqlCommand(consultaRelacionFacturas, conexion)
                    comandoVerificacionFacturas.Parameters.AddWithValue("@IDProducto", productoID)

                    conexion.Open()
                    Dim countFacturas As Integer = Convert.ToInt32(comandoVerificacionFacturas.ExecuteScalar())
                    tieneMovimientos = (countFacturas > 0)
                End Using
            End Using

            'VERIFICAR SI EL PRODUCTO TIENE PROVEEDORES RELACIONADOS EN stProductosProveedor
            Dim consultaRelacionProveedores As String = "SELECT COUNT(*) FROM stProductosProveedor WHERE IDProducto = @IDProducto"
            Dim tieneProveedores As Boolean

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using comandoVerificacionProveedores As New SqlCommand(consultaRelacionProveedores, conexion)
                    comandoVerificacionProveedores.Parameters.AddWithValue("@IDProducto", productoID)

                    conexion.Open()
                    Dim countProveedores As Integer = Convert.ToInt32(comandoVerificacionProveedores.ExecuteScalar())
                    tieneProveedores = (countProveedores > 0)
                End Using
            End Using

            'SI TIENE MOVIMIENTOS O PROVEEDORES RELACIONADOS, MOSTRAR MENSAJE Y CANCELAR ELIMINACIÓN
            If tieneMovimientos OrElse tieneProveedores Then
                MessageBox.Show("No se puede eliminar el producto porque tiene movimientos o proveedores asociados.", "Error de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'CONFIRMAR DELETE, POR SEGURIDAD
            Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim consultaSQL As String = "DELETE FROM stProductos WHERE ID = @ID"

                Using conexion As New SqlConnection(conexionSql.ConnectionString)
                    Using comando As New SqlCommand(consultaSQL, conexion)
                        comando.Parameters.AddWithValue("@ID", productoID)

                        conexion.Open()
                        comando.ExecuteNonQuery()
                    End Using
                End Using

                'LIMPIO LOS BOTONES DEL FORMULARIO
                limpiarBotones()
                'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
                btnActivos.BackColor = Color.FromArgb(49, 130, 255)
                'RECARGAR LA GRILLA
                estadoFiltro = "P.Activo = 1"
                txtBuscador.Text = ""
                CargarDatosProductos(estadoFiltro, txtBuscador.Text)
                MessageBox.Show("Producto eliminado exitosamente.", "Eliminación completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'FUNCIÓN PARA LIMPIAR LOS BOTONES DEL GRILLA PRODUCTOS (FRONT)
    Public Sub limpiarBotones()
        'BOTONES DEl GRILLA PRODUCTOS
        btnTodos.BackColor = Color.FromArgb(0, 59, 92)
        btnActivos.BackColor = Color.FromArgb(0, 59, 92)
        btnInactivos.BackColor = Color.FromArgb(0, 59, 92)
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        ' VERIFICA SI HAY UNA FILA SELECCIONADA
        If dgvProductos.CurrentRow IsNot Nothing Then
            ' OBTENER LOS DATOS DEL PRODUCTO SELECCIONADO
            Dim codigo As String = dgvProductos.CurrentRow.Cells(1).Value.ToString()
            Dim descripcion As String = dgvProductos.CurrentRow.Cells(3).Value.ToString()

            ' OBTENER EL STOCK COMO DECIMAL
            Dim stockComparacion As Decimal = Convert.ToDecimal(dgvProductos.CurrentRow.Cells(8).Value)

            ' VALIDAR SI EL PRODUCTO SE VENDE POR PESO
            Dim ventaPorPeso As Boolean = Convert.ToBoolean(dgvProductos.CurrentRow.Cells(13).Value)

            ' USAMOS OBJECT PARA QUE PUEDA TOMAR VALORES STRING O DECIMALES
            Dim stock As Object

            ' ASIGNAMOS EL VALOR DEL STOCK
            If Not ventaPorPeso Then
                ' SI EL PRODUCTO NO SE VENDE POR PESO, REDONDEAR EL STOCK A ENTERO
                stock = Math.Floor(stockComparacion) ' REDONDEAMOS HACIA ABAJO PARA PRODUCTOS QUE NO SE VENDE POR PESO
            Else
                ' SI SE VENDE POR PESO, MANTENEMOS EL VALOR TAL CUAL
                stock = stockComparacion.ToString() ' DEJAMOS EL STOCK TAL CUAL
            End If

            ' MOSTRAR LA INFORMACIÓN DEL PRODUCTO EN EL MENSAJE
            Dim mensaje As String = String.Format("Código: {0}{1}Descripción: {2}{1}Stock disponible: {3}{1}{1}Ingrese la cantidad a vender:",
                                              codigo, Environment.NewLine, descripcion, stock)

            ' SOLICITAR LA CANTIDAD A VENDER
            Dim cantidad As String = InputBox(mensaje, "Cantidad de Venta")

            ' VALIDAR QUE LA CANTIDAD SEA UN NÚMERO CON UN PUNTO Y UN MÁXIMO DE 3 DECIMALES
            If Not IsCantidadValida(cantidad) Then
                MessageBox.Show("Por favor, ingrese una cantidad válida. (Máximo 3 decimales)", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' SALIR DE LA FUNCIÓN PARA QUE INGRESE NUEVAMENTE LA CANTIDAD
            End If

            ' VALIDAR QUE LA CANTIDAD SEA UN NÚMERO VÁLIDO
            Dim cantidadNumero As Decimal
            If Decimal.TryParse(cantidad, cantidadNumero) AndAlso cantidadNumero > 0 Then
                ' VALIDAR QUE SI NO SE VENDE POR PESO, LA CANTIDAD NO SEA DECIMAL
                If Not ventaPorPeso AndAlso cantidad.Contains(".") Then
                    MessageBox.Show("El producto no se vende por peso, ingrese una cantidad entera.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' SALIR DE LA FUNCIÓN PARA QUE INGRESE DE NUEVO LA CANTIDAD
                End If

                ' VALIDAR QUE LA CANTIDAD NO SEA MAYOR AL STOCK DISPONIBLE
                If cantidadNumero > stock Then
                    MessageBox.Show("La cantidad ingresada supera el stock disponible.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return ' SALIR DE LA FUNCIÓN PARA QUE INGRESE UNA NUEVA CANTIDAD
                End If

                ' OBTENER EL PRECIO Y EL IVA DEL PRODUCTO
                Dim precio As Decimal = Convert.ToDecimal(dgvProductos.CurrentRow.Cells(9).Value)
                Dim iva As Decimal = Convert.ToDecimal(dgvProductos.CurrentRow.Cells(12).Value)

                ' LLAMAR AL MÉTODO DE FRMVENTAS PARA AGREGAR EL PRODUCTO
                ' Enviar la cantidad como string y permitir que el método de agregarProducto lo maneje
                frmVentas.agregarProducto(codigo, descripcion, precio, cantidadNumero, iva, ventaPorPeso)

                ' PREGUNTAR SI DESEA CARGAR OTRO PRODUCTO
                Dim respuesta As DialogResult = MessageBox.Show("¿Desea cargar otro producto?", "Cargar otro producto", MessageBoxButtons.YesNo)
                If respuesta = DialogResult.No Then
                    ' CERRAR EL FORMULARIO
                    Me.Close()
                End If
            Else
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Cantidad no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione un producto para importar.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ' CAMBIO LA TAREA
        lblTarea.Text = "Nada"
    End Sub

    Private Function IsCantidadValida(cantidad As String) As Boolean
        ' Expresión regular para permitir solo números y un único punto decimal, con hasta 3 dígitos después del punto
        Dim regex As New System.Text.RegularExpressions.Regex("^\d{1,7}(\.\d{1,3})?$")

        ' Verifica si la cantidad cumple con la expresión regular
        Return regex.IsMatch(cantidad)
    End Function


    ' METODO PARA GENERAR PDF DE PRODUCTOS
    Public Sub GenerarPDFProductos()
        ' FORMATO FECHA Y HORA PARA GUARDAR EL PDF
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ' DONDE LO VA A GUARDAR
        Dim pdfPath As String = $"C:\Almasoft\captures\productos_{timestamp}.pdf"

        Using writer As New PdfWriter(pdfPath)
            Using pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)
                Dim title As New Paragraph

                ' TITULO DEL PDF
                If pdfProductos = 1 Then
                    title = New Paragraph("Datos de Productos")
                ElseIf pdfProductos = 2 Then
                    title = New Paragraph("Datos de Productos Activos")
                ElseIf pdfProductos = 3 Then
                    title = New Paragraph("Datos de Productos Inactivos")
                End If
                title.SetFontSize(12)
                title.SetBold()
                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                document.Add(title)

                ' CREAR LA TABLA
                ' Reducimos el número de columnas a las que necesitamos
                Dim table As New Table(5) ' 5 columnas: CÓDIGO, DESCRIPCIÓN, FAMILIA, STOCK, PRECIO UNIT.

                ' AGREGA LOS ENCABEZADOS
                Dim headerNames As String() = {"CÓDIGO", "DESCRIPCIÓN", "FAMILIA", "STOCK", "PRECIO UNIT."}

                For Each header As String In headerNames
                    Dim headerCell As Cell = New Cell().Add(New Paragraph(header)).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                    table.AddHeaderCell(headerCell)
                Next




                ' AGREGA LAS FILAS
                For Each row As DataGridViewRow In dgvProductos.Rows
                    If Not row.IsNewRow Then
                        ' Solo agregar las celdas correspondientes a las columnas seleccionadas
                        ' Orden de columnas: CÓDIGO, DESCRIPCIÓN, FAMILIA, STOCK, PRECIO UNIT.
                        Dim cellValues As String() = {
                        If(row.Cells("CÓDIGO").Value IsNot Nothing, row.Cells("CÓDIGO").Value.ToString(), ""),
                        If(row.Cells("DESCRIPCIÓN").Value IsNot Nothing, row.Cells("DESCRIPCIÓN").Value.ToString(), ""),
                        If(row.Cells("FAMILIA/RUBRO").Value IsNot Nothing, row.Cells("FAMILIA/RUBRO").Value.ToString(), ""),
                        If(row.Cells("STOCK").Value IsNot Nothing, row.Cells("STOCK").Value.ToString(), ""),
                        If(row.Cells("PRECIO UNIT.").Value IsNot Nothing, row.Cells("PRECIO UNIT.").Value.ToString(), "")
                    }

                        For Each cellValue As String In cellValues
                            Dim cellParagraph As New Paragraph(cellValue)
                            cellParagraph.SetFontSize(10) ' Fuente más pequeña
                            Dim cell As New Cell()
                            cell.Add(cellParagraph)
                            table.AddCell(cell)
                        Next
                    End If
                Next

                ' ESTABLECER ANCHO DE TABLA
                table.SetWidth(UnitValue.CreatePercentValue(100))

                ' AGREGAR TABLA AL DOCUMENTO
                document.Add(table)
            End Using
        End Using

        MessageBox.Show("PDF generado correctamente en: " & pdfPath)

        ' ABRE EL PDF AUTOMÁTICAMENTE
        Try
            Process.Start(New ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGenerarPdf_Click(sender As Object, e As EventArgs) Handles btnGenerarPdf.Click
        'GENERO PDF
        GenerarPDFProductos()
    End Sub

    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnLimpiarImagen.Click
        'LIMPIO EL BUSCADOR
        txtBuscador.Clear()
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        'OBTENEMOS EL TEXTO INGRESADO POR EL USUARIO
        Dim filtroTexto As String = txtBuscador.Text.Trim()
        'LE PASAMOS EL FILTRO A LA FUNCIÓN
        CargarDatosProductos(estadoFiltro, filtroTexto)
    End Sub

    'CONSULTAR PRECIO DEL PRODUCTO
    Private Sub btnConsultarPrecio_Click(sender As Object, e As EventArgs) Handles btnConsultarPrecio.Click
        ' CONSULTAR PRECIO DEL PRODUCTO

        'LIMPIAR LOS CONTROLES DEL FORMULARIO PREVIAMENTE
        frmConsultarPrecio.limpiarControles()

        ' LLEVAR DATOS AL FORM Y ABRIRLO
        ' OBTENER EL CÓDIGO Y MOSTRARLO
        frmConsultarPrecio.lblCodigo.Text = dgvProductos.CurrentRow.Cells(1).Value.ToString()

        ' OBTENER LA DESCRIPCIÓN Y MOSTRARLA
        frmConsultarPrecio.lblDescripcion.Text = dgvProductos.CurrentRow.Cells(3).Value.ToString()

        ' OBTENER LA FAMILIA Y MOSTRARLA
        frmConsultarPrecio.lblFamilia.Text = dgvProductos.CurrentRow.Cells(5).Value.ToString()

        ' OBTENER LA SUBFAMILIA Y MOSTRARLA
        frmConsultarPrecio.lblSubFamilia.Text = dgvProductos.CurrentRow.Cells(7).Value.ToString()

        ' OBTENER EL PORCENTAJE DE IVA, CONVERTIRLO Y MOSTRARLO
        Dim porcentajeIva As Double = Convert.ToDouble(dgvProductos.CurrentRow.Cells(12).Value.ToString().Replace(",", "."))
        frmConsultarPrecio.lblPorcentajeIva.Text = porcentajeIva.ToString("F2") ' MOSTRAR CON DOS DECIMALES

        ' OBTENER EL PRECIO UNITARIO, CONVERTIRLO Y MOSTRARLO
        Dim precioUnitario As Double = Convert.ToDouble(dgvProductos.CurrentRow.Cells(9).Value.ToString().Replace(",", "."))
        frmConsultarPrecio.lblPrecioUnitario.Text = precioUnitario.ToString("F2") ' MOSTRAR CON DOS DECIMALES

        ' CARGAR LA IMAGEN DEL PRODUCTO DESDE LA BASE DE DATOS
        If dgvProductos.CurrentRow IsNot Nothing Then
            CargarImagenProducto(Convert.ToInt32(dgvProductos.CurrentRow.Cells(0).Value))
        End If

        ' CALCULAR EL PRECIO CON IVA
        Dim precioConIva As Double = precioUnitario + (precioUnitario * (porcentajeIva / 100))

        ' MOSTRAR EL PRECIO CON IVA EN lblCosto
        frmConsultarPrecio.lblCosto.Text = precioConIva.ToString("F2") ' MOSTRAR CON DOS DECIMALES

        ' MOSTRAR EL FORMULARIO
        frmConsultarPrecio.Show()
    End Sub

End Class