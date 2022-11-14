CREATE OR ALTER PROCEDURE NBA.RetrieveTeamSeasonSummaries
	@TeamName NVARCHAR(128) = '%'
AS
WITH SourceCTE AS (
SELECT IIF(HomeTeam.HomeScore > AwayTeam.AwayScore, 1, 0) as HomeWins,
            IIF(HomeTeam.HomeScore < AwayTeam.AwayScore, 1, 0) as AwayWins, HomeTeam.GameID,
			HomeTeam.HomeID, AwayTeam.AwayID, HomeTeam.HomeScore, AwayTeam.AwayScore
FROM (
	SELECT  TG.GameID, TG.TeamID AS HomeID, TG.Score AS HomeScore
	FROM NBA.TeamGame TG
	WHERE TG.TeamTypeID = 1
	)  HomeTeam
	INNER JOIN 
	(
	SELECT  TG.GameID, TG.TeamID AS AwayID, TG.Score AS AwayScore
	FROM NBA.TeamGame TG
	WHERE TG.TeamTypeID = 2
	) AwayTeam ON HomeTeam.GameID = AwayTeam.GameID
	)
SELECT T.[Name], SUM(HomeWins) + 
		(
		SELECT SUM(cte2.AwayWins)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		) as Wins,
		(Count(*) + (
		SELECT COUNT(*)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		)) - (SUM(HomeWins) + 
		(
		SELECT SUM(cte2.AwayWins)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID)
		) as Losses,
		CAST((SUM(HomeScore) + 
		(
		SELECT SUM(cte2.AwayScore)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		)) / (Count(*) + 0.0+(
		SELECT COUNT(*)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		)) AS DECIMAL(7,1)) as AveragePointsScored,
		CAST(
		(SUM(AwayScore) + 
		(
		SELECT SUM(cte2.HomeScore)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		)) / (Count(*) + 0.0+ (
		SELECT COUNT(*)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		)) AS DECIMAL(7,1))  as AveragePointsAgainst,
		(Count(*) + (
		SELECT COUNT(*)
		FROM SourceCTE cte2
		WHERE T.TeamID = cte2.AwayID
		)) as GamesPlayed
FROM SourceCTE INNER JOIN NBA.Team T ON SourceCTE.HomeID = T.TeamID
WHERE T.[Name] LIKE @TeamName
GROUP BY T.TeamID, T.[Name]
ORDER BY Wins DESC;
