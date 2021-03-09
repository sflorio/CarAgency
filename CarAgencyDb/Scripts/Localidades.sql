
SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Localidades] ON

MERGE INTO [dbo].[Localidades] AS [Target]
USING (
	:r ..\Data\LocalidadesData.sql
) AS [Source] ([LocalidadId],[Descripcion],[PartidoId])
ON ([Target].[LocalidadId] = [Source].[LocalidadId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[PartidoId], [Target].[PartidoId]) IS NOT NULL OR NULLIF([Target].[PartidoId], [Source].[PartidoId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[PartidoId] = [Source].[PartidoId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([LocalidadId],[Descripcion],[PartidoId])
 VALUES([Source].[LocalidadId],[Source].[Descripcion],[Source].[PartidoId])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[Localidades]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[Localidades] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[Localidades] OFF
SET NOCOUNT OFF
GO
