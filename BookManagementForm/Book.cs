using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagementForm
{
    public class Book
    {
        public Book(string id, string name, DateTime publishDate, int numOfReprints, double price, int quantity, string author, bool isNativeBook)
        {
            Id = id;
            Name = name;
            PublishDate = publishDate;
            NumOfReprints = numOfReprints;
            Price = price;
            Quantity = quantity;
            Author = author;
            IsNativeBook = isNativeBook;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public int NumOfReprints { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Author { get; set; }
        public bool IsNativeBook { get; set; }
        

    }
}
