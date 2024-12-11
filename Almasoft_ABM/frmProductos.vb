Imports System.IO
Imports System.Reflection
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore.DbLoggerCategory.Database

Public Class frmProductos

    'VARIABLE PARA VALIDACIÓN DE NO REPETIR CÓDIGO DE PRODUCTOS
    Public idProductoActual As Integer = -1

    'DESACTIVA LOS CONTROLES
    Public Sub desactivarControles()
        txtCodigo.Enabled = False
        txtCodigoBarra.Enabled = False
        txtDescripcion.Enabled = False
        cbFamilia.Enabled = False
        cbSubFamilia.Enabled = False
        txtStock.Enabled = False
        txtPrecioUnitario.Enabled = False
        txtPorcentajeIVA.Enabled = False
        gpVentaPorPeso.Enabled = False
        gpActivo.Enabled = False
    End Sub
    'ACTIVA LOS CONTROLES
    Public Sub activarControles()
        txtCodigo.Enabled = True
        txtCodigoBarra.Enabled = True
        txtDescripcion.Enabled = True
        cbFamilia.Enabled = True
        cbSubFamilia.Enabled = True
        txtStock.Enabled = True
        txtPrecioUnitario.Enabled = True
        txtPorcentajeIVA.Enabled = True
        gpVentaPorPeso.Enabled = True
        gpActivo.Enabled = True
    End Sub
    'LOAD
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTIVA O DESACTIVA CONTROLES
        Conexion.CargarCadenaConexion()
        If lblTarea.Text = "Ver producto" Then
            desactivarControles()
        Else
            activarControles()
        End If
        If lblTarea.Text = "Nuevo producto" Then
            rbSiActivo.Checked = True
            rbNo.Checked = True
        End If

        'LIMITES DE CARACTERES PARA LOS TXT
        txtCodigo.MaxLength = 9
        txtCodigoBarra.MaxLength = 30
        txtDescripcion.MaxLength = 255

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'FRONT
        'MINIMIZA EL FORMULARIO
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'VERIFICA EL LBLTAREA PARA VERIFICAR EL FUNCIONAMIENTO
        If lblTarea.Text = "Nuevo producto" Then
            NuevoProducto()
        ElseIf lblTarea.Text = "Editar producto" Then
            EditarProducto()
        End If
    End Sub
    Public Sub NuevoProducto()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If
        ' VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
        If CodigoExiste(txtCodigo.Text, idProductoActual) Then
            MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If
        ' SI NO ES UN PRODUCTO QUE SE VENDA POR PESO Y TIENE STOCK DECIMAL
        If rbNo.Checked AndAlso txtStock.Text.Contains(".") Then
            MessageBox.Show("Valor de stock inválido.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStock.Focus()
            Exit Sub
        End If


        'REALIZAMOS EL INSERT DEL NUEVO PRODUCTO A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES
            'Dim activo As Integer = If(chSi.Checked, "1", "0")
            Dim imageData As Byte() = Nothing
            'Dim stock As Decimal

            ' Si hay una imagen en el PictureBox, la convierte en un arreglo de bytes
            If pbProducto.Image IsNot Nothing Then
                Dim imageStream As New MemoryStream()
                pbProducto.Image.Save(imageStream, Imaging.ImageFormat.Png)
                imageData = imageStream.ToArray()
            End If




            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                'EJECUCION DEL INSERT A LA BASE
                Using command As New SqlCommand("INSERT INTO dbo.stProductos (Codigo, CodigoBarra, Descripcion, IDFamilia, IDSubFamilia, Stock, PrecioUnitario, Activo, Imagen, PorcentajeIVA, VentaPorPeso)
                                             VALUES (@codigo, @codigobarra, @descripcion, @idfamilia, @idsubfamilia, @stock, @preciounitario, @activo, @imagen, @PorcentajeIVA, @VentaPorPeso)", connection)

                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                    command.Parameters.AddWithValue("@CodigoBarra", txtCodigoBarra.Text)
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    command.Parameters.AddWithValue("@IDFamilia", cbFamilia.SelectedValue)
                    command.Parameters.AddWithValue("@IDSubFamilia", cbSubFamilia.SelectedValue)
                    command.Parameters.AddWithValue("@Stock", txtStock.Text)
                    command.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnitario.Text)
                    'DEFINE SI EL PRODUCTO ESTA ACTIVO O NO
                    If rbSiActivo.Checked Then
                        command.Parameters.AddWithValue("@Activo", 1)
                    ElseIf rbNoActivo.Checked Then
                        command.Parameters.AddWithValue("@Activo", 0)
                    Else
                        'MENSAJE PARA QUE SELECCIONE UNA OPCIÓN
                        MessageBox.Show("Debe seleccionar si el producto está activo ('Sí' o 'No').", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        'DETIENE LA CARGA
                        Exit Sub
                    End If
                    'command.Parameters.AddWithValue("@Activo", activo)
                    command.Parameters.AddWithValue("@PorcentajeIVA", txtPorcentajeIVA.Text)
                    'AGREGA LA IMAGEN COMO PARÁMETRO, SI EXISTE, O DBNULL EN CASO CONTRARIO
                    If imageData IsNot Nothing Then
                        command.Parameters.Add("@Imagen", SqlDbType.Image).Value = imageData
                    Else
                        command.Parameters.Add("@Imagen", SqlDbType.Image).Value = DBNull.Value
                    End If
                    'DEFINE SI EL PRODUCTO SE VENDE POR PESO O NO
                    If rbSi.Checked Then
                        command.Parameters.AddWithValue("@VentaPorPeso", 1)
                    ElseIf rbNo.Checked Then
                        command.Parameters.AddWithValue("@VentaPorPeso", 0)
                    Else
                        'MENSAJE PARA QUE SELECCIONE UNA OPCIÓN
                        MessageBox.Show("Debe seleccionar si el producto se vende por peso ('Sí' o 'No').", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        'DETIENE LA CARGA
                        Exit Sub
                    End If
                    command.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Se agregó correctamente el nuevo producto", vbOKOnly + vbInformation, "Almasoft - Nuevo Producto")
        Catch ex As Exception
            MessageBox.Show("Error al intentar agregar un nuevo producto: " & ex.Message)
        End Try
        'CERRAMOS FORM Y RECARGAMOS LA GRILLA
        frmMenu.abrirFrm(Of frmGrillaProductos)()
        Me.Close()
    End Sub
    Public Sub EditarProducto()

        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If
        ' VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
        If CodigoExiste(txtCodigo.Text, idProductoActual) Then
            MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If
        ' SI NO ES UN PRODUCTO QUE SE VENDA POR PESO Y TIENE STOCK DECIMAL
        If rbNo.Checked AndAlso txtStock.Text.Contains(".") Then
            MessageBox.Show("Valor de stock inválido.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStock.Focus()
            Exit Sub
        End If
        'REALIZAMOS EL UPDATE DEL PRODUCTO A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES
            'Dim activo As String = If(chSi.Checked, "1", "0")
            Dim imageData As Byte() = Nothing

            ' Si hay una imagen en el PictureBox, la convierte en un arreglo de bytes
            If pbProducto.Image IsNot Nothing Then
                Dim imageStream As New MemoryStream()
                pbProducto.Image.Save(imageStream, Imaging.ImageFormat.Png)
                imageData = imageStream.ToArray()
            End If

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()
                'EJECUCION DEL UPDATE A LA BASE
                Using command As New SqlCommand("UPDATE dbo.stProductos
                                            SET Codigo = @Codigo, 
                                                CodigoBarra = @CodigoBarra, 
                                                Descripcion = @Descripcion, 
                                                IDFamilia = @IDFamilia,
                                                IDSubFamilia = @IDSubFamilia,
                                                Stock = @Stock, 
                                                PrecioUnitario = @PrecioUnitario,
                                                Activo = @Activo,
                                                Imagen = @Imagen,
                                                PorcentajeIVA = @PorcentajeIVA,
                                                VentaPorPeso = @VentaPorPeso
                                             WHERE ID = @ID", connection)

                    command.Parameters.AddWithValue("@ID", lblID.Text)
                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                    command.Parameters.AddWithValue("@CodigoBarra", txtCodigoBarra.Text)
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    command.Parameters.AddWithValue("@IDFamilia", cbFamilia.SelectedValue)
                    command.Parameters.AddWithValue("@IDSubFamilia", cbSubFamilia.SelectedValue)
                    command.Parameters.AddWithValue("@Stock", txtStock.Text)
                    command.Parameters.AddWithValue("@PrecioUnitario", txtPrecioUnitario.Text)
                    'command.Parameters.AddWithValue("@Activo", activo)

                    'DEFINE SI EL PRODUCTO ESTA ACTIVO O NO
                    If rbSiActivo.Checked Then
                        command.Parameters.AddWithValue("@Activo", 1)
                    ElseIf rbNoActivo.Checked Then
                        command.Parameters.AddWithValue("@Activo", 0)
                    Else
                        'MENSAJE PARA QUE SELECCIONE UNA OPCIÓN
                        MessageBox.Show("Debe seleccionar si el producto está activo ('Sí' o 'No').", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        'DETIENE LA CARGA
                        Exit Sub
                    End If

                    command.Parameters.AddWithValue("@PorcentajeIVA", txtPorcentajeIVA.Text)

                    'AGREGA LA IMAGEN COMO PARÁMETRO, SI EXISTE, O DBNULL EN CASO CONTRARIO
                    If imageData IsNot Nothing Then
                        command.Parameters.Add("@Imagen", SqlDbType.Image).Value = imageData
                    Else
                        command.Parameters.Add("@Imagen", SqlDbType.Image).Value = DBNull.Value
                    End If

                    'DEFINE SI EL PRODUCTO SE VENDE POR PESO O NO
                    If rbSi.Checked Then
                        command.Parameters.AddWithValue("@VentaPorPeso", 1)
                    ElseIf rbNo.Checked Then
                        command.Parameters.AddWithValue("@VentaPorPeso", 0)
                    Else
                        'MENSAJE PARA QUE SELECCIONE UNA OPCIÓN
                        MessageBox.Show("Debe seleccionar si el producto se vende por peso ('Sí' o 'No').", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        'DETIENE LA CARGA
                        Exit Sub
                    End If

                    command.ExecuteNonQuery()

                End Using
            End Using
            MsgBox("Se editó correctamente el producto", vbOKOnly + vbInformation, "Almasoft - Editar Producto")
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar el producto: " & ex.Message)
        End Try
        'CERRAMOS FORM Y RECARGAMOS LA GRILLA
        frmMenu.abrirFrm(Of frmGrillaProductos)()
        Me.Close()
    End Sub
    ' COMBOBOXS
    Public Sub Familias()
        ' SELECT A LAS FAMILIAS Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Codigo, Familia FROM stFamilias"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim Familias As New DataTable
        adaptadorSql.Fill(Familias)
        ' TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
        cbFamilia.DataSource = Familias
        cbFamilia.DisplayMember = "Familia"
        cbFamilia.ValueMember = "ID"
    End Sub
    Public Sub SubFamilias(ByVal IDFamilia As Integer)
        ' CONSULTA SOLO LAS SUBFAMILIAS RELACIONADAS CON LA FAMILIA SELECCIONADA
        Dim query As String = "SELECT ID, IDFamilia, Codigo, Subfamilia FROM stSubfamilias WHERE IDFamilia = @IDFamilia"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        adaptadorSql.SelectCommand.Parameters.AddWithValue("@IDFamilia", IDFamilia)
        Dim Subfamilias As New DataTable
        adaptadorSql.Fill(Subfamilias)
        ' TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
        cbSubFamilia.DataSource = Subfamilias
        cbSubFamilia.DisplayMember = "Subfamilia"
        cbSubFamilia.ValueMember = "ID"
    End Sub
    'ACTUALIZA EL CB DE SUBFAMILIAS CUANDO CAMBIA EL CB DE FAMILIAS
    Private Sub cbFamilia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFamilia.SelectedIndexChanged
        'ASEGURARSE QUE HAYA UN VALOR ASIGNADO
        If cbFamilia.SelectedValue IsNot Nothing Then
            'OBTENGO EL ID COMO ENTERO
            Dim idFamilia As Integer
            If Integer.TryParse(cbFamilia.SelectedValue.ToString(), idFamilia) Then
                'ACTUALIZA EL CB DE SUBFAMILIA
                SubFamilias(idFamilia)
            End If
        End If
    End Sub
    'METODO PARA IMPEDIR CAMPOS VACIOS
    Public Sub condicionTxtLlenos()
        'LIMPIO VARIABLES
        modUtilidades.limpiarVariables()
        'METODO PARA IMPEDIR CAMPOS VACIOS
        Dim camposRequeridos As New Dictionary(Of TextBox, String) From {
        {txtCodigo, "Código"},
        {txtCodigoBarra, "Nombre"},
        {txtDescripcion, "Apellido"},
        {txtStock, "DNI"},
        {txtPrecioUnitario, "E-mail"},
        {txtPorcentajeIVA, "Porcentaje IVA"}
        }
        For Each campo In camposRequeridos
            If campo.Key.Text = "" Then
                bandera = True
                MessageBox.Show(campo.Value & " no puede ser un campo vacío.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                campo.Key.Focus()
                Exit Sub
            End If
        Next
    End Sub

    ''IMAGENES
    'PINCHA CUANDO LA IAMGEN ES DEMASIO GRANDE PARA LA MEMORIA, CORREGI EL METODO 

    'Private Sub btnCargaImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
    '    Using openFileDialog As New OpenFileDialog()
    '        openFileDialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
    '        openFileDialog.Title = "Seleccionar imagen del producto"
    '        If openFileDialog.ShowDialog() = DialogResult.OK Then
    '            'CARGA LA IMAGEN SELECCIONADA EN EL PB
    '            Dim selectedImagePath As String = openFileDialog.FileName
    '            Using originalImage As Image = Image.FromFile(selectedImagePath)
    '                ' REDIMENSIONA LA IMAGEN 
    '                'Dim resizedImage As Image = New Bitmap(originalImage, New Size(800, 800))
    '                pbProducto.Image = New Bitmap(originalImage)
    '            End Using
    '        End If
    '    End Using
    'End Sub

    'IMAGENES
    Private Sub btnCargaImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Archivos de imagen (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
            openFileDialog.Title = "Seleccionar imagen del producto"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim selectedImagePath As String = openFileDialog.FileName
                ' REDIMENSIONAR LA IMAGEN ANTES DE CARGARLA
                Try
                    ' ABRIR LA IMAGEN ORIGINAL Y REDIMENSIONARLA A UN TAMAÑO MÁS MANEJABLE
                    Using originalImage As Image = Image.FromFile(selectedImagePath)
                        ' CAMBIAMOS A UN TAMAÑO MAS PEQUEÑO
                        Dim newWidth As Integer = 800
                        Dim newHeight As Integer = 800
                        ' REDIMENSIONAR LA IMAGEN
                        Dim resizedImage As Image = New Bitmap(originalImage, newWidth, newHeight)
                        pbProducto.Image = resizedImage
                    End Using
                Catch ex As OutOfMemoryException
                    MessageBox.Show("La imagen del producto es demasiado grande.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error: " & ex.Message)
                End Try
            End If
        End Using
    End Sub




    'METODO PARA ELIMINAR LA IMAGEN RELACIONADA CON EL PRODUCTO
    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnLimpiarImagen.Click
        'VERIFICA QUE EL CAMPO IDPRODUCTO NO ESTE VACIO
        If Not String.IsNullOrWhiteSpace(lblID.Text) Then
            Dim idProducto As Integer = Val(lblID.Text)
            'PREGUNTA SI DESEA ELIMINAR LA IMAGEN REALMENTE
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar la imagen?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'SI EL RESULTADO ES SI
            If result = DialogResult.Yes Then
                'LIMPIA LA IMAGEN
                pbProducto.Image = Nothing
                'ELIMINA LA IMAGEN DE LA DB SI EXISTE
                Try
                    Using connection As New SqlConnection(conexionSql.ConnectionString)
                        connection.Open()
                        'ACTUALIZA EL CAMPO IMAGEN EN LA BASE DE DATOS A NULL PARA EL IDPRODUCTO ESPECIFICADO
                        Using command As New SqlCommand("UPDATE stProductos SET Imagen = NULL WHERE ID = @ID", connection)
                            command.Parameters.AddWithValue("@ID", idProducto)
                            command.ExecuteNonQuery()
                        End Using
                    End Using
                    MsgBox("Imagen eliminada correctamente.", vbOKOnly + vbInformation)
                Catch ex As Exception
                    MsgBox("Error al intentar eliminar la imagen: " & ex.Message, vbOKOnly + vbExclamation)
                End Try
            End If
        Else
            MsgBox("El ID del producto está vacío. No se puede eliminar la imagen.", vbOKOnly + vbExclamation)
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

    ' METODO PARA PERMITIR VALORES NUMEROS Y SOLO UN PUNTO EN TXTPORCENTAJEIVA
    Private Sub txtPorcentajeIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentajeIVA.KeyPress
        ' PERMITIR BORRAR CON LA TECLA BACKSPACE
        If Asc(e.KeyChar) = 8 Then
            Return
        End If

        ' PERMITIR SOLO NUMEROS (0-9)
        If Not Char.IsDigit(e.KeyChar) Then
            ' PERMITIR UN SOLO PUNTO DECIMAL
            If e.KeyChar = "." AndAlso Not txtPorcentajeIVA.Text.Contains(".") Then
                Return ' PERMITE EL PUNTO DECIMAL SOLO SI NO HAY UNO EN EL TEXTO
            End If

            ' SI NO ES UN NUMERO NI UN PUNTO, EVITAR LA TECLA
            e.Handled = True
        End If

        ' LIMITAR LA CANTIDAD DE DIGITOS ANTES Y DESPUES DEL PUNTO DECIMAL
        If txtPorcentajeIVA.Text.Contains(".") Then
            ' PERMITIR SOLO 2 DIGITOS DESPUES DEL PUNTO DECIMAL
            If txtPorcentajeIVA.Text.Split(".")(1).Length >= 2 Then
                If Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        End If

        ' LIMITAR LA CANTIDAD DE DIGITOS ANTES DEL PUNTO DECIMAL (6 DIGITOS)
        If txtPorcentajeIVA.Text.Length >= 6 Then
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    ' METODO PARA PERMITIR VALORES NUMEROS Y SOLO UN PUNTO EN TXTSTOCK
    Private Sub txtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock.KeyPress
        ' PERMITIR BORRAR CON LA TECLA BACKSPACE
        If Asc(e.KeyChar) = 8 Then
            Return
        End If

        ' PERMITIR SOLO NUMEROS (0-9)
        If Not Char.IsDigit(e.KeyChar) Then
            ' PERMITIR UN SOLO PUNTO DECIMAL
            If e.KeyChar = "." AndAlso Not txtStock.Text.Contains(".") Then
                Return ' PERMITE EL PUNTO DECIMAL SOLO SI NO HAY UNO EN EL TEXTO
            End If

            ' SI NO ES UN NUMERO NI UN PUNTO, EVITAR LA TECLA
            e.Handled = True
        End If

        ' LIMITAR LA CANTIDAD DE DIGITOS ANTES Y DESPUES DEL PUNTO DECIMAL
        If txtStock.Text.Contains(".") Then
            ' PERMITIR SOLO 3 DIGITOS DESPUES DEL PUNTO DECIMAL
            If txtStock.Text.Split(".")(1).Length >= 3 Then
                If Not Char.IsControl(e.KeyChar) Then
                    e.Handled = True
                End If
            End If
        End If

        ' LIMITAR LA CANTIDAD DE DIGITOS ANTES DEL PUNTO DECIMAL (6 DIGITOS)
        If txtStock.Text.Length >= 6 Then
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    ' FUNCIÓN PARA VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
    Private Function CodigoExiste(codigo As String, Optional idProducto As Integer = -1) As Boolean
        Dim existe As Boolean = False
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' SE CREATIVA LA CONSULTA PARA EXCLUIR EL PRODUCTO ACTUAL (SI SE ESTÁ EDITANDO)
            Dim query As String = "SELECT COUNT(*) FROM dbo.stProductos WHERE Codigo = @codigo"
            If idProducto <> -1 Then
                query &= " AND ID <> @idProducto" ' Excluye el producto actual si es edición
            End If

            ' EJECUTAR LA CONSULTA
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", codigo)

                ' SI SE ESTÁ EDITANDO UN PRODUCTO, AGREGAMOS EL ID DEL PRODUCTO ACTUAL
                If idProducto <> -1 Then
                    command.Parameters.AddWithValue("@idProducto", idProducto)
                End If

                ' EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' SI EL CÓDIGO EXISTE Y NO ES EL PRODUCTO ACTUAL, ESTÁ REPETIDO
                If count > 0 Then
                    existe = True ' El código ya existe
                End If
            End Using
        End Using

        ' DEVUELVE EL RESULTADO
        Return existe
    End Function



    Private Sub rbSiActivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbSiActivo.CheckedChanged
        'CAMBIA EL COLOR DE LOS RB EN ACTIVO
        colorActivo()
    End Sub

    Private Sub rbNoActivo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNoActivo.CheckedChanged
        'CAMBIA EL COLOR DE LOS RB EN ACTIVO
        colorActivo()
    End Sub

    Private Sub rbSi_CheckedChanged(sender As Object, e As EventArgs) Handles rbSi.CheckedChanged
        'CAMBIA EL COLOR DE LOS RB EN VENTA POR PESO
        colorVentaPorPeso()
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        'CAMBIA EL COLOR DE LOS RB EN VENTA POR PESO
        colorVentaPorPeso()
    End Sub

    'CAMBIA EL COLOR DE LOS RB ACTIVO
    Public Sub colorActivo()
        'CAMBIA EL COLOR DE LOS RB EN ACTIVO
        If rbSiActivo.Checked Then
            rbSiActivo.ForeColor = Color.FromArgb(148, 255, 136) ' VERDE CLARO
            rbNoActivo.ForeColor = Color.FromArgb(255, 255, 255) ' BLANCO
            gpActivo.ForeColor = Color.FromArgb(148, 255, 136) ' VERDE CLARO
        Else
            rbSiActivo.ForeColor = Color.FromArgb(255, 255, 255) ' BLANCO
            rbNoActivo.ForeColor = Color.FromArgb(148, 255, 136) ' VERDE CLARO
            gpActivo.ForeColor = Color.FromArgb(255, 136, 136) ' ROJO CLARO
        End If
    End Sub

    'CAMBIA EL COLOR DE LOS RB VENTA POR PESO
    Public Sub colorVentaPorPeso()
        'CAMBIA EL COLOR DE LOS RB EN VENTA POR PESO
        If rbSi.Checked Then
            rbSi.ForeColor = Color.FromArgb(148, 255, 136) ' VERDE CLARO
            rbNo.ForeColor = Color.FromArgb(255, 255, 255) ' BLANCO
            gpVentaPorPeso.ForeColor = Color.FromArgb(148, 255, 136) ' VERDE CLARO
        Else
            rbSi.ForeColor = Color.FromArgb(255, 255, 255) ' BLANCO
            rbNo.ForeColor = Color.FromArgb(148, 255, 136) ' VERDE CLARO
            gpVentaPorPeso.ForeColor = Color.FromArgb(255, 136, 136) ' ROJO CLARO
        End If
    End Sub

End Class