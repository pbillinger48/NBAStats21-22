CREATE OR ALTER PROCEDURE NBA.InsertPlayer
	@PlayerName NVARCHAR(128),
	@TeamName NVARCHAR(128)
AS
DECLARE
@TeamID INT = (SELECT T.TeamID FROM NBA.Team T WHERE T.[Name] = @TeamName);

INSERT NBA.Player ([Name], CurrentTeamID)
VALUES (@PlayerName, @TeamID);
GO