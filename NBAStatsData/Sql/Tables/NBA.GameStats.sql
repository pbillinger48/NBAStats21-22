IF OBJECT_ID(N'NBA.GameStats') IS NULL
BEGIN
   CREATE TABLE NBA.GameStats
   (
      GameStatsID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      GameID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Game(GameID),
      PlayerID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Player(PlayerID),
      TeamID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Team(TeamID),
      Points INT NOT NULL,
      Rebounds INT NOT NULL,
      Assists INT NOT NULL,
      Blocks INT NOT NULL,
      Steals INT NOT NULL,
      Turnovers INT NOT NULL,
      [Minutes] DECIMAL NOT NULL,

      UNIQUE(GameID, PlayerID)
   );
END;
