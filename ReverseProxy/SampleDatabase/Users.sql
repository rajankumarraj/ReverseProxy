CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[FullName] varchar(200) not null,
	[Email] varchar (100),
	[Phone] varchar(20),
	[IsActive] bit default 1,
	[CreatedOn] datetime default Getdate()
)
