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
Create PROCEDURE Order_search_PlayerForScouts
	-- Add the parameters for the stored procedure here
	@orderby	int	,	
	@inputN varchar(50)	
	AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

select [Fname]
      ,[Lname]
      ,DATEDIFF(YY,Bdate,GETDATE()) As Age
      ,[Pos]
      ,[Height]      
      ,[Status]
  FROM [Player] where (@inputN is null )or  Fname Like @inputN+'%'  or Lname Like @inputN + '%' 
	order by 
	
	case WHEN @orderby = 1 THEN [Fname] end,
    	case WHEN @orderby = 2 THEN [Lname] end,
	case WHEN @orderby = 3 THEN DATEDIFF(YY,Bdate,GETDATE()) end,
    	case WHEN @orderby = 4 THEN [Pos] end,
	case WHEN @orderby = 5 THEN [Height]end




END
GO
