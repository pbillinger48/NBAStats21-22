IF OBJECT_ID(N'NBA.Team') IS NULL
BEGIN
   CREATE TABLE NBA.Team
   (
      TeamID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
      [Name] NVARCHAR(50) NOT NULL,
      OwnerName NVARCHAR(50) NOT NULL,
      [Location] NVARCHAR(50) NOT NULL,
      StadiumName NVARCHAR(50) NOT NULL,

      UNIQUE([Name])
   );
END;
