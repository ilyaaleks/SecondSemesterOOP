USE [Lab8]
GO

/****** Object:  StoredProcedure [dbo].[sp_InsertStudent]    Script Date: 17.04.2019 22:27:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertStudent]
    @photo varbinary(max),
    @name nvarchar(50),
    @dateOfBirth date,
	@group nvarchar(50),
    @Id int out
AS
    INSERT INTO Student(Photo, Name, DateOfBirth, [Group])
    VALUES (@photo, @name, @dateOfBirth, @group)
   
    SET @Id=SCOPE_IDENTITY()
GO


