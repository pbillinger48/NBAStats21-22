IF OBJECT_ID(N'NBA.TempData') IS NULL
BEGIN
   CREATE TABLE NBA.TempData
   (
      --TempDataID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      --GameID INT NOT NULL FOREIGN KEY
        --REFERENCES NBA.Game(GameID),
      --TeamID INT NOT NULL FOREIGN KEY
        --REFERENCES NBA.Team(TeamID),
      --PlayerID INT NOT NULL FOREIGN KEY
        --REFERENCES NBA.Player(PlayerID),
      GameDate NVARCHAR(100) NOT NULL,
      TeamAbbrev NVARCHAR(100) NOT NULL,
      TeamScore INT NOT NULL,
      HomeOrAway NVARCHAR(100) NOT NULL,
      OpponentTeamAbbrev NVARCHAR(100) NOT NULL,
      OpponentTeamScore INT NOT NULL,
      PlayerName NVARCHAR(100) NOT NULL,
      Points INT NOT NULL,
      Rebounds INT NOT NULL,
      Assists INT NOT NULL,
      Blocks INT NOT NULL,
      Steals INT NOT NULL,
      Turnovers INT NOT NULL,
      [Minutes] NVARCHAR(100) NOT NULL,

      PRIMARY KEY(GameDate, PlayerName)
      --UNIQUE(GameID, PlayerID)
   );
END;
