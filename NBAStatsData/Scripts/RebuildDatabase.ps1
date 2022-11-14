Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "NBAStatsDB"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\DropDatabase.ps1" -Database $Database
& ".\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Schemas\NBA.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.Team.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.Coach.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.Player.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.Game.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.TeamType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.TeamGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.GameStats.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Tables\NBA.TempData.sql"

Write-Host "Stored procedures..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Procedures\NBA.CreateNBA.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.GetPlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.GetAllPlayers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.GetAllTeams.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.RetrievePlayersSeasonStats.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.RetrieveTeamSeasonSummaries.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.RetrievePlayersMonthStats.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.RetrieveRecordBasedOnMinutes.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Procedures\NBA.RetrievePlayerVSOpponentStats.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreateTeam.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreateCoach.sql"	
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreateTeamType.sql"
./ImportGameStatsData.ps1
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreatePlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreateGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreateTeamGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "..\Sql\Data\NBA.CreateGameStats.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
