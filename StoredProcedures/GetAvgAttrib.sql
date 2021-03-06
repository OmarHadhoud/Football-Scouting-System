USE [Scouting System]
GO
/****** Object:  StoredProcedure [dbo].[GetAvgAttrib]    Script Date: 14/12/2019 11:49:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetAvgAttrib]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [PlayerID]
      ,round(sum([Pace]*scout.Endorses)/cast(sum(scout.Endorses)						as float),0)as  [Pace]
      ,round(sum([Acceleration]*scout.Endorses)/cast(sum(scout.Endorses)				as float),0)as  [Acceleration]
      ,round(sum([Strength]*scout.Endorses)/cast(sum(scout.Endorses)					as float),0)as  [Strength]
      ,round(sum([Jumping]*scout.Endorses)/cast(sum(scout.Endorses)						as float),0)as  [Jumping]
      ,round(sum([Shooting]*scout.Endorses)/cast(sum(scout.Endorses)					as float),0)as  [Shooting]
      ,round(sum([Passing]*scout.Endorses)/cast(sum(scout.Endorses)						as float),0)as	[Passing]
      ,round(sum([Dribbling]*scout.Endorses)/cast(sum(scout.Endorses)					as float),0)as	[Dribbling]
      ,round(sum([Positionning]*scout.Endorses)/cast(sum(scout.Endorses)				as float),0)as	[Positioning]
      ,round(sum([Off the ball]*scout.Endorses)/cast(sum(scout.Endorses)				as float),0)as	[Off the ball]
      ,round(sum([Goalkeeper handling]*scout.Endorses)/cast(sum(scout.Endorses)			as float),0)as  [Goalkeeper handling]
      ,round(sum([Goalkeeper positioning]*scout.Endorses)/cast(sum(scout.Endorses)		as float),0)as  [Goalkeeper positioning]
      ,round(sum([Goalkeeper decisions]*scout.Endorses)/cast(sum(scout.Endorses)		as float),0)as	[Goalkeeper decisions]	 
  FROM [Attributes profile] left join Scout on ScoutID=SID group by PlayerID having playerID=@ID

END
