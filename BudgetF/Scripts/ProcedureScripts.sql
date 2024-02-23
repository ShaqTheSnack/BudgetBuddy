CREATE PROCEDURE ValidateUser
    @Username VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IsValid BIT;


    IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username AND Password = @Password)
        SET @IsValid = 1; 
    ELSE
        SET @IsValid = 0; 


    SELECT @IsValid AS IsValid;
END;




GO;



CREATE PROCEDURE CreateUser
    @Firstname VARCHAR(50),
    @Lastname VARCHAR(50),
    @Username VARCHAR(50),
    @Password VARCHAR(50),
    @Salary FLOAT
AS
BEGIN
    -- Check if the username already exists
    IF EXISTS (SELECT 1 FROM Users WHERE Username = @Username)
    BEGIN
        PRINT 'Username already exists. Please choose a different one.'
        RETURN
    END

    -- Insert the new user into the Users table
    INSERT INTO Users (Firstname, Lastname, Username, Password, Salary)
    VALUES (@Firstname, @Lastname, @Username, @Password, @Salary)

    PRINT 'User created successfully.'
END




GO;






CREATE PROCEDURE UpdateSalary
    @Username NVARCHAR(50),
    @NewSalary FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Users
    SET Salary = @NewSalary
    WHERE Username = @Username;
END;





GO;




CREATE PROCEDURE GetSalaryByUsername
    @Username VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Salary
    FROM Users
    WHERE Username = @Username;
END;






GO;



