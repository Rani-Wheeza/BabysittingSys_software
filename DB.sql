DROP TABLE Clients;
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
Email VARCHAR2 (35) NOT NULL UNIQUE,
PhoneNo NUMBER (10) NOT NULL,
County VARCHAR2 (30) NOT NULL,
Town VARCHAR2 (30) NOT NULL,
Street VARCHAR2 (30) NOT NULL,
Eircode VARCHAR2 (7) NOT NULL,
NoOfChildren NUMBER (13) NOT NULL,
AgeOfChild VARCHAR2 (1) NOT NULL,
Languages VARCHAR2 (30) NOT NULL,
Description VARCHAR2 (30) NOT NULL);



--Sitters Table
/*CREATE TABLE Sitters(
SitterID NUMBER  PRIMARY KEY,
FirstName VARCHAR2 (30) NOT NULL,
LastName VARCHAR2 (30) NOT NULL,
Email VARCHAR2 (30) NOT NULL,
PhoneNo VARCHAR2 (30) NOT NULL,
DOB DATE,
County VARCHAR2 (30) NOT NULL,
Town VARCHAR2 (30) NOT NULL,
Street VARCHAR2 (30) NOT NULL,
Eircode VARCHAR2 (30) NOT NULL,
ChildCareCertified VARCHAR2 (30) NOT NULL,
MedicalCertified VARCHAR2 (30) NOT NULL,
Languages VARCHAR2 (30) NOT NULL,
Availability VARCHAR2 (30) NOT NULL,
Description VARCHAR2 (30) NOT NULL,
HourlyRate NUMBER (4) NOT NULL);*/

--Bookings Table

--Add data to the Clients table
--1C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1000, 'Anna', 'Joy', 'anna.joy23@example.com',  '0832451129', 'Kerry', 'Killarney','56 Some Street', 'V93 1234',  2, '1-5 years', 'Mandarine', 'New to the area and hoping to connect with trustworthy sitters for date nights and last-minute support.');

--2C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1001,'Mark',  "Kim", “mark.kim89@example.com”, "0856729041", "Dublin", "Dublin 2", "10 St. Stephen’s Green","D02 XY45", 1, 2, 2, "We need a dependable babysitter comfortable with pets and light homework help for our 8-year-old.");

--3C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1002, 'Sarah', "Cole", “sarah.cole04@example.com”, "0873195570", "Cork", "Cork city", "34 Patrick Street", "T12 ABC1", 4, 4, 6, "Family of three looking for someone patient and energetic to mind our toddler a few hours a week");

--4C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1003, 'Daniel', "O'Reilly", “daniel.oreilly@example.com”, "0869102234", "Carlow", "Carlow", "12 Church Lane", "R93 9999", 3, 3, 4, "Family of three looking for someone patient and energetic to mind our toddler a few hours a week");

--5C
INSERT INTO Clients(ClientID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode, NoOfChildren, AgeOfChild, Languages, Description)
VALUES(1004,'Lily', "Brenda", “lily.banda99@example.com”, "0894307786", "Donegal", "Letterkenny", "5 Main Street", "F92 5678", 2, 1, 1, "Busy working parents seeking a caring, punctual babysitter who can help with after-school care.");

/*--Add data to the Sitters table
--1S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Availability,Description,HourlyRate)
VALUES(2000);

--2S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Availability,Description,HourlyRate)
VALUES(2000);

--3S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Availability,Description,HourlyRate)
VALUES(2000);

--4S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Availability,Description,HourlyRate)
VALUES(2000);

--5S
INSERT INTO Sitters(SitterID, FirstName, LastName, Email, PhoneNo, County, Town, Street, Eircode,ChildCareCertified, MedicalCertified,Languages, Availability,Description,HourlyRate)
VALUES(2000);*/







