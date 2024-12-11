Imports Microsoft.Data.SqlClient

Public Class frmGrillaUsuarios

    Private Sub frmGrillaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        'CARGA A TODOS LOS CLIENTES ACTIVOS
        CargarDatosUsuarios("WHERE U.Activo = 1")
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'TRAE EL FORMULARIO PARA AGREGAR UN NUEVO USUARIO
        frmUsuarios.lblTarea.Text = "Nuevo usuario"
        frmUsuarios.Show()
        frmUsuarios.chActivo.Checked = True
        frmUsuarios.lblAvisoActivo.Visible = False
        frmUsuarios.Niveles()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'TRAE EL FORMULARIO PARA EDITAR UN USUARIO
        'CAMBIA LA TAREA DEL FORMULARIO
        frmUsuarios.lblTarea.Text = "Editar usuario"
        'ACTIVO
        Dim activo As Integer = dgvUsuarios.CurrentRow.Cells(7).Value
        Dim activoSecundario As Boolean = dgvUsuarios.CurrentRow.Cells(7).Value
        frmUsuarios.chActivo.Checked = (activo = 1)
        If activoSecundario = True Then
            frmUsuarios.lblAvisoActivo.Text = "El usuario se encuentra ACTIVO"
        Else
            frmUsuarios.lblAvisoActivo.Text = "El usuario se encuentra INACTIVO"
        End If
        'CARGAR COMBOBOX
        frmUsuarios.Niveles()
        'LLEVAR DATOS AL FORM Y ABRIRLO
        frmUsuarios.lblID.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        frmUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        frmUsuarios.txtApellido.Text = dgvUsuarios.CurrentRow.Cells(2).Value
        frmUsuarios.txtPass.Text = dgvUsuarios.CurrentRow.Cells(3).Value
        frmUsuarios.cbNivel.SelectedValue = dgvUsuarios.CurrentRow.Cells(4).Value
        frmUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(6).Value
        frmUsuarios.chActivo.Checked = activo
        'MUESTRA EL FORMULARIO
        frmUsuarios.Show()

    End Sub



    'FUNCIÓN PARA CARGAR A TODOS LOS USUARIOS EXISTENTES
    Public Sub CargarDatosUsuarios(ByVal filtro As String)
        Conexion.CargarCadenaConexion()
        'LLENAR GRILLA
        Dim consultaSQL As String = "SELECT 
                                    U.ID as 'ID',
                                    U.Nombre as 'NOMBRE', 
                                    U.Apellido as 'APELLIDO', 
                                    U.Contraseña as 'CONTRASEÑA',
                                    U.IDNivel,
                                    NU.Nivel as 'NIVEL',
                                    U.Usuario as 'USUARIO',
                                    U.Activo as 'ACTIVO' 
                                    FROM usUsuarios U
                                    INNER JOIN usNiveles NU ON U.IDNivel = NU.ID"
        'CONSULTA SQL CON FILTRO
        If Not String.IsNullOrEmpty(filtro) Then
            consultaSQL &= " " & filtro
        End If
        Dim adaptador As New SqlDataAdapter(consultaSQL, Conexion.conexionSql)
        Dim dsUsuarios As New DataSet()
        adaptador.Fill(dsUsuarios, "usUsuarios")
        dgvUsuarios.DataSource = dsUsuarios.Tables("usUsuarios")
        ' HACER NO VISIBLE LAS COLUMNAS = 0 (ID), 3 (CONTRASEÑA), 4 (ID NIVEL), 7 (ACTIVO)
        dgvUsuarios.Columns(0).Visible = False
        dgvUsuarios.Columns(3).Visible = False
        dgvUsuarios.Columns(4).Visible = False
        dgvUsuarios.Columns(7).Visible = False

        If filtroActivoUsuarios Then
            'SI EL FILTRO ESTA ACTIVO
            aplicarFiltrosDgvUsuarios()
            filtroActivoUsuarios = True
        Else
            'SI EL FILTRO ESTA DESACTIVADO
            filtroActivoUsuarios = False
        End If

    End Sub


    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        CargarDatosUsuarios("")
    End Sub

    Private Sub btnActivos_Click(sender As Object, e As EventArgs) Handles btnActivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnActivos.BackColor = Color.FromArgb(49, 130, 255)
        CargarDatosUsuarios("WHERE U.Activo = 1")
    End Sub

    Private Sub btnInactivos_Click(sender As Object, e As EventArgs) Handles btnInactivos.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnInactivos.BackColor = Color.FromArgb(49, 130, 255)
        CargarDatosUsuarios("WHERE U.Activo = 0")
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'LIMPIO LOS BOTONES DEL FORMULARIO
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnTodos.BackColor = Color.FromArgb(49, 130, 255)
        CargarDatosUsuarios("")
    End Sub


    'FRONT
    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        If filtroActivoUsuarios Then
            ' Si el filtro está activo, desactivarlo
            quitarFiltrosDgvUsuarios()
            filtroActivoUsuarios = False
        Else
            ' Si el filtro está desactivado, activarlo
            aplicarFiltrosDgvUsuarios()
            filtroActivoUsuarios = True
        End If
    End Sub


    'FRONT
    Private Sub aplicarFiltrosDgvUsuarios()
        'ME CAMBIA EL COLOR DEPENDIENDO DE LOS ESTADOS DE LOS CLIENTES
        For Each row As DataGridViewRow In dgvUsuarios.Rows
            Dim activo As Boolean = Convert.ToBoolean(row.Cells("ACTIVO").Value)
            If activo = True Then
                row.DefaultCellStyle.BackColor = Color.FromArgb(148, 255, 136) ' Verde claro
            Else
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 136, 136) ' Rojo claro
            End If
        Next
    End Sub

    'FRONT
    Private Sub quitarFiltrosDgvUsuarios()
        'QUITA LOS COLORES DE LOS FILTROS DE LA GRILLA
        For Each row As DataGridViewRow In dgvUsuarios.Rows
            row.DefaultCellStyle.BackColor = SystemColors.Control
        Next
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        'TRAE EL FORMULARIO PARA VER UN USUARIO
        'CAMBIA LA TAREA DEL FORMULARIO
        frmUsuarios.lblTarea.Text = "Ver usuario"
        'ACTIVO
        Dim activo As Integer = dgvUsuarios.CurrentRow.Cells(7).Value
        Dim activoSecundario As Boolean = dgvUsuarios.CurrentRow.Cells(7).Value
        frmUsuarios.chActivo.Checked = (activo = 1)
        If activoSecundario = True Then
            frmUsuarios.lblAvisoActivo.Text = "El usuario se encuentra ACTIVO"
        Else
            frmUsuarios.lblAvisoActivo.Text = "El usuario se encuentra INACTIVO"
        End If
        'CARGAR COMBOBOX
        frmUsuarios.Niveles()
        'LLEVAR DATOS AL FORM Y ABRIRLO
        frmUsuarios.lblID.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        frmUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        frmUsuarios.txtApellido.Text = dgvUsuarios.CurrentRow.Cells(2).Value
        frmUsuarios.txtPass.Text = dgvUsuarios.CurrentRow.Cells(3).Value
        frmUsuarios.cbNivel.SelectedValue = dgvUsuarios.CurrentRow.Cells(4).Value
        frmUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(6).Value
        frmUsuarios.chActivo.Checked = activo
        'MUESTRA EL FORMULARIO
        frmUsuarios.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'VERIFICAR QUE LA GRILLA NO ESTE VACIA
        If dgvUsuarios.SelectedRows.Count > 0 Then
            'SE OBTIENE EL ID DEL USUARIO
            Dim usuarioID As Integer = dgvUsuarios.CurrentRow.Cells("ID").Value

            'CONFIRMAR DELETE, POR SEGURIDAD
            Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            'SOLO EL USUARIO ADMIN PUEDE ELIMINAR USUARIOS
            If result = DialogResult.Yes Then

                Conexion.CargarCadenaConexion()
                Dim consultaSQL As String = "DELETE FROM usUsuarios WHERE ID = @ID"

                Using conexion As New SqlConnection(conexionSql.ConnectionString)
                    Using comando As New SqlCommand(consultaSQL, conexion)

                        comando.Parameters.AddWithValue("@ID", usuarioID)

                        conexion.Open()
                        comando.ExecuteNonQuery()

                    End Using
                End Using

                'LIMPIO LOS BOTONES DEL FORMULARIO
                limpiarBotones()
                'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
                btnActivos.BackColor = Color.FromArgb(49, 130, 255)
                'RECARGAR LA GRILLA
                CargarDatosUsuarios("WHERE U.Activo = 1")
                MessageBox.Show("Usuario eliminado exitosamente.", "Eliminación completa", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("Seleccione un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'FUNCIÓN PARA LIMPIAR LOS BOTONES DEL GRILLA USUARIOS (FRONT)
    Public Sub limpiarBotones()
        'BOTONES DEl GRILLA USUARIOS
        btnTodos.BackColor = Color.FromArgb(0, 59, 92)
        btnActivos.BackColor = Color.FromArgb(0, 59, 92)
        btnInactivos.BackColor = Color.FromArgb(0, 59, 92)
    End Sub



End Class