--create database ESportsSampleDB

use ESportsSampleDB

create table Players (
	PlayerId int PRIMARY KEY,
	PlayerName varchar(50),
	Age int,
	MainCharacter varchar(50),
)

create table Teams (
	TeamId int PRIMARY KEY,
	TeamName varchar(50),
	PlayerId int foreign key references Players(PlayerId),
)

create table Matches (
	MatchId int PRIMARY KEY,
	TeamId int foreign key references Teams(TeamId),
	Outcome int
)