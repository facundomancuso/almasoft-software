Imports System.Globalization
Imports System.Threading

Public Class frmCalculadora
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESTABLECE SEPARADORES DECIMALES POR PUNTO Y NO POR COMA
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        'LIMPIA VARIABLES A USAR
        txtRecibido.Clear()
        lblCambio.Text = String.Empty
    End Sub

    Private Sub txtRecibido_TextChanged(sender As Object, e As EventArgs) Handles txtRecibido.TextChanged
        CalcularCambio()
    End Sub

    Private Sub CalcularCambio()
        Dim totalVenta As Decimal
        'VERIFICA EL TOTAL
        If Decimal.TryParse(lblTotal.Text, totalVenta) Then
            Dim dineroRecibido As Decimal
            'VERIFICA EL DINERO RECIBIDO
            If Decimal.TryParse(txtRecibido.Text, dineroRecibido) Then
                'CALCULA EL CAMBIO
                Dim cambio As Decimal = dineroRecibido - totalVenta

                'MUESTRA EL CAMBIO
                lblCambio.Text = cambio.ToString("F2") 'FORMATEAR A DOS DECIMALES
            Else
                'VALOR INVÁLIDO
                lblCambio.Text = "0.00"
            End If
        Else
            'VALOR INVÁLIDO EN EL TOTAL
            lblCambio.Text = "Error en el total de la venta"
        End If
    End Sub

    Private Sub txtRecibido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecibido.KeyPress

        'PERMITIR BORRAR
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        'PERMITIR NUMEROS Y UN SOLO PUNTO
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        Else
            'VERIFICA SI YA HAY UN PUNTO
            If e.KeyChar = "," AndAlso txtRecibido.Text.Contains(".") Then
                e.Handled = True 'SI YA HAY UN PUNTO, NO PERMITE OTRO
            End If
        End If
    End Sub


End Class