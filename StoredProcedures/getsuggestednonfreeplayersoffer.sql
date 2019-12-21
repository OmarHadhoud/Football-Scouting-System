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
CREATE PROCEDURE getsuggestednonfreeplayersoffer
	-- Add the parameters for the stored procedure here
	@club int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select  s.SID as ScoutID,s.Name as ScoutName, PlayerID,p.Fname as Firstname,p.Lname as Lastname,c.Fee,p.Match_Rating as Rating,l.CID as ClubID,l.Name as Club,Date 
	from OfferPlayerC2C c,Player p,Club l, Scout s 
	where SenderClubID=@club and Suggestion=1 and c.PlayerID=p.PID and c.RecClubID=l.CID and s.SID=c.ScoutID
	
END
GO
