Imports System.IO
Module modUtilidades
    Public filtroActivoClientes As Boolean = False
    Public filtroActivoProveedores As Boolean = False
    Public filtroActivoUsuarios As Boolean = False
    Public filtroActivoProductos As Boolean = False
    Public bandera As Boolean = False
    Public pdfClientes As Integer = 0
    Public pdfProveedores As Integer = 0
    Public pdfProductos As Integer = 0
    Public nivelUsuarioLogeado As Integer = 0

    '''
    'LIMPIAR VARIABLES
    Public Sub limpiarVariables()
        'LIMPIA LOS PARAMETROS PREVIOS
        consultasSql.Parameters.Clear()
        'LIMPIA EL DATASET ANTES DE LLENARLO
        setdedatos.Clear()
        'VERIFICA SI EL SELECTCOMMAND DEL SQLADATAADAPTER NO ES NULO ANTES DE LIMPIARLO
        If adaptadorSql.SelectCommand IsNot Nothing Then
            adaptadorSql.SelectCommand.Parameters.Clear()
        End If
        'LIMPIO VARIABLES GLOBALES
        bandera = False
    End Sub


    'PERMISO DE USUARIO EN EL PANEL
    Public Sub permisousuario(form As Form)
        'ADMINISTRADOR
        If nivelUsuarioLogeado = 1 Then
            'CLIENTES
            If TypeOf form Is frmGrillaClientes Then
                CType(form, frmGrillaClientes).btnEditar.Enabled = True
                CType(form, frmGrillaClientes).btnEliminar.Enabled = True
                CType(form, frmGrillaClientes).btnGenerarPdf.Enabled = True
            End If

            'PROVEEDORES
            If TypeOf form Is frmGrillaProveedores Then
                CType(form, frmGrillaProveedores).btnEditar.Enabled = True
                CType(form, frmGrillaProveedores).btnEliminar.Enabled = True
                CType(form, frmGrillaProveedores).btnGenerarPdf.Enabled = True
                CType(form, frmGrillaProveedores).btnRelaciones.Enabled = True
            End If

            'PRODUCTOS
            If TypeOf form Is frmGrillaProductos Then
                CType(form, frmGrillaProductos).btnEditar.Enabled = True
                CType(form, frmGrillaProductos).btnEliminar.Enabled = True
                CType(form, frmGrillaProductos).btnGenerarPdf.Enabled = True
            End If

            'VENTAS
            If TypeOf form Is frmGrillaVentas Then
                CType(form, frmGrillaVentas).btnEditar.Enabled = True
                CType(form, frmGrillaVentas).btnEliminar.Enabled = True
            End If

            'USUARIO/VENDEDOR
        ElseIf nivelUsuarioLogeado = 2 Or nivelUsuarioLogeado = 3 Then
            'CLIENTES
            If TypeOf form Is frmGrillaClientes Then
                CType(form, frmGrillaClientes).btnEditar.Enabled = False
                CType(form, frmGrillaClientes).btnEliminar.Enabled = False
                CType(form, frmGrillaClientes).btnGenerarPdf.Enabled = False
            End If

            'PROVEEDORES
            If TypeOf form Is frmGrillaProveedores Then
                CType(form, frmGrillaProveedores).btnEditar.Enabled = False
                CType(form, frmGrillaProveedores).btnEliminar.Enabled = False
                CType(form, frmGrillaProveedores).btnGenerarPdf.Enabled = False
                CType(form, frmGrillaProveedores).btnRelaciones.Enabled = False
            End If

            'PRODUCTOS
            If TypeOf form Is frmGrillaProductos Then
                CType(form, frmGrillaProductos).btnEditar.Enabled = False
                CType(form, frmGrillaProductos).btnEliminar.Enabled = False
                CType(form, frmGrillaProductos).btnGenerarPdf.Enabled = False
            End If

            'VENTAS
            If TypeOf form Is frmGrillaVentas Then
                CType(form, frmGrillaVentas).btnEditar.Enabled = False
                CType(form, frmGrillaVentas).btnEliminar.Enabled = False
            End If
        End If
    End Sub


    'PERMISOS DE USUARIO EN EL MENU PRINCIPAL
    Public Sub permisoUsuarioMenu()
        'ADMINISTRADOR
        If nivelUsuarioLogeado = 1 Then
            'MENU
            frmMenu.btnCobros.Enabled = True
            frmMenu.btnListados.Enabled = True
            frmMenu.btnUsuarios.Enabled = True
            'USUARIO/VENDEDOR
        ElseIf nivelUsuarioLogeado = 2 Or nivelUsuarioLogeado = 3 Then
            frmMenu.btnCobros.Enabled = False
            frmMenu.btnListados.Enabled = False
            frmMenu.btnUsuarios.Enabled = False
        End If
    End Sub

    '''

    Public Sub cerrarbase()
        If conexionSql.State = ConnectionState.Open Then
            conexionSql.Close()
        End If
    End Sub
    Public Sub abrirbase()
        If conexionSql.State <> ConnectionState.Open Then
            conexionSql.Open()
        End If
    End Sub

End Module
