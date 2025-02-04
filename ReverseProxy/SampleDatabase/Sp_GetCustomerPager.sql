CREATE PROCEDURE [dbo].[Sp_GetCustomerPager]
	@PageSize int = 10,
	@PageNum int =1
AS
	Select * from [dbo].[Customers] order by Id 
	OFFSET @PageSize *(@PageNum - 1) Rows
	Fetch next @PageSize rows only 