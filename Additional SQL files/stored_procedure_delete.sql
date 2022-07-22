CREATE PROCEDURE sp_DeleteTeamById
	@teamId int 
AS
BEGIN
	Delete from Teams where Id = @teamId
END
GO