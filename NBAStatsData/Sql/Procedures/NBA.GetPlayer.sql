CREATE OR ALTER PROCEDURE NBA.GetPlayer
   @Name NVARCHAR(128)
AS

SELECT P.PlayerID, P.CurrentTeamID ,P.[Name]
FROM NBA.Player P
WHERE P.[Name] = @Name;
GO

