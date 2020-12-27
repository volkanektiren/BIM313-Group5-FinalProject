# BIM313-Group5-FinalProject
BIM313 Advanced Programming Techniques course final project.

# Library Management System
We decided to implement a library management system as the project idea. The program will
provide the following features to the library managements.
1. A library will be able to manage their book stocks with our program.
2. A library management can see actual number of books in stock, search them according to its
name, author name, publisher name and order them by ascending or descending from its ID,
number of pages, publication year.
3. The worker needs to manage lends from the system too, so the program provides them to
lend a book to a visitor. The program will decrease the number of books in stock by 1 when a
book is lent and as vice versa, increase by 1 when a visitor gives back a book which is lent
before.
4. A library management can do crud operations (create, read, update, delete) for books,
authors, publishers, stocks, loan records.
5. A book cannot be lent if it is out of stock.
6. When a book is lent, tenancy will be calculated as page number divided by 5.

# Database
We will create a database for the program which includes following tables.
1. Book table: ID, title, publicationYear, pageNumber, publisherID, authorID
2. Author table: ID, name, surname
3. Publisher table: ID, name
4. Stock table: ID, number, bookID
5. Loan table: ID, visitorFullname, lendDate, tenancy, bookID
