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
& "NBAStatsData\Scripts\DropDatabase.ps1" -Database $Database
& "NBAStatsData\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Schemas\NBA.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.Team.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.Coach.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.Player.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.Game.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.TeamType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.TeamGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Tables\NBA.GameStats.sql"

Write-Host "Stored procedures..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Procedures\NBA.CreateNBA.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Data\NBA.CreateTeam.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "NBAStatsData\Sql\Data\NBA.CreateCoach.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
