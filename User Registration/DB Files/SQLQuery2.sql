CREATE PROC UserViewByID
@UserID int
AS
	SELECT * 
	FROM UserRegistration
	WHERE UserID = @UserID