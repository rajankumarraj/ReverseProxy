CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[CustomerName] Varchar(200) not null,
	[Address1] Varchar(200),
	[Address2] Varchar(200),
	[City] Varchar(200),
	[State] Varchar(200),
	[Pin] Varchar(10),
	[Country] Varchar(200),
	[Email] varchar (100),
	[Phone] varchar(20),
	[IsActive] bit default 1,
	[CreatedOn] dateTime Default GetDate()
)
