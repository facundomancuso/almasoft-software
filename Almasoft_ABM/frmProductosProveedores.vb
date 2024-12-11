Imports System.Globalization
Imports System.Threading
Imports Microsoft.Data.SqlClient


Public Class frmProductosProveedores
    Private Sub frmProductosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTABLECE SEPARADORES DECIMALES POR PUNTO Y NO POR COMA
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        'CARGA LA CONEXION
        Conexion.CargarCadenaConexion()
        'LLENA LA GRILLA PRODUCTOS
        CargarDatosProductos("WHERE P.Activo = 1")
    End Sub

    ' CARGAR DATOS DE PRODUCTOS EN EL DGV
    Private Sub CargarDatosProductos(ByVal filtro As String)
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
                             P.PorcentajeIVA as '% IVA',
                             P.VentaPorPeso
                             FROM stProductos P
                             INNER JOIN stFamilias F ON P.IDFamilia = F.ID
                             INNER JOIN stSubfamilias SF ON P.IDSubFamilia = SF.ID"

        ' CONSULTA CON FILTRO SI EXISTE
        If Not String.IsNullOrEmpty(filtro) Then
            consultaSQL &= " " & filtro
        End If

        ' ADAPTADOR Y DATASET PARA OBTENER LOS DATOS DE LA BASE
        Dim adaptador As New SqlDataAdapter(consultaSQL, Conexion.conexionSql)
        Dim dsProductos As New DataSet()
        adaptador.Fill(dsProductos, "stProductos")

        ' ASIGNAR EL DATATABLE AL DATAGRIDVIEW
        dgvProductos.DataSource = dsProductos.Tables("stProductos")

        ' HACER NO VISIBLES LAS COLUMNAS INNECESARIAS
        dgvProductos.Columns(0).Visible = False 'ID
        dgvProductos.Columns(2).Visible = False 'CODIGO BARRA
        dgvProductos.Columns(4).Visible = False 'ID FAMILIA
        dgvProductos.Columns(6).Visible = False 'ID SUBFAMILIA
        dgvProductos.Columns(8).Visible = False 'STOCK
        dgvProductos.Columns(9).Visible = False 'PRECIO UNITARIO
        dgvProductos.Columns(10).Visible = False    'ACTIVO
        dgvProductos.Columns(11).Visible = False    '% IVA
        dgvProductos.Columns(12).Visible = False    'VENTA POR PESO

        ' CAMBIAR LA FUENTE DEL DATAGRIDVIEW
        dgvProductos.DefaultCellStyle.Font = New Font("Arial", 8) ' TAMAÑO DE LA FUENTE
        dgvProductos.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8) ' AJUSTA LAS CABECERAS PRINCIPALES

        ' AJUSTAR EL TAMAÑO DE LAS COLUMNAS SEGÚN EL CONTENIDO
        dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        ' AJUSTAR LA ALTURA DE LAS CABECERAS PARA QUE SE ADAPTEN AL TAMAÑO DE LA FUENTE
        dgvProductos.AutoResizeColumnHeadersHeight()

        ' AQUI ES DONDE AGREGAMOS LAS COLUMNAS EN EL DATAGRIDVIEW DERECHO SI NO ESTÁN CARGADAS
        ' SI EL DGV DE PRODUCTOS RELACIONADOS NO TIENE COLUMNNAS, LAS AGREGA
        If dgvProductosRelacionados.Columns.Count = 0 Then
            For Each col As DataGridViewColumn In dgvProductos.Columns
                dgvProductosRelacionados.Columns.Add(col.Clone())
            Next
        End If

        ' ASIGNAR UN DataTable VACÍO COMO DataSource DEL dgvProductosRelacionados
        If dgvProductosRelacionados.DataSource Is Nothing Then
            Dim dtRelacionados As New DataTable()
            ' AGREGAR LAS MISMAS COLUMNAS QUE EL DGVPRODUCTOS
            For Each col As DataGridViewColumn In dgvProductos.Columns
                dtRelacionados.Columns.Add(col.HeaderText) ' USAR EL ENCABEZADO COMO NOMBRE DE COLUMNA
            Next
            dgvProductosRelacionados.DataSource = dtRelacionados
        End If

        ' CAMBIAR LA FUENTE AL DGV DE LA DERECHA (dgvProductosRelacionados)
        dgvProductosRelacionados.DefaultCellStyle.Font = New Font("Arial", 8) ' TAMAÑO DE LA FUENTE
        dgvProductosRelacionados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8) ' AJUSTA LAS CABECERAS PRINCIPALES

        ' AJUSTAR EL TAMAÑO DE LAS COLUMNAS SEGÚN EL CONTENIDO EN EL DGV DE LA DERECHA
        dgvProductosRelacionados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

        ' AJUSTAR LA ALTURA DE LAS CABECERAS PARA QUE SE ADAPTEN AL TAMAÑO DE LA FUENTE EN EL DGV DE LA DERECHA
        dgvProductosRelacionados.AutoResizeColumnHeadersHeight()

    End Sub


    'COMBOBOXS

    'COMBOBOX PROVEEDORES
    Public Sub CargarCBProveedores()
        ' SELECT A LOS PROVEEDORES
        Dim query As String = "SELECT ID, Codigo, Empresa, Firma, CUIT FROM prProveedores"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim Proveedores As New DataTable
        adaptadorSql.Fill(Proveedores)

        ' PARA COMBINAR DATOS
        Proveedores.Columns.Add("Descripcion", GetType(String))
        ' COMBINAR LOS CAMPOS
        For Each row As DataRow In Proveedores.Rows
            row("Descripcion") = row("Codigo").ToString() & ", " & row("Empresa").ToString() & ", " & row("Firma").ToString() & ", " & row("CUIT").ToString()
        Next

        ' CARGAMOS EL COMBOBOX
        cbProveedores.DataSource = Proveedores
        cbProveedores.DisplayMember = "Descripcion"
        cbProveedores.ValueMember = "ID"
        '
        'COMENTE ESTO PARA QUE SELECCIONE UN VALOR INICIAL
        'cbProveedores.SelectedIndex = -1 ' Esto evita una selección inicial

        ' VERIFICAR SI HAY UNA SELECCIÓN VÁLIDA EN EL COMBOBOX
        If cbProveedores.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cbProveedores.SelectedValue.ToString(), Nothing) Then
            Dim idProveedor As Integer = Convert.ToInt32(cbProveedores.SelectedValue)
            ' CARGAR LOS PRODUCTOS RELACIONADOS
            CargarCBProductosPorProveedor(idProveedor)
        End If
    End Sub


    ' COMBOBOX PRODUCTOS RELACIONADOS
    Public Sub CargarCBProductosPorProveedor(ByVal idProveedor As Integer)
        ' VERIFICA QUE HAYA SELECCIONADO UN PROVEEDOR EN EL COMBOBOX
        If cbProveedores.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' CONSULTA LOS PRODUCTOS RELACIONADOS CON EL PROVEEDOR SELECCIONADO
        Dim query As String = "SELECT p.ID AS IDProducto, 
                                      p.Codigo AS ProductoCodigo, 
                                      p.Descripcion AS ProductoDescripcion, 
                                      p.IDFamilia, 
                                      f.Familia AS Familia, 
                                      p.IDSubFamilia, 
                                      sf.SubFamilia AS SubFamilia
                                      FROM stProductosProveedor pp
                                      INNER JOIN stProductos p ON pp.IDProducto = p.ID
                                      INNER JOIN stFamilias f ON p.IDFamilia = f.ID
                                      INNER JOIN stSubFamilias sf ON p.IDSubFamilia = sf.ID
                                      WHERE pp.IDProveedor = @idProveedor"

        ' ADAPTADOR DE DATOS Y DATATABLE
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        adaptadorSql.SelectCommand.Parameters.AddWithValue("@IDProveedor", idProveedor)
        Dim productos As New DataTable

        ' LLENAMOS EL DATATABLE
        adaptadorSql.Fill(productos)

        ' AGREGAR LA COLUMNA DESCRIPCION
        productos.Columns.Add("Descripcion", GetType(String))

        ' COMBINAMOS LOS CAMPOS 
        For Each row As DataRow In productos.Rows
            row("Descripcion") = row("ProductoCodigo").ToString() & " - " & row("ProductoDescripcion").ToString() & ", " &
                                 row("Familia").ToString() & " - " & row("SubFamilia").ToString()
        Next

        'CARGA EL COMBOBOX CON LOS PRODUCTOS
        cbProductosProveedor.DataSource = productos
        cbProductosProveedor.DisplayMember = "Descripcion"
        cbProductosProveedor.ValueMember = "IDProducto"
        '' SELECCIONAR EL PRIMER PRODUCTO POR DEFECTO
        'If productos.Rows.Count > 0 Then
        '    cbProductosProveedor.SelectedIndex = 0 ' Establece el primer producto como seleccionado
        'End If
    End Sub

    'CIERRA EL FORMULARIO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'PASA DATOS DEL DGVPRODUCTOS AL DGVPRODUCTOSRELACIONADOS
    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        ' VERIFICA QUE HAYA UNA FILA EN EL DGV
        If dgvProductos.SelectedRows.Count > 0 Then
            ' OBTIENE LA FILA SELECCIONADA
            Dim filaSeleccionada As DataGridViewRow = dgvProductos.SelectedRows(0)

            ' QUE EL DATASOURCE DE DGVPRODUCTOSRELACIONADOS NO SEA NOTHING
            If dgvProductosRelacionados.DataSource IsNot Nothing Then
                ' OBTENER EL DATATABLE
                Dim dtDerecha As DataTable = CType(dgvProductosRelacionados.DataSource, DataTable)

                ' VERIFICA SI EL PRODUCTO YA ESTÁ EN DGVPRODUCTOSRELACIONADOS
                Dim productoYaRelacionado As Boolean = False
                For Each row As DataRow In dtDerecha.Rows
                    If row("ID") = filaSeleccionada.Cells("ID").Value Then
                        productoYaRelacionado = True
                        Exit For
                    End If
                Next

                If productoYaRelacionado Then
                    ' YA ESTÁ, MENSAJE DE ADVERTENCIA
                    MessageBox.Show("Este producto ya está relacionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' NO ESTÁ, COPIA LA FILA
                    Dim nuevaFila As DataRow = dtDerecha.NewRow()

                    ' COPIA LOS VALORES DE LA FILA
                    For i As Integer = 0 To filaSeleccionada.Cells.Count - 1
                        nuevaFila(i) = filaSeleccionada.Cells(i).Value
                    Next

                    ' AGG LA NUEVA FILA
                    dtDerecha.Rows.Add(nuevaFila)

                    ' REMOVER LA FILA DEL DGV DE PRODUCTOS ORIGINALES
                    Dim dtIzquierda As DataTable = CType(dgvProductos.DataSource, DataTable)
                    dtIzquierda.Rows.Remove(CType(filaSeleccionada.DataBoundItem, DataRowView).Row)
                End If
            Else
                MessageBox.Show("El DataGridView de productos relacionados no tiene datos vinculados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' NO SE SELECCIONÓ NINGUNA FILA
            MessageBox.Show("Por favor, seleccione un producto para agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'ELIMINA EL REGISTO DE LA DGVPRODUCTOSRELACIONADOS
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' VERIFICA SI HAY ALGUNA FILA SELECCIONADA
        If dgvProductosRelacionados.SelectedRows.Count > 0 Then
            ' OBTIENE LA FILA SELECCIONADA
            Dim filaSeleccionada As DataGridViewRow = dgvProductosRelacionados.SelectedRows(0)

            ' CONFIRMA SI EL USUARIO QUIERE ELIMINAR LA FILA
            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                ' OBTIENE EL DataTable DE dgvProductosRelacionados Y ELIMINA LA FILA SELECCIONADA
                Dim dtDerecha As DataTable = CType(dgvProductosRelacionados.DataSource, DataTable)
                Dim nuevaFila As DataRow = CType(filaSeleccionada.DataBoundItem, DataRowView).Row

                ' AGREGAR LA FILA AL DataTable DE dgvProductos (izquierda)
                Dim dtIzquierda As DataTable = CType(dgvProductos.DataSource, DataTable)
                Dim filaRestaurada As DataRow = dtIzquierda.NewRow()

                ' COPIAR LOS VALORES A LA NUEVA FILA EN EL DataTable IZQUIERDO
                For i As Integer = 0 To nuevaFila.ItemArray.Length - 1
                    filaRestaurada(i) = nuevaFila(i)
                Next
                dtIzquierda.Rows.Add(filaRestaurada)

                ' REMOVER LA FILA SELECCIONADA DEL DataTable DERECHA
                dtDerecha.Rows.Remove(nuevaFila)
            End If
        Else
            ' MENSAJE DE ADVERTENCIA, NO SE SELECCIONO NINGUNA FILA
            MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' VERIFICA QUE SE HAYA SELECCIONADO UN PROVEEDOR EN EL CBPROVEEDORES
        If cbProveedores.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ID DEL PROVEEDOR SELECCIONADO
        Dim idProveedor As Integer = Convert.ToInt32(cbProveedores.SelectedValue)

        ' VERIFICAR SI HAY RELACIONES EXISTENTES PARA EL PROVEEDOR
        Dim tieneRelaciones As Boolean = False
        Conexion.CargarCadenaConexion()
        Dim consultaRelacion As String = "SELECT COUNT(*) FROM stProductosProveedor WHERE IDProveedor = @IDProveedor"

        Using conexion As New SqlConnection(conexionSql.ConnectionString)
            Using cmd As New SqlCommand(consultaRelacion, conexion)
                cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)
                conexion.Open()
                tieneRelaciones = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using

        ' SI EXISTEN RELACIONES Y EL DGV ESTÁ VACÍO, MOSTRAR ADVERTENCIA
        If tieneRelaciones AndAlso dgvProductosRelacionados.Rows.Count = 0 Then
            Dim result As DialogResult = MessageBox.Show("Esto vaciará todas las relaciones. ¿Está seguro de continuar?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Return
            End If
        End If

        ' SI EL DGV DE PRODUCTOS TIENE FILAS O EL USUARIO CONFIRMÓ VACÍO
        If dgvProductosRelacionados.Rows.Count > 0 OrElse tieneRelaciones Then
            ' CONFIRMACION PARA BORRAR REGISTROS ANTERIORES
            Dim result As DialogResult = MessageBox.Show("Las relaciones serán actualizadas, ¿desea continuar?", "Almasoft - Productos-Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' ABRIR LA CONEXION A LA DB
                Try
                    Using connection As New SqlConnection(conexionSql.ConnectionString)
                        connection.Open()
                        Using cmd As New SqlCommand()
                            cmd.Connection = connection
                            cmd.CommandType = CommandType.Text

                            ' 1. CONSULTAR LOS PRODUCTOS YA RELACIONADOS CON EL PROVEEDOR
                            Dim productosRelacionados As New List(Of Integer)()
                            cmd.CommandText = "SELECT IDProducto FROM stProductosProveedor WHERE IDProveedor = @IDProveedor"
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)

                            ' LEEMOS LOS PRODUCTOS RELACIONADOS
                            Using reader As SqlDataReader = cmd.ExecuteReader()
                                While reader.Read()
                                    productosRelacionados.Add(reader.GetInt32(0))  ' AÑADIMOS LOS IDS DE LOS PRODUCTOS YA RELACIONADOS
                                End While
                            End Using

                            ' 2. COMPROBAR LOS PRODUCTOS EN EL DGV Y ACTUALIZAR LA DB
                            For Each row As DataGridViewRow In dgvProductosRelacionados.Rows
                                ' SALTAR LAS FILAS VACIAS (SI LAS HAY)
                                If row.IsNewRow Then Continue For

                                ' OBTENER EL ID DEL PRODUCTO DE LA FILA
                                Dim idProducto As Integer = Convert.ToInt32(row.Cells("ID").Value)

                                ' SI EL PRODUCTO NO ESTA EN LA BASE DE DATOS PERO ESTÁ EN EL DGV, LO INSERTAMOS
                                If Not productosRelacionados.Contains(idProducto) Then
                                    ' INSERTAR DATOS
                                    cmd.CommandText = "INSERT INTO stProductosProveedor (IDProducto, IDProveedor, Costo) VALUES (@IDProducto, @IDProveedor, @Costo)"
                                    cmd.Parameters.Clear()
                                    cmd.Parameters.AddWithValue("@IDProducto", idProducto)
                                    cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)
                                    cmd.Parameters.AddWithValue("@Costo", 0.00) ' ASIGNAMOS UN COSTO DE 0.00 POR DEFECTO
                                    cmd.ExecuteNonQuery()
                                End If
                            Next

                            ' 3. ELIMINAR LOS PRODUCTOS QUE ESTAN EN LA BASE DE DATOS PERO NO ESTAN EN EL DGV
                            For Each idProducto In productosRelacionados
                                Dim encontrado As Boolean = False

                                ' VERIFICAMOS SI EL PRODUCTO ESTÁ EN EL DGV
                                For Each row As DataGridViewRow In dgvProductosRelacionados.Rows
                                    If row.IsNewRow Then Continue For
                                    If Convert.ToInt32(row.Cells("ID").Value) = idProducto Then
                                        encontrado = True
                                        Exit For
                                    End If
                                Next

                                ' SI EL PRODUCTO NO ESTA EN EL DGV, LO ELIMINAMOS DE LA BASE DE DATOS
                                If Not encontrado Then
                                    cmd.CommandText = "DELETE FROM stProductosProveedor WHERE IDProducto = @IDProducto AND IDProveedor = @IDProveedor"
                                    cmd.Parameters.Clear()
                                    cmd.Parameters.AddWithValue("@IDProducto", idProducto)
                                    cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)
                                    cmd.ExecuteNonQuery()
                                End If
                            Next

                            ' CARTEL DE CONFIRMACION EXITOSO
                            MessageBox.Show("Los productos fueron relacionados exitosamente con el proveedor.", "Almasoft - Productos-Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarCBProductosPorProveedor(idProveedor)
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al guardar los datos: " & ex.Message, "Almasoft - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("El proceso ha sido cancelado.", "Almasoft - Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No hay productos seleccionados para relacionar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedores.SelectedIndexChanged
        ' LIMPIA LAS TABLAS AL CAMBIAR EL PROVEEDOR SELECCIONADO
        dgvProductos.DataSource = Nothing
        dgvProductosRelacionados.DataSource = Nothing

        ' VERIFICAR QUE HAYA UN PROVEEDOR SELECCIONADO Y QUE NO SEA NADA
        Dim idProveedor As Integer = 0
        If cbProveedores.SelectedValue IsNot Nothing AndAlso TypeOf cbProveedores.SelectedValue Is Integer Then
            idProveedor = Convert.ToInt32(cbProveedores.SelectedValue)

            ' CARGAR PRODUCTOS RELACIONADOS (DERECHA)
            Dim dtRelacionados As New DataTable()
            Conexion.CargarCadenaConexion()
            Dim consultaRelacionados As String = "SELECT P.ID, P.Codigo, P.Descripcion, F.Familia AS Familia " &
                                             "FROM stProductosProveedor SP " &
                                             "INNER JOIN stProductos P ON SP.IDProducto = P.ID " &
                                             "INNER JOIN stFamilias F ON P.IDFamilia = F.ID " &
                                             "WHERE SP.IDProveedor = @IDProveedor"

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using cmd As New SqlCommand(consultaRelacionados, conexion)
                    cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)
                    Dim adaptador As New SqlDataAdapter(cmd)
                    adaptador.Fill(dtRelacionados)
                End Using
            End Using

            ' ASIGNAR LOS PRODUCTOS RELACIONADOS A LA TABLA DERECHA
            dgvProductosRelacionados.DataSource = dtRelacionados
            ' OCULTAR LA COLUMNA ID
            If dgvProductosRelacionados.Columns("ID") IsNot Nothing Then
                dgvProductosRelacionados.Columns("ID").Visible = False
            End If

            ' AJUSTAR EL TAMAÑO DE LAS COLUMNAS
            For Each column As DataGridViewColumn In dgvProductosRelacionados.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            ' CARGAR PRODUCTOS NO RELACIONADOS (IZQUIERDA)
            Dim dtNoRelacionados As New DataTable()
            Dim consultaNoRelacionados As String = "SELECT P.ID, P.Codigo, P.Descripcion, F.Familia AS Familia " &
                                               "FROM stProductos P " &
                                               "INNER JOIN stFamilias F ON P.IDFamilia = F.ID " &
                                               "WHERE P.ID NOT IN (SELECT IDProducto FROM stProductosProveedor WHERE IDProveedor = @IDProveedor)"

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using cmd As New SqlCommand(consultaNoRelacionados, conexion)
                    cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)
                    Dim adaptador As New SqlDataAdapter(cmd)
                    adaptador.Fill(dtNoRelacionados)
                End Using
            End Using

            ' ASIGNAR LOS PRODUCTOS NO RELACIONADOS A LA TABLA IZQUIERDA
            dgvProductos.DataSource = dtNoRelacionados
            ' OCULTAR LA COLUMNA ID
            If dgvProductos.Columns("ID") IsNot Nothing Then
                dgvProductos.Columns("ID").Visible = False
            End If

            ' AJUSTAR EL TAMAÑO DE LAS COLUMNAS
            For Each column As DataGridViewColumn In dgvProductos.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

            ' ACTUALIZAR EL COMBOBOX DE PRODUCTOS RELACIONADOS
            ActualizarProductosRelacionadosComboBox(idProveedor)
        Else
            ' SI NO HAY NINGÚN PROVEEDOR SELECCIONADO, CARGAR TODOS LOS PRODUCTOS EN LA IZQUIERDA Y VACÍO EN LA DERECHA
            CargarTodosLosProductos()
            dgvProductosRelacionados.DataSource = Nothing
            cbProductosProveedor.DataSource = Nothing
        End If
    End Sub

    ' MÉTODO PARA CARGAR LOS PRODUCTOS RELACIONADOS EN EL COMBOBOX
    'FIJATE QUE YA HAY UN METODO COMO ESTE, TAMOS REPITIENDO CODIGO xd
    Private Sub ActualizarProductosRelacionadosComboBox(idProveedor As Integer)
        Dim dtProductosRelacionados As New DataTable()
        Dim consultaProductosRelacionados As String = "SELECT P.ID AS IDProducto, P.Codigo + ' - ' + P.Descripcion AS Producto " &
                                                  "FROM stProductosProveedor SP " &
                                                  "INNER JOIN stProductos P ON SP.IDProducto = P.ID " &
                                                  "WHERE SP.IDProveedor = @IDProveedor"

        Using conexion As New SqlConnection(conexionSql.ConnectionString)
            Using cmd As New SqlCommand(consultaProductosRelacionados, conexion)
                cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(dtProductosRelacionados)
            End Using
        End Using

        ' ASIGNAR EL DATATABLE AL COMBOBOX DE PRODUCTOS RELACIONADOS
        cbProductosProveedor.DataSource = dtProductosRelacionados
        cbProductosProveedor.DisplayMember = "Producto"
        cbProductosProveedor.ValueMember = "IDProducto"
        'QUITO ESTA LINEA PARA QUE SELECCIONE UN PRODUCTO INICALMENTE
        'cbProductosProveedor.SelectedIndex = -1 ' Opcional: para no seleccionar ningún producto inicialmente
    End Sub


    ' MÉTODO PARA CARGAR TODOS LOS PRODUCTOS EN LA TABLA IZQUIERDA
    Private Sub CargarTodosLosProductos()
        Dim dtTodosProductos As New DataTable()
        Conexion.CargarCadenaConexion()
        Dim consultaTodosProductos As String = "SELECT P.ID, P.Codigo, P.Descripcion, F.Familia AS Familia " &
                                           "FROM stProductos P " &
                                           "INNER JOIN stFamilias F ON P.IDFamilia = F.ID"

        Using conexion As New SqlConnection(conexionSql.ConnectionString)
            Using cmd As New SqlCommand(consultaTodosProductos, conexion)
                Dim adaptador As New SqlDataAdapter(cmd)
                adaptador.Fill(dtTodosProductos)
            End Using
        End Using

        dgvProductos.DataSource = dtTodosProductos
        ' OCULTAR LA COLUMNA ID
        If dgvProductos.Columns("ID") IsNot Nothing Then
            dgvProductos.Columns("ID").Visible = False
        End If

        ' AJUSTAR EL TAMAÑO DE LAS COLUMNAS
        For Each column As DataGridViewColumn In dgvProductos.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' VERIFICA QUE SE HAYA SELECCIONADO UN PROVEEDOR
        If cbProveedores.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, seleccione un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' OBTIENE EL ID DEL PROVEEDOR SELECCIONADO
        Dim idProveedor As Integer = Convert.ToInt32(cbProveedores.SelectedValue)

        ' VERIFICA QUE SE HAYA SELECCIONADO UN PRODUCTO
        If cbProductosProveedor.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor, seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'OBTIENE EL ID DEL PRODUCTO SELECCIONADO
        Dim idProducto As Integer = Convert.ToInt32(cbProductosProveedor.SelectedValue)

        ' VERIFICA QUE EL PRECIO INGRESADO SEA VÁLIDO
        Dim precioUnitario As Decimal
        If Not Decimal.TryParse(txtPrecioUnitario.Text, precioUnitario) Then
            MessageBox.Show("Por favor, ingrese un precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' CONFIRMA SI EL USUARIO DESEA ACTUALIZAR EL PRECIO
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea actualizar el costo para este producto?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' ACTUALIZA EL COSTO DEL PRODUCTO EN LA TABLA STPRODUCTOSPROVEEDOR
            Try
                ' ABRE LA CONEXIÓN
                Conexion.CargarCadenaConexion()
                Using conexion As New SqlConnection(conexionSql.ConnectionString)
                    Using cmd As New SqlCommand()
                        cmd.Connection = conexion
                        cmd.CommandType = CommandType.Text

                        ' CONSULTA SQL
                        cmd.CommandText = "UPDATE stProductosProveedor SET Costo = @Costo WHERE IDProducto = @IDProducto AND IDProveedor = @IDProveedor"

                        ' AGG LOS PARAMETROS
                        cmd.Parameters.AddWithValue("@Costo", precioUnitario)
                        cmd.Parameters.AddWithValue("@IDProducto", idProducto)
                        cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)

                        ' ABRIMOS LA CONEXION Y EJECUTAMOS EL COMANDO
                        conexion.Open()
                        cmd.ExecuteNonQuery()

                        ' MENSAJE DE CONFIRMACIÓN EXITOSA
                        MessageBox.Show("El costo fue actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End Using
                End Using
            Catch ex As Exception
                'ERROR
                MessageBox.Show("Ocurrió un error al actualizar el costo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cbProductosProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductosProveedor.SelectedIndexChanged
        ' LIMPIAR EL TEXTBOX DE PRECIO UNITARIO
        txtPrecioUnitario.Clear()

        ' VERIFICAR QUE HAYA ELEMENTOS SELECCIONADOS EN LOS COMBOBOX
        If cbProductosProveedor.SelectedValue IsNot Nothing And cbProveedores.SelectedValue IsNot Nothing Then
            ' OBTENER LOS ID DE PRODUCTO Y PROVEEDOR
            Dim idProducto As Integer = Convert.ToInt32(CType(cbProductosProveedor.SelectedItem, DataRowView)("IDProducto"))
            Dim idProveedor As Integer = Convert.ToInt32(cbProveedores.SelectedValue)

            ' CONSULTA PARA VERIFICAR SI EL PRODUCTO YA ESTÁ RELACIONADO CON EL PROVEEDOR
            Conexion.CargarCadenaConexion()
            Dim consultaRelacion As String = "SELECT Costo FROM stProductosProveedor WHERE IDProducto = @IDProducto AND IDProveedor = @IDProveedor"

            Using conexion As New SqlConnection(conexionSql.ConnectionString)
                Using cmd As New SqlCommand(consultaRelacion, conexion)
                    cmd.Parameters.AddWithValue("@IDProducto", idProducto)
                    cmd.Parameters.AddWithValue("@IDProveedor", idProveedor)

                    conexion.Open()
                    Dim precioExistente As Object = cmd.ExecuteScalar()

                    ' SI EL PRODUCTO YA ESTÁ RELACIONADO, MANTENER EL PRECIO ACTUAL EN txtPrecioUnitario
                    If precioExistente IsNot Nothing Then
                        ' El producto ya está relacionado; no modificar el precio actual
                        If String.IsNullOrEmpty(txtPrecioUnitario.Text) Then
                            txtPrecioUnitario.Text = precioExistente.ToString()
                        End If
                    Else
                        ' Si el producto no está relacionado, establecer precio predeterminado de 0.00
                        txtPrecioUnitario.Text = "0.00"
                    End If
                End Using
            End Using
        End If
    End Sub

    ' METODO PARA PERMITIR VALORES NUMEROS Y SOLO UN PUNTO EN TXTPRECIOUNITARIO
    Private Sub txtPrecioUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioUnitario.KeyPress
        ' PERMITIR BORRAR CON LA TECLA BACKSPACE
        If Asc(e.KeyChar) = 8 Then
            Return
        End If

        ' PERMITIR SOLO NUMEROS (0-9)
        If Not Char.IsDigit(e.KeyChar) Then
            ' PERMITIR UN SOLO PUNTO DECIMAL
            If e.KeyChar = "." AndAlso Not txtPrecioUnitario.Text.Contains(".") Then
                Return ' PERMITE EL PUNTO DECIMAL SOLO SI NO HAY UNO EN EL TEXTO
            End If

            ' SI NO ES UN NUMERO NI UN PUNTO, EVITAR LA TECLA
            e.Handled = True
        End If

        ' LIMITAR LA CANTIDAD DE DIGITOS ANTES Y DESPUES DEL PUNTO DECIMAL
        If txtPrecioUnitario.Text.Contains(".") Then
            ' PERMITIR SOLO 2 DIGITOS DESPUES DEL PUNTO DECIMAL
            If txtPrecioUnitario.Text.Split(".")(1).Length >= 2 Then
                If Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        End If

        ' LIMITAR LA CANTIDAD DE DIGITOS ANTES DEL PUNTO DECIMAL (8 DIGITOS)
        If txtPrecioUnitario.Text.Length >= 8 Then
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'ACTIVA O DESACTIVA EL TXTPRECIOUNITARIO
        If txtPrecioUnitario.Enabled = True Then
            txtPrecioUnitario.Enabled = False
        Else
            txtPrecioUnitario.Enabled = True
            txtPrecioUnitario.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class