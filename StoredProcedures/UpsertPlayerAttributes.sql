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
CREATE PROCEDURE UpsertPlayerAttributes
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


			MERGE 
			   [Attributes profile] AS t
			USING 
			   (values 
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
				,@gkd)) AS s(PID,ScID,Pace,ACC,Stren,Jump,Shoot,Pass,Drib,Pos,Otb,gkh,gkp,gkd)
			ON 
			   t.PlayerID = s.PID and t.ScoutID=s.ScID
			WHEN MATCHED THEN 
			   UPDATE SET 
			   t.pace = s.pace,
			   t.acceleration = s.acc,
			   t.strength = s.stren
			  ,t.[Jumping] = s.Jump
			  ,t.[Shooting]=s.Shoot
			  ,t.[Passing] =s.pass
			  ,t.[Dribbling] =s.drib
			  ,t.[Positionning] = s.pos
			  ,t.[Off the ball] =s.otb 
			  ,t.[Goalkeeper handling] =s.gkh
			  ,t.[Goalkeeper positioning] =s.gkp
			  ,t.[Goalkeeper decisions]= s.gkd
			WHEN NOT MATCHED THEN 
			   
			insert ([PlayerID]
			  ,[ScoutID]
			  ,Pace
			  ,[Acceleration]
			  ,[Strength]
			  ,[Jumping]
			  ,[Shooting]
			  ,[Passing]
			  ,[Dribbling]
			  ,[Positionning]
			  ,[Off the ball]
			  ,[Goalkeeper handling]
			  ,[Goalkeeper positioning]
			  ,[Goalkeeper decisions])
			values 
				(s.PID			
				,s.ScID			
				,s.Pace			
				,s.Acc	
				,s.Stren		
				,s.Jump		
				,s.Shoot		
				,s.Pass			
				,s.Drib		
				,s.Pos		
				,s.otb				
				,s.gkh				
				,s.gkp				
				,s.gkd);
END
GO
