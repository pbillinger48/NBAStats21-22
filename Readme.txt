Team 4 -- Readme.txt

21-22NBAStats Project
	Contains: All the WindowsForms forms and controls
	
DataAccess Project
	Contains: Classes used for interfacing with the Sql Database. This project was copied from the Lecture 25 Project shown in class.
	Examples: SqlCommandExecutor
			  DataDelegate
			  DataReaderDelegate
			  
NBAStatsData Project
	Folders:
		Scripts Folder: Stores all powershell scripts (including RebuildDatabase)
		DataDelegates Folder: All the DataDelegates created for the Project
		Models Folder: All the model classes for the Project
		Sql Folder: 
			 Data Folder: contains the csv file (which contains all of our original data) and insert sql files used to originally populate the tables
		     Procedures Folder: contains all of our stored procedures some of which are our Aggregating queries
			 Schemas Folder: contains all schema creation files
			 Tables Folder: contains all table creation files
	Also Contains:
		All of our repositories and their interfaces. Team, Player, and DataModification repositories.
			 