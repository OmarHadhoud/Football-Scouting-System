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
CREATE PROCEDURE GetFreePlayerOffers
	@FA_ID int
AS
BEGIN
	Select c.Name as 'Sender club', p.Fname as 'Player first name', p.Lname as 'Player last name', Fee from OfferPlayerC2E o ,Player p,Club c where o.PlayerID = p.PID and c.CID = o.SenderClubID and o.EFAID = @FA_ID and Suggestion = 0 
END
GO
