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
CREATE PROCEDURE insertClub
	-- Add the parameters for the stored procedure here
	@CID	int	,
	@Name	varchar(50)	,
	@Abbreviation	varchar(3) 	,
	@City	varchar(50)	= NULL,
	@LeagueName	varchar(50)	= NULL,
	@League_EFAID	int	= NULL,
	@Foundation_Date	date	= NULL,
	@Password	varchar(50)	
AS
BEGIN
INSERT INTO Club(CID,Name,Abbreviation, City, LeagueName, League_EFAID, Foundation_Date, Password)
Values (@CID, @Name, @Abbreviation, @City, @LeagueName, @League_EFAID, @Foundation_Date, @Password)
END
GO
