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


select [Fname]
      ,[Lname]
	  ,DATEDIFF(YY,Bdate,GETDATE()) As Age
	  ,[Pos]
      ,[Height]      
      ,[Status]
  FROM [Player] where (@inputN is null )or  Fname Like @inputN+'%'  or Lname Like @inputN + '%' 
	order by 
	CASE
    WHEN @orderby = 1 THEN [Fname] end,
    case WHEN @orderby = 2 THEN [Lname] end,
	case WHEN @orderby = 3 THEN DATEDIFF(YY,Bdate,GETDATE()) end,
    case WHEN @orderby = 4 THEN [Pos] end,
	case WHEN @orderby = 5 THEN [Height]end




END
GO