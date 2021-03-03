SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Paises] ON

MERGE INTO [dbo].[Paises] AS [Target]
USING (VALUES
  (1,N'Argentina')
 ,(2,N'Uruguay')
) AS [Source] ([PaisId],[Descripcion])
ON ([Target].[PaisId] = [Source].[PaisId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([PaisId],[Descripcion])
 VALUES([Source].[PaisId],[Source].[Descripcion])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[Paises]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[Paises] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[Paises] OFF
SET NOCOUNT OFF
GO
