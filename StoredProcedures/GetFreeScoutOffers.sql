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
CREATE PROCEDURE GetFreeScoutsOffers
	@FA_ID int
AS	
BEGIN
	Select c.Name as 'Sender club', c.CID as 'Club ID', s.Name as 'Scout name', s.SID as 'Scout ID', Fee from OfferScoutC2E o ,Scout s,Club c where o.ScoutID = s.SID and c.CID = o.SenderClubID and o.EFAID = @FA_ID and Suggestion = 0 and s.ClubID is NULL 
END
GO
