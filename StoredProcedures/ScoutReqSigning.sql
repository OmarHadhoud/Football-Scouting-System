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
CREATE PROCEDURE ScoutReqSigningC2C
	-- Add the parameters for the stored procedure here
	 @CID1 int --send
	,@CID2 int --Recive
	,@PID int
	,@Fee int
	,@suggestion bit
	,@Sid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into OfferPlayerC2C Values(@CID1
      ,@CID2
      ,@PID
      ,CURRENT_TIMESTAMP
      ,@Fee
      ,1
      ,@Sid)
END
GO
