CREATE PROCEDURE spUpdateStudent(
	@Id			INT,
	@FirstName	VARCHAR(50),
	@LastName	VARCHAR(50),
	@Email		VARCHAR(30),
	@Mobile		VARCHAR(20),
	@Addresss	VARCHAR(220)
)
AS
BEGIN
	UPDATE	Student 
	SET
	FirstName	= @FirstName,
	LastName	= @LastName, 
	Email		= @Email,
	Mobile		= @Mobile,
	Addresss	= @Addresss
	where 
	Id = @Id
END
