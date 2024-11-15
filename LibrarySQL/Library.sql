INSERT INTO Authors (Name, Surname)
VALUES 
    ('George', 'Orwell'),
    ('Harper', 'Lee'),
    ('J.K.', 'Rowling'),
    ('F. Scott', 'Fitzgerald'),
    ('J.R.R.', 'Tolkien');


create table Authors(
Id int IDENTITY PRIMARY KEY,
Name nvarchar(20) NOT NULL,
Surname nvarchar(20) NOT NULL
)

INSERT INTO Books (AuthorId, Name, PageCount)
VALUES 
    (1, '1984', 328),
    (1, 'Animal Farm', 112),
    (2, 'To Kill a Mockingbird', 281),
    (3, 'Harry Potter and the Philosophers Stone', 223),
    (4, 'The Great Gatsby', 180),
    (5, 'The Hobbit', 310),
    (5, 'The Lord of the Rings', 1178);


create table Books(
Id int IDENTITY PRIMARY KEY,
AuthorId int,
FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
Name nvarchar(50) NOT NULL CHECK (LEN(Name) >= 2),
PageCount int NOT NULL CHECK (PageCount >= 10)
)

CREATE VIEW BooksAuthorsView AS
SELECT 
    B.Id,
    B.Name,
    B.PageCount,
    CONCAT(A.Name, ' ', A.Surname) AS AuthorFullName
FROM 
    Books B
JOIN 
    Authors A ON B.AuthorId = A.Id;

CREATE PROCEDURE sp_SearchBooks
    @search NVARCHAR(50)
AS
BEGIN
    SELECT 
        B.Id,
        B.Name,
        B.PageCount,
        CONCAT(A.Name, ' ', A.Surname) AS AuthorFullName
    FROM 
        Books B
    JOIN 
        Authors A ON B.AuthorId = A.Id
    WHERE 
        B.Name LIKE '%' + @search + '%'
        OR A.Name LIKE '%' + @search + '%';
END;

CREATE FUNCTION fn_CountBooksByPageCount
    (@MinPageCount INT = 10)
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    
    SELECT 
        @Count = COUNT(*)
    FROM 
        Books
    WHERE 
        PageCount > @MinPageCount;
        
    RETURN @Count;
END;
