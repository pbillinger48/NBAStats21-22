bcp NBAStatsDB.NBA.TempData format nul -f TempData.fmt -S "(localdb)\MSSQLLocalDb" -c -T -t ","
bcp NBAStatsDB.NBA.TempData in "../Sql/Data/CurrentNBAData.csv" -S "(localdb)\MSSQLLocalDb" -T -f TempData.fmt -h "CHECK_CONSTRAINTS"


