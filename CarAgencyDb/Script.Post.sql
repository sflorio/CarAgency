/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

:r .\Scripts\TipoVehiculo.sql
:r .\Scripts\Marcas.sql
:r .\Scripts\Modelos.sql
:r .\Scripts\Paises.sql
:r .\Scripts\Provincias.sql
:r .\Scripts\Partidos.sql
:r .\Scripts\Localidades.sql
:r .\Scripts\Procedencias.sql


