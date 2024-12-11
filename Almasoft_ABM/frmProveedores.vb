Imports System.Reflection
Imports Microsoft.Data.SqlClient
Public Class frmProveedores


    'VARIABLE PARA VALIDACIÓN DE NO REPETIR CÓDIGO DE PRODUCTOS
    Public idProveedorActual As Integer = -1

    'DESACTIVA LOS CONTROLES
    Public Sub desactivarControles()
        chActivo.Enabled = False
        txtCodigo.Enabled = False
        txtEmpresa.Enabled = False
        txtFirma.Enabled = False
        txtCuit.Enabled = False
        txtDireccion.Enabled = False
        txtLocalidad.Enabled = False
        txtCp.Enabled = False
        cbProvincia.Enabled = False
        txtTelefono.Enabled = False
        txtEmail.Enabled = False
        cbCondicionIva.Enabled = False
    End Sub

    'ACTIVA LOS CONTROLES
    Public Sub activarControles()
        chActivo.Enabled = True
        txtCodigo.Enabled = True
        txtEmpresa.Enabled = True
        txtFirma.Enabled = True
        txtCuit.Enabled = True
        txtDireccion.Enabled = True
        txtLocalidad.Enabled = True
        txtCp.Enabled = True
        cbProvincia.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        cbCondicionIva.Enabled = True
    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTIVA O DESACTIVA CONTROLES
        Conexion.CargarCadenaConexion()
        If lblTarea.Text = "Ver proveedor" Then
            desactivarControles()
        Else
            activarControles()
        End If
        If lblTarea.Text <> "Nuevo proveedor" Then
            btnVerProductos.Enabled = True
            lblAvisoActivo.Visible = True
            If lblAvisoActivo.Text = "El proveedor se encuentra ACTIVO" Then
                lblAvisoActivo.ForeColor = Color.FromArgb(148, 255, 136) ' Verde claro
            ElseIf lblAvisoActivo.Text = "El proveedor se encuentra INACTIVO" Then
                lblAvisoActivo.ForeColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Else
            btnVerProductos.Enabled = False
            lblAvisoActivo.Visible = False
        End If
        'LIMITES DE CARACTERES PARA LOS TXT
        txtCodigo.MaxLength = 6
        txtEmpresa.MaxLength = 50
        txtFirma.MaxLength = 50
        txtCuit.MaxLength = 13
        txtDireccion.MaxLength = 50
        txtLocalidad.MaxLength = 50
        txtCp.MaxLength = 5
        txtTelefono.MaxLength = 50
        txtEmail.MaxLength = 50
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        If lblTarea.Text = "Nuevo proveedor" Then
            NuevoProveedor()
        ElseIf lblTarea.Text = "Editar proveedor" Then
            EditarProveedor()
        End If
    End Sub


    Public Sub NuevoProveedor()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If

        ' VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
        If CodigoProveedorExiste(txtCodigo.Text, idProveedorActual) Then
            MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        ' VERIFICAR SI LA EMPRESA YA EXISTE EN LA BASE DE DATOS
        If EmpresaProveedorExiste(txtEmpresa.Text, idProveedorActual) Then
            MessageBox.Show("La empresa ingresado ya existe. Por favor, ingrese un nombre de empresa diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        ' VERIFICAR SI EL CUIT YA EXISTE EN LA BASE DE DATOS
        If CuitProveedorExiste(txtCuit.Text, idProveedorActual) Then
            MessageBox.Show("El CUIT ingresado ya existe. Por favor, ingrese un CUIT diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        'REALIZAMOS EL INSERT DEL NUEVO PROVEEDOR A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES

            'ACTIVO ("1" SI, "0" NO)
            Dim activo As Integer = If(chActivo.Checked, "1", "0")

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                'EJECUCION DEL INSERT A LA BASE
                Using command As New SqlCommand("INSERT INTO dbo.prProveedores (Codigo, Empresa, Firma, CUIT, Telefono, Email, Direccion, Localidad, CodPostal, IDProvincia, IDCondicionIVA, Activo)
                                             VALUES (@codigo, @empresa, @firma, @cuit, @telefono, @email, @direccion, @localidad, @codpostal, @idprovincia, @idcondicioniva, @activo)", connection)

                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                    command.Parameters.AddWithValue("@Empresa", txtEmpresa.Text)
                    command.Parameters.AddWithValue("@Firma", txtFirma.Text)
                    command.Parameters.AddWithValue("@CUIT", txtCuit.Text)
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    command.Parameters.AddWithValue("@Localidad", txtLocalidad.Text)
                    command.Parameters.AddWithValue("@CodPostal", txtCp.Text)
                    command.Parameters.AddWithValue("@IDProvincia", cbProvincia.SelectedValue)
                    command.Parameters.AddWithValue("@IDCondicionIVA", cbCondicionIva.SelectedValue)
                    command.Parameters.AddWithValue("@Activo", activo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Se agregó correctamente el nuevo proveedor", vbOKOnly + vbInformation, "Almasoft - Nuevo Proveedor")
        Catch ex As Exception
            MessageBox.Show("Error al intentar agregar un nuevo proveedor: " & ex.Message)
        End Try

        'CERRAMOS FORM Y RECARGAMOS LA GRILLA
        frmMenu.abrirFrm(Of frmGrillaProveedores)()
        Me.Close()

    End Sub


    Public Sub EditarProveedor()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If

        ' VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
        If CodigoProveedorExiste(txtCodigo.Text, idProveedorActual) Then
            MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        ' VERIFICAR SI LA EMPRESA YA EXISTE EN LA BASE DE DATOS
        If EmpresaProveedorExiste(txtEmpresa.Text, idProveedorActual) Then
            MessageBox.Show("La empresa ingresado ya existe. Por favor, ingrese un nombre de empresa diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        ' VERIFICAR SI EL CUIT YA EXISTE EN LA BASE DE DATOS
        If CuitProveedorExiste(txtCuit.Text, idProveedorActual) Then
            MessageBox.Show("El CUIT ingresado ya existe. Por favor, ingrese un CUIT diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        'REALIZAMOS EL UPDATE DEL PROVEEDOR A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES

            'ACTIVO ("1" SI, "0" NO)
            Dim activo As String = If(chActivo.Checked, "1", "0")

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()
                'EJECUCION DEL UPDATE A LA BASE
                Using command As New SqlCommand("UPDATE dbo.prProveedores
                                                SET Codigo = @Codigo, 
                                                    Empresa = @Empresa, 
                                                    Firma = @Firma, 
                                                    CUIT = @CUIT,
                                                    Telefono = @Telefono,
                                                    Email = @Email, 
                                                    Direccion = @Direccion,
                                                    Localidad = @Localidad,
                                                    CodPostal = @CodPostal,
                                                    IDProvincia = @IDProvincia,
                                                    IDCondicionIVA = @IDCondicionIVA,
                                                    Activo = @Activo
                                                 WHERE ID = @ID", connection)

                    command.Parameters.AddWithValue("@ID", lblID.Text)
                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                    command.Parameters.AddWithValue("@Empresa", txtEmpresa.Text)
                    command.Parameters.AddWithValue("@Firma", txtFirma.Text)
                    command.Parameters.AddWithValue("@CUIT", txtCuit.Text)
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    command.Parameters.AddWithValue("@Localidad", txtLocalidad.Text)
                    command.Parameters.AddWithValue("@CodPostal", txtCp.Text)
                    command.Parameters.AddWithValue("@IDProvincia", cbProvincia.SelectedValue)
                    command.Parameters.AddWithValue("@IDCondicionIVA", cbCondicionIva.SelectedValue)
                    command.Parameters.AddWithValue("@Activo", activo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Se editó correctamente el proveedor", vbOKOnly + vbInformation, "Almasoft - Editar Proveedor")
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar el proveedor: " & ex.Message)
        End Try

        'CERRAMOS FORM Y RECARGAMOS LA GRILLA

        frmMenu.abrirFrm(Of frmGrillaProveedores)()
        Me.Close()

    End Sub



    ' COMBOBOXS
    Public Sub Provincias()
        'SELECT A LAS PROVINCIAS Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Provincia FROM adProvincias"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim Provincias As New DataTable
        adaptadorSql.Fill(Provincias)

        'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
        cbProvincia.DataSource = Provincias
        cbProvincia.DisplayMember = "Provincia"
        cbProvincia.ValueMember = "ID"
    End Sub
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

    'METODO PARA IMPEDIR CAMPOS VACIOS
    Public Sub condicionTxtLlenos()
        'LIMPIO VARIABLES
        modUtilidades.limpiarVariables()
        'METODO PARA IMPEDIR CAMPOS VACIOS
        Dim camposRequeridos As New Dictionary(Of TextBox, String) From {
        {txtCodigo, "Código"},
        {txtEmpresa, "Empresa"},
        {txtFirma, "Firma"},
        {txtCuit, "CUIT"},
        {txtDireccion, "Dirección"},
        {txtCp, "Código postal"},
        {txtLocalidad, "Localidad"},
        {txtTelefono, "Teléfono"},
        {txtEmail, "E-mail"}
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

    ' FUNCIÓN PARA VERIFICAR SI EL CÓDIGO YA EXISTE EN LA TABLA PRPROVEEDORES
    Private Function CodigoProveedorExiste(codigo As String, Optional idProveedor As Integer = -1) As Boolean
        Dim existe As Boolean = False
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' CONSULTA PARA VERIFICAR SI EL CÓDIGO YA EXISTE EN LA TABLA prProveedores
            Dim query As String = "SELECT COUNT(*) FROM dbo.prProveedores WHERE Codigo = @codigo"
            If idProveedor <> -1 Then
                query &= " AND ID <> @idProveedor" ' Excluye el proveedor actual si es edición
            End If

            ' EJECUTAR LA CONSULTA
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", codigo)

                ' SI SE ESTÁ EDITANDO UN PROVEEDOR, AGREGAMOS EL ID DEL PROVEEDOR ACTUAL
                If idProveedor <> -1 Then
                    command.Parameters.AddWithValue("@idProveedor", idProveedor)
                End If

                ' EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' SI EL CÓDIGO EXISTE, ESTÁ REPETIDO
                If count > 0 Then
                    existe = True ' EL CODIGO YA EXISTE
                End If
            End Using
        End Using

        ' DEVUELVE EL RESULTADO
        Return existe
    End Function


    ' FUNCIÓN PARA VERIFICAR SI LA EMPRESA YA EXISTE EN LA TABLA prProveedores
    Private Function EmpresaProveedorExiste(empresa As String, Optional idProveedor As Integer = -1) As Boolean
        Dim existe As Boolean = False
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' CONSULTA PARA VERIFICAR SI EL NOMBRE DE LA EMPRESA YA EXISTE EN LA TABLA prProveedores
            Dim query As String = "SELECT COUNT(*) FROM dbo.prProveedores WHERE Empresa = @empresa"
            If idProveedor <> -1 Then
                query &= " AND ID <> @idProveedor" ' Excluye el proveedor actual si es edición
            End If

            ' EJECUTAR LA CONSULTA
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@empresa", empresa) ' NOMBRE DE LA EMPRESA INGRESADO COMO PARAMETRO

                ' SI SE ESTÁ EDITANDO UN PROVEEDOR, AGREGAMOS EL ID DEL PROVEEDOR ACTUAL
                If idProveedor <> -1 Then
                    command.Parameters.AddWithValue("@idProveedor", idProveedor)
                End If

                ' EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' SI EL NOMBRE DE LA EMPRESA EXISTE, ESTÁ REPETIDO
                If count > 0 Then
                    existe = True ' YA EXISTE
                End If
            End Using
        End Using

        ' DEVUELVE EL RESULTADO
        Return existe
    End Function



    ' FUNCIÓN PARA VERIFICAR SI EL CUIT YA EXISTE EN LA TABLA PRPROVEEDORES
    Private Function CuitProveedorExiste(cuit As String, Optional idProveedor As Integer = -1) As Boolean
        Dim existe As Boolean = False
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' CONSULTA PARA VERIFICAR SI EL DNI YA EXISTE EN LA TABLA PRPROVEEDORES
            Dim query As String = "SELECT COUNT(*) FROM dbo.prProveedores WHERE CUIT = @cuit"
            If idProveedor <> -1 Then
                query &= " AND ID <> @idProveedor" ' Excluye el proveedor actual si es edición
            End If

            ' EJECUTAR LA CONSULTA
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@cuit", cuit)  ' EL PARAMETRO ES EL CUIT INGRESADO

                ' SI SE ESTÁ EDITANDO UN PROVEEDOR, AGREGAMOS EL ID DEL PROVEEDOR ACTUAL
                If idProveedor <> -1 Then
                    command.Parameters.AddWithValue("@idProveedor", idProveedor)
                End If

                ' EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' SI EL CUIT EXISTE, ESTÁ REPETIDO
                If count > 0 Then
                    existe = True ' El DNI YA EXISTE
                End If
            End Using
        End Using

        ' DEVUELVE EL RESULTADO
        Return existe
    End Function



    'SOLO PERMITE NUMEROS EN EL CUIT
    Private Sub txtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuit.KeyPress
        ' SOLO NUMEROS
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' NO PERMITE CARACTERES NO NUMERICOS
        End If

        ' LIMITAR A 13 CARACTERES
        If txtDni.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' NO PERMITE SUPERAR 13 CARACTERES
        End If
    End Sub

    'SOLO PERMITE NUMEROS EN EL TELEFONO
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        ' SOLO NUMEROS
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' NO PERMITE CARACTERES NO NUMERICOS
        End If

        ' LIMITAR A 50 CARACTERES
        If txtTelefono.Text.Length >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' NO PERMITE SUPERAR 50 CARACTERES
        End If
    End Sub

    Private Sub btnVerProductos_Click(sender As Object, e As EventArgs) Handles btnVerProductos.Click

    End Sub
End Class