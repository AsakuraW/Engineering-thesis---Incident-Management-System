--tworzenie bazy danych

use AnsSystem

create database AnsSystem
-- tworzenie tabel
CREATE TABLE Status (
  idStatus INTEGER IDENTITY(1,1)  NOT NULL   ,
  name VARCHAR(20)  NULL  ,
PRIMARY KEY(idStatus));


CREATE TABLE Type (
  idType INTEGER IDENTITY(1,1)  NOT NULL ,
  name VARCHAR(30)  NULL    ,
  is_hidden int null,
PRIMARY KEY(idType));


CREATE TABLE Role (
  idRole INTEGER IDENTITY(1,1)  NOT NULL   ,
  name VARCHAR(30)  NULL    ,
PRIMARY KEY(idRole));


CREATE TABLE Users (
  idUsers INTEGER IDENTITY(1,1)  NOT NULL  ,
  email VARCHAR(50)  NULL  ,
  passwd VARCHAR(20)  NULL  ,
  Role_idRole INTEGER  NOT NULL    ,
  able_to_change_passwd varchar(1) not null,
PRIMARY KEY(idUsers)  ,
INDEX Users_FKIndex1(Role_idRole),
  FOREIGN KEY(Role_idRole)
    REFERENCES Role(idRole)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);


drop table Troubles
CREATE TABLE Troubles (
  idTroubles INTEGER IDENTITY(1,1) NOT NULL  ,
  Users_idUsers INTEGER  NOT NULL  ,
  Type_idType INTEGER  NOT NULL  ,
  subiect VARCHAR(100)  NULL  ,
  description VARCHAR(500)   NULL  ,
  place varchar(3) null,
  building varchar(1) null,
  start_date DATETIME  NULL  ,
  Status_idStatus INTEGER  NOT NULL  ,
  Who Varchar(50) NULL ,
  end_date DATETIME  NULL    ,
PRIMARY KEY(idTroubles)  ,
INDEX Troubles_FKIndex1(Users_idUsers)  ,
INDEX Troubles_FKIndex2(Type_idType)  ,
INDEX Troubles_FKIndex3(Status_idStatus),
  FOREIGN KEY(Users_idUsers)
    REFERENCES Users(idUsers)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Type_idType)
    REFERENCES Type(idType)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION,
  FOREIGN KEY(Status_idStatus)
    REFERENCES Status(idStatus)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION);

CREATE TABLE Request (
  idRequest INTEGER IDENTITY(1,1)  NOT NULL ,
  email VARCHAR(50)  NULL    ,
  date_start DATETIME NULL ,
  place VARCHAR(3) NULL,
  building varchar(1) null,
  date_end DATETIME NULL , 
  programs VARCHAR(200) NULL,
PRIMARY KEY(idRequest));

create table emails_for_realization(
	idEmails_for_realization INTEGER IDENTITY(1,1) NOT NULL,
	email varchar(60) NULL,
	PRIMARY KEY(idEmails_for_realization));

create table programs_for_checkboxs(
	idPrograms_for_checkboxs INTEGER IDENTITY(1,1) NOT NULL,
	name varchar(60) NULL,
	PRIMARY KEY(idPrograms_for_checkboxs));


	
-- inserty do testowania
insert into role values ('administrator'),('uzytkownik');
insert into Users values ('admin','admin',1,'1'),('b3s011','test',2,'0'),('b2s112','test',2,'0'),('b1s10','test',2,'0'),('b3s242','test',2,'0');
insert into Status values ('oczekuj¹ce'),('w realizacji'),('zakoñczono');
insert into Type values ('sprzêtowe',0),('systemowe/programowe',0);
insert into Troubles values (2,1,'Problem z drukarka','cos bardzo dlugo nie dziala','011','3',GETDATE(),1,NULL,NULL),(4,2,'cos nie dziala','cos bardzo dlugo nie dziala ZNOWU','10','1',GETDATE(),2,NULL,NULL),(3,2,'Nie dziala strona ans','w sali nie ma internetu','112','2','2023-05-22 12:12:12',1,NULL,NULL);
insert into emails_for_realization values ('gracjan.zarzycki@onet.pl'),('test@firma.pl');

-- select'y do pomocy
select * from status
select * from Users 
select * from Troubles
select * from type
select * from Role
select * from  Request
select * from  emails_for_realization
select * from programs_for_checkboxs

update Troubles set Status_idStatus = 3 where idTroubles = 1

SELECT SUBSTRING(email, 4, 3) as place FROM users
SELECT SUBSTRING(email, 2, 1) AS building FROM users;

select u.email, ty.name, t.subiect, t.Users_idUsers from Troubles t 
join Users u on  t.Users_idUsers = u.idUsers
join Type ty on t.Type_idType=ty.idType
where t.Users_idUsers=1;

SELECT SUBSTRING(email, 4, 3) as place FROM users u left join Troubles t on u.idUsers=t.Users_idUsers where t.idTroubles=4

select t.idTroubles, t.subiect, s.name from Troubles t 
join Status s on t.Status_idStatus = s.idStatus
where t.Users_idUsers=1;
select * from Request
select idRequest as ID, email as 'E-mail', date_start as 'Data z³o¿enia', place as Sala, date_end as 'Data planowana', programs as Programy from Request order by date_end asc

SELECT value AS Programy 
FROM Request 
CROSS APPLY STRING_SPLIT(programs, ',') 
WHERE idRequest = 7



SELECT DISTINCT 
    email, 
    MAX(CASE WHEN value = 'Program1' THEN 'TAK' ELSE 'NIE' END) AS Program1,
    MAX(CASE WHEN value = 'Program2' THEN 'TAK' ELSE 'NIE' END) AS Program2,
    MAX(CASE WHEN value = 'Program3' THEN 'TAK' ELSE 'NIE' END) AS Program3
FROM 
    Request
    CROSS APPLY STRING_SPLIT(programs, ',')
WHERE 
    idRequest = 7
GROUP BY 
    email

	delete from Troubles where idTroubles BETWEEN 2009 and 3003

	DECLARE @counter INT = 1;

WHILE @counter <= 1000
BEGIN
  INSERT INTO Troubles (Users_idUsers, Type_idType, subiect, description, place, building, start_date, Status_idStatus, Who, end_date)
  VALUES (3, 1, 'Subiect', 'Description' , '112', '2', '2025-04-30 21:17:32.240', 1, NULL, NULL);
  
  SET @counter = @counter + 1;
END

SELECT COUNT(*) FROM Troubles WHERE start_date < DATEADD(DAY, 2, GETDATE()) and Status_idStatus in (1,2);