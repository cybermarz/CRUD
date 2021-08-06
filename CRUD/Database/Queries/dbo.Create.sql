CREATE PROC spCreate
(
	@FirstName	varchar(50),
	@LastName	varchar(30),
	@Email		varchar(30),
	@Mobile		varchar(20),
	@Addresss	varchar(220)
)
AS
BEGIN
	INSERT INTO Student
	(
		[FirstName], 
		[LastName], 
		[Email], 
		[Mobile], 
		[Addresss]
	)

	Values 
	(
		@FirstName, 
		@LastName,
		@Email, 
		@Mobile, 
		@Addresss
	)
END
