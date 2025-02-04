CREATE PROCEDURE [dbo].[Sp_InsertInvoice]
	@CustomerId int = 0,
	@TotalAmount decimal (18,2),
	@Tax decimal (18,2),
	@Discount decimal (18,2),
	@Amount decimal (18,2),
	@InvoiceStatus varchar(200),
	@PaymentMode varchar(200)
AS
	begin 
	insert into [dbo].[Invoices](CustomerId, TotalAmount, TAX, Discount, Amount, InvoiceStatus, PaymentMode)
	values (@CustomerId, @TotalAmount, @Tax, @Discount, @Amount, @InvoiceStatus, @PaymentMode)
	end