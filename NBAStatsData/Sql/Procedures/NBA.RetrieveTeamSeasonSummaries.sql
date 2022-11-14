CREATE OR ALTER PROCEDURE NBA.RetrieveTeamSeasonSummaries
	@TeamName NVARCHAR(128) = '%',
	@WinsMin INT = 0,
	@WinsMax INT = 1000,
	@LossesMin INT = 0,
	@LossesMax INT = 1000,
	@PPGScoredMin DECIMAL(7,1) = 0,
	@PPGScoredMax DECIMAL(7,1) = 1000,
	@PPGAgainstMin DECIMAL(7,1) = 0,
	@PPGAgainstMax DECIMAL(7,1) = 1000,
	@GamesPlayedMin INT = 0,
	@GamesPlayedMax INT = 1000
AS
WITH CTE as (
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
CTE2 AS(
SELECT CTE.TeamID, 
		T.[Name],
		SUM(IIF(CTE.Score > CTE.OppScore, 1, 0)) AS Wins, 
		SUM(IIF(CTE.Score > CTE.OppScore, 0, 1)) AS Losses,
		CAST(AVG(CTE.Score+0.0) AS DECIMAL(7,1)) AS PPGScored,
		CAST(AVG(CTE.OppScore+0.0) AS DECIMAL(7,1)) AS PPGAgainst,
		COUNT(CTE.TeamID) AS GamesPlayed
FROM CTE INNER JOIN NBA.Team T ON CTE.TeamID = T.TeamID
GROUP BY CTE.TeamID, T.[Name]
)
SELECT *
FROM CTE2
WHERE CTE2.[Name] LIKE @TeamName
		AND CTE2.Wins BETWEEN @WinsMin AND @WinsMax
		AND CTE2.Losses BETWEEN @LossesMin AND @LossesMax
		AND CTE2.PPGScored BETWEEN @PPGScoredMin AND @PPGScoredMax
		AND CTE2.PPGAgainst BETWEEN @PPGAgainstMin AND @PPGAgainstMax
		AND CTE2.GamesPlayed BETWEEN @GamesPlayedMin AND @GamesPlayedMax
ORDER BY CTE2.Wins DESC;