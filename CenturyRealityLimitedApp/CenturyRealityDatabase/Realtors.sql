CREATE TABLE [dbo].[Realtors]
(
	[RealtorId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(20) NOT NULL, 
    [UserName] NCHAR(20) NOT NULL, 
    [Password] NCHAR(20) NOT NULL, 
    [CommissionEarned] DECIMAL(18, 2) NOT NULL, 
    [CompanyEarnings] DECIMAL(18, 2) NOT NULL
)
