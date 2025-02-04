CREATE PROCEDURE [dbo].[Sp_InsertProduct]
	@ProductName Varchar(200),
	@Category int
AS
	begin 
	insert into [dbo].[Products] (ProductName, Category) values (@ProductName, @Category)
	end