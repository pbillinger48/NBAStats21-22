CREATE OR ALTER PROCEDURE NBA.RetrievePlayersSeasonStats
	@PlayerName NVARCHAR(128) = '%',
	@MinutesThreshold DECIMAL(7,1) = 0	
AS
WITH SourceCTE AS (
	SELECT IIF(HomeTeam.HomeScore > AwayTeam.AwayScore, 1, 0) as HomeWins,
				IIF(HomeTeam.HomeScore < AwayTeam.AwayScore, 1, 0) as AwayWins, HomeTeam.GameID,
				HomeTeam.HomeID, AwayTeam.AwayID, HomeTeam.HomeScore, AwayTeam.AwayScore, P.[Name], P.CurrentTeamID AS PlayersTeamID
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
		INNER JOIN NBA.GameStats GS ON GS.GameID = HomeTeam.GameID
		INNER JOIN NBA.Player P ON P.PlayerID = GS.PlayerID
		WHERE P.[Name] Like @PlayerName AND GS.[Minutes] > @MinutesThreshold
)

SELECT P.[Name],@MinutesThreshold AS MinutesThreshold, COUNT(*) AS GamesPlayed, 
		SUM(HomeWins) + (
		SELECT SUM(SCTE.AwayWins)
		FROM SourceCTE SCTE
		WHERE SCTE.PlayersTeamID = SCTE.AwayID
		) as Wins,
		COUNT(*) - (SUM(HomeWins) + (
		SELECT SUM(SCTE.AwayWins)
		FROM SourceCTE SCTE
		WHERE SCTE.PlayersTeamID = SCTE.AwayID
		)) AS Losses,
		CAST((SUM(HomeWins) + (
		SELECT SUM(SCTE.AwayWins)
		FROM SourceCTE SCTE
		WHERE SCTE.PlayersTeamID = SCTE.AwayID
		)) / (Count(*) + 0.0) * 100 AS DECIMAL(7,2))AS WinningPercentage


FROM SourceCTE SCTE
INNER JOIN NBA.Team T ON SCTE.HomeID = T.TeamID
INNER JOIN NBA.Player P ON P.[Name] = SCTE.[Name]
GROUP BY P.[Name]
GO

