SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Procedencias] ON

MERGE INTO [dbo].[Procedencias] AS [Target]
USING (VALUES
  (1,N'Particular')
) AS [Source] ([ProcedenciaId],[Descripcion])
ON ([Target].[ProcedenciaId] = [Source].[ProcedenciaId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ProcedenciaId],[Descripcion])
 VALUES([Source].[ProcedenciaId],[Source].[Descripcion])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[Procedencias]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[Procedencias] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[Procedencias] OFF
SET NOCOUNT OFF
GO