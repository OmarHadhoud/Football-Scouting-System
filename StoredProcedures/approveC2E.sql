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
CREATE PROCEDURE approveC2EOffer 
	@FA_ID int,
	@SCID int,
	@PID int
AS
BEGIN
	update OfferPlayerC2E set Suggestion=0 where EFAID = @FA_ID and SenderClubID = @SCID and PlayerID = @PID
END
GO
