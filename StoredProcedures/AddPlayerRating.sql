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
CREATE PROCEDURE AddPlayerRating
	-- Add the parameters for the stored procedure here
		@PlayerID			int	
		,@ScoutID			int	
		,@Pace				int	
		,@Acceleration		int	
		,@Strength			int	
		,@Jumping			int	
		,@Shooting			int	
		,@Passing			int	
		,@Dribbling			int	
		,@Positionning		int	
		,@otb				int	
		,@gkh				int	
		,@gkp				int	
		,@gkd				int	
		
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into [Attributes profile] 
	values 
		(@PlayerID			
		,@ScoutID			
		,@Pace				
		,@Acceleration		
		,@Strength			
		,@Jumping			
		,@Shooting			
		,@Passing			
		,@Dribbling			
		,@Positionning		
		,@otb				
		,@gkh				
		,@gkp				
		,@gkd)
END
GO
