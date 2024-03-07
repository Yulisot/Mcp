-- INSERT INTO Emps (UserId, CompanyId, IdNum, EmpNo, Dept, FirstName, LastName, FirstNameEng, LastNameEng, Email, Tel, AdditionalTel, City, CityKod, Address, HouseNo, ApartmentNo, ZipCode, MailOfficeBox, Gender, MaritalStatus, HealthOrganization, Alia, IsIsraelCitizen, HaverKibutz, StartDate, CreatedAt, DisabledAt, LastChange)
-- VALUES (1, 1, 987654321, 12345, 1, 'EmployeeFirstName', 'EmployeeLastName', 'EngFirstName', 'EngLastName', 'employee@example.com', '987654321', '987654321', 'EmployeeCity', 1234567, 'EmployeeAddress', '1A', 2, 12345, 67890, 'Male', 'Single', 1, '1995-01-01', 1, 0, '2024-02-07', DATETIME('now'), NULL, NULL);

SELECT * FROM Companies 
where Clientid = 2