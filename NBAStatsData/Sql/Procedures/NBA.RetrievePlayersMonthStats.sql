CREATE OR ALTER PROCEDURE NBA.RetrievePlayersMonthStats
	@Name NVARCHAR(128) = '%',
	@MONTH INT = 1
AS
WITH PlayerStatsValues AS (
Select P.[Name] AS PlayerName,
CAST(CAST(SUM(GS.Points)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS PointsPG, 
CAST(CAST(SUM(GS.Rebounds)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS ReboundsPG, 
CAST(CAST(SUM(GS.Assists)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS AssistsPG,
CAST(CAST(SUM(GS.Blocks)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS BlocksPG,
CAST(CAST(SUM(GS.Steals)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS StealsPG,
CAST(CAST(SUM(GS.Turnovers)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS TurnoversPG,
CAST(CAST(SUM(GS.Minutes)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS MinutesPG,
COUNT(*) AS GamesPlayed



From Nba.GameStats GS
INNER JOIN Nba.Player P ON P.PlayerID = GS.PlayerID 
INNER JOIN Nba.Team T ON T.TeamID = GS.TeamID
INNER JOIN Nba.Game G ON G.GameID = GS.GameID
WHERE GS.[Minutes] > 0 AND MONTH(G.Date) = @MONTH
GROUP BY P.[Name]
),
CTE AS (
SELECT  CAST(ROW_NUMBER() OVER(ORDER BY PointsPG DESC) AS INT) AS [Rank], V.PlayerName, V.PointsPG, V.ReboundsPG, V.AssistsPG, V.BlocksPG, V.StealsPG, V.TurnoversPG, V.MinutesPG, V.GamesPlayed, T.[Name] AS TeamName
FROM PlayerStatsValues V
INNER JOIN NBA.Player P ON P.[Name] = V.PlayerName
INNER JOIN NBA.Team T ON T.TeamID = P.CurrentTeamID
)
SELECT *
FROM CTE
WHERE CTE.[PlayerName] LIKE @Name
ORDER BY PointsPG DESC;

