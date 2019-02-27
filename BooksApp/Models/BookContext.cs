using Microsoft.EntityFrameworkCore; //!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApp.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options) //konstruktor
        {

        }

        public DbSet<Book> Books { get; set; } //przekazujemy model do contextu dla db
    }
}
