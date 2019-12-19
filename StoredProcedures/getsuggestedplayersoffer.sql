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
CREATE PROCEDURE getsuggestedfreeplayersoffer
	-- Add the parameters for the stored procedure here
	@club int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select   s2.SID as ScoutID,s2.Name as ScoutName,PlayerID,p2.Fname as Firstname,p2.Lname as Lastname,c2.Fee,p2.Match_Rating as Rating,Date 
	from OfferPlayerC2E c2,Player p2,Scout s2 
	where SenderClubID=@club and Suggestion=1 and c2.PlayerID=p2.PID	and s2.SID=c2.ScoutID
	
END
GO
