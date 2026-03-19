DROP TABLE Clients;
DROP TABLE Sitters;
DROP TABLE Bookings;
DROP TABLE S_Availability;


/*BEGIN
    FOR t IN (SELECT table_name FROM user_tables) LOOP
        BEGIN
            -- Drop table with CASCADE CONSTRAINTS to remove dependent constraints
            EXECUTE IMMEDIATE 'DROP TABLE "' || t.Clients || '" CASCADE CONSTRAINTS';
        EXCEPTION
            WHEN OTHERS THEN
                -- Log any errors without stopping the loop
                DBMS_OUTPUT.PUT_LINE('Failed to drop table ' || t.Clients|| ': ' || SQLERRM);
        END;
    END LOOP;
END;*/

--Clients Table
CREATE TABLE Clients(
ClientID NUMBER  PRIMARY KEY,
FirstName VARCHAR2 (30) NOT NULL,
LastName VARCHAR2 (30) NOT NULL,
Email VARCHAR2 (55) NOT NULL UNIQUE,
PhoneNo NUMBER (10) NOT NULL,
County VARCHAR2 (50) NOT NULL,
Town VARCHAR2 (50) NOT NULL,
Street VARCHAR2 (50) NOT NULL,
Eircode VARCHAR2 (8) NOT NULL,
NoOfChildren NUMBER (2) NOT NULL,
AgeOfChild VARCHAR2 (4) NOT NULL,
Languages VARCHAR2 (30) NOT NULL,
Description VARCHAR2 (130) NOT NULL);

--Sitters Table
CREATE TABLE Sitters(
SitterID NUMBER  PRIMARY KEY,
FirstName VARCHAR2 (30) NOT NULL,
LastName VARCHAR2 (30) NOT NULL,
Email VARCHAR2 (30) NOT NULL UNIQUE,
PhoneNo VARCHAR2 (10) NOT NULL,
DOB DATE,
County VARCHAR2 (30) NOT NULL,
Town VARCHAR2 (30) NOT NULL,
Street VARCHAR2 (30) NOT NULL,
Eircode VARCHAR2 (30) NOT NULL,
ChildCareCertified VARCHAR2 (30) NOT NULL,
MedicalCertified VARCHAR2 (30) NOT NULL,
Languages VARCHAR2 (30) NOT NULL,
--Availability VARCHAR2 (30) NOT NULL,
Description VARCHAR2 (130) NOT NULL,
HourlyRate VARCHAR2 (5) NOT NULL);

--Bookings Table
CREATE TABLE Bookings(
BookingID NUMBER  PRIMARY KEY, 
ClientID NUMBER (4) NOT NULL, 
ClientName VARCHAR2 (30) NOT NULL, 
ClientEmail VARCHAR2 (30) NOT NULL UNIQUE, 
ClientPhoneNo NUMBER (10) NOT NULL, 
SitterID NUMBER (4) NOT NULL,
SitterName VARCHAR2 (30) NOT NULL UNIQUE, 
SitterEmail VARCHAR2 (30) NOT NULL, 
SitterPhoneNo NUMBER (10) NOT NULL, 
HourlyRate VARCHAR2 (5) NOT NULL, 
BookDate DATE, 
BookTime DATE, 
Duration NUMBER (2) NOT NULL, 
TotalCost NUMBER (5) NOT NULL,
Payement VARCHAR2 (4) NOT NULL);

-- Sitters Availaiblity Table
CREATE TABLE S_Availability(
VailablityID NUMBER  PRIMARY KEY,
SitterID NUMBER (4) NOT NULL,
FirstName VARCHAR2 (30) NOT NULL,
LastName VARCHAR2 (30) NOT NULL,
Email VARCHAR2 (30) NOT NULL UNIQUE,
PhoneNo VARCHAR2 (10) NOT NULL,
Monday VARCHAR2 (5) NOT NULL,
Tuesday VARCHAR2 (5) NOT NULL,
Wednesday VARCHAR2 (5) NOT NULL,
Thursday VARCHAR2 (5) NOT NULL,
Friday VARCHAR2 (5) NOT NULL,
Saturday VARCHAR2 (5) NOT NULL,
Sunday VARCHAR2 (5) NOT NULL);



--Add data to the Clients table
--1C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1000, 'Anna', 'Joy', 'anna.joy23@example.com', '0832451129', 'Kerry', 'Killarney','56 Some Street', 'V93 1234',  2, 3, 5, 'New to the area and hoping to connect with trustworthy sitters for date nights and last-minute support.');

--2C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1001,'Mark',  'Kim', 'mark.kim89@example.com', '0856729041', 'Dublin', 'Dublin 2', '10 St. Stephen’s Green','D02 XY45', 1, 2, 2, 'We need a dependable babysitter comfortable with pets and light homework help for our 8-year-old.');

--3C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1002, 'Sarah', 'Cole', 'sarah.cole04@example.com', '0873195570', 'Cork', 'Cork city', '34 Patrick Street', 'T12 ABC1', 4, 4, 6, 'Family of three looking for someone patient and energetic to mind our toddler a few hours a week');

--4C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1003, 'Daniel', 'O Reilly', 'daniel.oreilly@example.com', '0869102234', 'Carlow', 'Carlow', '12 Church Lane', 'R93 9999', 3, 3, 4,'Family of three looking for someone patient and energetic to mind our toddler a few hours a week');

--5C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1004,'Lily', 'Brenda', 'lily.banda99@example.com', '0894307786', 'Donegal', 'Letterkenny', '5 Main Street', 'F92 5678', 2, 1, 1, 'Busy working parents seeking a caring, punctual babysitter who can help with after-school care.');



--Add data to the Sitters table
--1S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages,Description,HourlyRate)
VALUES(2000,'Sarah', 'O Grady', 'sarah2@gmail.com', '0848261852', TO_DATE('21-4-2004', 'DD-MM-YYYY'),'Dublin','Swords','14 Oakview Drive','K67 A9F2',2,0,0,'Friendly and responsible sitter with 3+ years of experience caring for children of all ages.','13.50');

--2S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Description,HourlyRate)
VALUES(2001, 'Aoife','Murphy','murphy.a@gmail.com','0850379963', TO_DATE('23-6-2006', 'DD-MM-YYYY'),'Cork', 'Midleton', '22 Riverside Walk','P25 D3K4',4, 0, 1, 'Qualified childcare worker with first-aid training, available for evening and weekend babysitting.', '15.00');

--3S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Description,HourlyRate)
VALUES(2002,'Ciara','Donnelly','ciaradonnelly@gmail.com','0827386277',TO_DATE('27-2-2000', 'DD-MM-YYYY'),'Galway','Oranmore','8 Castle Road','H91 T2W7',9,0,0,'Energetic college student studying early childhood education.','14.80');

--4S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages,Description,HourlyRate)
VALUES(2003,'Saoirse','O Sullivan','saoirseos@gmail.com','0869781639',TO_DATE('3-10-2001', 'DD-MM-YYYY'),'Wexford','Gorey','5 Meadowbrook Lane','Y25 R9C8',11,1,0, 'Calm, dependable babysitter experienced with infants and toddlers.', '20.00');

--5S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages,Description,HourlyRate)
VALUES(2004,'Caoimhe','Walsh','walshc@gmail.com','0869285630',TO_DATE('12-5-1999', 'DD-MM-YYYY'),'Limerick','Newcastle West','31 Ashwood Grove','V42 P6H0',7,1,1,'Creative and upbeat sitter who loves games, storytelling, and supporting kids’ interests','14.00');



--Add data to the Bookings table
--1B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3000,1000,'Anna Joy','anna.joy23@example.com','0832451129',2001,'Aoife Murphy', 'murphy.a@gmail.com','0850379963','24',TO_DATE('06-4-2025', 'DD-MM-YYYY'),TO_DATE('18:30', 'HH24:MI'),'3','72','Yes');

--2B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3001,1001,'Mark Kim','mark.kim89@example.com','0856729041', 2004,'Caoimhe Walsh','walshc@gmail.com','0813960070','18',TO_DATE('23-8-2025', 'DD-MM-YYYY'),TO_DATE('11:00', 'HH24:MI'),'5','130','Yes');

--3B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3002,1002, 'Sarah Cole','sarah2@gmail.com', '0848261852',2000,'Sarah O Grady','sarah2@gmail.com','0848261852','12',TO_DATE('10-6-2025', 'DD-MM-YYYY'), TO_DATE('13:15', 'HH24:MI'), '2', '48','Yes');

--4B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3003,1003,'Daniel O Reilly','daniel.oreilly@example.com','0869102234',2003,'Saoirse O Sullivan','saoirseos@gmail.com','0869781639','13.50',TO_DATE('16-9-2025', 'DD-MM-YYYY'),TO_DATE('16:30', 'HH24:MI'), '1','25','Yes');

--5B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3004,1004, 'Lily Brenda','lily.banda99@example.com','0894307786', 2002,'Ciara Donnelly', 'ciaradonnelly@gmail.com', '0827386277','15.50',TO_DATE('27-5-2025', 'DD-MM-YYYY'),TO_DATE('08:30', 'HH24:MI'),'3','72', 'Yes');


--Add data to the S_Availability table
--1A
INSERT INTO S_Availability(VailablityID,SitterID,FirstName,LastName, Email,PhoneNo,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4000,2000, 'Sarah', 'O Grady', 'sarah2@gmail.com', '0848261852', 'Yes', 'No', 'No','No', 'No', 'Yes', 'Yes');

--2A
INSERT INTO S_Availability(VailablityID,SitterID,FirstName,LastName, Email,PhoneNo,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4001,2001, 'Aoife','Murphy','murphy.a@gmail.com','0850379963', 'No', 'Yes', 'Yes', 'Yes', 'No', 'Yes', 'No');

--3A
INSERT INTO S_Availability(VailablityID,SitterID,FirstName,LastName, Email,PhoneNo,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4002,2002,'Ciara','Donnelly','ciaradonnelly@gmail.com','0827386277', 'Yes', 'Yes', 'Yes', 'Yes', 'Yes', 'No', 'No');

--4A
INSERT INTO S_Availability(VailablityID,SitterID,FirstName,LastName, Email,PhoneNo,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4003,2003,'Saoirse','O Sullivan','saoirseos@gmail.com','0869781639', 'No', 'No', 'No', 'No', 'No', 'Yes', 'Yes');

--5A
INSERT INTO S_Availability(VailablityID,SitterID,FirstName,LastName, Email,PhoneNo,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4004,2004,'Caoimhe','Walsh','walshc@gmail.com', '0813960070','Yes', 'No', 'Yes', 'No', 'Yes', 'No', 'No');






