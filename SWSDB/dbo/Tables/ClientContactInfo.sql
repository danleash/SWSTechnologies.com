CREATE TABLE [dbo].[ClientContactInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [Message] NVARCHAR(MAX) NOT NULL
)
