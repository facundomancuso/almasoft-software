Public Class frmLogout
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        frmMenu.limpiarBotones()
        frmMenu.Close()
        'CIERRA LOS FORMULARIOS QUE SE ABREN EN VENTANAS ADYACENTES
        frmClientes.Close()
        frmProductos.Close()
        frmProductosProveedores.Close()
        frmProveedores.Close()
        frmUsuarios.Close()
        frmVentas.Close()
        frmCalculadora.Close()
        frmCierreCaja.Close()
        frmGrillaUsuarios.Close()
        'CIERRA EL LOGOUT
        Me.Close()
        'CIERRA LA CONEXIÓN
        modUtilidades.cerrarbase()
        'MUESTRA EL LOGIN
        frmLogin.txtUsuario.Select()
        frmLogin.Show()
        'RESETEO LA VARIABLE DE PERMISOS
        nivelUsuarioLogeado = 0
        'MsgBox("El nivel del usuario logeado es: " & nivelUsuarioLogeado.ToString(), MsgBoxStyle.Information, "Nivel de Usuario")
    End Sub
End Class