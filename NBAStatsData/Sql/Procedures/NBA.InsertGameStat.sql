CREATE OR ALTER PROCEDURE NBA.InsertGameStat
	@GameDate DATE,
	@HomeTeam NVARCHAR(128),
	@AwayTeam NVARCHAR(128),
	@PlayerName NVARCHAR(128),
	@PlayerTeam NVARCHAR(128),
	@Points INT,
	@Rebounds INT,
	@Assists INT,
	@Blocks INT,
	@Steals INT,
	@Turnovers INT,
	@Minutes DECIMAL
AS
DECLARE
@HomeAbbr NVARCHAR(128) = (CASE
	WHEN @HomeTeam = N'Atlanta Hawks' THEN 'ATL'
	WHEN @HomeTeam = N'Boston Celtics' THEN 'BOS'
	WHEN @HomeTeam = N'Brooklyn Nets' THEN 'BRK'  
	WHEN @HomeTeam = N'Charlotte Hornets' THEN 'CHO'  
	WHEN @HomeTeam = N'Chicago Bulls' THEN 'CHI'  
	WHEN @HomeTeam = N'Cleveland Cavaliers' THEN 'CLE'  
	WHEN @HomeTeam = N'Dallas Mavericks' THEN 'DAL'  
	WHEN @HomeTeam = N'Denver Nuggets' THEN 'DEN'  
	WHEN @HomeTeam = N'Detroit Pistons' THEN 'DET'  
	WHEN @HomeTeam = N'Golden State Warriors' THEN 'GSW'  
	WHEN @HomeTeam = N'Houston Rockets' THEN 'HOU'  
	WHEN @HomeTeam = N'Indiana Pacers' THEN 'IND' 
	WHEN @HomeTeam = N'Los Angeles Clippers' THEN 'LAC'  
	WHEN @HomeTeam = N'Los Angeles Lakers' THEN 'LAL'  
	WHEN @HomeTeam = N'Memphis Grizzlies' THEN 'MEM'  
	WHEN @HomeTeam = N'Miami Heat' THEN 'MIA'  
	WHEN @HomeTeam = N'Milwaukee Bucks' THEN 'MIL'  
	WHEN @HomeTeam = N'Minnesota Timberwolves' THEN 'MIN'  
	WHEN @HomeTeam = N'New Orleans Pelicans' THEN 'NOP'  
	WHEN @HomeTeam = N'New York Knicks' THEN 'NYK'  
	WHEN @HomeTeam = N'Oklahoma City Thunder' THEN 'OKC'  
	WHEN @HomeTeam = N'Orlando Magic' THEN 'ORL'  
	WHEN @HomeTeam = N'Philadelphia 76ers' THEN 'PHI'  
	WHEN @HomeTeam = N'Phoenix Suns' THEN 'PHO'  
	WHEN @HomeTeam = N'Portland Trail Blazers' THEN 'POR'  
	WHEN @HomeTeam = N'Sacramento Kings' THEN 'SAC'  
	WHEN @HomeTeam = N'San Antonio Spurs' THEN 'SAS'  
	WHEN @HomeTeam = N'Toronto Raptors' THEN 'TOR'  
	WHEN @HomeTeam = N'Utah Jazz' THEN 'UTA'  
	WHEN @HomeTeam = N'Washington Wizards' THEN 'WAS' 
END),
@AwayAbbr NVARCHAR(128) = (CASE
	WHEN @AwayTeam = N'Atlanta Hawks' THEN 'ATL'
	WHEN @AwayTeam = N'Boston Celtics' THEN 'BOS'
	WHEN @AwayTeam = N'Brooklyn Nets' THEN 'BRK'  
	WHEN @AwayTeam = N'Charlotte Hornets' THEN 'CHO'  
	WHEN @AwayTeam = N'Chicago Bulls' THEN 'CHI'  
	WHEN @AwayTeam = N'Cleveland Cavaliers' THEN 'CLE'  
	WHEN @AwayTeam = N'Dallas Mavericks' THEN 'DAL'  
	WHEN @AwayTeam = N'Denver Nuggets' THEN 'DEN'  
	WHEN @AwayTeam = N'Detroit Pistons' THEN 'DET'  
	WHEN @AwayTeam = N'Golden State Warriors' THEN 'GSW'  
	WHEN @AwayTeam = N'Houston Rockets' THEN 'HOU'  
	WHEN @AwayTeam = N'Indiana Pacers' THEN 'IND' 
	WHEN @AwayTeam = N'Los Angeles Clippers' THEN 'LAC'  
	WHEN @AwayTeam = N'Los Angeles Lakers' THEN 'LAL'  
	WHEN @AwayTeam = N'Memphis Grizzlies' THEN 'MEM'  
	WHEN @AwayTeam = N'Miami Heat' THEN 'MIA'  
	WHEN @AwayTeam = N'Milwaukee Bucks' THEN 'MIL'  
	WHEN @AwayTeam = N'Minnesota Timberwolves' THEN 'MIN'  
	WHEN @AwayTeam = N'New Orleans Pelicans' THEN 'NOP'  
	WHEN @AwayTeam = N'New York Knicks' THEN 'NYK'  
	WHEN @AwayTeam = N'Oklahoma City Thunder' THEN 'OKC'  
	WHEN @AwayTeam = N'Orlando Magic' THEN 'ORL'  
	WHEN @AwayTeam = N'Philadelphia 76ers' THEN 'PHI'  
	WHEN @AwayTeam = N'Phoenix Suns' THEN 'PHO'  
	WHEN @AwayTeam = N'Portland Trail Blazers' THEN 'POR'  
	WHEN @AwayTeam = N'Sacramento Kings' THEN 'SAC'  
	WHEN @AwayTeam = N'San Antonio Spurs' THEN 'SAS'  
	WHEN @AwayTeam = N'Toronto Raptors' THEN 'TOR'  
	WHEN @AwayTeam = N'Utah Jazz' THEN 'UTA'  
	WHEN @AwayTeam = N'Washington Wizards' THEN 'WAS' 
END);


DECLARE
@GameID INT = (SELECT G.GameID FROM NBA.Game G WHERE G.[Date] = @GameDate AND G.Matchup = @HomeAbbr + N' v. ' + @AwayAbbr),
@TeamID INT = (SELECT T.TeamID FROM NBA.Team T WHERE T.[Name] = @PlayerTeam),
@PlayerID INT = (SELECT P.PlayerID FROM NBA.Player P WHERE P.[Name] = @PlayerName);

INSERT NBA.GameStats (GameID, PlayerID, TeamID, Points, Rebounds, Assists, Blocks, Steals, Turnovers, [Minutes])
VALUES (@GameID, @PlayerID, @TeamID, @Points, @Rebounds, @Assists, @Blocks, @Steals, @Turnovers, @Minutes);
GO



