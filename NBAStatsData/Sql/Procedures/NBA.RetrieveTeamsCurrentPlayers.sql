CREATE OR ALTER PROCEDURE NBA.RetrieveTeamsCurrentPlayers
	@TeamName NVARCHAR(128) = '%'
AS
SELECT P.[Name], SUM(IIF(GS.TeamID = P.CurrentTeamID, 1, 0)) as GamesPlayed,
	CAST(SUM(IIF(GS.TeamID = P.CurrentTeamID, GS.[Minutes], 0)) as int) as TotalMinutesPlayed
FROM NBA.Team T
	INNER JOIN NBA.Player P ON P.CurrentTeamID = T.TeamID
	INNER JOIN NBA.GameStats GS ON GS.PlayerID = P.PlayerID
WHERE T.[Name] LIKE @TeamName AND GS.[Minutes] > 0
GROUP BY P.PlayerID, P.[Name]
ORDER BY GamesPlayed DESC, TotalMinutesPlayed DESC;