IF OBJECT_ID(N'NBA.TeamGame') IS NULL
BEGIN
   CREATE TABLE NBA.TeamGame
   (
      GameID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Game(GameID),
      TeamID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Team(TeamID),
      TeamTypeID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.TeamType(TeamTypeID),
      Score INT NOT NULL,

      PRIMARY KEY(GameID, TeamTypeID),
      UNIQUE(GameID, TeamID)
   );
END;
