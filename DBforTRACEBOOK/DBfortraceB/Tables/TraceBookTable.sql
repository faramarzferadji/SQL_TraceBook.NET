CREATE TABLE [dbo].[TraceBookTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [block] INT NULL, 
    [stname] VARCHAR(50) NULL, 
    [bookname] VARCHAR(50) NULL, 
    [bookid] NCHAR(10) NULL, 
    [dateout] DATE NULL, 
    [datedue] DATE NULL
)
