using Microsoft.EntityFrameworkCore;
using Moment3.Models;

namespace Moment3.Data
{
    //Anslutning till databas för Book
    public class BookStoreDbContext: DbContext
    {
        //Konstruktor
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

        //Tabeller
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
