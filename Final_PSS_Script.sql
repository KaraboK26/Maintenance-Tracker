USE master
GO

CREATE DATABASE [Premier Service Solutions]
GO

Use [Premier Service Solutions]
GO

CREATE TABLE Contract(
ContractID int PRIMARY KEY identity(1,1),
ContractType varchar(50) not null,
ContractPriority varchar(10) not null,
ContractSales int not null,
Price money not null,
Availablity varchar(20) not null
)

GO

INSERT INTO Contract(ContractType,ContractPriority,ContractSales,Price,Availablity)VALUES('Bronze','Low',1150,13000,'Unavaialble')
INSERT INTO Contract(ContractType,ContractPriority,ContractSales,Price,Availablity)VALUES('Silver','Low',90,5500,'Available')
INSERT INTO Contract(ContractType,ContractPriority,ContractSales,Price,Availablity)VALUES('Gold','High',150,3000,'Available')
INSERT INTO Contract(ContractType,ContractPriority,ContractSales,Price,Availablity)VALUES('Diamond','High',15,9000,'Unavailable')
INSERT INTO Contract(ContractType,ContractPriority,ContractSales,Price,Availablity)VALUES('Platinum','High',45,7500,'Available')

GO

CREATE TABLE Client(
ClientID int PRIMARY KEY identity(1,1),
ClientName varchar(50) not null,
ClientSurname varchar(50) not null,
ClientNumber nvarchar(10) not null,
ClientAddress nvarchar(50) not null,
ClientType varchar(50) not null,
ContractID int FOREIGN KEY REFERENCES Contract(ContractID),
)

GO

INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Karabo','Koka','0712345678','544 Moletjie','Business',1)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Heinrich','Neihaus','0721345678','36 Landroes Mare','Individual',3)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Shakeng','Thamaga','0787654321','44 Heatherdale Akasia','Business',5)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Opal', 'Murray','0855419835','45 Hatfield','Business',4)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Eloise','Bell','0822674593','360 Seshego','Individual',2)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Ricardo','Walls','0846397541','4 Jane Furse','Business',1)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Macey','Lamb','0845254745','18 Parktown','Business',5)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Katlyn','Rudd','0852164541','07 Soshanguve block K','Individual',2)
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)VALUES('Mehdi','Moran','0836094331','01 Soweto Zone 4','Business',4)


GO

CREATE TABLE CallManager(
CallID int PRIMARY KEY identity(1,1),
CallDate datetime not null,
CallDuration time not null,
CallNumber nvarchar(10) not null,
ClientProblem varchar(150),
ClientID int FOREIGN KEY REFERENCES Client(ClientID)
)

GO

INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-19, '00:02:01', '08376','Solar panel',1)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-19, '00:01:01','08278','Wifi',2)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-20, '00:03:00', '08115','Dstv Installation',3)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-21, '00:00:51','08284','Wifi installation',4)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-22, '00:01:22', '08748','Solar panel',5)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-23, '00:01:10','08148','Wifi',6)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-24, '00:00:31', '08745','Wifi Service Check up',7)
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)VALUES(2022-07-25, '00:00:46','08359','Wifi installation',8)

GO

CREATE TABLE Branch(
BranchID int PRIMARY KEY identity(1,1),
BranchName nvarchar(100) not null,
BranchLocation nvarchar(100) not null
)

GO

INSERT INTO Branch(BranchName,BranchLocation)VALUES('PSSjhb','Johannesburg')
INSERT INTO Branch(BranchName,BranchLocation)VALUES('PSScpt','Cape Town')

GO

CREATE TABLE Employee(
EmployeeID int PRIMARY KEY,
BranchID int FOREIGN KEY REFERENCES Branch(BranchID)
)

GO 

INSERT INTO Employee(EmployeeID,BranchID)VALUES(578204,1)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578205,2)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578206,2)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578207,1)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578208,1)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578209,1)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578210,2)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578211,2)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578212,1)
INSERT INTO Employee(EmployeeID,BranchID)VALUES(578213,1)

GO

CREATE TABLE CallAgent(
AgentName varchar(50) not null,
AgentSurname varchar(50) not null,
PhoneNumber nvarchar(10) not null,
AgentID int UNIQUE FOREIGN KEY REFERENCES Employee(EmployeeID) ON DELETE CASCADE,
PRIMARY KEY(AgentID)
)

GO

INSERT INTO CallAgent(AgentName,AgentSurname,PhoneNumber,AgentID)VALUES('Edwin', 'Blair', '0831728714', 578204)
INSERT INTO CallAgent(AgentName,AgentSurname,PhoneNumber,AgentID)VALUES('Cora', 'Fenton', '0853559764', 578205)
INSERT INTO CallAgent(AgentName,AgentSurname,PhoneNumber,AgentID)VALUES('Krisha','Ireland', '0856765741', 578211)
INSERT INTO CallAgent(AgentName,AgentSurname,PhoneNumber,AgentID)VALUES('Hoorain','Espinoza', '0823658555', 578212)
INSERT INTO CallAgent(AgentName,AgentSurname,PhoneNumber,AgentID)VALUES('Delilah','Valentine', '0822373440', 578213)

GO

CREATE TABLE Technician(
TechhnicianName varchar(50) not null,
TechnicianSurname varchar(50) not null,
PhoneNumber nvarchar(10) not null,
JobDescription varchar(50) not null,
Availability varchar(50) default 'Available',
TechnicianID int FOREIGN KEY REFERENCES Employee(EmployeeID) ON DELETE CASCADE,
PRIMARY KEY(TechnicianID)
)

GO

INSERT INTO Technician(TechhnicianName,TechnicianSurname, PhoneNumber,JobDescription,TechnicianID)VALUES('Devon', 'Navarro','0843006338','wifi installation expert',578206)
INSERT INTO Technician(TechhnicianName,TechnicianSurname, PhoneNumber,JobDescription,TechnicianID)VALUES('Simra' ,'Stott','0847147510','solar installation expert',578207)
INSERT INTO Technician(TechhnicianName,TechnicianSurname, PhoneNumber,JobDescription,TechnicianID)VALUES('Benjamin','Mcmahon','0847174753','dstv installation expert',578208)
INSERT INTO Technician(TechhnicianName,TechnicianSurname, PhoneNumber,JobDescription,TechnicianID)VALUES('Varun','Benton', '0826339916','Wifi installation expert', 578209)
INSERT INTO Technician(TechhnicianName,TechnicianSurname, PhoneNumber,JobDescription,TechnicianID)VALUES('Damien','Bellamy', '0831097323','Dstv installation expert', 578210)


GO

CREATE TABLE Service(
ServiceID int PRIMARY KEY identity(1,1),
ServiceDescription varchar(100) not null,
ServiceLevel int
)

GO

INSERT INTO Service(ServiceDescription,ServiceLevel)VALUES('wifi installation',2)
INSERT INTO Service(ServiceDescription,ServiceLevel)VALUES('Solar installation',4)
INSERT INTO Service(ServiceDescription,ServiceLevel)VALUES('tv installation',2)
INSERT INTO Service(ServiceDescription,ServiceLevel)VALUES('maintenance',1)
INSERT INTO Service(ServiceDescription,ServiceLevel)VALUES('repairs',1)

GO

CREATE TABLE Jobs(
JobID int PRIMARY KEY identity(1,1),
JobPriority nvarchar(10) not null,
TechnicianID int FOREIGN KEY REFERENCES Technician(TechnicianID) ON DELETE CASCADE,
ClientID int FOREIGN KEY REFERENCES Client(ClientID) ON DELETE CASCADE,
ServiceID int FOREIGN KEY REFERENCES Service(ServiceID)
)
GO

INSERT INTO Jobs(JobPriority,TechnicianID,ServiceID,ClientID)VALUES('High',578206,1,1)
INSERT INTO Jobs(JobPriority,TechnicianID,ServiceID,ClientID)VALUES('Low',578208,2,2)
INSERT INTO Jobs(JobPriority,TechnicianID,ServiceID,ClientID)VALUES('High',578207,1,3)
INSERT INTO Jobs(JobPriority,TechnicianID,ServiceID,ClientID)VALUES('Low',578209,2,4)
INSERT INTO Jobs(JobPriority,TechnicianID,ServiceID,ClientID)VALUES('High',578210,1,5)

GO

CREATE TABLE ServiceRequests(
RequestID int PRIMARY KEY identity(1,1),
ClientID int FOREIGN KEY REFERENCES Client(ClientID) ON DELETE CASCADE,
ServiceID int FOREIGN KEY REFERENCES Service(ServiceID)
)

INSERT INTO ServiceRequests(ClientID,ServiceID)VALUES(3,1)
INSERT INTO ServiceRequests(ClientID,ServiceID)VALUES(1,1)
INSERT INTO ServiceRequests(ClientID,ServiceID)VALUES(1,2)
INSERT INTO ServiceRequests(ClientID,ServiceID)VALUES(2,2)
INSERT INTO ServiceRequests(ClientID,ServiceID)VALUES(4,3)
INSERT INTO ServiceRequests(ClientID,ServiceID)VALUES(5,4)

GO

/* Call Operations */

CREATE PROCEDURE spViewCalls
AS
BEGIN
SELECT * FROM CallManager
END

GO

CREATE PROCEDURE spNewCall
(
@CallDate datetime,
@CallDuration time,
@CallNumber nvarchar(10),
@ClientProblem varchar(150),
@ClientID int
)
AS
BEGIN
INSERT INTO CallManager(CallDate,CallDuration,CallNumber,ClientProblem,ClientID)
VALUES(@CallDate,@CallDuration,@CallNumber,@ClientProblem,@ClientID)
END

GO

/* Service Operations */

CREATE PROCEDURE spViewServices
AS
BEGIN
SELECT * FROM Service
END

GO

CREATE PROCEDURE spServiceLevel
(
@ServiceID INT
)
AS
BEGIN
SELECT ServiceLevel FROM Service
WHERE ServiceID = @ServiceID
END

GO

/* Service Request Operations */

CREATE PROCEDURE spViewRequests
AS
BEGIN
SELECT * FROM ServiceRequests
END

GO

CREATE PROCEDURE spNewRequest
(
@ClientID int,
@ServiceID int
)
AS
BEGIN
INSERT INTO ServiceRequests(ClientID,ServiceID)
VALUES(@ClientID,@ServiceID)
END

GO

CREATE PROCEDURE spRemoveRequest
(
@RequestID INT
)
AS
BEGIN
DELETE FROM ServiceRequests
WHERE RequestID = @RequestID
END

GO

/* Job Operations */

CREATE PROCEDURE spViewJobs
AS
BEGIN
SELECT * FROM Jobs
END

GO

CREATE PROCEDURE spNewJob
(
@JobPriority nvarchar(10),
@TechnicianID int,
@ClientID int,
@ServiceID int
)
AS
BEGIN
INSERT INTO Jobs(JobPriority,TechnicianID,ClientID,ServiceID)
VALUES(@JobPriority,@TechnicianID,@ClientID,@ServiceID)
END

GO

CREATE PROCEDURE spCloseJob
(
@JobID INT
)
AS
BEGIN
DELETE FROM Jobs
WHERE JobID = @JobID
END

GO

CREATE PROCEDURE spTrackJob
(
@JobID INT
)
AS
BEGIN
SELECT * FROM Jobs
WHERE JobID = @JobID
END

GO

CREATE PROCEDURE spEscalateJob
(
@JobID INT,
@JobPriority nvarchar(10)
)
AS
BEGIN
UPDATE Jobs
SET JobPriority = @JobPriority
WHERE JobID = @JobID
END

GO

CREATE PROCEDURE spReassignJob
(
@JobID INT,
@TechnicianID INT
)
AS
BEGIN
UPDATE Jobs
SET TechnicianID = @TechnicianID
WHERE JobID = @JobID
END

GO

/* Client Operations */

CREATE PROCEDURE spViewClients
AS
BEGIN
SELECT * FROM Client
END

GO

CREATE PROCEDURE spAddClient
(
@ClientName varchar(50),
@ClientSurname varchar(50),
@ClientNumber nvarchar(10),
@ClientAddress nvarchar(50),
@ClientType varchar(50),
@ContractID int
)
AS
BEGIN
INSERT INTO Client(ClientName,ClientSurname,ClientNumber,ClientAddress,ClientType,ContractID)
VALUES(@ClientName,@ClientSurname,@ClientNumber,@ClientAddress,@ClientType,@ContractID)
END

GO

CREATE PROCEDURE spDeleteClient
(
@ClientID INT
)
AS
BEGIN
DELETE FROM Client
WHERE ClientID = @ClientID
END

GO

CREATE PROCEDURE spSearchClient
(
@ClientID INT
)
AS
BEGIN
SELECT * FROM Client
WHERE ClientID = @ClientID
END

GO

CREATE PROCEDURE spUpdateClient
(
@ClientID int,
@ClientName varchar(50),
@ClientSurname varchar(50),
@ClientNumber nvarchar(10),
@ClientAddress nvarchar(50),
@ClientType varchar(50),
@ContractID int
)
AS
BEGIN
UPDATE Client
SET ClientName = @ClientName, ClientSurname = @ClientSurname, ClientNumber = @ClientNumber, ClientType = @ClientType, ContractID = @ContractID
WHERE ClientID = @ClientID
END

GO

CREATE PROCEDURE spClientAgreement
(
@ClientID INT
)
AS
BEGIN
SELECT * FROM Contract
INNER JOIN Client ON Contract.ContractID=Client.ContractID
WHERE Client.ClientID = @ClientID
END

GO


/* Contract Operations */

CREATE PROCEDURE spViewContracts
AS
BEGIN
SELECT * FROM Contract
END

GO

CREATE PROCEDURE spContractAvailability
(
@ContractID int,
@Availability varchar(50)
)
AS
BEGIN
UPDATE Contract
SET Availablity = @Availability
WHERE ContractID = @ContractID
END

GO

CREATE PROCEDURE spContractPerformance
(
@ContractID INT
)
AS
BEGIN
SELECT ContractSales FROM Contract
WHERE ContractID = @ContractID
END

GO

CREATE PROCEDURE spContractSale
(
@ContractID INT
)
AS
BEGIN
Update Contract
SET ContractSales += 1
WHERE ContractID = @ContractID
END

GO

/* Employee Opertaions */

CREATE PROCEDURE spAddEmployee
(
@EmployeeID varchar(50),
@BranchID varchar(50)
)
AS
BEGIN
INSERT INTO Employee(EmployeeID,BranchID)
VALUES(@EmployeeID,@BranchID)
END

GO

CREATE PROCEDURE spDeleteEmployee
(
@EmployeeID INT
)
AS
BEGIN
DELETE FROM Employee
WHERE EmployeeID = @EmployeeID
END

GO

/* Call Agent Operations */

CREATE PROCEDURE spViewAgents
AS
BEGIN
SELECT * FROM CallAgent
END

GO

CREATE PROCEDURE spAddAgent
(
@AgentName varchar(50),
@AgentSurname varchar(50),
@PhoneNumber nvarchar(10),
@AgentID int
)
AS
BEGIN
INSERT INTO CallAgent(AgentName,AgentSurname,PhoneNumber,AgentID)
VALUES(@AgentName,@AgentSurname,@PhoneNumber,@AgentID)
END

GO

CREATE PROCEDURE spSearchAgent
(
@AgentID INT
)
AS
BEGIN
SELECT * FROM CallAgent
WHERE AgentID = @AgentID
END

GO

CREATE PROCEDURE spUpdateAgent
(
@AgentName varchar(50),
@AgentSurname varchar(50),
@PhoneNumber nvarchar(10),
@AgentID int
)
AS
BEGIN
UPDATE CallAgent
SET AgentName = @AgentName, AgentSurname = @AgentSurname, PhoneNumber = @PhoneNumber
WHERE AgentID = @AgentID
END

GO

/* Technician operations*/

CREATE PROCEDURE spViewTechnicians
AS
BEGIN
SELECT * FROM Technician
END

GO

CREATE PROCEDURE spAddTechnician
(
@TechnicianName varchar(50),
@TechnicianSurname varchar(50),
@PhoneNumber nvarchar(10),
@JobDescription varchar(50),
@TechnicianID int
)
AS
BEGIN
INSERT INTO Technician(TechhnicianName,TechnicianSurname, PhoneNumber,JobDescription,TechnicianID)
VALUES(@TechnicianName,@TechnicianSurname,@PhoneNumber,@JobDescription,@TechnicianID)
END

GO

CREATE PROCEDURE spSearchTechnician
(
@TechnicianID int
)
AS
BEGIN
SELECT * FROM Technician
WHERE TechnicianID = @TechnicianID
END

GO

CREATE PROCEDURE spUpdateTechnician
(
@TechnicianName varchar(50),
@TechnicianSurname varchar(50),
@PhoneNumber nvarchar(10),
@JobDescription varchar(50),
@TechnicianID int
)
AS
BEGIN
UPDATE Technician
SET TechhnicianName = @TechnicianName, TechnicianSurname = @TechnicianSurname, PhoneNumber = @PhoneNumber, JobDescription = @JobDescription
WHERE TechnicianID = @TechnicianID
END

GO

CREATE PROCEDURE spTechnicianAvailability
(
@TechnicianID INT,
@Availability VARCHAR(50)
)
AS
BEGIN 
UPDATE Technician
SET Availability = @Availability
WHERE TechnicianID = @TechnicianID
END

GO

