Imports System.Reflection
Imports Microsoft.Data.SqlClient

Public Class frmUsuarios

    'DESACTIVA LOS CONTROLES
    Public Sub desactivarControles()
        chActivo.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtUsuario.Enabled = False
        txtPass.Enabled = False
        checkMostrarPass.Enabled = False
        cbNivel.Enabled = False
    End Sub

    'ACTIVA LOS CONTROLES
    Public Sub activarControles()
        chActivo.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtUsuario.Enabled = True
        txtPass.Enabled = True
        checkMostrarPass.Enabled = True
        cbNivel.Enabled = True
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OCULTO LA CONTRASEÑA INGRESADA 
        txtPass.UseSystemPasswordChar = True
        'ACTIVA O DESACTIVA CONTROLES
        Conexion.CargarCadenaConexion()
        If lblTarea.Text = "Ver usuario" Then
            desactivarControles()
        Else
            activarControles()
        End If
        If lblTarea.Text <> "Nuevo usuario" Then
            lblAvisoActivo.Visible = True
            lblID.Visible = True
            If lblAvisoActivo.Text = "El usuario se encuentra ACTIVO" Then
                lblAvisoActivo.ForeColor = Color.FromArgb(148, 255, 136) ' Verde claro
            ElseIf lblAvisoActivo.Text = "El usuario se encuentra INACTIVO" Then
                lblAvisoActivo.ForeColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Else
            lblAvisoActivo.Visible = False
            lblID.Visible = False
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
        If lblTarea.Text = "Nuevo usuario" Then
            NuevoUsuario()
        ElseIf lblTarea.Text = "Editar usuario" Then
            EditarUsuario()
        End If
    End Sub

    Public Sub NuevoUsuario()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If
        'REALIZAMOS EL INSERT DEL NUEVO USUARIO A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES

            'ACTIVO ("1" SI, "0" NO)
            Dim activo As Integer = If(chActivo.Checked, "1", "0")

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()

                'EJECUCION DEL INSERT A LA BASE
                Using command As New SqlCommand("INSERT INTO dbo.usUsuarios (Nombre, Apellido, Contraseña, IDNivel, Usuario, Activo)
                                             VALUES (@nombre, @apellido, @contraseña, @idnivel, @usuario, @activo)", connection)

                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    command.Parameters.AddWithValue("@Contraseña", txtPass.Text)
                    command.Parameters.AddWithValue("@IDNivel", cbNivel.SelectedValue)
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                    command.Parameters.AddWithValue("@Activo", activo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Se agregó correctamente", vbOKOnly + vbInformation)
        Catch ex As Exception
            MessageBox.Show("Error al intentar agregar un nuevo usuario: " & ex.Message)
        End Try

        'CERRAMOS FORM Y RECARGAMOS LA GRILLA
        frmMenu.abrirFrm(Of frmGrillaUsuarios)()
        Me.Close()

    End Sub

    Public Sub EditarUsuario()
        'VERIFICA QUE TODOS LOS TXT TENGAN DATOS CARGADOS
        condicionTxtLlenos()
        'SI BANDERA ES TRUE, HAY CAMPOS VACIOS
        If bandera = True Then
            ' Detiene la carga
            Exit Sub
        End If
        'REALIZAMOS EL UPDATE DEL USUARIO A LA BASE DE DATOS
        Try
            'DECLARACION DE VARIABLES

            'ACTIVO ("1" SI, "0" NO)
            Dim activo As String = If(chActivo.Checked, "1", "0")

            Using connection As New SqlConnection(conexionSql.ConnectionString)
                connection.Open()
                'EJECUCION DEL UPDATE A LA BASE
                Using command As New SqlCommand("UPDATE dbo.usUsuarios
                                                SET Nombre = @Nombre, 
                                                    Apellido = @Apellido, 
                                                    Contraseña = @Contraseña,
                                                    IDNivel = @IDNivel,
                                                    Usuario = @Usuario,
                                                    Activo = @Activo
                                                 WHERE ID = @ID", connection)

                    command.Parameters.AddWithValue("@ID", lblID.Text)
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    command.Parameters.AddWithValue("@Contraseña", txtPass.Text)
                    command.Parameters.AddWithValue("@IDNivel", cbNivel.SelectedValue)
                    command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                    command.Parameters.AddWithValue("@Activo", activo)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Se editó correctamente", vbOKOnly + vbInformation)
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar el usuario: " & ex.Message)
        End Try

        'CERRAMOS FORM Y RECARGAMOS LA GRILLA

        frmMenu.abrirFrm(Of frmGrillaUsuarios)()
        Me.Close()

    End Sub


    ' COMBOBOXS
    Public Sub Niveles()
        'SELECT A LOS NIVELES Y GUARDADO EN UNA DATATABLE
        Dim query As String = "SELECT ID, Nivel FROM usNiveles"
        Dim adaptadorSql As New SqlDataAdapter(query, conexionSql)
        Dim Niveles As New DataTable
        adaptadorSql.Fill(Niveles)
        'TOMAMOS EL RECURSO GUARDADO Y LO MOSTRAMOS EN EL CB
        cbNivel.DataSource = Niveles
        cbNivel.DisplayMember = "Nivel"
        cbNivel.ValueMember = "ID"
    End Sub

    'METODO PARA IMPEDIR CAMPOS VACIOS
    Public Sub condicionTxtLlenos()
        'LIMPIO VARIABLES
        modUtilidades.limpiarVariables()
        'METODO PARA IMPEDIR CAMPOS VACIOS
        Dim camposRequeridos As New Dictionary(Of TextBox, String) From {
        {txtNombre, "Nombre"},
        {txtApellido, "Apellido"},
        {txtUsuario, "Usuario"},
        {txtPass, "Contraseña"}
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

    Private Sub checkMostrarPass_CheckedChanged_1(sender As Object, e As EventArgs) Handles checkMostrarPass.CheckedChanged
        If checkMostrarPass.Checked Then
            'MUESTRA LA CONTRASEÑA
            txtPass.UseSystemPasswordChar = False
        Else
            'OCULTA LA CONTRASEÑA
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class