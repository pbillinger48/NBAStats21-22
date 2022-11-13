﻿CREATE OR ALTER PROCEDURE NBA.RetrievePlayersSeasonStats
	@Name NVARCHAR(128) = '%',
	@PPGMin DECIMAL(7,1) = 0,
	@PPGMax DECIMAL(7,1) = 99,
	@RPGMin DECIMAL(7,1) = 0,
	@RPGMax DECIMAL(7,1) = 99,
	@APGMin DECIMAL(7,1) = 0,
	@APGMax DECIMAL(7,1) = 99,
	@BPGMin DECIMAL(7,1) = 0,
	@BPGMax DECIMAL(7,1) = 99,
	@SPGMin DECIMAL(7,1) = 0,
	@SPGMax DECIMAL(7,1) = 99,
	@TOPGMin DECIMAL(7,1) = 0,
	@TOPGMax DECIMAL(7,1) = 99,
	@MPGMin DECIMAL(7,1) = 0,
	@MPGMax DECIMAL(7,1) = 99,
	@TeamName NVARCHAR(128) = '%'
AS
WITH PlayerStatsValues AS (
Select P.[Name] AS PlayerName,
CAST(CAST(SUM(G.Points)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS PointsPG, 
CAST(CAST(SUM(G.Rebounds)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS ReboundsPG, 
CAST(CAST(SUM(G.Assists)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS AssistsPG,
CAST(CAST(SUM(G.Blocks)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS BlocksPG,
CAST(CAST(SUM(G.Steals)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS StealsPG,
CAST(CAST(SUM(G.Turnovers)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS TurnoversPG,
CAST(CAST(SUM(G.Minutes)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS MinutesPG



From Nba.GameStats G
INNER JOIN Nba.Player P ON P.PlayerID = G.PlayerID 
INNER JOIN Nba.Team T ON T.TeamID = G.TeamID
WHERE G.Minutes > 0 
GROUP BY P.[Name]
)
SELECT V.PlayerName, V.PointsPG, V.ReboundsPG, V.AssistsPG, V.BlocksPG, V.StealsPG, V.TurnoversPG, V.MinutesPG, T.[Name] AS TeamName
FROM PlayerStatsValues V
INNER JOIN NBA.Player P ON P.[Name] = V.PlayerName
INNER JOIN NBA.Team T ON T.TeamID = P.CurrentTeamID
Where V.PlayerName LIKE @Name 
AND V.PointsPG BETWEEN @PPGMin AND @PPGMax 
AND V.ReboundsPG BETWEEN @RPGMin AND @RPGMax
AND V.AssistsPG BETWEEN @APGMin AND @APGMax
AND V.BlocksPG BETWEEN @BPGMin AND @BPGMax
AND V.StealsPG BETWEEN @SPGMin AND @SPGMax
AND V.TurnoversPG BETWEEN @TOPGMin AND @TOPGMax
AND V.MinutesPG BETWEEN @MPGMin AND @MPGMax
AND T.[Name] LIKE @TeamName;
GO
