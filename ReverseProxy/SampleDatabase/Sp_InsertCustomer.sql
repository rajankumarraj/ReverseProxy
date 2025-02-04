CREATE PROCEDURE [dbo].[Sp_InsertCustomer]
	@CustomerName varchar(200),
	@Address1 varchar(200),
	@Address2 varchar(200),
	@Pin varchar(10),
	@City varchar(200),
	@State varchar(200),
	@Country varchar(200),
	@Email varchar(200),
	@Phone varchar(20)
AS
	Begin
	Insert into [dbo].[Customers] (CustomerName, Address1, Address2, Pin, City, State, Country, Email, Phone) 
	values(@CustomerName, @Address1, @Address2, @Pin, @City, @State, @Country, @Email, @Phone)
	end