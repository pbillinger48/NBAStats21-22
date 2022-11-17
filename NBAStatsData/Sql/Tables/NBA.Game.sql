﻿IF OBJECT_ID(N'NBA.Game') IS NULL
BEGIN
   CREATE TABLE NBA.Game
   (
      GameID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      [Date] DATE NOT NULL,
      Matchup NVARCHAR(15) NOT NULL,

      UNIQUE([Date], Matchup)
   );
END;
