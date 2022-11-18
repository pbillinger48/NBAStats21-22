CREATE OR ALTER PROCEDURE NBA.UpdatePlayer
	@PlayerName NVARCHAR(128),
	@TeamName NVARCHAR(128)
AS
DECLARE
	@TeamID INT = (SELECT T.TeamID FROM NBA.Team T WHERE T.[Name] = @TeamName);

UPDATE NBA.Player
SET CurrentTeamID = @TeamID
WHERE [Name] = @PlayerName;
GO

