CREATE TABLE [dbo].[Pessoa]
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NCHAR(50) NULL, 
    [Company] NCHAR(50) NULL, 
    [Telephone] NCHAR(50) NULL, 
    [Email] NCHAR(50) NULL, 
    [Client] BIT NULL, 
    [LastCall] DATETIME NULL

)
