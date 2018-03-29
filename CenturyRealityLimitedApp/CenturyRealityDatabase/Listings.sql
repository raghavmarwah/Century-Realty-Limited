CREATE TABLE [dbo].[Listings]
(
	[ListingId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StreetAddress] NCHAR(30) NOT NULL, 
    [City] NCHAR(15) NOT NULL, 
    [Pincode] NCHAR(6) NOT NULL, 
    [Province] NCHAR(2) NOT NULL, 
    [Bedrooms] INT NOT NULL, 
    [Bathrooms] INT NOT NULL, 
    [FloorArea] DECIMAL(18, 2) NOT NULL, 
    [SellerName] NCHAR(30) NOT NULL, 
    [ListPrice] DECIMAL(18, 2) NOT NULL, 
    [Available] BIT NOT NULL, 
    [SellDate] DATE NULL, 
    [RealtorId] INT NULL
)
