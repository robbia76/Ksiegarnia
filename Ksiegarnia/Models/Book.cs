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
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
=======
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
>>>>>>> 31b0bdd2adb99b65805a6cf394113d6a2a0a7167
    }
}