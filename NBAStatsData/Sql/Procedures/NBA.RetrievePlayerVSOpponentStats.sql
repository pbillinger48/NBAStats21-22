CREATE OR ALTER PROCEDURE NBA.RetrievePlayerVSOpponentStats
	@PlayerName NVARCHAR(128) = '%',
	@OpponentName NVARCHAR(128) = '%'
AS
WITH teamSource AS(
SELECT TG.GameID, MAX(TG.TeamID)AS Team1, MIN(TG.TeamID) AS Team2
FROM NBA.TeamGame TG
GROUP BY TG.GameID
),
opponentSource AS
(
SELECT TG.GameID,TG.TeamID,T.[Name], IIF(tS.Team1 = TG.TeamID, tS.Team2,ts.Team1) AS OpponentID, T.[Name] AS OpponentName
FROM NBA.TeamGame TG
INNER JOIN teamSource tS ON tS.GameID = TG.GameID
INNER JOIN NBA.Team T ON T.TeamID = IIF(tS.Team1 = TG.TeamID, tS.Team2,ts.Team1)
),

PlayerStatsValues AS (
Select P.[Name] AS PlayerName,
CAST(CAST(SUM(G.Points)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS PointsPG, 
CAST(CAST(SUM(G.Rebounds)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS ReboundsPG, 
CAST(CAST(SUM(G.Assists)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS AssistsPG,
CAST(CAST(SUM(G.Blocks)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS BlocksPG,
CAST(CAST(SUM(G.Steals)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS StealsPG,
CAST(CAST(SUM(G.Turnovers)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS TurnoversPG,
CAST(CAST(SUM(G.Minutes)AS DECIMAL(7,1)) / (CAST(COUNT(*)AS DECIMAL(7,1)))AS DECIMAL (7,1)) AS MinutesPG,
@OpponentName AS OpponentName



From Nba.GameStats G
INNER JOIN Nba.Player P ON P.PlayerID = G.PlayerID 
INNER JOIN Nba.Team T ON T.TeamID = G.TeamID
INNER JOIN opponentSource OS ON OS.GameID = G.GameID
WHERE G.Minutes > 0 AND OS.OpponentName LIKE @OpponentName

GROUP BY P.[Name]
)
SELECT V.PlayerName, V.PointsPG, V.ReboundsPG, V.AssistsPG, V.BlocksPG, V.StealsPG, V.TurnoversPG, V.MinutesPG, T.[Name] AS TeamName, V.OpponentName
FROM PlayerStatsValues V
INNER JOIN NBA.Player P ON P.[Name] = V.PlayerName
INNER JOIN NBA.Team T ON T.TeamID = P.CurrentTeamID

WHERE P.[Name] LIKE @PlayerName

