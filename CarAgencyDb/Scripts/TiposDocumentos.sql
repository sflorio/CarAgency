SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[TipoDocumentos] ON

MERGE INTO [dbo].[TipoDocumentos] AS [Target]
USING (VALUES
  (1,N'DNI')
) AS [Source] ([TipoDocumentoId],[Descripcion])
ON ([Target].[TipoDocumentoId] = [Source].[TipoDocumentoId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([TipoDocumentoId],[Descripcion])
 VALUES([Source].[TipoDocumentoId],[Source].[Descripcion])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[TipoDocumentos]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[TipoDocumentos] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[TipoDocumentos] OFF
SET NOCOUNT OFF
GO