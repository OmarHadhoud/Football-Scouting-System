USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[GetPlayerClub]    Script Date: 19/12/2019 11:52:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetPlayerClub] 
	-- Add the parameters for the stored procedure here
	@PID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT	ISNULL(ISNULL( ClubID,YouthClubID),0) from Player where PID = @PID
END
