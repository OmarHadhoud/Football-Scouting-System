-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE insertFA
	-- Add the parameters for the stored procedure here
	@FA_ID	int	,	
	@Email	varchar(50)	= NULL,
	@Address	varchar(50) = NULL	,
	@Password	varchar(50)	
	AS
BEGIN
INSERT INTO EFA
Values (@FA_ID, @Email, @Address, @Password)
END
GO
