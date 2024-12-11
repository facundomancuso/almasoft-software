Imports System.Reflection
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports Microsoft.Data.SqlClient

Public Class frmClientes

    'VARIABLE PARA VALIDACIÓN DE NO REPETIR CÓDIGO DE PRODUCTOS
    Public idClienteActual As Integer = -1

    'DESACTIVA LOS CONTROLES
    Public Sub desactivarControles()
        chActivo.Enabled = False
        txtCodigo.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDni.Enabled = False
        dtFechaDeNacimiento.Enabled = False
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
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDni.Enabled = True
        dtFechaDeNacimiento.Enabled = True
        txtDireccion.Enabled = True
        txtLocalidad.Enabled = True
        txtCp.Enabled = True
        cbProvincia.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        cbCondicionIva.Enabled = True
    End Sub
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ACTIVA O DESACTIVA CONTROLES
        Conexion.CargarCadenaConexion()
        If lblTarea.Text = "Ver cliente" Then
            desactivarControles()
            btnGenerarPdf.Visible = True
            btnGenerarPdf.Enabled = True
        Else
            activarControles()
            btnGenerarPdf.Visible = False
            btnGenerarPdf.Enabled = False
        End If
        If lblTarea.Text <> "Nuevo cliente" Then
            lblAvisoActivo.Visible = True
            If lblAvisoActivo.Text = "El cliente se encuentra ACTIVO" Then
                lblAvisoActivo.ForeColor = Color.FromArgb(148, 255, 136) ' Verde claro
            ElseIf lblAvisoActivo.Text = "El cliente se encuentra INACTIVO" Then
                lblAvisoActivo.ForeColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Else
            lblAvisoActivo.Visible = False
        End If
        'LIMITES DE CARACTERES PARA LOS TXT
        txtCodigo.MaxLength = 6
        txtNombre.MaxLength = 50
        txtApellido.MaxLength = 50
        txtDni.MaxLength = 8
        txtDireccion.MaxLength = 50
        txtLocalidad.MaxLength = 50
        txtCp.MaxLength = 5
        txtTelefono.MaxLength = 50
        txtEmail.MaxLength = 50

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
        If lblTarea.Text = "Nuevo cliente" Then
            NuevoCliente()
        ElseIf lblTarea.Text = "Editar cliente" Then
            EditarCliente()
        End If
    End Sub

    Public Sub NuevoCliente()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If

        ' VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
        If CodigoClienteExiste(txtCodigo.Text, idClienteActual) Then
            MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        ' VERIFICAR SI EL DNI YA EXISTE EN LA BASE DE DATOS
        If DniClienteExiste(txtDni.Text, idClienteActual) Then
            MessageBox.Show("El DNI ingresado ya existe. Por favor, ingrese un DNI diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        'REALIZAMOS EL INSERT DEL NUEVO CLIENTE A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES
            'ACTIVO ("1" SI, "0" NO)
            Dim activo As Integer = If(chActivo.Checked, "1", "0")

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                'EJECUCION DEL INSERT A LA BASE
                Using command As New SqlCommand("INSERT INTO dbo.vtClientes (Codigo, Nombre, Apellido, DNI, Telefono, Email, Direccion, Localidad, CodPostal, IDProvincia, IDCondicionIVA, FechaNacimiento, Activo)
                                             VALUES (@codigo, @nombre, @apellido, @dni, @telefono, @email, @direccion, @localidad, @codpostal, @idprovincia, @idcondicioniva, @fechanacimiento, @activo)", connection)

                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    command.Parameters.AddWithValue("@DNI", txtDni.Text)
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    command.Parameters.AddWithValue("@Localidad", txtLocalidad.Text)
                    command.Parameters.AddWithValue("@CodPostal", txtCp.Text)
                    command.Parameters.AddWithValue("@IDProvincia", cbProvincia.SelectedValue)
                    command.Parameters.AddWithValue("@IDCondicionIVA", cbCondicionIva.SelectedValue)
                    command.Parameters.AddWithValue("@FechaNacimiento", dtFechaDeNacimiento.Value)
                    command.Parameters.AddWithValue("@Activo", activo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Se agregó correctamente el nuevo cliente", vbOKOnly + vbInformation, "Almasoft - Nuevo Cliente")

        Catch ex As Exception
            MessageBox.Show("Error al intentar agregar un nuevo cliente: " & ex.Message)
        End Try

        'CERRAMOS FORM Y RECARGAMOS LA GRILLA
        frmMenu.abrirFrm(Of frmGrillaClientes)()
        Me.Close()

    End Sub

    Public Sub EditarCliente()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If

        ' VERIFICAR SI EL CÓDIGO YA EXISTE EN LA BASE DE DATOS
        If CodigoClienteExiste(txtCodigo.Text, idClienteActual) Then
            MessageBox.Show("El código ingresado ya existe. Por favor, ingrese un código diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        ' VERIFICAR SI EL DNI YA EXISTE EN LA BASE DE DATOS
        If DniClienteExiste(txtDni.Text, idClienteActual) Then
            MessageBox.Show("El DNI ingresado ya existe. Por favor, ingrese un DNI diferente.", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Exit Sub
        End If

        'REALIZAMOS EL UPDATE DEL CLIENTE A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES

            'ACTIVO ("1" SI, "0" NO)
            Dim activo As String = If(chActivo.Checked, "1", "0")

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()
                'EJECUCION DEL UPDATE A LA BASE
                Using command As New SqlCommand("UPDATE dbo.vtClientes
                                                SET Codigo = @Codigo, 
                                                    Nombre = @Nombre, 
                                                    Apellido = @Apellido, 
                                                    DNI = @DNI,
                                                    Telefono = @Telefono,
                                                    Email = @Email, 
                                                    Direccion = @Direccion,
                                                    Localidad = @Localidad,
                                                    CodPostal = @CodPostal,
                                                    IDProvincia = @IDProvincia,
                                                    IDCondicionIVA = @IDCondicionIVA,
                                                    FechaNacimiento = @FechaNacimiento,
                                                    Activo = @Activo
                                                 WHERE ID = @ID", connection)

                    command.Parameters.AddWithValue("@ID", lblID.Text)
                    command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    command.Parameters.AddWithValue("@DNI", txtDni.Text)
                    command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
                    command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    command.Parameters.AddWithValue("@Localidad", txtLocalidad.Text)
                    command.Parameters.AddWithValue("@CodPostal", txtCp.Text)
                    command.Parameters.AddWithValue("@IDProvincia", cbProvincia.SelectedValue)
                    command.Parameters.AddWithValue("@IDCondicionIVA", cbCondicionIva.SelectedValue)
                    command.Parameters.AddWithValue("@FechaNacimiento", dtFechaDeNacimiento.Value)
                    command.Parameters.AddWithValue("@Activo", activo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Se editó correctamente el cliente", vbOKOnly + vbInformation, "Almasoft - Editar Cliente")
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar el cliente: " & ex.Message)
        End Try

        'CERRAMOS FORM Y RECARGAMOS LA GRILLA

        frmMenu.abrirFrm(Of frmGrillaClientes)()
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
        {txtNombre, "Nombre"},
        {txtApellido, "Apellido"},
        {txtDni, "DNI"},
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

    ' FUNCIÓN PARA VERIFICAR SI EL CÓDIGO YA EXISTE EN LA TABLA VTCLIENTES
    Private Function CodigoClienteExiste(codigo As String, Optional idCliente As Integer = -1) As Boolean
        Dim existe As Boolean = False
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' CONSULTA PARA VERIFICAR SI EL CÓDIGO YA EXISTE EN LA TABLA VTCLIENTES
            Dim query As String = "SELECT COUNT(*) FROM dbo.vtClientes WHERE Codigo = @codigo"
            If idCliente <> -1 Then
                query &= " AND ID <> @idCliente" ' Excluye el cliente actual si es edición
            End If


            ' EJECUTAR LA CONSULTA
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", codigo)

                ' SI SE ESTÁ EDITANDO UN CLIENTE, AGREGAMOS EL ID DEL CLIENTE ACTUAL
                If idCliente <> -1 Then
                    command.Parameters.AddWithValue("@idCliente", idCliente)
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

    ' FUNCIÓN PARA VERIFICAR SI EL DNI YA EXISTE EN LA TABLA VTCLIENTES
    Private Function DniClienteExiste(dni As String, Optional idCliente As Integer = -1) As Boolean
        Dim existe As Boolean = False
        Using connection As New SqlConnection(conexionSql.ConnectionString)
            connection.Open()

            ' CONSULTA PARA VERIFICAR SI EL DNI YA EXISTE EN LA TABLA VTCLIENTES
            Dim query As String = "SELECT COUNT(*) FROM dbo.vtClientes WHERE DNI = @dni"
            If idCliente <> -1 Then
                query &= " AND ID <> @idCliente" ' Excluye el cliente actual si es edición
            End If

            ' EJECUTAR LA CONSULTA
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@dni", dni)  ' EL PARAMETRO ES EL DNI INGRESADO

                ' SI SE ESTÁ EDITANDO UN CLIENTE, AGREGAMOS EL ID DEL CLIENTE ACTUAL
                If idCliente <> -1 Then
                    command.Parameters.AddWithValue("@idCliente", idCliente)
                End If

                ' EJECUTA LA CONSULTA Y OBTIENE EL RESULTADO
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' SI EL DNI EXISTE, ESTÁ REPETIDO
                If count > 0 Then
                    existe = True ' El DNI YA EXISTE
                End If
            End Using
        End Using

        ' DEVUELVE EL RESULTADO
        Return existe
    End Function

    'SOLO PERMITE NUMEROS EN EL DNI
    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        ' SOLO NUMEROS
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' NO PERMITE CARACTERES NO NUMERICOS
        End If

        ' LIMITAR A 8 CARACTERES
        If txtDni.Text.Length >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' NO PERMITE SUPERAR 8 CARACTERES
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

    ' Método para generar el PDF de los clientes según los datos del formulario frmClientes
    Public Sub GenerarPDFClientesFrmClientes()
        ' FORMATO FECHA Y HORA PARA GUARDAR EL PDF
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ' DONDE LO VA A GUARDAR
        Dim pdfPath As String = $"C:\Almasoft\captures\clientes_{timestamp}.pdf"

        Using writer As New PdfWriter(pdfPath)
            Using pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)
                Dim title As New Paragraph

                ' TITULO DEL PDF
                title = New Paragraph("DATOS DEL CLIENTE")
                title.SetFontSize(12)
                title.SetBold()
                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                document.Add(title)

                ' CREAR LA TABLA
                Dim table As New Table(8) 'DEFINIMOS 8 COLUMNAS

                ' ANCHO DE LA TABLA 100%
                table.SetWidth(UnitValue.CreatePercentValue(100))
                'PARA RESPETAR LOS ANCHOS DEFINIDOS
                table.SetFixedLayout()

                ' Definir los anchos de las columnas para que se distribuyan bien
                ' Aquí puedes ajustar los valores para adaptarlo a tus necesidades
                table.AddCell(New Cell().Add(New Paragraph("CÓDIGO")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("NOMBRE")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("APELLIDO")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("DNI")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("TEL.")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("DIR.")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("C. IVA")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))
                table.AddCell(New Cell().Add(New Paragraph("FECHA DE NAC.")).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY))

                '' Anchos de cada columna (en porcentajes)
                '' Estos valores pueden ajustarse según el contenido que tengas en las columnas
                'table.SetWidths(New Single() {10, 20, 20, 10, 15, 25, 10, 10})

                '' AGREGA LOS ENCABEZADOS
                'Dim headers As String() = {"CÓDIGO", "NOMBRE", "APELLIDO", "DNI", "TELÉFONO", "DIRECCIÓN", "CONDICIÓN IVA", "FECHA DE NAC."}

                'For Each header As String In headers
                '    Dim headerCell As Cell = New Cell().Add(New Paragraph(header)).SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                '    table.AddHeaderCell(headerCell)
                'Next

                'AGREGA LAS FILAS
                Dim clientData As New List(Of String) From {
                txtCodigo.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtTelefono.Text,
                txtDireccion.Text
            }
                ' VALOR DEL CB CONDICIONIVA
                Dim selectedCondicionIVA As String = ""
                If cbCondicionIva.SelectedItem IsNot Nothing Then
                    ' SI EL CB TIENE UN DATATABLE COMO DATASOURCE
                    If TypeOf cbCondicionIva.SelectedItem Is DataRowView Then
                        selectedCondicionIVA = DirectCast(cbCondicionIva.SelectedItem, DataRowView)("Condicion").ToString()
                    Else
                        ' SI TIENE UNA LISTA STRING
                        selectedCondicionIVA = cbCondicionIva.SelectedItem.ToString()
                    End If
                End If

                ' AGREGAMOS EL VALOR DE LA CONDICION IVA
                clientData.Add(selectedCondicionIVA)

                'AGREGAMOS LA FECHA DE NACIMIENTO
                clientData.Add(dtFechaDeNacimiento.Value.ToString("dd/MM/yyyy"))

                ' AÑADIR LA FILA CON LOS DATOS INGRESADOS
                For Each data As String In clientData
                    Dim cellParagraph As New Paragraph(data)
                    cellParagraph.SetFontSize(10) ' FUENTE
                    Dim cell As New Cell()
                    cell.Add(cellParagraph)
                    ' SI LA COLUMNA ES DIRECCIÓN
                    If clientData.IndexOf(data) = 5 Then ' DIRECCIÓN
                        cell.SetWidth(150) ' MAS ANCHO
                    End If
                    table.AddCell(cell)
                Next

                ' ESTABLECER ANCHO DE LA TABLA
                'table.SetWidth(UnitValue.CreatePercentValue(100))
                ' AGREGAR LA TABLA AL DOCUMENTO
                document.Add(table)
            End Using
        End Using

        'ABRE EL PDF Y CARTEL DE CONFIRMACIÓN EXITOSA
        MessageBox.Show("PDF generado correctamente en: " & pdfPath)
        Try
            Process.Start(New ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiarImagen_Click(sender As Object, e As EventArgs) Handles btnGenerarPdf.Click
        'GENERO PDF
        GenerarPDFClientesFrmClientes()
    End Sub
End Class