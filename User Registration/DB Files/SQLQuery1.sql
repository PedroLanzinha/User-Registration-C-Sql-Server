CREATE PROC UserAddOrEdit /*Executing stores the procedure becoming normal to get an error trying to execute again
/programability/stored procedures to see saved prodedures	*/
@UserId int,
@FirstName varchar(50),
@LastName varchar(50),
@Contact varchar(50),
@Gender varchar(50),
@Address varchar(50),
@Username varchar(50),
@Password varchar(50)
As
	IF @UserId = 0
	BEGIN
		INSERT INTO UserRegistration (FirstName,LastName,Contact,Gender,Address,Username,Password)
		VALUES (@FirstName,@LastName,@Contact,@Gender,@Address,@Username,@Password)
	END
	ELSE
	BEGIN
		UPDATE UserRegistration
		SET
			FirstName = @FirstName,
			LastName = @LastName,
			Contact = @Contact,
			Gender = @Gender,
			Address = @Address,
			Username = @Username,
			Password = @Password
		WHERE UserID = @UserId
	END
