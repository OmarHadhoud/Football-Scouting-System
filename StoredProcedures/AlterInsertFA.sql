USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[insertFA]    Script Date: 12/19/2019 11:52:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[insertFA]
	-- Add the parameters for the stored procedure here
	@FA_ID	int	,	
	@Email	varchar(50)	= NULL,
	@Address	varchar(50) = NULL	,
	@Password	varchar(66)	
	AS
BEGIN
INSERT INTO EFA
Values (@FA_ID, @Email, @Address, @Password)
END
