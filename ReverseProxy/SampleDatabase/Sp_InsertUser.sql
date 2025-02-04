CREATE PROCEDURE [dbo].[Sp_InsertUser]
	@FullName varchar(200),
	@Email varchar(200),
	@Phone varchar(20)
AS
	Begin
	Insert into [dbo].[Users] (FullName, Email, Phone) values(@FullName, @Email, @Phone)
	End