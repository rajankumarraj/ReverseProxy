CREATE PROCEDURE [dbo].[Sp_GetInvoicePager]
	@PageSize int = 10,
	@PageNum int =1
AS
 Select * from [dbo].[Invoices] order by Id 
 OFFSET @PageSize * (@PageNum - 1) rows 
 fetch Next @PageSize Rows Only 