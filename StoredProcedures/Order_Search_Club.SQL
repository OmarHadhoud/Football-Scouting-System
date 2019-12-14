USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[Order_Search_Club]    Script Date: 14/12/2019 3:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Order_Search_Club]
	-- Add the parameters for the stored procedure here
	@orderby	int	,	
	@inputN varchar(50),
	@orderDir bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; --------------------------------------------------------------need to ADD GROUP BY NON EXISTENT STUFF

	SET @orderby = ISNULL(@orderby,0)
    -- Insert statements for procedure here
	select [Name]
      ,[Abbreviation]
      ,[LeagueName]
	  ,ISNULL([Squad],0) as Squad
	  ,ISNULL([Average age],0) as [Average age]
	  FROM
	   (select CID
	  ,COUNT(Player.PID) as Squad
	  ,AVG(DATEDIFF(YY,Bdate,GETDATE()))as [Average age]
	FROM Club join Player on ClubID=CID group by CID) as s right join Club as c on c.CID=s.cid
	where (@inputN is null )or  [Name] Like @inputN+'%' 
	order by 
	CASE WHEN @orderby = 1 AND @orderDir =0 THEN  [Name] end asc,
    case WHEN @orderby = 2 AND @orderDir =0 THEN  [Abbreviation] end asc,
	case WHEN @orderby = 3 AND @orderDir =0 THEN [LeagueName]  end asc,
	case WHEN @orderby = 4 AND @orderDir =0 THEN Squad end asc,
    case WHEN @orderby = 5 AND @orderDir =0 THEN [Average age] end asc,
	case WHEN @orderby = 1 AND @orderDir =1 THEN  [Name] end desc,
    case WHEN @orderby = 2 AND @orderDir =1 THEN  [Abbreviation] end desc,
	case WHEN @orderby = 3 AND @orderDir =1 THEN [LeagueName]  end desc,
	case WHEN @orderby = 4 AND @orderDir =1 THEN Squad end desc,
    case WHEN @orderby = 5 AND @orderDir =1 THEN [Average age] end desc
	
END
