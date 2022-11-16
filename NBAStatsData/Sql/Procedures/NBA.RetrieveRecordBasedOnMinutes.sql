CREATE OR ALTER PROCEDURE NBA.RetrieveRecordBasedOnMinutes

	@PlayerName NVARCHAR(128) = '%',
	@MinutesThreshold DECIMAL(7,1) = 0	
AS
WITH CTE as (
SELECT P.[Name], GS.TeamID as PlayerTeamID, GS.[Minutes], G.GameID, TG.TeamID, TG.Score, 
	(
		SELECT TG1.Score
		FROM NBA.Game G1 INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID <> TG.TeamTypeID
	) as OppScore,
	(
		SELECT TG1.TeamID
		FROM NBA.Game G1 INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID <> TG.TeamTypeID
	) as OppID
FROM NBA.Game G 
INNER JOIN NBA.TeamGame TG ON G.GameID = TG.GameID  
INNER JOIN NBA.GameStats GS ON GS.GameID = G.GameID
INNER JOIN NBA.Player P ON P.PlayerID = GS.PlayerID
WHERE P.[Name] = @PlayerName AND GS.TeamID = P.CurrentTeamID
),
CTE2 AS(
SELECT  CTE.[Name] as PlayerName, T.[Name],
		SUM(IIF(CTE.Score > CTE.OppScore AND CTE.[Minutes] >= @MinutesThreshold, 1, 0)) AS WinsWhenThresholdMet, 
		SUM(IIF(CTE.Score < CTE.OppScore AND CTE.[Minutes] >= @MinutesThreshold, 1, 0)) AS LossesWhenThresholdMet,
		SUM(IIF(CTE.Score > CTE.OppScore AND CTE.[Minutes] < @MinutesThreshold, 1, 0)) AS WinsWhenThresholdNotMet, 
		SUM(IIF(CTE.Score < CTE.OppScore AND CTE.[Minutes] < @MinutesThreshold, 1, 0)) AS LossesWhenThresholdNotMet,
		SUM(IIF(CTE.Score > CTE.OppScore AND CTE.[Minutes] >= @MinutesThreshold, 1, 0)) + SUM(IIF(CTE.Score < CTE.OppScore AND CTE.[Minutes] >= @MinutesThreshold, 1, 0)) AS GamesPlayed
FROM CTE 
INNER JOIN NBA.Team T ON CTE.TeamID = T.TeamID
WHERE T.TeamID = CTE.PlayerTeamID
GROUP BY CTE.TeamID, T.[Name], CTE.[Name]
),
CTE3 as (
SELECT G.GameID, TG.TeamID, TG.Score,
	(
		SELECT TG1.Score
		FROM NBA.Game G1 INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID <> TG.TeamTypeID
	) as OppScore,
	(
		SELECT TG1.TeamID
		FROM NBA.Game G1 INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID <> TG.TeamTypeID
	) as OppID
FROM NBA.Game G INNER JOIN NBA.TeamGame TG ON G.GameID = TG.GameID
),
CTE4 AS(
SELECT CTE3.TeamID, 
		T.[Name],
		SUM(IIF(CTE3.Score > CTE3.OppScore, 1, 0)) AS Wins, 
		SUM(IIF(CTE3.Score > CTE3.OppScore, 0, 1)) AS Losses,
		
		COUNT(CTE3.TeamID) AS GamesPlayed
FROM CTE3 INNER JOIN NBA.Team T ON CTE3.TeamID = T.TeamID
GROUP BY CTE3.TeamID, T.[Name]
)
SELECT CTE2.PlayerName, CTE2.[Name], CTE2.WinsWhenThresholdMet, CTE2.LossesWhenThresholdMet, (CTE4.Wins - CTE2.WinsWhenThresholdMet) AS WinsWhenThresholdNotMet, (CTE4.Losses - CTE2.LossesWhenThresholdMet) AS LossesWhenThresholdNotMet
FROM CTE2
INNER JOIN CTE4 ON CTE4.[Name] = CTE2.[Name]

GO

