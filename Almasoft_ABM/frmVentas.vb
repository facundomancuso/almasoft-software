Imports System.IO
Imports System.Drawing
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports Microsoft.Data.SqlClient
Imports System.Globalization
Imports System.Threading

Public Class frmVentas

    'DESACTIVA LOS CONTROLES
    Public Sub desactivarControles()
        txtCodigo.Enabled = False
        txtNombreApellido.Enabled = False
        txtDni.Enabled = False
        cbCondicionIva.Enabled = False
        btnBuscarCliente.Enabled = False
        dgvProductos.Enabled = False
        btnBuscarProductos.Enabled = False
        btnLimpiarProducto.Enabled = False
        cbTipoDeCobro.Enabled = False
    End Sub

    'ACTIVA LOS CONTROLES
    Public Sub activarControles()
        btnBuscarCliente.Enabled = True
        dgvProductos.Enabled = True
        btnBuscarProductos.Enabled = True
        btnLimpiarProducto.Enabled = True
        cbTipoDeCobro.Enabled = True
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTABLECE SEPARADORES DECIMALES POR PUNTO Y NO POR COMA
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        'DEFINIR LAS COLUMNAS DEL DGV
        With dgvProductos
            ' LIMPIO LAS COLUMNAS EXISTENTES
            .Columns.Clear()
            ' AGREGAR COLUMNA DE IMAGEN
            Dim imagenColumn As New DataGridViewImageColumn()
            imagenColumn.Name = "Imagen"
            imagenColumn.HeaderText = "Imagen"
            'AJUSTA LA IMAGEN
            imagenColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            'AGREGA LA COLUMNA DE LA IMAGEN
            .Columns.Add(imagenColumn)
            ' AGREGAR OTRAS COLUMNAS
            .Columns.Add("Codigo", "Código")
            .Columns.Add("Nombre", "Nombre")
            .Columns.Add("Precio", "Precio")
            .Columns.Add("Cantidad", "Cantidad")
            .Columns.Add("IVA", "IVA")
            .Columns.Add("Total", "Total")
            ' AJUSTAR EL ANCHO DE LA COLUMNA DE IMAGEN
            .Columns(0).Width = 50  ' Establece el ancho de la columna de imagen
            ' SE AJUSTAN AL ANCHO DEL DGV, EXCEPTO LA COLUMNA DE IMAGEN
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            ' AJUSTAR LA ALTURA DE LAS FILAS
            .RowTemplate.Height = 100 ' Establece la altura de las filas
        End With

        ' ACTIVA O DESACTIVA CONTROLES
        Conexion.CargarCadenaConexion()
        If lblTarea.Text = "Ver venta" Then
            desactivarControles()
        Else
            activarControles()
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'FRONT
        Me.Close()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        'FRONT
        'MINIMIZA EL FORMULARIO
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'FRONT
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'VERIFICA EL LBLTAREA PARA VERIFICAR EL FUNCIONAMIENTO
        If lblTarea.Text = "Nueva venta" Then
            NuevaVenta()
        End If
    End Sub
    Public Sub NuevaVenta()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        If bandera = True Then
            Exit Sub
        End If

        ' VALIDAR QUE EL STOCK SEA SUFICIENTE PARA TODOS LOS PRODUCTOS DEL DGV
        If Not validarStockSuficiente() Then
            ' NO ES SUFICIENTE, CORTAMOS LA VENTA
            Exit Sub
        End If

        Dim comprobante As Integer
        Dim letra As String = ObtenerLetra()
        Dim idFactura As Integer = 0 ' Variable para almacenar el ID de la factura

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                ' Obtener el último número de comprobante según la letra
                Dim query As String = "SELECT CASE WHEN @letra = 'A' THEN NumeracionFacturaA " &
                                  "WHEN @letra = 'B' THEN NumeracionFacturaB " &
                                  "WHEN @letra = 'C' THEN NumeracionFacturaC END AS Comprobante " &
                                  "FROM adConfiguraciones"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@letra", letra)
                    comprobante = Convert.ToInt32(command.ExecuteScalar())
                End Using

                ' Aumentamos el número de comprobante
                comprobante += 1


                ' Verificación para evitar duplicados antes de insertar
                Dim verificaDuplicadoQuery As String = "SELECT COUNT(*) FROM dbo.vtFacturas WHERE IDCliente = @idcliente AND Letra = @letra AND Comprobante = @comprobante"
                Using verificaCommand As New SqlCommand(verificaDuplicadoQuery, connection)
                    verificaCommand.Parameters.AddWithValue("@idcliente", lblIdCliente.Text)
                    verificaCommand.Parameters.AddWithValue("@letra", letra)
                    verificaCommand.Parameters.AddWithValue("@comprobante", comprobante)

                    Dim count As Integer = Convert.ToInt32(verificaCommand.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Ya existe una venta con los mismos datos.", "Almasoft - Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Inserción de la nueva venta y obtener IDFactura usando SCOPE_IDENTITY()
                Using insertCommand As New SqlCommand("INSERT INTO dbo.vtFacturas (IDCliente, IDTipo, Fecha, PuntoVenta, Letra, Comprobante, Gravado, IVA, Total) " &
                                                   "VALUES (@idcliente, @idtipo, @fecha, @puntoventa, @letra, @comprobante, @gravado, @iva, @total); " &
                                                   "SELECT SCOPE_IDENTITY();", connection)

                    insertCommand.Parameters.AddWithValue("@fecha", DateTime.Now)
                    insertCommand.Parameters.AddWithValue("@idcliente", lblIdCliente.Text)
                    insertCommand.Parameters.AddWithValue("@idtipo", 1)
                    insertCommand.Parameters.AddWithValue("@puntoventa", obtenerPuntoDeVenta())
                    insertCommand.Parameters.AddWithValue("@letra", letra)
                    insertCommand.Parameters.AddWithValue("@comprobante", comprobante)

                    'insertCommand.Parameters.AddWithValue("@gravado", ConvertirFormatoNumerico(txtSubTotal.Text)) ' Valor genérico
                    'insertCommand.Parameters.AddWithValue("@iva", ConvertirFormatoNumerico(txtIVA.Text)) ' Valor genérico
                    'insertCommand.Parameters.AddWithValue("@total", ConvertirFormatoNumerico(txtTotal.Text)) ' Valor genérico

                    Dim gravado As Decimal
                    Dim iva As Decimal
                    Dim total As Decimal

                    If Decimal.TryParse(txtSubTotal.Text, gravado) AndAlso
                       Decimal.TryParse(txtIVA.Text, iva) AndAlso
                       Decimal.TryParse(txtTotal.Text, total) Then
                        insertCommand.Parameters.AddWithValue("@gravado", gravado)
                        insertCommand.Parameters.AddWithValue("@iva", iva)
                        insertCommand.Parameters.AddWithValue("@total", total)
                    Else
                        MessageBox.Show("Por favor, ingrese valores válidos para los campos de subtotal, IVA y total.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If



                    idFactura = Convert.ToInt32(insertCommand.ExecuteScalar()) ' Obtener el ID de la factura recién insertada
                End Using

                ' Actualizar la numeración en configuraciones
                Dim updateQuery As String = "UPDATE adConfiguraciones SET " &
                                         "NumeracionFacturaA = CASE WHEN @letra = 'A' THEN @comprobante ELSE NumeracionFacturaA END, " &
                                         "NumeracionFacturaB = CASE WHEN @letra = 'B' THEN @comprobante ELSE NumeracionFacturaB END, " &
                                         "NumeracionFacturaC = CASE WHEN @letra = 'C' THEN @comprobante ELSE NumeracionFacturaC END"

                Using updateCommand As New SqlCommand(updateQuery, connection)
                    updateCommand.Parameters.AddWithValue("@letra", letra)
                    updateCommand.Parameters.AddWithValue("@comprobante", comprobante)
                    updateCommand.ExecuteNonQuery()
                End Using

                ' INSERTAR LOS PRODUCTOS EN VTFACTURASMOV Y ACTUALIZAR STOCK EN STPRODUCTOS
                For Each row As DataGridViewRow In dgvProductos.Rows
                    If Not row.IsNewRow Then
                        Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells(3).Value)
                        Dim cantidad As Integer = Convert.ToInt32(row.Cells(4).Value)
                        Dim subtotalUnitario As Decimal = precioUnitario * cantidad
                        Dim porcentajeIVA As Decimal = ObtenerPorcentajeIVAPorProducto(row.Cells(1).Value.ToString())
                        Dim subtotalIVA As Decimal = subtotalUnitario * (porcentajeIVA / 100)
                        Dim totalUnitario As Decimal = subtotalUnitario + subtotalIVA

                        'INSERTA EL MOVIMIENTO DE LA VENTA
                        Using insertMovCommand As New SqlCommand("INSERT INTO vtFacturasMov (IDFactura, IDProducto, PrecioUnitario, Cantidad, PorcentajeIVA, SubtotalUnitario, SubtotalIVA, TotalUnitario) " &
                                                              "VALUES (@idFactura, @idProducto, @precioUnitario, @cantidad, @porcentajeIVA, @subtotalUnitario, @subtotalIVA, @totalUnitario)", connection)

                            insertMovCommand.Parameters.AddWithValue("@idFactura", idFactura)
                            insertMovCommand.Parameters.AddWithValue("@idProducto", ObtenerIDProductoPorCodigo(row.Cells(1).Value.ToString()))
                            insertMovCommand.Parameters.AddWithValue("@precioUnitario", precioUnitario)
                            insertMovCommand.Parameters.AddWithValue("@cantidad", cantidad)
                            insertMovCommand.Parameters.AddWithValue("@porcentajeIVA", porcentajeIVA)
                            insertMovCommand.Parameters.AddWithValue("@subtotalUnitario", subtotalUnitario)
                            insertMovCommand.Parameters.AddWithValue("@subtotalIVA", subtotalIVA)
                            insertMovCommand.Parameters.AddWithValue("@totalUnitario", totalUnitario)

                            insertMovCommand.ExecuteNonQuery()
                        End Using

                        'RESTAR EL STOCK DEL PRODUCTO EN LA TABLA STPRODUCTOS
                        Dim updateStockQuery As String = "UPDATE stProductos SET Stock = Stock - @cantidad WHERE Codigo = @codigo"
                        Using updateStockCommand As New SqlCommand(updateStockQuery, connection)
                            updateStockCommand.Parameters.AddWithValue("@cantidad", Convert.ToDecimal(row.Cells(4).Value)) 'CANTIDAD EN EL DGV DEL PRODUCTO
                            updateStockCommand.Parameters.AddWithValue("@codigo", row.Cells(1).Value.ToString()) 'CODIGO DEL PRODUCTO
                            updateStockCommand.ExecuteNonQuery()
                        End Using
                    End If
                Next

                'SI PAGA EL CLIENTE CON EFECTIVO, ME MUESTRA LA CALCULADORA
                If cbTipoDeCobro.SelectedValue = 1 Then
                    frmCalculadora.lblTotal.Text = txtTotal.Text
                    frmCalculadora.ShowDialog()
                End If


                MsgBox("Se agregó correctamente la nueva venta", vbOKOnly + vbInformation, "Almasoft - Nueva Venta")
                'GENERO EL TICKET DE LA VENTA
                GenerarPDFTicket()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al intentar agregar una nueva venta: " & ex.Message)
        End Try

        Me.Close()
    End Sub

    ' Función para obtener el ID del producto según el código
    Private Function ObtenerIDProductoPorCodigo(codigo As String) As Integer
        Dim idProducto As Integer = 0
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()
            Dim query As String = "SELECT ID FROM stProductos WHERE Codigo = @codigo"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", codigo)
                idProducto = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
        Return idProducto
    End Function

    ' Función para obtener el porcentaje de IVA según el producto
    Private Function ObtenerPorcentajeIVAPorProducto(codigo As String) As Decimal
        Dim porcentajeIVA As Decimal = 0
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()
            Dim query As String = "SELECT PorcentajeIVA FROM stProductos WHERE Codigo = @codigo"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", codigo)
                porcentajeIVA = Convert.ToDecimal(command.ExecuteScalar())
            End Using
        End Using
        Return porcentajeIVA
    End Function

    Private Function ObtenerLetra() As String
        Dim letra As String = ""

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                ' Obtener IDCondicionIVAEmpresa
                Dim idCondicionIVAEmpresa As Integer
                Using command As New SqlCommand("SELECT IDCondicionIVAEmpresa FROM adConfiguraciones", connection)
                    idCondicionIVAEmpresa = Convert.ToInt32(command.ExecuteScalar())
                End Using

                ' Obtener IDCondicionIVA del cliente
                Dim idCondicionIVACliente As Integer
                Using command As New SqlCommand("SELECT IDCondicionIVA FROM vtClientes WHERE ID = @idcliente", connection)
                    command.Parameters.AddWithValue("@idcliente", lblIdCliente.Text)
                    idCondicionIVACliente = Convert.ToInt32(command.ExecuteScalar())
                End Using

                ' Determinar la letra según las condiciones

                If idCondicionIVAEmpresa = 1 Then
                    If idCondicionIVACliente = 1 OrElse idCondicionIVACliente = 3 Then
                        letra = "A"
                    ElseIf idCondicionIVACliente = 2 OrElse idCondicionIVACliente = 5 OrElse idCondicionIVACliente = 4 Then
                        letra = "B"
                    End If
                ElseIf idCondicionIVAEmpresa = 3 Then
                    letra = "C"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al determinar la letra: " & ex.Message)
        End Try

        Return letra
    End Function

    Private Function obtenerPuntoDeVenta() As Integer
        Dim puntoDeVenta As Integer = 0

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                ' Consulta para obtener el PuntoDeVenta de la tabla Configuraciones
                Using command As New SqlCommand("SELECT PuntoDeVenta FROM adConfiguraciones", connection)
                    ' Ejecutamos el comando y leemos el valor
                    puntoDeVenta = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el Punto de Venta: " & ex.Message)
        End Try

        Return puntoDeVenta
    End Function

    'BUSCA CLIENTE PARA LA NOTA DE VENTA
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        'MUESTRO LA GRILLA Y CAMBIO TAREA
        frmGrillaClientes.lblTarea.Text = "Venta"
        frmGrillaClientes.ShowDialog()
    End Sub

    'COMBOBOXS
    Public Sub CondicionesIva()
        'SELECT A LAS CONDICIONES IVA Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Condicion FROM adCondicionesIva"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim CondicionesIva As New DataTable
        adaptadorSql.Fill(CondicionesIva)

        'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
        cbCondicionIva.DataSource = CondicionesIva
        cbCondicionIva.DisplayMember = "Condicion"
        cbCondicionIva.ValueMember = "ID"
    End Sub
    Public Sub FormaDePago()
        'SELECT A LAS FORMAS DE PAGO Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Tipo FROM FormaDePago"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim FormaDePago As New DataTable
        adaptadorSql.Fill(FormaDePago)

        'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
        cbTipoDeCobro.DataSource = FormaDePago
        cbTipoDeCobro.DisplayMember = "Tipo"
        cbTipoDeCobro.ValueMember = "ID"
    End Sub

    'METODO PARA IMPEDIR CAMPOS VACIOS
    Public Sub condicionTxtLlenos()
        'LIMPIO VARIABLES
        modUtilidades.limpiarVariables()
        'HAY CLIENTE SELECCIONADO?
        If String.IsNullOrWhiteSpace(txtCodigo.Text) Then
            'NO HAY NINGUN CLIENTE
            bandera = True
            MessageBox.Show("No hay ningún cliente seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'HAY ALGÚN PRODUCTO SELECCIONADO?
        If dgvProductos.Rows.Count = 0 Then
            'NO HAY NINGUN PRODUCTO
            bandera = True
            MessageBox.Show("No hay ningún producto seleccionado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

    End Sub

    'BUSCA PRODUCTOS PARA LA NOTA DE VENTA
    Private Sub btnBuscarProductos_Click(sender As Object, e As EventArgs) Handles btnBuscarProductos.Click
        'MUESTRO LA GRILLA Y CAMBIO TAREA
        frmGrillaProductos.lblTarea.Text = "Venta"
        frmGrillaProductos.ShowDialog()
    End Sub


    'METODO PARA AGREGAR PRODUCTO A LA VENTA
    Public Sub agregarProducto(codigo As String, nombre As String, precio As Decimal, cantidad As Decimal, iva As Decimal, ventaporpeso As Boolean)
        Dim productoExistente As DataGridViewRow = Nothing

        ' Verifica si el producto ya está en el DataGridView
        For Each row As DataGridViewRow In dgvProductos.Rows
            If row.Cells(1).Value.ToString() = codigo Then
                productoExistente = row
                Exit For
            End If
        Next

        If productoExistente IsNot Nothing Then
            ' El producto existe, actualizamos la cantidad
            ' Usamos Decimal para cantidadActual para que podamos manejar decimales si es necesario
            Dim cantidadActual As Decimal = Convert.ToDecimal(productoExistente.Cells(4).Value)
            cantidadActual += cantidad

            ' Si ventaporpeso es False (venta por unidades), mostramos solo la parte entera
            If ventaporpeso = False Then
                cantidadActual = Math.Floor(cantidadActual) ' Redondeamos a entero
            End If

            productoExistente.Cells(4).Value = cantidadActual

            ' Calcular el nuevo total del producto
            Dim nuevoTotal As Decimal = Convert.ToDecimal(productoExistente.Cells(3).Value)
            nuevoTotal = nuevoTotal + (nuevoTotal * (Convert.ToDecimal(productoExistente.Cells(5).Value) / 100))
            nuevoTotal = nuevoTotal * cantidadActual
            productoExistente.Cells(6).Value = nuevoTotal.ToString("F2") ' Formato con dos decimales
        Else
            ' El producto no está en el DGV, lo agregamos
            Dim row As DataGridViewRow = New DataGridViewRow()
            row.CreateCells(dgvProductos)

            ' Asignamos los valores al nuevo producto
            row.Cells(1).Value = codigo
            row.Cells(2).Value = nombre
            row.Cells(3).Value = precio

            ' Usamos Decimal para cantidad, ya que si ventaporpeso es True, la cantidad puede tener decimales
            Dim cantidadProducto As Decimal = cantidad

            ' Si ventaporpeso es False, mostramos solo la cantidad entera
            If ventaporpeso = False Then
                cantidadProducto = Math.Floor(cantidadProducto) ' Redondeamos a entero
            End If

            row.Cells(4).Value = cantidadProducto
            row.Cells(5).Value = iva

            ' Calculamos el total
            Dim totalProducto As Decimal = precio
            totalProducto = totalProducto + (precio * (iva / 100))
            totalProducto = totalProducto * cantidadProducto
            row.Cells(6).Value = totalProducto.ToString("F2") ' Formato con dos decimales

            ' Cargamos la imagen del producto (si existe)
            Try
                Dim img As System.Drawing.Image = ObtenerImagenProducto(codigo)
                If img IsNot Nothing Then
                    row.Cells(0).Value = img
                Else
                    row.Cells(0).Value = My.Resources.no_image  ' Imagen predeterminada
                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen del producto: " & ex.Message)
                row.Cells(0).Value = My.Resources.no_image
            End Try

            ' Agregar la fila al DataGridView
            dgvProductos.Rows.Add(row)
        End If

        ' Recalcular totales
        CalcularSubtotal()
        CalcularIVA()
        CalcularTotal()
    End Sub


    ' Método para obtener la imagen del producto desde la base de datos
    Private Function ObtenerImagenProducto(codigo As String) As System.Drawing.Image
        Dim imagen As System.Drawing.Image = Nothing
        Dim consultaSQL As String = "SELECT Imagen FROM stProductos WHERE Codigo = @Codigo"

        Using connection As New SqlConnection(Conexion.conexionSql.ConnectionString),
          command As New SqlCommand(consultaSQL, connection)
            command.Parameters.AddWithValue("@Codigo", codigo)
            connection.Open()

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim imageData As Byte() = If(reader("Imagen") IsNot DBNull.Value, CType(reader("Imagen"), Byte()), Nothing)
                    If imageData IsNot Nothing Then
                        Using ms As New IO.MemoryStream(imageData)
                            imagen = System.Drawing.Image.FromStream(ms)
                        End Using
                    End If
                End If
            End Using
        End Using

        Return imagen
    End Function


    'METODO PARA QUITAR ALGÚN PRODUCTO DEL DGV
    Private Sub btnLimpiarProducto_Click(sender As Object, e As EventArgs) Handles btnLimpiarProducto.Click
        'VERIFICA SI HAY UNA FILA SELECCIONADA
        If dgvProductos.CurrentRow IsNot Nothing Then
            'CONFIRMACIÓN
            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este producto de la venta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                'QUITA EL PRODUCTO DEL DGV
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow)
                'CALCULAR EL SUBTOTAL
                CalcularSubtotal()
                CalcularIVA()
                CalcularTotal()
            End If
        Else
            MessageBox.Show("Por favor, seleccione un producto para eliminar.")
        End If
    End Sub


    ' METODO PARA IR SUMANDO EL SUBTOTAL DE LOS PRODUCTOS
    Private Sub CalcularSubtotal()
        Dim subtotal As Decimal = 0
        ' Sumar los precios del DGV
        For Each row As DataGridViewRow In dgvProductos.Rows
            If Not row.IsNewRow Then ' EVITA LA FILA DE NUEVO
                Dim precio As Decimal
                Dim cantidad As Decimal
                'ASEGURAMOS LOS INDICES DE LAS FILAS
                If Decimal.TryParse(row.Cells("Precio").Value.ToString(), precio) AndAlso
               Decimal.TryParse(row.Cells("Cantidad").Value.ToString(), cantidad) Then ' Cambiar Integer.TryParse a Decimal.TryParse
                    subtotal += precio * cantidad
                End If
            End If
        Next
        ' Actualizamos el subtotal
        txtSubTotal.Text = subtotal.ToString("F2") ' Formatear a dos decimales
    End Sub


    ' METODO PARA IR SUMANDO EL IVA DE LOS PRODUCTOS
    Private Sub CalcularIVA()
        Dim ivaTotal As Decimal = 0
        ' Sumar el IVA de los productos en el DGV
        For Each row As DataGridViewRow In dgvProductos.Rows
            If Not row.IsNewRow Then
                Dim precio As Decimal
                Dim cantidad As Decimal ' Cambiar a Decimal para manejar cantidades decimales
                Dim iva As Decimal
                ' Aseguramos los índices de las filas
                If Decimal.TryParse(row.Cells("Precio").Value.ToString(), precio) AndAlso
               Decimal.TryParse(row.Cells("Cantidad").Value.ToString(), cantidad) AndAlso
               Decimal.TryParse(row.Cells("IVA").Value.ToString(), iva) Then
                    Dim totalProducto As Decimal = precio * cantidad
                    Dim impuestoProducto As Decimal = totalProducto * (iva / 100)
                    ivaTotal += impuestoProducto
                End If
            End If
        Next
        ' Actualizamos el IVA
        txtIVA.Text = ivaTotal.ToString("F2") ' Formatear a dos decimales
    End Sub




    'METODO PARA IR SUMANDO EL TOTAL
    Private Sub CalcularTotal()
        Dim subtotal As Decimal
        Dim iva As Decimal
        ' Verifica el subtotal
        If Decimal.TryParse(txtSubTotal.Text, subtotal) Then
            ' Verifica el IVA
            If Decimal.TryParse(txtIVA.Text, iva) Then
                ' Calcula el total sumando el subtotal + IVA
                Dim total As Decimal = subtotal + iva
                txtTotal.Text = total.ToString("F2") ' Formatear a dos decimales
            Else
                txtTotal.Text = subtotal.ToString("F2") ' Solo subtotal si no hay IVA
            End If
        Else
            txtTotal.Text = "0.00" ' Si no hay que sumar, muestra 0
        End If
    End Sub




    'ESTE ANDA PERFECTO PARA FORMATO A4
    'METODO PARA GENERAR PDF DEL TICKET DE VENTAS
    Public Sub GenerarPDFTicket()
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim pdfPath As String = $"C:\Almasoft\captures\ticket_{timestamp}.pdf"
        Using writer As New PdfWriter(pdfPath)
            Using pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)
                document.SetMargins(10, 10, 10, 10) 'MARGENES AJUSTADOS PARA FORMATO TICKET

                'TÍTULO DEL TICKET
                Dim letra As String = ObtenerLetra() ' OBTIENE LA LETRA
                Dim title As New Paragraph($"TICKET DE VENTA   -   {letra}") ' AGREGA LA LETRA A LA DERECHA
                title.SetFontSize(14).SetBold().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                document.Add(title)

                ' DATOS DEL CLIENTE Y COMPROBANTE
                Dim cliente As String = $"Cliente: {txtNombreApellido.Text}"
                Dim puntoDeVenta As Integer = obtenerPuntoDeVenta()
                Dim comprobante As String = $"Comprobante: {obtenerComprobante()}"
                Dim dni As String = $"DNI: {txtDni.Text}"
                Dim condicionIVA As String = $"Condición IVA: {cbCondicionIva.Text}"
                Dim fecha As String = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}"

                'AGREGAR NOMBRE CLIENTE Y COMPROBANTE EN LA MISMA LINEA
                document.Add(New Paragraph($"{cliente}                                                                                        {comprobante}").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT))
                'AGREGAR DNI Y FECHA EN LA MISMA LINEA
                document.Add(New Paragraph($"{dni}                                                                                                  {fecha}").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT))
                'AGREGA EL CODIGO DE CLIENTE Y LA CONDICION DE IVA
                document.Add(New Paragraph($"Cod. Cliente: {txtCodigo.Text}"))
                document.Add(New Paragraph($"Condición IVA: {cbCondicionIva.Text}"))
                document.Add(New Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------"))
                ' TABLA DE PRODUCTOS
                Dim table As New Table(4) ' 4 columnas: Código, Producto, Cantidad, Total
                table.SetWidth(UnitValue.CreatePercentValue(100))

                ' AGREGAR ENCABEZADOS
                table.AddHeaderCell("CÓDIGO")
                table.AddHeaderCell("PRODUCTO")
                table.AddHeaderCell("CANT.")
                table.AddHeaderCell("TOTAL")

                ' AGREGAR LAS FILAS DEL DGV
                For Each row As DataGridViewRow In dgvProductos.Rows
                    If Not row.IsNewRow Then
                        table.AddCell(row.Cells(1).Value.ToString()) ' Código
                        table.AddCell(row.Cells(2).Value.ToString()) ' Nombre del producto
                        table.AddCell(row.Cells(4).Value.ToString()) ' Cantidad
                        table.AddCell(row.Cells(6).Value.ToString()) ' Total
                    End If
                Next

                document.Add(table)

                ' RESUMEN DE TOTALES
                document.Add(New Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------"))
                document.Add(New Paragraph($"SUBTOTAL: {txtSubTotal.Text}"))
                document.Add(New Paragraph($"IVA: {txtIVA.Text}"))
                document.Add(New Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------"))
                document.Add(New Paragraph($"TOTAL: {txtTotal.Text}"))
                document.Add(New Paragraph("-----------------------------------------------------------------------------------------------------------------------------------------------"))
                document.Add(New Paragraph("¡Gracias por su compra!").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER))

                document.Close()
            End Using
        End Using

        MessageBox.Show("Ticket generado correctamente en: " & pdfPath)

        ' ABRE EL PDF AUTOMÁTICAMENTE
        Try
            Process.Start(New ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

    'METODO PARA VALIDAR SI EL STOCK ES SUFICENTE EN LOS PRODUCTOS DEL DGV
    Private Function validarStockSuficiente() As Boolean
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' RECORRE TODAS LAS FILAS DEL DGV
            For Each row As DataGridViewRow In dgvProductos.Rows
                If Not row.IsNewRow Then
                    Dim codigoProducto As String = row.Cells(1).Value.ToString() ' CÓDIGO DEL PRODUCTO
                    Dim cantidadSolicitada As Decimal = Convert.ToDecimal(row.Cells(4).Value) ' CANTIDAD SOLICITADA PARA LA VENTA

                    ' CONSULTA SQL PARA OBTENER EL STOCK DISPONIBLE Y LA INFORMACIÓN DE VENTA POR PESO
                    Dim query As String = "SELECT Stock, VentaPorPeso FROM stProductos WHERE Codigo = @codigo"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@codigo", codigoProducto)

                        ' EJECUTA LA CONSULTA Y OBTIENE EL STOCK DISPONIBLE Y SI SE VENDE POR PESO
                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                Dim stockDisponible As Decimal = Convert.ToDecimal(reader("Stock"))
                                Dim ventaPorPeso As Boolean = Convert.ToBoolean(reader("VentaPorPeso"))

                                ' FORMATEO DEL STOCK SEGÚN SE VENDA POR PESO O NO
                                Dim stock As Object
                                If Not ventaPorPeso Then
                                    ' SI NO SE VENDE POR PESO, REDONDEAR A ENTERO
                                    stock = Math.Floor(stockDisponible) ' REDONDEAMOS HACIA ABAJO
                                Else
                                    ' SI SE VENDE POR PESO, MOSTRAR EL STOCK CON DECIMALES
                                    stock = stockDisponible.ToString() ' MANTENEMOS EL FORMATO ORIGINAL
                                End If

                                ' SI LA CANTIDAD SOLICITADA ES MAYOR AL STOCK DISPONIBLE, MOSTRAR MENSAJE
                                If cantidadSolicitada > stockDisponible Then
                                    ' PERSONALIZAR EL MENSAJE DE ALERTA
                                    Dim mensaje As String = String.Format(
                                    "Producto: {0}{1}Descripción: {2}{1}Stock disponible: {3}{1}{1}Cantidad solicitada: {4}{1}No se puede proceder con la venta.",
                                    codigoProducto, Environment.NewLine, row.Cells(2).Value.ToString(), stock, cantidadSolicitada)

                                    ' MOSTRAR EL MENSAJE Y DETENER LA VENTA
                                    MessageBox.Show(mensaje, "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Return False 'LA VENTA NO PUEDE CONTINUAR
                                End If
                            End If
                        End Using
                    End Using
                End If
            Next
        End Using

        ' LA VENTA PUEDE CONTINUAR
        Return True
    End Function




    'MÉTODO PARA OBTENER EL COMPROBANTE PARA EL TICKET
    Private Function obtenerComprobante() As String
        Dim comprobante As Integer = 0
        Dim letra As String = ObtenerLetra() ' OBTENER LA LETRA PARA LA CONSULTA
        Dim puntoDeVenta As Integer = obtenerPuntoDeVenta() ' OBTENER EL PUNTO DE VENTA

        Try
            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                ' OBTENER EL ULTIMO NUMERO DE COMPROBANTE SEGUN LA LETRA
                Dim query As String = "SELECT CASE WHEN @letra = 'A' THEN NumeracionFacturaA " &
                                      "WHEN @letra = 'B' THEN NumeracionFacturaB " &
                                      "WHEN @letra = 'C' THEN NumeracionFacturaC END AS Comprobante " &
                                      "FROM adConfiguraciones"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@letra", letra)
                    comprobante = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el número de comprobante: " & ex.Message)
        End Try

        Return $"{comprobante} - {puntoDeVenta}" ' RETORNA NRO COMPROBANTE Y PUNTO VENTA
    End Function

End Class