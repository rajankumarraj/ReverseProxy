CREATE PROCEDURE [dbo].[Sp_GetUserpager]
	@PageSize int = 10,
	@PageNum int =1
AS
	Select * from [dbo].[Users] Order by Id 
	OFFSET @PageSize *(@PageNum - 1) Rows
	Fetch Next @PageSize rows only