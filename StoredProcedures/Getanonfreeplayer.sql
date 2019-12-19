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
CREATE PROCEDURE GetanonfreePlayerproc 
	@inputN varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select Player.PID as ID,Player.Fname as First_Name,Player.Lname as Last_Name, Player.Match_Rating as Rating, Club.Name as Club from Player join Club on ClubID=CID where (ClubID is not null or YouthClubID is not null) and  Fname Like'%'+@inputN+'%'  or Lname Like '%'+@inputN + '%'
END
GO
