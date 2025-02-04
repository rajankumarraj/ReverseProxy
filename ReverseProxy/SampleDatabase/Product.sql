CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[ProductName] Varchar(200),
	[Category] Int not null,
	[IsActive] bit default 1,
	[CreatedOn] dateTime Default GetDate()
)
