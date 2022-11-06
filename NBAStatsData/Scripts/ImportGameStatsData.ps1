bcp NBAStatsDB.NBA.TempData format nul -f TempData.fmt -S "(localdb)\MSSQLLocalDb" -c -T
bcp NBAStatsDB.NBA.TempData in "C:\Users\caleb\Downloads\NewNBAData.csv" -S "(localdb)\MSSQLLocalDb" -T -f TempData.fmt -h "CHECK_CONSTRAINTS"


