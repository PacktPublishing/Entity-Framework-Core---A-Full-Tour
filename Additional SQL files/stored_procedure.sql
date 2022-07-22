CREATE PROCEDURE sp_GetTeamCoach
	@teamId int 
AS
BEGIN
	SELECT * from Coaches where TeamId = @teamId
END
GO