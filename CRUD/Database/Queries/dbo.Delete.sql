﻿CREATE PROC spDelete
(
	@Id	INT
)
AS
BEGIN
	DELETE FROM Student 
	WHERE Id = @Id
END
