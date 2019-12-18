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
CREATE PROCEDURE Addplayer 
	-- Add the parameters for the stored procedure here
	@fname varchar(50),
	@mname varchar(10),
	@lname varchar(50),
	@bdate date,
	@bplace varchar(50),
	@nationality varchar(50),
	@height float,
	@status varchar(50),
	@games int,
	@minutes int,
	@rating float,
	@id int,
	@clubid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Player(PID,Fname,Mname,Lname,Bdate,Birth_Place,Nationality,Height,Games_Played,Minutes_Played,Match_Rating,dbo.player.Status,ClubID)
	values(@id,@fname,@mname,@lname,@bdate,@bplace,@nationality,@height,@games,@minutes,@rating,@status,@clubid)
END
GO
