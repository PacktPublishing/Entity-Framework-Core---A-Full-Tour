CREATE FUNCTION [dbo].[GetEarliestMatch] (@teamId int)
	RETURNS datetime
	BEGIN
		DECLARE @result datetime
		SELECT TOP 1 @result = date
		FROM MATCHES [dbo].[Matches]
		order by Date
		return @result
	END
	
	CREATE VIEW [dbo].[View_1]
	AS
	SELECT t.Name, c.Name AS CoachName, l.Name AS LeagueName
	FROM  dbo.Teams AS t LEFT OUTER JOIN
					  dbo.Coaches AS c ON t.Id = c.TeamId INNER JOIN
					  dbo.Leagues AS l ON t.LeagueId = l.Id
	