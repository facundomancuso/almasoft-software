Imports System.Reflection

Public Class frmLogin
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        modUtilidades.cerrarbase()
        Me.Close()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'CONDICIÓN PARA QUE SE INGRESE SI O SI UN USUARIO Y UNA CONTRASEÑA
        If (Me.txtUsuario.Text = "") Then
            MessageBox.Show("Usuario inválido", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtUsuario.Select()
            Exit Sub
        ElseIf (Me.txtPass.Text = "") Then
            MessageBox.Show("Contraseña inválida", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtPass.Select()
            Exit Sub
        End If
        Try
            ' Construir la consulta SQL utilizando parámetros para evitar la inyección SQL
            consultaSqlString = "SELECT id, usuario, contraseña, idnivel FROM usUsuarios WHERE Usuario = @NombreUsuario"
            ' Asignar la conexión al comando SQL
            consultasSql.Connection = conexionSql
            consultasSql.CommandText = consultaSqlString
            ' Limpiar parámetros existentes
            consultasSql.Parameters.Clear()
            ' Añadir el parámetro para el nombre de usuario
            consultasSql.Parameters.AddWithValue("@NombreUsuario", txtUsuario.Text)
            ' Abrir la conexión si no está abierta
            modUtilidades.abrirbase()
            ' Ejecutar la consulta y obtener el resultado en un DataTable
            Dim tablaResultados As New DataTable()
            adaptadorSql.SelectCommand = consultasSql
            adaptadorSql.Fill(tablaResultados)
            ' Verificar si se encontraron resultados en la tabla
            If tablaResultados.Rows.Count > 0 Then
                ' Comprobar si la contraseña ingresada coincide con la contraseña en la base de datos
                If txtPass.Text = tablaResultados.Rows(0)("contraseña").ToString() Then
                    ' Contraseña correcta
                    bandera = True
                    ' ASIGNO VALOR A LA VARIABLE PARA SABER EL NIVEL DEL USUARIO INGRESANDO AL SISTEMA
                    nivelUsuarioLogeado = Convert.ToInt32(tablaResultados.Rows(0)("idnivel"))
                    'MsgBox("El nivel del usuario logeado es: " & nivelUsuarioLogeado.ToString(), MsgBoxStyle.Information, "Nivel de Usuario")
                Else
                    ' Contraseña incorrecta
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPass.Focus()
                End If
            Else
                ' Usuario no encontrado
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPass.Focus()
            End If
        Catch ex As Exception
            ' Manejo de excepciones
            MsgBox("Error: " & ex.Message)
        Finally
            If bandera = True Then
                'ASIGNO EL NOMBRE DEL USUARIO EN EL MENU
                frmMenu.lblUsuario.Text = txtUsuario.Text
                'LIMPIO LOS TXT
                txtUsuario.Clear()
                txtPass.Clear()
                'LIMPIO VARIABLES Y CIERRO CONEXIÓN
                modUtilidades.limpiarVariables()
                modUtilidades.cerrarbase()
                frmMenu.Show()
                Me.Hide()
            End If
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONEXION
        Conexion.CargarCadenaConexion()
        'LIMPIO LOS CAMPOS
        txtUsuario.Clear()
        txtPass.Clear()
        'SELECCIONO TXTUSUARIO
        txtUsuario.Select()
        txtUsuario.Focus()
        'OCULTO LA CONTRASEÑA INGRESADA 
        txtPass.UseSystemPasswordChar = True
        'COMANDO PARA BOTONES
        Me.AcceptButton = btnIngresar
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        'MINIMIZA EL FORMULARIO
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'VERIFICA SI SE PRESIONO LA TECLA "ESCAPE"
        If e.KeyCode = Keys.Escape Then
            'CIERRA EL FORMULARIO
            Me.Close()
        End If
    End Sub

    'PARA QUE FUNCIONEN LOS BOTONES COMO COMANDOS
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Establecer KeyPreview en True en el constructor del formulario
    End Sub

    Private Sub checkMostrarPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostrarPass.CheckedChanged
        If checkMostrarPass.Checked Then
            'MUESTRA LA CONTRASEÑA
            txtPass.UseSystemPasswordChar = False
        Else
            'OCULTA LA CONTRASEÑA
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub
End Class