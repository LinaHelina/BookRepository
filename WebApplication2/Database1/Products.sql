CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL PRIMARY KEY, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [ProductPrice] DECIMAL(18, 2) NOT NULL, 
    [ProductImageUrl] NVARCHAR(MAX) NOT NULL, 
    [ProductAuthor] NVARCHAR(50) NOT NULL
)
