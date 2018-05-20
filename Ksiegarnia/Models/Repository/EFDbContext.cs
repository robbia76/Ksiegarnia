using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

<<<<<<< HEAD
namespace Ksiegarnia.Models.Repository
=======
namespace BookStore.Models.Repository
>>>>>>> 31b0bdd2adb99b65805a6cf394113d6a2a0a7167
{
    public class EFDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}