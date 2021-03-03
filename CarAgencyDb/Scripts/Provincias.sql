SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Provincias] ON

MERGE INTO [dbo].[Provincias] AS [Target]
USING (VALUES
  (1,N'Buenos Aires',1)
 ,(3,N'Capital Federal',1)
 ,(4,N'Montevideo',2)
) AS [Source] ([ProvinciaId],[Descripcion],[PaisId])
ON ([Target].[ProvinciaId] = [Source].[ProvinciaId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[PaisId], [Target].[PaisId]) IS NOT NULL OR NULLIF([Target].[PaisId], [Source].[PaisId]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[PaisId] = [Source].[PaisId]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ProvinciaId],[Descripcion],[PaisId])
 VALUES([Source].[ProvinciaId],[Source].[Descripcion],[Source].[PaisId])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[Provincias]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[Provincias] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[Provincias] OFF
SET NOCOUNT OFF
GO
