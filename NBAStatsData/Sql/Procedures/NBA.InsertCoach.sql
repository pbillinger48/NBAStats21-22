CREATE OR ALTER PROCEDURE NBA.InsertCoach
	@CoachName NVARCHAR(128),
	@TeamName NVARCHAR(128)
AS
DECLARE
@TeamID INT = (SELECT T.TeamID FROM NBA.Team T WHERE T.[Name] = @TeamName);

INSERT NBA.Coach (TeamID, [Name])
VALUES (@TeamID, @CoachName);
GO