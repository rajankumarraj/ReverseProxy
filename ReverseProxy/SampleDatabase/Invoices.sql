CREATE TABLE [dbo].[Invoices]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[CustomerId] int not Null,
	[TotalAmount] decimal(18,2) not null,
	[TAX] decimal(18,2) not null,
	[Discount]decimal(18,2) not null,
	[Amount]decimal(18,2) not null,
	[InvoiceStatus] varchar(20),
	[PaymentMode] Varchar(100),
	[CreatedOn] datetime default Getdate()
)
