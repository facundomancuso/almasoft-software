Public Class frmGrillaVentas
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        'CIERRA EL FORMULARIO Y LIMPIA LOS BOTONES DEL MENU
        'frmMenu.limpiarBotones()
        'Me.Close()
    End Sub

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        'TRAE EL FORMULARIO PARA AGREGAR UN NUEVO CLIENTE
        'frmVentas.lblTarea.Text = "Nueva venta"
        'frmVentas.Show()
        'frmVentas.FormaDePago()
    End Sub

    Private Sub frmGrillaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class