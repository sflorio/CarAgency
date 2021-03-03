SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Partidos] ON

MERGE INTO [dbo].[Partidos] AS [Target]
USING (SELECT [PartidoId],[Descripcion],[ProvinciaId] FROM [dbo].[Partidos] WHERE 1 = 0 -- Empty dataset (source table contained no rows at time of MERGE generation) 
) AS [Source] ([PartidoId],[Descripcion],[ProvinciaId])
ON ([Target].[PartidoId] = [Source].[PartidoId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[ProvinciaId], [Target].[ProvinciaId]) IS NOT NULL OR NULLIF([Target].[ProvinciaId], [Source].[ProvinciaId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[ProvinciaId] = [Source].[ProvinciaId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([PartidoId],[Descripcion],[ProvinciaId])
 VALUES([Source].[PartidoId],[Source].[Descripcion],[Source].[ProvinciaId])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[Partidos]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[Partidos] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[Partidos] OFF
SET NOCOUNT OFF
GO

