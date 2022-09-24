CREATE TABLE Users
(  
    UserID int IDENTITY(1,1) PRIMARY KEY,
    FirstName nvarchar(50) NOT NULL,  
    LastName nvarchar(50) NOT NULL
);

INSERT INTO Users (FirstName, LastName) VALUES
 ('John','Wick'),
 ('Magnus','Carlsen'),
 ('Charlie','Brown'),
 ('Otter','Brownlig'),
 ('Mario','Super'),
 ('Obi-Wan','Kenobi')
