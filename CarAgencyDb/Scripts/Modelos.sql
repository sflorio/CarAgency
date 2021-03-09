SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Modelos] ON

MERGE INTO [dbo].[Modelos] AS [Target]
USING (
	:r ..\Data\ModeloData.sql
) AS [Source] ([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
ON ([Target].[ModeloId] = [Source].[ModeloId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[MarcaId], [Target].[MarcaId]) IS NOT NULL OR NULLIF([Target].[MarcaId], [Source].[MarcaId]) IS NOT NULL OR 
	NULLIF([Source].[TipoVehiculoId], [Target].[TipoVehiculoId]) IS NOT NULL OR NULLIF([Target].[TipoVehiculoId], [Source].[TipoVehiculoId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[MarcaId] = [Source].[MarcaId], 
  [Target].[TipoVehiculoId] = [Source].[TipoVehiculoId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
 VALUES([Source].[ModeloId],[Source].[Descripcion],[Source].[MarcaId],[Source].[TipoVehiculoId])
;


 MERGE INTO [dbo].[Modelos] AS [Target]
USING (
	:r ..\Data\ModeloData2.sql
) AS [Source] ([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
ON ([Target].[ModeloId] = [Source].[ModeloId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[MarcaId], [Target].[MarcaId]) IS NOT NULL OR NULLIF([Target].[MarcaId], [Source].[MarcaId]) IS NOT NULL OR 
	NULLIF([Source].[TipoVehiculoId], [Target].[TipoVehiculoId]) IS NOT NULL OR NULLIF([Target].[TipoVehiculoId], [Source].[TipoVehiculoId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[MarcaId] = [Source].[MarcaId], 
  [Target].[TipoVehiculoId] = [Source].[TipoVehiculoId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
 VALUES([Source].[ModeloId],[Source].[Descripcion],[Source].[MarcaId],[Source].[TipoVehiculoId])
;

 MERGE INTO [dbo].[Modelos] AS [Target]
USING (
	:r ..\Data\ModeloData3.sql
) AS [Source] ([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
ON ([Target].[ModeloId] = [Source].[ModeloId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[MarcaId], [Target].[MarcaId]) IS NOT NULL OR NULLIF([Target].[MarcaId], [Source].[MarcaId]) IS NOT NULL OR 
	NULLIF([Source].[TipoVehiculoId], [Target].[TipoVehiculoId]) IS NOT NULL OR NULLIF([Target].[TipoVehiculoId], [Source].[TipoVehiculoId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[MarcaId] = [Source].[MarcaId], 
  [Target].[TipoVehiculoId] = [Source].[TipoVehiculoId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
 VALUES([Source].[ModeloId],[Source].[Descripcion],[Source].[MarcaId],[Source].[TipoVehiculoId])
;


 MERGE INTO [dbo].[Modelos] AS [Target]
USING (
	:r ..\Data\ModeloData4.sql
) AS [Source] ([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
ON ([Target].[ModeloId] = [Source].[ModeloId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[MarcaId], [Target].[MarcaId]) IS NOT NULL OR NULLIF([Target].[MarcaId], [Source].[MarcaId]) IS NOT NULL OR 
	NULLIF([Source].[TipoVehiculoId], [Target].[TipoVehiculoId]) IS NOT NULL OR NULLIF([Target].[TipoVehiculoId], [Source].[TipoVehiculoId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[MarcaId] = [Source].[MarcaId], 
  [Target].[TipoVehiculoId] = [Source].[TipoVehiculoId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
 VALUES([Source].[ModeloId],[Source].[Descripcion],[Source].[MarcaId],[Source].[TipoVehiculoId])
;


 MERGE INTO [dbo].[Modelos] AS [Target]
USING (
	:r ..\Data\ModeloData5.sql
) AS [Source] ([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
ON ([Target].[ModeloId] = [Source].[ModeloId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[MarcaId], [Target].[MarcaId]) IS NOT NULL OR NULLIF([Target].[MarcaId], [Source].[MarcaId]) IS NOT NULL OR 
	NULLIF([Source].[TipoVehiculoId], [Target].[TipoVehiculoId]) IS NOT NULL OR NULLIF([Target].[TipoVehiculoId], [Source].[TipoVehiculoId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[MarcaId] = [Source].[MarcaId], 
  [Target].[TipoVehiculoId] = [Source].[TipoVehiculoId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ModeloId],[Descripcion],[MarcaId],[TipoVehiculoId])
 VALUES([Source].[ModeloId],[Source].[Descripcion],[Source].[MarcaId],[Source].[TipoVehiculoId])
;

SET IDENTITY_INSERT [dbo].[Modelos] OFF