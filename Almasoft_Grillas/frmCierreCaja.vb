Imports Microsoft.Data.SqlClient
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.Diagnostics
Imports System.Globalization
Imports System.Threading

Public Class frmCierreCaja
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        'MINIMIZA EL FORMULARIO
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCierre_Click(sender As Object, e As EventArgs) Handles btnCierre.Click
        GenerarPDFCierreCaja()
    End Sub

    Public Sub GenerarPDFCierreCaja()
        ' FORMATO FECHA Y HORA PARA GUARDAR EL PDF
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ' RUTA DONDE SE GUARDARÁ EL PDF
        Dim pdfPath As String = $"C:\Almasoft\captures\cierreCaja_{timestamp}.pdf"

        ' CONFIGURAR CONEXIÓN Y CONSULTA A LA BASE DE DATOS
        Conexion.CargarCadenaConexion()
        Dim consultaSQL As String = "SELECT F.ID, C.Nombre + ' ' + C.Apellido AS Cliente, F.Fecha, F.PuntoVenta, F.Letra, F.Comprobante, F.Total " &
                                    "FROM vtFacturas F " &
                                    "INNER JOIN vtClientes C ON C.ID = F.IDCliente " &
                                    "WHERE CONVERT(date, F.Fecha) = @fechaCierre"
        Dim adaptador As New SqlDataAdapter(consultaSQL, Conexion.conexionSql)
        adaptador.SelectCommand.Parameters.AddWithValue("@fechaCierre", dtpCierre.Value.Date)

        ' LLENAR EL DATASET
        Dim dsFacturas As New DataSet()
        adaptador.Fill(dsFacturas, "vtFacturas")

        ' CALCULAR TOTALES
        Dim totalComprobantesA As Decimal = 0
        Dim totalComprobantesB As Decimal = 0
        Dim totalGeneral As Decimal = 0

        ' Separar las facturas en A y B
        Dim facturasA = dsFacturas.Tables("vtFacturas").Select("Letra = 'A'")
        Dim facturasB = dsFacturas.Tables("vtFacturas").Select("Letra = 'B'")

        For Each row As DataRow In dsFacturas.Tables("vtFacturas").Rows
            Dim total As Decimal = If(row("Total") IsNot DBNull.Value, Convert.ToDecimal(row("Total")), 0)
            If row("Letra").ToString() = "A" Then
                totalComprobantesA += total
            ElseIf row("Letra").ToString() = "B" Then
                totalComprobantesB += total
            End If
            totalGeneral += total
        Next

        ' INICIAR LA CREACIÓN DEL PDF
        Using writer As New PdfWriter(pdfPath)
            Using pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)

                ' PRIMERA PÁGINA: TOTALES GENERALES
                Dim title As New Paragraph("Cierre de Caja - Fecha: " & dtpCierre.Value.ToString("dd/MM/yyyy"))
                title.SetFontSize(12)
                title.SetBold()
                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                document.Add(title)

                ' Agregar subtítulo de Totales Generales
                Dim subtitulo As New Paragraph("Cierre de caja - Totales Generales")
                subtitulo.SetFontSize(10)
                subtitulo.SetBold()
                document.Add(subtitulo)

                ' Mostrar Totales
                document.Add(New Paragraph("Comprobantes A - Total: " & totalComprobantesA.ToString("C")))
                document.Add(New Paragraph("Comprobantes B - Total: " & totalComprobantesB.ToString("C")))
                document.Add(New Paragraph("-----------------------------"))
                document.Add(New Paragraph("Totales Generales - Total: " & totalGeneral.ToString("C")))

                ' Espacio antes del listado
                document.Add(New Paragraph(" ").SetFontSize(12))

                ' LISTADO DE COMPROBANTES A
                Dim subtituloListadoA As New Paragraph("Cierre de caja - Listado A")
                subtituloListadoA.SetFontSize(10)
                subtituloListadoA.SetBold()
                document.Add(subtituloListadoA)

                ' CREAR LA TABLA PARA EL LISTADO DE COMPROBANTES A
                Dim tableA As New Table(6) ' Usamos 6 columnas para ID, Cliente, Fecha, PuntoVenta, Comprobante y Total
                Dim encabezados As String() = {"ID", "Cliente", "Fecha", "PuntoVenta", "Comprobante", "Total"}
                For Each encabezado In encabezados
                    Dim headerCell As New Cell()
                    headerCell.Add(New Paragraph(encabezado))
                    headerCell.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                    tableA.AddHeaderCell(headerCell)
                Next

                ' AGREGAR LAS FILAS DE DATOS PARA COMPROBANTES A
                For Each row As DataRow In facturasA
                    tableA.AddCell(New Cell().Add(New Paragraph(row("ID").ToString())))
                    tableA.AddCell(New Cell().Add(New Paragraph(row("Cliente").ToString())))
                    tableA.AddCell(New Cell().Add(New Paragraph(Convert.ToDateTime(row("Fecha")).ToString("dd/MM/yyyy"))))
                    tableA.AddCell(New Cell().Add(New Paragraph(row("PuntoVenta").ToString())))
                    tableA.AddCell(New Cell().Add(New Paragraph(row("Comprobante").ToString())))
                    Dim totalValueA As Decimal = Convert.ToDecimal(row("Total"))
                    tableA.AddCell(New Cell().Add(New Paragraph(totalValueA.ToString("C"))))
                Next

                ' AGREGAR TABLA AL DOCUMENTO
                document.Add(tableA)

                ' Espacio antes del listado B
                document.Add(New Paragraph(" ").SetFontSize(12))

                ' LISTADO DE COMPROBANTES B
                Dim subtituloListadoB As New Paragraph("Cierre de caja - Listado B")
                subtituloListadoB.SetFontSize(10)
                subtituloListadoB.SetBold()
                document.Add(subtituloListadoB)

                ' CREAR LA TABLA PARA EL LISTADO DE COMPROBANTES B
                Dim tableB As New Table(6) ' Usamos 6 columnas para ID, Cliente, Fecha, PuntoVenta, Comprobante y Total
                For Each encabezado In encabezados
                    Dim headerCell As New Cell()
                    headerCell.Add(New Paragraph(encabezado))
                    headerCell.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                    tableB.AddHeaderCell(headerCell)
                Next

                ' AGREGAR LAS FILAS DE DATOS PARA COMPROBANTES B
                For Each row As DataRow In facturasB
                    tableB.AddCell(New Cell().Add(New Paragraph(row("ID").ToString())))
                    tableB.AddCell(New Cell().Add(New Paragraph(row("Cliente").ToString())))
                    tableB.AddCell(New Cell().Add(New Paragraph(Convert.ToDateTime(row("Fecha")).ToString("dd/MM/yyyy"))))
                    tableB.AddCell(New Cell().Add(New Paragraph(row("PuntoVenta").ToString())))
                    tableB.AddCell(New Cell().Add(New Paragraph(row("Comprobante").ToString())))
                    Dim totalValueB As Decimal = Convert.ToDecimal(row("Total"))
                    tableB.AddCell(New Cell().Add(New Paragraph(totalValueB.ToString("C"))))
                Next

                ' AGREGAR TABLA AL DOCUMENTO
                document.Add(tableB)
            End Using
        End Using

        ' MENSAJE DE CONFIRMACIÓN Y APERTURA DEL PDF
        MessageBox.Show("PDF de cierre de caja generado correctamente en: " & pdfPath)
        ' ABRE EL PDF AUTOMÁTICAMENTE
        Try
            Process.Start(New ProcessStartInfo(pdfPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el PDF: " & ex.Message)
        End Try
    End Sub

End Class