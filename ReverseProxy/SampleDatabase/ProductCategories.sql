CREATE TABLE [dbo].[ProductCategories]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[CategoryName] varchar(200),
	[IsActive] bit default 1
	
)
