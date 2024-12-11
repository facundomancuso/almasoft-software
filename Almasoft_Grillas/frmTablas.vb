Public Class frmTablas

    Private Sub frmTablas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerr_Click(sender As Object, e As EventArgs) Handles btnCerr.Click
        'CIERRA EL FORMULARIO
        Close()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'MINIMIZA EL FORMULARIO
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        'LIMPIO BOTONES
        limpiarBotones()
        'CAMBIO EL COLOR DEL BOTON SELECCIONADO
        btnProductos.BackColor = Color.FromArgb(0, 92, 146)
        'CAMBIO EL COLOR DEL PANEL
        pnlTablas.BackColor = Color.White
        'LLAMO AL METODO PARA ABRIR EL FORMULARIO EN EL PANEL
        abrirFrm(Of frmTablaProductos)(pnlTablas)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        'LIMPIO BOTONES
        limpiarBotones()
        'CAMBIO EL COLOR DEL BOTON SELECCIONADO
        btnVentas.BackColor = Color.FromArgb(0, 92, 146)
        'CAMBIO EL COLOR DEL PANEL
        pnlTablas.BackColor = Color.White
        'LLAMO AL METODO PARA ABRIR EL FORMULARIO EN EL PANEL
        abrirFrm(Of frmTablaVentas)(pnlTablas)
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        'LIMPIO BOTOONES
        limpiarBotones()
        'CAMBIO EL COLOR DEL BOTON SELECCIONADO
        btnConfiguracion.BackColor = Color.FromArgb(0, 92, 146)
        'CAMBIO EL COLOR DEL PANEL
        pnlTablas.BackColor = Color.White
        'LLAMO AL METODO PARA ABRIR FORMULARIO EN EL PANEL
        abrirFrm(Of frmTablaConfig)(pnlTablas)
    End Sub

    Private Sub limpiarBotones()
        'LIMPIO LOS BOTONES
        btnProductos.BackColor = Color.FromArgb(8, 36, 53)
        btnVentas.BackColor = Color.FromArgb(8, 36, 53)
        btnConfiguracion.BackColor = Color.FromArgb(8, 36, 53)
        'LIMPIO EL PANEL
        pnlTablas.BackColor = Color.FromArgb(8, 36, 53)
    End Sub

    'METODO PARA ABRIR FORMULARIOS EN EL PANEL
    Public Sub abrirFrm(Of Forms As {Form, New})(panel As Panel)
        panel.Controls.Clear()
        Dim formulario As Form
        formulario = panel.Controls.OfType(Of Forms)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New Forms()
            formulario.TopLevel = False
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill
            panel.Controls.Add(formulario)
            panel.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
            permisousuario(formulario)
        Else
            If formulario.WindowState = FormWindowState.Minimized Then
                formulario.WindowState = FormWindowState.Normal
            End If
            formulario.BringToFront()
        End If
    End Sub

End Class
