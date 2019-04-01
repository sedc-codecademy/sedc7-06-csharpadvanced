# Library management

Create an application that will enable you to enter and view different kinds of books.

## Description of the data
Available book types are:

- Novel
- Story collection
- Anthology

All books have a:

- ID - unique numeric value for each book
- Title
- Type of edition (Hardcover, Paperback, EBook, Audiobook)
- Number of pages
- Method to generate an ISBN for the book (random 13-digit number)

Additionally, Novels are books that have the following additional properties

- Author
- Series (if applicable, can be empty if it's not part of a series)
- Series number (if applicable, can be zero if it's not part of a series)

Story collections are books that have the following additional properties

- Author
- A collection of stories, where each story has the following properties
    - Story title
    - Story type (Novellette, Novella, Short Story)
    - Whether the story is original to the collection

An anthology is a book that has the following additional properties

- Editor
- Theme
- A collection of stories, where each story has the following properties
    - Author name
    - Story title
    - Story type (Novellette, Novella, Short Story)
    - Whether the story is original to the anthology

## Application

The finished application should enable us to:

- View All Books (Titles, Author/Editor and Edition Type)
- View All Novels (Title, Author, Series with Number, Number of pages)
- View All Story Collections (Title, Author, Number of stories)
- View All Anthologies (Title, Editor, Number of stories, Number of contribution authors)

The data entry is not mandatory, and can be hardcoded. If you need a good place to get book information you can visit [goodreads](https://www.goodreads.com)

## Advice

- Think what can be best done by an interface
- Remember that you can have extension methods implemented on an interface
- You can always override the ToString method to return an appropriate format of the data
- Think how the application will change if we need to support Poem collections as well