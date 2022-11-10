IF OBJECT_ID(N'NBA.Player') IS NULL
BEGIN
   CREATE TABLE NBA.Player
   (
      PlayerID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      CurrentTeamID INT NOT NULL FOREIGN KEY
        REFERENCES NBA.Team(TeamID),
      [Name] NVARCHAR(50) NOT NULL,
      --Age NVARCHAR(3) NOT NULL,
      --Position NVARCHAR(3) NOT NULL,
      --Height NVARCHAR(15) NOT NULL,
      --[Weight] NVARCHAR(5) NOT NULL,

      UNIQUE([Name])
   );
END;
