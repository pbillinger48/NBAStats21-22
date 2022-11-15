IF OBJECT_ID(N'NBA.GameStats') IS NULL
BEGIN
   CREATE TABLE NBA.GameStats
   (
      GameStatsID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      GameID INT NOT NULL,
      PlayerID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Player(PlayerID),
      TeamID INT NOT NULL,
      Points INT NOT NULL,
      Rebounds INT NOT NULL,
      Assists INT NOT NULL,
      Blocks INT NOT NULL,
      Steals INT NOT NULL,
      Turnovers INT NOT NULL,
      [Minutes] DECIMAL NOT NULL,
	  FOREIGN KEY(GameID, TeamID) REFERENCES NBA.TeamGame(GameID,TeamID),
      UNIQUE(GameID, PlayerID)
   );
END;
