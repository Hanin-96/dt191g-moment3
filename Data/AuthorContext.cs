using Microsoft.EntityFrameworkCore;
using Moment3.Models;
namespace Moment3.Data
{
    //Anslutning till databas för Author
    public class AuthorContext: DbContext
    {
        //Konstruktor
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options) { }

        //Tabellen tilldelas namnet Authors
        public DbSet<Author> Authors { get; set; }
    }
}
