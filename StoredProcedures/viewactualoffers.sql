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
CREATE PROCEDURE getactualplayersoffer 
	-- Add the parameters for the stored procedure here
	@club int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select c.Name as 'Sender club', c.CID as 'Club ID', p.Fname as 'Player first name', p.Lname as 'Player last name', p.PID as 'Player ID', Fee,Date from OfferPlayerC2C o ,Player p,Club c where o.PlayerID = p.PID and c.CID = o.SenderClubID and o.RecClubID=@club and Suggestion = 0
END
GO
