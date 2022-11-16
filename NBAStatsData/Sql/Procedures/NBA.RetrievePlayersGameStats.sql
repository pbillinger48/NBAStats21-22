CREATE OR ALTER PROCEDURE NBA.RetrievePlayersGameStats
	@PlayerName NVARCHAR(128) = '%',
	@PointsMin int = 0,
	@PointsMax int = 200,
	@ReboundsMin int = 0,
	@ReboundsMax int = 200,
	@AssistsMin int = 0,
	@AssistsMax int = 200,
	@BlocksMin int = 0,
	@BlocksMax int = 200,
	@StealsMin int = 0,
	@StealsMax int = 200,
	@TurnoversMin int = 0,
	@TurnoversMax int = 200,
	@MinutesMin int = 0,
	@MinutesMax int = 200,
	@OppName int = '%'
AS
WITH CTE AS
(
SELECT P.[Name]AS PlayerName, T.[Name] AS TeamName, 
GS.Points, GS.Rebounds, GS.Assists, GS.Blocks, GS.Steals, GS.Turnovers, GS.[Minutes],
(
		SELECT T1.[Name]
		FROM NBA.Game G1 
		INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		INNER JOIN NBA.Team T1 ON T1.TeamID = TG1.TeamID		
		WHERE G1.GameID = G.GameID AND 
		T.[Name] <> T1.[Name]
) as OppName,
G.[Date],
(
		SELECT T1.[Location]
		FROM NBA.Game G1 INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		INNER JOIN NBA.Team T1 ON T1.TeamID = TG1.TeamID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID = 1
) as [Location]

FROM NBA.GameStats GS
INNER JOIN NBA.Team T ON T.TeamID = GS.TeamID
INNER JOIN NBA.Player P ON P.PlayerID = GS.PlayerID
INNER JOIN NBA.Game G ON G.GameID = GS.GameID
)

SELECT *
FROM CTE
WHERE CTE.PlayerName LIKE @PlayerName 
AND CTE.OppName = @OppName
AND CTE.Points BETWEEN @PointsMin AND @PointsMax
AND CTE.Rebounds BETWEEN @ReboundsMin AND @ReboundsMax
AND CTE.Assists BETWEEN @AssistsMin AND @AssistsMax
AND CTE.Blocks BETWEEN @BlocksMin AND @BlocksMax
AND CTE.Steals BETWEEN @StealsMin AND @StealsMax
AND CTE.Turnovers BETWEEN @TurnoversMin AND @TurnoversMax
AND CTE.[Minutes] BETWEEN @MinutesMin AND @MinutesMax
ORDER BY CTE.[Date], CTE.Points DESC