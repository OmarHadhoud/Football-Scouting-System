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
CREATE PROCEDURE AddManager
	-- Add the parameters for the stored procedure here
	@MID	int	,
	@Name	varchar(50)	= null,
	@Bdate	date =null	,
	@Nationality	varchar(50) = null	,
	@ClubID	int	= null,
	@AgentID	int	 = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	Insert into Manager values(@MID,@Name,@Bdate,@Nationality,@ClubID,@AgentID)
END
GO
