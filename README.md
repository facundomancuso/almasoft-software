## Licencia

Este proyecto está bajo la Licencia No Comercial. Se concede permiso para usar, copiar, modificar y distribuir este software con fines no comerciales. El uso comercial está prohibido sin el permiso explícito de los autores. Para más información acceda al archivo LICENCE

## Introducción
Este es un sistema de gestión realizado en conjunto con un gran compañero (Francisco Vargas). El mismo fue diseñado y creado para la gestión de un almacén. Para más información acceda al archivo ABOUTME

## IMPORTANTE: 
•	Instalar SQL Server 2022 en adelante.

•	Restaurar la base de datos (backup-database/AlmaSoft.bak)

•	Modificar la cadena de conexión del archivo sistema.ini con tus respectivas credenciales (bin/Debug/net8.0-windows/Sistema.ini)

Tu archivo Sistema.ini debería verse así:


  Initial Catalog=Almasoft;
  
  User ID=TU_USER_SQL_SERVER;
  
  Password=TU_PASS_SQL_SERVER;
  
  Data Source=TUDIRECTORIO\SQLAQUI;
  
  Persist Security Info=True;
  
  TrustServerCertificate=True
  

•	Ejecutar Almasoft.exe
