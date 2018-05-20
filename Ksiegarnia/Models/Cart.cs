using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

<<<<<<< HEAD
namespace Ksiegarnia.Models
=======
namespace BookStore.Models
>>>>>>> 31b0bdd2adb99b65805a6cf394113d6a2a0a7167
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Book book, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Book book)
        {
            lineCollection.RemoveAll(l => l.Book.BookId == book.BookId);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Book.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}