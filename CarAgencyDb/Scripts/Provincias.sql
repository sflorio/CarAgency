SET NOCOUNT ON

SET IDENTITY_INSERT [dbo].[Provincias] ON

MERGE INTO [dbo].[Provincias] AS [Target]
USING (VALUES
( 1, 'Misiones', 1),
( 2, 'San Luis', 1),
( 3, 'San Juan', 1),
( 4, 'Entre Ríos', 1),
( 5, 'Santa Cruz', 1),
( 6, 'Río Negro', 1),
( 7, 'Chubut', 1),
( 8, 'Córdoba', 1),
( 9, 'Mendoza', 1),
( 10, 'La Rioja', 1),
( 11, 'Catamarca', 1),
( 12, 'La Pampa', 1),
( 13, 'Santiago del Estero', 1),
( 14, 'Corrientes', 1),
( 15, 'Santa Fe', 1),
( 16, 'Tucumán', 1),
( 17, 'Neuquén', 1),
( 18, 'Salta', 1),
( 19, 'Chaco', 1),
( 20, 'Formosa', 1),
( 21, 'Jujuy', 1),
( 22, 'Ciudad Autónoma de Buenos Aires', 1),
( 23, 'Buenos Aires', 1),
( 24, 'Tierra del Fuego, Antártida e Islas del Atlántico Sur',  1)
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
