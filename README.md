# BIM313-Group5-FinalProject
BIM313 Advanced Programming Techniques course final project.

We decided to implement a library management system as the project idea. The program will
provide the following features to the library managements.
• A library will be able to manage their book stocks with our program.
• A library management can see actual number of books in stock, search them according to its
name, author name, publisher name and order them by ascending or descending from its ID,
number of pages, publication year.
• The worker needs to manage lends from the system too, so the program provides them to
lend a book to a visitor. The program will decrease the number of books in stock by 1 when a
book is lent and as vice versa, increase by 1 when a visitor gives back a book which is lent
before.
• A library management can do crud operations (create, read, update, delete) for books,
authors, publishers, stocks, loan records.
• A book cannot be lent if it is out of stock.
• When a book is lent, tenancy will be calculated as page number divided by 5.
We will create a database for the program which includes following tables.
• Book table: ID, title, publicationYear, pageNumber, publisherID, authorID
• Author table: ID, name, surname
• Publisher table: ID, name
• Stock table: ID, number, bookID
• Loan table: ID, visitorFullname, lendDate, tenancy, bookID
