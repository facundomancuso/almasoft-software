Public Class frmConsultarPrecio
    Private Sub frmConsultarPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        'LIMPIA LOS CONTROLES
        limpiarControles
        'CIERRA EL FORMULARIO
        Close
    End Sub

    'METODO PARA LIMPIAR LOS CONTROLES
    Public Sub limpiarControles()
        lblCodigo.Text = ""
        lblDescripcion.Text = ""
        lblPorcentajeIva.Text = ""
        lblPrecioUnitario.Text = ""
        lblFamilia.Text = ""
        lblSubFamilia.Text = ""
        lblCosto.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'LIMPIA LOS CONTROLES
        limpiarControles()
        'CIERRA EL FORMULARIO
        Me.Close()
    End Sub
End Class