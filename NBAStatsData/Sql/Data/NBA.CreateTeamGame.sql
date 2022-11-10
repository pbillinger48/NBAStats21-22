INSERT NBA.TeamGame(GameID, TeamID, TeamTypeID, Score)
SELECT G.GameID, 
	CASE
		WHEN T.TeamAbbrev = 'ATL' THEN 1
		WHEN T.TeamAbbrev = 'BOS' THEN 2
		WHEN T.TeamAbbrev = 'BRK' THEN 3
		WHEN T.TeamAbbrev = 'CHO' THEN 4
		WHEN T.TeamAbbrev = 'CHI' THEN 5
		WHEN T.TeamAbbrev = 'CLE' THEN 6
		WHEN T.TeamAbbrev = 'DAL' THEN 7
		WHEN T.TeamAbbrev = 'DEN' THEN 8
		WHEN T.TeamAbbrev = 'DET' THEN 9
		WHEN T.TeamAbbrev = 'GSW' THEN 10
		WHEN T.TeamAbbrev = 'HOU' THEN 11
		WHEN T.TeamAbbrev = 'IND' THEN 12
		WHEN T.TeamAbbrev = 'LAC' THEN 13
		WHEN T.TeamAbbrev = 'LAL' THEN 14
		WHEN T.TeamAbbrev = 'MEM' THEN 15
		WHEN T.TeamAbbrev = 'MIA' THEN 16
		WHEN T.TeamAbbrev = 'MIL' THEN 17
		WHEN T.TeamAbbrev = 'MIN' THEN 18
		WHEN T.TeamAbbrev = 'NOP' THEN 19
		WHEN T.TeamAbbrev = 'NYK' THEN 20
		WHEN T.TeamAbbrev = 'OKC' THEN 21
		WHEN T.TeamAbbrev = 'ORL' THEN 22
		WHEN T.TeamAbbrev = 'PHI' THEN 23
		WHEN T.TeamAbbrev = 'PHO' THEN 24
		WHEN T.TeamAbbrev = 'POR' THEN 25
		WHEN T.TeamAbbrev = 'SAC' THEN 26
		WHEN T.TeamAbbrev = 'SAS' THEN 27
		WHEN T.TeamAbbrev = 'TOR' THEN 28
		WHEN T.TeamAbbrev = 'UTA' THEN 29
		WHEN T.TeamAbbrev = 'WAS' THEN 30
	END as TeamID,
	CASE WHEN T.HomeOrAway = 'H' THEN 1
	ELSE 2
	END as TeamTypeID, T.TeamScore
FROM NBA.TempData T
	INNER JOIN NBA.Game G ON G.[Date] = T.GameDate
WHERE G.Matchup LIKE CONCAT('%', T.TeamAbbrev, '%') AND G.Matchup LIKE CONCAT('%', T.OpponentTeamAbbrev, '%')
GROUP BY G.GameID, T.TeamAbbrev, T.HomeOrAway, T.TeamScore;
