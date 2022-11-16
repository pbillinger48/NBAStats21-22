CREATE OR ALTER PROCEDURE NBA.RetrieveTeamGameResults
	@TeamName NVARCHAR(128) = '%'	
AS
WITH CTE AS (
SELECT G.[Date], T.[Name], TG.Score,
	(
		SELECT T1.[Name]
		FROM NBA.Game G1 INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		INNER JOIN NBA.Team T1 ON T1.TeamID = TG1.TeamID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID <> TG.TeamTypeID
	) as OppName,	
	(
		SELECT TG1.Score
		FROM NBA.Game G1 
		INNER JOIN NBA.TeamGame TG1 ON TG1.GameID = G1.GameID
		WHERE G1.GameID = G.GameID AND TG1.TeamTypeID <> TG.TeamTypeID
	) as OppScore,
	(
		SELECT TG2.TeamID
		FROM NBA.Game G2
		INNER JOIN NBA.TeamGame TG2 ON TG2.GameID = G2.GameID
		WHERE G2.GameID = G.GameID AND TG2.TeamTypeID = 1
	) AS HomeTeamID
	
	
FROM NBA.Game G 
INNER JOIN NBA.TeamGame TG ON G.GameID = TG.GameID
INNER JOIN NBA.Team T ON T.TeamID = TG.TeamID
WHERE T.[Name] LIKE @TeamName
)

SELECT CTE.[Date], CTE.[Name], CTE.Score, CTE.OppScore, CTE.OppName, CTE.OppScore, 
IIF(CTE.Score > CTE.OppScore, 'Win', 'Loss') AS RESULT,
T.[Location]
FROM CTE
INNER JOIN NBA.Team T ON T.TeamID = CTE.HomeTeamID
ORDER BY CTE.[Date] ASC

