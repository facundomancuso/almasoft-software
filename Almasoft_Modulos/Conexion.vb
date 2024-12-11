Imports System.IO
Imports Microsoft.Data.SqlClient
Module Conexion
    ' Para poder generar una cadena de conexión
    Public conexionSql As New SqlConnection

    ' Para la recepción de datos
    Public adaptadorSql As New SqlDataAdapter

    ' Para la ejecución de los comandos de SQL
    Public consultasSql As New SqlCommand

    ' Para realizar las acciones de ejecución 
    Public acciones As New SqlCommand

    ' Para ser un repositorio de datos de la consulta 
    Public lectordatos As SqlDataReader

    ' Para setear datos
    Public setdedatos As New DataSet

    'declaracion de consultaSql
    Public consultaSqlString As String

    ' Método para cargar la cadena de conexión desde el archivo Sistema.ini
    Public Sub CargarCadenaConexion()
        Dim directorio As String = Path.Combine(Directory.GetCurrentDirectory(), "Sistema.ini")

        If File.Exists(directorio) Then
            Try
                ' Lee el contenido del archivo Sistema.ini
                Dim lines As String() = File.ReadAllLines(directorio)

                ' Procesa las líneas y construye la cadena de conexión
                Dim connectionString As String = String.Join(";", lines)

                ' Asigna la cadena de conexión al objeto SqlConnection
                conexionSql.ConnectionString = connectionString
            Catch ex As Exception
                Console.WriteLine("Error al leer el archivo: " & ex.ToString())
            End Try
        Else
            Console.WriteLine("El archivo Sistema.ini no existe en la ruta actual del sistema.")
        End If
    End Sub


End Module
