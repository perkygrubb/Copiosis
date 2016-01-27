CREATE TABLE location (
locationID int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
country varchar(55), 
state varchar(55), 
city varchar(55), 
neighborhood varchar(55), 
signupKey varchar(55)
);

-- Insert the initial neighborhood needed for the Copiosis Application
INSERT INTO location VALUES(
	'USA',
	'Oregon',
	'Portland',
	'Kenton',
	'kenton2014trial'
);

CREATE TABLE [user] (
userID int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
vendorCode int NOT NULL,
username varchar(55) NOT NULL, 
email varchar(200), 
firstName varchar(55), 
lastName varchar(55), 
status int NOT NULL,	
nbr float,
lastLogin datetime,
prevLastLogin datetime,
locationID int NOT NULL FOREIGN KEY REFERENCES location(locationID)
);

CREATE TABLE itemClass (
classID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
name varchar(55),
suggestedGateway int,
cPdb float,
a float,
aMax int,
d int,
aPrime int,
cCb float,
m1 float,
pO int,
m2 float,
cEb float,
s int,
m3 float,
sE smallint,
m4 float,
sH smallint,
m5 float
);

-- Insert the Default itemClass values needed for the Copiosis Application
INSERT INTO itemClass VALUES (
	'Default',
	1,
	1.0,
	10,
	10,
	2,
	1,
	1.0,
	1.0,
	1.0,
	1.0,
	1.0,
	1,
	1.0,
	1,
	1.0,
	1.0,
	1.0
);

CREATE TABLE product (
productID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
type varchar(25) NOT NULL DEFAULT 'Product',
name varchar(155) NOT NULL,
description varchar(max) NOT NULL,
gateway int NOT NULL,
itemClass int NOT NULL FOREIGN KEY REFERENCES itemClass(classID),
createdDate datetime NOT NULL, 
deletedDate datetime,
ownerID int NOT NULL FOREIGN KEY REFERENCES [user](userID),
guid uniqueidentifier NOT NULL DEFAULT newid() 
);

CREATE TABLE [transaction] (
transactionID uniqueidentifier NOT NULL DEFAULT newid() PRIMARY KEY, 
providerID int NOT NULL FOREIGN KEY REFERENCES [user](userID),
providerNotes text,
receiverID int NOT NULL FOREIGN KEY REFERENCES [user](userID),
receiverNotes text,
date date, 
productID int NOT NULL FOREIGN KEY REFERENCES product(productID),
productGateway int NOT NULL,
productDesc varchar(max) NOT NULL,
status varchar(16),
dateAdded datetime NOT NULL,
createdBy int NOT NULL FOREIGN KEY REFERENCES [user](userID),
dateClosed datetime,
nbr float,
satisfaction smallint
);

CREATE TABLE [Version] (
	Id varchar(25),
	VersionNumber int
);

INSERT INTO Version VALUES('Copiosis', 1)