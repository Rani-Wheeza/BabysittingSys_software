DROP TABLE Clients;
DROP TABLE Sitters;
DROP TABLE Bookings;
DROP TABLE S_Availability;
DROP TABLE Admin;


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
AgeOfChild VARCHAR2 (15) NOT NULL,
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
Description VARCHAR2 (130) NOT NULL,
HourlyRate VARCHAR2 (5) NOT NULL);

--Bookings Table
CREATE TABLE Bookings(
BookingID NUMBER  PRIMARY KEY, 
ClientID NUMBER (4) NOT NULL, 
ClientName VARCHAR2 (30) NOT NULL, 
ClientEmail VARCHAR2 (30) NOT NULL , 
ClientPhoneNo NUMBER (10) NOT NULL, 
SitterID NUMBER (4) NOT NULL,
SitterName VARCHAR2 (30) NOT NULL , 
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
AvailabilityID NUMBER (4)  PRIMARY KEY,
SitterID NUMBER (4) NOT NULL,
Monday VARCHAR2 (5) NOT NULL,
Tuesday VARCHAR2 (5) NOT NULL,
Wednesday VARCHAR2 (5) NOT NULL,
Thursday VARCHAR2 (5) NOT NULL,
Friday VARCHAR2 (5) NOT NULL,
Saturday VARCHAR2 (5) NOT NULL,
Sunday VARCHAR2 (5) NOT NULL);


--Admin Table
CREATE TABLE ADMIN(
AdminID NUMBER (4) PRIMARY KEY,
Email VARCHAR2 (30) NOT NULL,
Password VARCHAR2 (30) NOT NULL);


--Add data to the Clients table
--1C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1000, 'Anna', 'Joy', 'anna.joy23@example.com', '0832451129', 'Kerry', 'Killarney','56 Some Street', 'V93 1234',  2, 3, 'Irish', 'New to the area and hoping to connect with trustworthy sitters for date nights and last-minute support.');

--2C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1001,'Mark',  'Kim', 'mark.kim89@example.com', '0856729041', 'Dublin', 'Dublin 2', '10 St. Stephen’s Green','D02 XY45', 1, 2, 'Mandarin', 'We need a dependable babysitter comfortable with pets and light homework help for our 8-year-old.');

--3C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1002, 'Sarah', 'Cole', 'sarah.cole04@example.com', '0873195570', 'Cork', 'Cork city', '34 Patrick Street', 'T12 ABC1', 4, 4, 'Korean', 'Family of three looking for someone patient and energetic to mind our toddler a few hours a week');

--4C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1003, 'Daniel', 'O Reilly', 'daniel.oreilly@example.com', '0869102234', 'Carlow', 'Carlow', '12 Church Lane', 'R93 9999', 3, 3, 'Irish','Family of three looking for someone patient and energetic to mind our toddler a few hours a week');

--5C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1004,'Lily', 'Brenda', 'lily.banda99@example.com', '0894307786', 'Donegal', 'Letterkenny', '5 Main Street', 'F92 5678', 2, 1, 'English', 'Busy working parents seeking a caring, punctual babysitter who can help with after-school care.');

--6C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1005,'David','Kim','david.kim23@example.com',0815566778,'Limerick','Dooradoyle','22 Rose Avenue','V94 K2L1',2,'6-10','English','Looking for a sitter who is dependable for after-school care during weekdays.');

--7C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1006,'Aisha','Khan','aisha.khan11@example.com',0837788991,'Galway','Salthill','7 Seaview Park','H91 M4N2',1,'0-2','English','Need occasional evening babysitting for our toddler.');

--8C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1007,'Tom','Murphy','tom.murphy44@example.com',0864455667,'Cork','Ballincollig','14 Elm Court','P31 R5T8',3,'3-5','Irish','Busy family looking for weekend support and occasional school pickup help.');

--9C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1008,'Grace','Lee','grace.lee90@example.com',0871122334,'Dublin','Tallaght','9 Oakwood Drive','D24 P6Q7',2,'6-10','Mandarin','Looking for a friendly sitter comfortable with homework support and meal prep.');

--10C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1009,'Maya','Singh','maya.singh12@example.com',0859988776,'Kerry','Tralee','31 Riverwalk','V92 X3Y4',1,'11-14','English','Need a reliable sitter for evening events and occasional weekend cover.');


--Add data to the Sitters table
--1S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages,Description,HourlyRate)
VALUES(2000,'Sarah', 'O Grady', 'sarah2@gmail.com', '0848261852', TO_DATE('21-4-2004', 'DD-MM-YYYY'),'Dublin','Swords','14 Oakview Drive','K67 A9F2','No','Yes','Irish','Friendly and responsible sitter with 3+ years of experience caring for children of all ages.','13.50');

--2S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Description,HourlyRate)
VALUES(2001, 'Aoife','Murphy','murphy.a@gmail.com','0850379963', TO_DATE('23-6-2006', 'DD-MM-YYYY'),'Cork', 'Midleton', '22 Riverside Walk','P25 D3K4','No', 'Yes', 'Russian', 'Qualified childcare worker with first-aid training, available for evening and weekend babysitting.', '15.00');

--3S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Description,HourlyRate)
VALUES(2002,'Ciara','Donnelly','ciaradonnelly@gmail.com','0827386277',TO_DATE('27-2-2000', 'DD-MM-YYYY'),'Galway','Oranmore','8 Castle Road','H91 T2W7','No','Yes','French','Energetic college student studying early childhood education.','14.80');

--4S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages,Description,HourlyRate)
VALUES(2003,'Saoirse','O Sullivan','saoirseos@gmail.com','0869781639',TO_DATE('3-10-2001', 'DD-MM-YYYY'),'Wexford','Gorey','5 Meadowbrook Lane','Y25 R9C8','Yes','No','German', 'Calm, dependable babysitter experienced with infants and toddlers.', '20.00');

--5S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo,DOB, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages,Description,HourlyRate)
VALUES(2004,'Caoimhe','Walsh','walshc@gmail.com','0869285630',TO_DATE('12-5-1999', 'DD-MM-YYYY'),'Limerick','Newcastle West','31 Ashwood Grove','V42 P6H0','Yes','Yes','Dutch','Creative and upbeat sitter who loves games, storytelling, and supporting kids’ interests','14.00');

--6S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, DOB, County, Town, Street, Eircode, ChildCareCertified, MedicalCertified, Languages, Description, HourlyRate)
VALUES(2005,'Emma','Walsh','emma.walsh@gmail.com','0874455661',TO_DATE('14-07-2002','DD-MM-YYYY'),'Limerick','Dooradoyle','18 Cedar Grove','V94 T8R2','Yes','Yes','English','Patient and energetic sitter experienced with school-age children.','16.00');

--7S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, DOB, County, Town, Street, Eircode, ChildCareCertified, MedicalCertified, Languages, Description, HourlyRate)
VALUES(2006,'Niamh','Doyle','niamh.doyle@gmail.com','0863344556',TO_DATE('02-11-2001','DD-MM-YYYY'),'Galway','Knocknacarra','11 Hazel Park','H91 W2K5','Yes','No','English','Friendly university student with weekend and evening availability.','15.00');

--8S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, DOB, County, Town, Street, Eircode, ChildCareCertified, MedicalCertified, Languages, Description, HourlyRate)
VALUES(2007,'Chloe','Byrne','chloe.byrne@gmail.com','0856677889',TO_DATE('25-03-1998','DD-MM-YYYY'),'Dublin','Blanchardstown','5 Maple Drive','D15 Z6Y7','Yes','Yes','French','Experienced sitter who enjoys arts, games, and helping children with routines.','18.00');

--9S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, DOB, County, Town, Street, Eircode, ChildCareCertified, MedicalCertified, Languages, Description, HourlyRate)
VALUES(2008,'Lucy','Brown','lucy.brown@gmail.com','0832211445',TO_DATE('09-09-2000','DD-MM-YYYY'),'Cork','Midleton','27 Willow Court','P25 F4G6','Yes','No','German','Reliable sitter with experience caring for infants and toddlers.','17.50');

--10S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, DOB, County, Town, Street, Eircode, ChildCareCertified, MedicalCertified, Languages, Description, HourlyRate)
VALUES(2009,'Orla','Fitzgerald','orla.fitzgerald@gmail.com','0897766554',TO_DATE('19-01-1997','DD-MM-YYYY'),'Kerry','Killarney','42 Pine View','V93 N8M1','Yes','Yes','Irish','Calm and organised sitter available for after-school care and evenings.','19.00');


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

--6B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3005,1005,'David Kim','david.kim23@example.com',0815566778,2005,'Emma Walsh','emma.walsh@gmail.com',0874455661,'16.00',TO_DATE('14-02-2024','DD-MM-YYYY'),TO_DATE('17:30','HH24:MI'),3,48,'Yes');

--7B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3006,1006,'Aisha Khan','aisha.khan11@example.com',0837788991,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('09-05-2024','DD-MM-YYYY'),TO_DATE('18:00','HH24:MI'),4,60,'Yes');

--8B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3007,1007,'Tom Murphy','tom.murphy44@example.com',0864455667,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('22-07-2024','DD-MM-YYYY'),TO_DATE('13:00','HH24:MI'),5,90,'Yes');

--9B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3008,1008,'Grace Lee','grace.lee90@example.com',0871122334,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('03-10-2024','DD-MM-YYYY'),TO_DATE('16:15','HH24:MI'),2,35,'Yes');

--10B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3009,1009,'Maya Singh','maya.singh12@example.com',0859988776,2009,'Orla Fitzgerald','orla.fitzgerald@gmail.com',0897766554,'19.00',TO_DATE('18-12-2024','DD-MM-YYYY'),TO_DATE('19:00','HH24:MI'),4,76,'Yes');

--11B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3010,1000,'Anna Joy','anna.joy23@example.com',0832451129,2005,'Emma Walsh','emma.walsh@gmail.com',0874455661,'16.00',TO_DATE('11-01-2025','DD-MM-YYYY'),TO_DATE('18:30','HH24:MI'),3,48,'Yes');

--12B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3011,1001,'Mark Kim','mark.kim89@example.com',0856729041,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('23-03-2025','DD-MM-YYYY'),TO_DATE('12:00','HH24:MI'),2,36,'Yes');

--13B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3012,1002,'Sarah Cole','sarah.cole04@example.com',0873195570,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('12-06-2025','DD-MM-YYYY'),TO_DATE('15:00','HH24:MI'),4,70,'Yes');

--14B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3013,1003,'Daniel O Reilly','daniel.oreilly@example.com',0869102234,2009,'Orla Fitzgerald','orla.fitzgerald@gmail.com',0897766554,'19.00',TO_DATE('05-09-2025','DD-MM-YYYY'),TO_DATE('17:30','HH24:MI'),5,95,'Yes');

--15B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3014,1004,'Lily Brenda','lily.banda99@example.com',0894307786,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('29-11-2025','DD-MM-YYYY'),TO_DATE('08:30','HH24:MI'),3,45,'Yes');

-- 16B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3015,1005,'David Kim','david.kim23@example.com',0815566778,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('18-02-2022','DD-MM-YYYY'),TO_DATE('17:00','HH24:MI'),2,30,'Yes');

-- 17B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3016,1006,'Aisha Khan','aisha.khan11@example.com',0837788991,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('09-04-2022','DD-MM-YYYY'),TO_DATE('18:30','HH24:MI'),3,54,'Yes');

-- 18B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3017,1007,'Tom Murphy','tom.murphy44@example.com',0864455667,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('22-07-2022','DD-MM-YYYY'),TO_DATE('12:00','HH24:MI'),4,70,'Yes');

-- 19B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3018,1008,'Grace Lee','grace.lee90@example.com',0871122334,2009,'Orla Fitzgerald','orla.fitzgerald@gmail.com',0897766554,'19.00',TO_DATE('15-10-2022','DD-MM-YYYY'),TO_DATE('19:00','HH24:MI'),2,38,'Yes');

-- 20B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3019,1009,'Maya Singh','maya.singh12@example.com',0859988776,2005,'Emma Walsh','emma.walsh@gmail.com',0874455661,'16.00',TO_DATE('03-12-2022','DD-MM-YYYY'),TO_DATE('16:00','HH24:MI'),5,80,'Yes');

-- 21B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3020,1000,'Anna Joy','anna.joy23@example.com',0832451129,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('14-01-2023','DD-MM-YYYY'),TO_DATE('13:00','HH24:MI'),3,45,'Yes');

-- 22B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3021,1001,'Mark Kim','mark.kim89@example.com',0856729041,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('26-03-2023','DD-MM-YYYY'),TO_DATE('11:30','HH24:MI'),4,72,'Yes');

-- 23B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3022,1002,'Sarah Cole','sarah.cole04@example.com',0873195570,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('07-05-2023','DD-MM-YYYY'),TO_DATE('14:00','HH24:MI'),2,35,'Yes');

-- 24B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3023,1003,'Daniel O Reilly','daniel.oreilly@example.com',0869102234,2009,'Orla Fitzgerald','orla.fitzgerald@gmail.com',0897766554,'19.00',TO_DATE('19-08-2023','DD-MM-YYYY'),TO_DATE('18:15','HH24:MI'),3,57,'Yes');

-- 25B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3024,1004,'Lily Brenda','lily.banda99@example.com',0894307786,2005,'Emma Walsh','emma.walsh@gmail.com',0874455661,'16.00',TO_DATE('02-11-2023','DD-MM-YYYY'),TO_DATE('17:45','HH24:MI'),5,80,'Yes');

-- 26B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3025,1005,'David Kim','david.kim23@example.com',0815566778,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('21-12-2023','DD-MM-YYYY'),TO_DATE('19:30','HH24:MI'),2,30,'Yes');

-- 27B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3026,1006,'Aisha Khan','aisha.khan11@example.com',0837788991,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('09-02-2024','DD-MM-YYYY'),TO_DATE('18:00','HH24:MI'),4,72,'Yes');

-- 28B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3027,1007,'Tom Murphy','tom.murphy44@example.com',0864455667,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('17-04-2024','DD-MM-YYYY'),TO_DATE('15:15','HH24:MI'),3,52.5,'Yes');

-- 29B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3028,1008,'Grace Lee','grace.lee90@example.com',0871122334,2009,'Orla Fitzgerald','orla.fitzgerald@gmail.com',0897766554,'19.00',TO_DATE('28-06-2024','DD-MM-YYYY'),TO_DATE('20:00','HH24:MI'),4,76,'Yes');

-- 30B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3029,1009,'Maya Singh','maya.singh12@example.com',0859988776,2005,'Emma Walsh','emma.walsh@gmail.com',0874455661,'16.00',TO_DATE('13-09-2024','DD-MM-YYYY'),TO_DATE('10:00','HH24:MI'),6,96,'Yes');

-- 31B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3030,1000,'Anna Joy','anna.joy23@example.com',0832451129,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('24-11-2024','DD-MM-YYYY'),TO_DATE('14:30','HH24:MI'),3,45,'Yes');

-- 32B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3031,1001,'Mark Kim','mark.kim89@example.com',0856729041,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('06-01-2025','DD-MM-YYYY'),TO_DATE('09:30','HH24:MI'),5,90,'Yes');

-- 33B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3032,1002,'Sarah Cole','sarah.cole04@example.com',0873195570,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('18-03-2025','DD-MM-YYYY'),TO_DATE('13:45','HH24:MI'),2,35,'Yes');

-- 34B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3033,1003,'Daniel O Reilly','daniel.oreilly@example.com',0869102234,2009,'Orla Fitzgerald','orla.fitzgerald@gmail.com',0897766554,'19.00',TO_DATE('27-05-2025','DD-MM-YYYY'),TO_DATE('18:30','HH24:MI'),4,76,'Yes');

-- 35B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3034,1004,'Lily Brenda','lily.banda99@example.com',0894307786,2005,'Emma Walsh','emma.walsh@gmail.com',0874455661,'16.00',TO_DATE('09-08-2025','DD-MM-YYYY'),TO_DATE('11:00','HH24:MI'),3,48,'Yes');

-- 36B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3035,1005,'David Kim','david.kim23@example.com',0815566778,2006,'Niamh Doyle','niamh.doyle@gmail.com',0863344556,'15.00',TO_DATE('14-10-2025','DD-MM-YYYY'),TO_DATE('16:30','HH24:MI'),4,60,'Yes');

-- 37B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3036,1006,'Aisha Khan','aisha.khan11@example.com',0837788991,2007,'Chloe Byrne','chloe.byrne@gmail.com',0856677889,'18.00',TO_DATE('22-11-2025','DD-MM-YYYY'),TO_DATE('19:00','HH24:MI'),3,54,'Yes');

-- 38B
INSERT INTO Bookings(BookingID,ClientID,ClientName,ClientEmail,ClientPhoneNo,SitterID,SitterName,SitterEmail,SitterPhoneNo,HourlyRate,BookDate,BookTime,Duration,TotalCost,Payement)
VALUES(3037,1007,'Tom Murphy','tom.murphy44@example.com',0864455667,2008,'Lucy Brown','lucy.brown@gmail.com',0832211445,'17.50',TO_DATE('03-12-2025','DD-MM-YYYY'),TO_DATE('15:00','HH24:MI'),5,87.5,'Yes');

--Add data to the S_Availability table
--1A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4000,2000, 'Yes', 'No', 'No','No', 'No', 'Yes', 'Yes');

--2A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4001,2001, 'No', 'Yes', 'Yes', 'Yes', 'No', 'Yes', 'No');

--3A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4002,2002,'Yes', 'Yes', 'Yes', 'Yes', 'Yes', 'No', 'No');

--4A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4003,2003,'No', 'No', 'No', 'No', 'No', 'Yes', 'Yes');

--5A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4004,2004,'Yes', 'No', 'Yes', 'No', 'Yes', 'No', 'No');

--6A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4005,2005,'Yes','Yes','No','Yes','Yes','No','Yes');

--7A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4006,2006,'No','Yes','Yes','No','Yes','Yes','No');

--8A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4007,2007,'Yes','No','Yes','Yes','No','Yes','Yes');

--9A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4008,2008,'Yes','Yes','Yes','No','Yes','No','No');

--10A
INSERT INTO S_Availability(AvailabilityID,SitterID,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday)
VALUES(4009,2009,'No','No','Yes','Yes','Yes','Yes','Yes');

--Add data to the Admin table
--1A
INSERT INTO ADMIN(AdminID,Email,Password)
VALUES(9718,'admin@gmail.com','Rw1811317');

COMMIT;



