﻿CREATE OR ALTER PROCEDURE NBA.GetAllPlayers
AS

SELECT P.PlayerID, P.CurrentTeamID ,P.[Name]
FROM NBA.Player P
GO

