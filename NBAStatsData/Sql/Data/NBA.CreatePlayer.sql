INSERT NBA.Player(CurrentTeamID, [Name])
SELECT
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
	END as TeamID
	, T.PlayerName
FROM 
	(
		SELECT MAX(CAST(T.GameDate as date)) as MaxDate, T.PlayerName
		FROM NBA.TempData T
		GROUP BY T.PlayerName
	) Derived
	INNER JOIN NBA.TempData T ON T.PlayerName = Derived.PlayerName
		AND T.GameDate = Derived.MaxDate
