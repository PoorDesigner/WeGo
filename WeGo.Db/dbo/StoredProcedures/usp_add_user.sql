CREATE PROCEDURE [dbo].[usp_add_user]
	@UserName varchar(50)
AS
	INSERT INTO AspNetUsers values (NEWID(), @UserName, 0, 'AI0+8WzXl7FQ93nkW/noOWe/Iv0M+dkoTuEQllOLiRm/eAgpJWw1t7sP1Ud0onFQIg==', '1c85fd29-c037-40e0-8a3a-9de7b341fb3c', NULL, 0,	0,	NULL,	1,	0, @UserName)
RETURN 0
