SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[TiposOperaciones] ON

MERGE INTO [dbo].[TiposOperaciones] AS [Target]
USING (VALUES
  (1,N'Debito','2021-02-26T23:09:02.597',N'migration',NULL,NULL,NULL,NULL,1)
 ,(2,N'Credito','2021-02-26T23:09:02.597',N'migration',NULL,NULL,NULL,NULL,1)
) AS [Source] ([TipoOperacionId],[Descripcion],[CreateDateTime],[CreateUser],[UpdateDateTime],[UpdateUser],[DeleteDateTime],[DeleteUser],[Active])
ON ([Target].[TipoOperacionId] = [Source].[TipoOperacionId])
WHEN MATCHED AND (
	NULLIF([Source].[Descripcion], [Target].[Descripcion]) IS NOT NULL OR NULLIF([Target].[Descripcion], [Source].[Descripcion]) IS NOT NULL OR 
	NULLIF([Source].[CreateDateTime], [Target].[CreateDateTime]) IS NOT NULL OR NULLIF([Target].[CreateDateTime], [Source].[CreateDateTime]) IS NOT NULL OR 
	NULLIF([Source].[CreateUser], [Target].[CreateUser]) IS NOT NULL OR NULLIF([Target].[CreateUser], [Source].[CreateUser]) IS NOT NULL OR 
	NULLIF([Source].[UpdateDateTime], [Target].[UpdateDateTime]) IS NOT NULL OR NULLIF([Target].[UpdateDateTime], [Source].[UpdateDateTime]) IS NOT NULL OR 
	NULLIF([Source].[UpdateUser], [Target].[UpdateUser]) IS NOT NULL OR NULLIF([Target].[UpdateUser], [Source].[UpdateUser]) IS NOT NULL OR 
	NULLIF([Source].[DeleteDateTime], [Target].[DeleteDateTime]) IS NOT NULL OR NULLIF([Target].[DeleteDateTime], [Source].[DeleteDateTime]) IS NOT NULL OR 
	NULLIF([Source].[DeleteUser], [Target].[DeleteUser]) IS NOT NULL OR NULLIF([Target].[DeleteUser], [Source].[DeleteUser]) IS NOT NULL OR 
	NULLIF([Source].[Active], [Target].[Active]) IS NOT NULL OR NULLIF([Target].[Active], [Source].[Active]) IS NOT NULL) THEN
 UPDATE SET
  [Target].[Descripcion] = [Source].[Descripcion], 
  [Target].[CreateDateTime] = [Source].[CreateDateTime], 
  [Target].[CreateUser] = [Source].[CreateUser], 
  [Target].[UpdateDateTime] = [Source].[UpdateDateTime], 
  [Target].[UpdateUser] = [Source].[UpdateUser], 
  [Target].[DeleteDateTime] = [Source].[DeleteDateTime], 
  [Target].[DeleteUser] = [Source].[DeleteUser], 
  [Target].[Active] = [Source].[Active]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([TipoOperacionId],[Descripcion],[CreateDateTime],[CreateUser],[UpdateDateTime],[UpdateUser],[DeleteDateTime],[DeleteUser],[Active])
 VALUES([Source].[TipoOperacionId],[Source].[Descripcion],[Source].[CreateDateTime],[Source].[CreateUser],[Source].[UpdateDateTime],[Source].[UpdateUser],[Source].[DeleteDateTime],[Source].[DeleteUser],[Source].[Active])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE;

DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [dbo].[TiposOperaciones]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[dbo].[TiposOperaciones] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO



SET IDENTITY_INSERT [dbo].[TiposOperaciones] OFF
SET NOCOUNT OFF
GO