CREATE PROCEDURE [dbo].[Sp_GetProductPager]
	@PageSize int = 10,
	@PageNum int =1
AS
	Select * from [dbo].[Products] order by Id 
	OFFSET @PageSize * (@PageNum-1) Rows 
	Fetch Next @PageSize rows only 