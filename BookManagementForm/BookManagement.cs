using System;
using System.Collections.Generic;
using System.IO;

namespace BookManagementForm
{
    class BookManagement
    {
        private readonly List<Book> books = new List<Book>();

        public List<Book> GetListBook()
        {
            return books;
        }
        public Book GetBookById(string id)
        {
            foreach(Book book in books){
                if (book.Id.Trim().Equals(id.Trim())){
                    return book;
                }
            }
            return null;
        }
        public bool AddBook(Book newBook)
        {
            if(GetBookById(newBook.Id) != null)
            {
                return false;
            }
            books.Add(newBook);
            return true;
        }

        public bool RemoveBook(string id)
        {
            Book selectedBook = GetBookById(id);
            if(selectedBook == null)
            {
                return false;
            } else
            {
                books.Remove(selectedBook);
                return true;
            }
        }

        public bool UpdateBook(Book newBook)
        {
            Book currentBook = GetBookById(newBook.Id);
            if(currentBook != null)
            {
                currentBook.Name = newBook.Name;
                currentBook.IsNativeBook = newBook.IsNativeBook;
                currentBook.NumOfReprints = newBook.NumOfReprints;
                currentBook.Price = newBook.Price;
                currentBook.PublishDate = newBook.PublishDate;
                currentBook.Quantity = newBook.Quantity;
                currentBook.Author = newBook.Author;
                return true;
            }
            return false;
        }

        public void ExportData(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach(Book book in books)
            {
                string line = "";
                line += (book.Id + "-" + book.Name + "-" + book.Author + "-" + book.NumOfReprints + "-" + book.Price + "-" + book.Quantity + "-" + (book.IsNativeBook ? "1" : "0" + "-") + book.PublishDate);
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public void ImportData(string fileName, bool isRewrite)
        {
            List<Book> booksFromFile = new List<Book>();
            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine();
            while ((line != null) && (line != " "))
            {
                string[] array = line.Split('-');
                line = sr.ReadLine();
                booksFromFile.Add(new Book(array[0].Trim(), array[1].Trim(), DateTime.Parse(array[7].Trim()), int.Parse(array[3].Trim()), double.Parse(array[4].Trim()), int.Parse(array[5].Trim()), array[2].Trim(), "1".Equals(array[6].Trim()) ? true : false));
            }
            sr.Close();
            if (isRewrite)
            {
                books.Clear();

            }
            books.AddRange(booksFromFile);
        }

        public List<Book> SearchByNameAndRangeOfDate(string name, DateTime start, DateTime end)
        {
            List<Book> searchBooks = new List<Book>();
            foreach(Book b in books)
            {
                if (b.Name.Contains(name) && b.PublishDate.CompareTo(start) >= 0 && b.PublishDate.CompareTo(end) <= 0)
                {
                    searchBooks.Add(b);
                }
            }

            return searchBooks;
        }
    }
}
