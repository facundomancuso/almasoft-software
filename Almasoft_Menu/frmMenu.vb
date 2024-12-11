Public Class frmMenu

    'FRONT
    'METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL
    Public Sub abrirFrm(Of Forms As {Form, New})()
        Conexion.CargarCadenaConexion()
        pnPrincipal.Controls.Clear()
        Dim formulario As Form
        formulario = pnPrincipal.Controls.OfType(Of Forms)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New Forms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            pnPrincipal.Controls.Add(formulario)
            pnPrincipal.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
            'PERMISO DE USUARIO
            permisousuario(formulario)
        Else
            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If
            formulario.BringToFront()
        End If
    End Sub

    'FRONT
    'FUNCIÓN PARA LIMPIAR LOS BOTONES DEL MENU (FRONT)
    Public Sub limpiarBotones()
        'BOTONES DEL MENU 
        btnInicio.BackColor = Color.FromArgb(8, 36, 53)
        btnClientes.BackColor = Color.FromArgb(8, 36, 53)
        btnProveedores.BackColor = Color.FromArgb(8, 36, 53)
        btnProductos.BackColor = Color.FromArgb(8, 36, 53)
        btnVentas.BackColor = Color.FromArgb(8, 36, 53)
        btnSalir.BackColor = Color.FromArgb(8, 36, 53)
        'BOTONES DEL PANEL SUPERIOR
        btnUsuarios.BackColor = Color.FromArgb(0, 59, 92)
        'PANELES DEL MENU
        pnInicio.BackColor = Color.FromArgb(0, 59, 92)
        pnClientes.BackColor = Color.FromArgb(0, 59, 92)
        pnProveedores.BackColor = Color.FromArgb(0, 59, 92)
        pnProductos.BackColor = Color.FromArgb(40, 56, 104)
        pnVentas.BackColor = Color.FromArgb(0, 59, 92)
        pnSalir.BackColor = Color.FromArgb(0, 59, 92)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'LLAMO AL LOGOUT
        frmLogout.Show()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        'FRONT
        'LIMPIO EL PANEL
        pnPrincipal.Controls.Clear()
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnInicio.BackColor = Color.FromArgb(0, 92, 146)
        pnInicio.BackColor = Color.White
        'MUESTRO EL LOGO
        pnPrincipal.Controls.Add(imgLogoAlmasoft)
        imgLogoAlmasoft.BringToFront()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        'FRONT
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnClientes.BackColor = Color.FromArgb(0, 92, 146)
        pnClientes.BackColor = Color.White
        'TRAE EL FORMULARIO AL PANEL PRINCIPAL
        abrirFrm(Of frmGrillaClientes)()
        'ASIGNO TAREA
        'frmGrillaClientes.lblTarea.Text = "Vista"
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        'FRONT
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnProveedores.BackColor = Color.FromArgb(0, 92, 146)
        pnProveedores.BackColor = Color.White
        'TRAE EL FORMULARIO AL PANEL PRINCIPAL
        abrirFrm(Of frmGrillaProveedores)()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        'FRONT
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnProductos.BackColor = Color.FromArgb(0, 92, 146)
        pnProductos.BackColor = Color.White
        'TRAE EL FORMULARIO AL PANEL PRINCIPAL
        abrirFrm(Of frmGrillaProductos)()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        'FRONT
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnVentas.BackColor = Color.FromArgb(0, 92, 146)
        pnVentas.BackColor = Color.White

        frmVentas.lblTarea.Text = "Nueva venta"
        frmVentas.Show()
        frmVentas.FormaDePago()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'FRONT
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnSalir.BackColor = Color.FromArgb(0, 92, 146)
        pnSalir.BackColor = Color.White
        'LLAMO AL LOGOUT
        frmLogout.Show()
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        'FRONT
        'RESTAURA EL FORMULARIO
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        'FRONT
        'MAXIMIZA EL FORMULARIO
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        'FRONT
        'MINIMIZA EL FORMULARIO
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        'FRONT
        'ACTIVAR OCULTAR/MOSTRAR DEPENDIENDO EL TAMAÑO DEL MENU
        If pnMenu.Width = 60 Then
            tmMostrarMenu.Enabled = True
        ElseIf pnMenu.Width = 240 Then
            tmOcultarMenu.Enabled = True
        End If
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        'FRONT
        'REDUCCION PARA EL MENU 
        If pnMenu.Width <= 60 Then
            tmOcultarMenu.Enabled = False
        Else
            pnMenu.Width = pnMenu.Width - 20
            pnLineaMenu1.Width = pnLineaMenu1.Width - 20
            pnLineaMenu2.Width = pnLineaMenu2.Width - 20
            pnPrincipal.Width = pnPrincipal.Width + 20
            pnPrincipal.Left = pnPrincipal.Left - 20
            pnAbajo.Width = pnAbajo.Width + 20
            pnAbajo.Left = pnAbajo.Left - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        'FRONT
        'AUMENTO PARA EL MENU
        If pnMenu.Width >= 240 Then
            tmMostrarMenu.Enabled = False
        Else
            pnMenu.Width = pnMenu.Width + 20
            pnLineaMenu1.Width = pnLineaMenu1.Width + 20
            pnLineaMenu2.Width = pnLineaMenu2.Width + 20
            pnPrincipal.Width = pnPrincipal.Width - 20
            pnPrincipal.Left = pnPrincipal.Left + 20
            pnAbajo.Width = pnAbajo.Width - 20
            pnAbajo.Left = pnAbajo.Left + 20
        End If
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FRONT
        'METODO PARA NO TAPAR LA BARRA DE WINDOWS
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        'PERMISOS DE USUARIO
        permisoUsuarioMenu()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        'FRONT
        'LIMPIO LOS BOTONES DEL MENU
        limpiarBotones()
        'CAMBIO DE COLOR EL BOTÓN SELECCIONADO
        btnUsuarios.BackColor = Color.FromArgb(0, 92, 146)
        'TRAE EL FORMULARIO AL PANEL PRINCIPAL
        'abrirFrm(Of frmGrillaUsuarios)()

        'ABRO EL FORMULARIO
        frmGrillaUsuarios.Show()
    End Sub

    'CONFIGURACION DE SUBMENU LISTADOS
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        MsgBox("En proceso...")
    End Sub

    Private Sub btnCobros_Click(sender As Object, e As EventArgs) Handles btnCobros.Click
        frmCierreCaja.Show()
    End Sub

    Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click
        frmTablas.Show()
    End Sub
End Class