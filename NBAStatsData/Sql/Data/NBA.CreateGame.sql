INSERT NBA.Game([Date], Matchup)
SELECT CAST(T.GameDate as date), CONCAT(T.TeamAbbrev, ' v. ', T.OpponentTeamAbbrev) as Matchup
FROM NBA.TempData T
WHERE T.HomeOrAway = 'H'
GROUP BY T.GameDate, T.TeamAbbrev, T.OpponentTeamAbbrev
