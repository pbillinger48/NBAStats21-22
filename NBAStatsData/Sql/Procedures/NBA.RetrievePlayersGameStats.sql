CREATE OR ALTER PROCEDURE NBA.RetrievePlayersGameStats
	@PlayerName NVARCHAR(128) = '%',
	@PointsMin int = 0,
	@PointsMax int = 200,
	@MinutesMin int = 0,
	@MinutesMax int = 200,
	@OppName NVARCHAR(128) = '%'
AS
WITH CTE AS
(
SELECT P.[Name]AS PlayerName, T.[Name] AS TeamName, 
GS.Points, GS.Rebounds, GS.Assists, GS.Blocks, GS.Steals, GS.Turnovers, CAST(GS.[Minutes] as int) as Minutes,
(
		SELECT T1.[Name]
		FROM NBA.Game G1 
		INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		INNER JOIN NBA.Team T1 ON T1.TeamID = TG1.TeamID		
		WHERE G1.GameID = G.GameID AND 
		T.[Name] <> T1.[Name]
) as OppName,
G.[Date]

FROM NBA.GameStats GS
INNER JOIN NBA.Team T ON T.TeamID = GS.TeamID
INNER JOIN NBA.Player P ON P.PlayerID = GS.PlayerID
INNER JOIN NBA.Game G ON G.GameID = GS.GameID
)

SELECT *
FROM CTE
WHERE CTE.PlayerName LIKE @PlayerName 
AND CTE.OppName LIKE @OppName
AND CTE.Points BETWEEN @PointsMin AND @PointsMax
AND CTE.[Minutes] BETWEEN @MinutesMin AND @MinutesMax
ORDER BY CTE.[Date], CTE.Points DESC