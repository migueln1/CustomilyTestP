using CustomilyNETTest.Models;
using System.Data.Entity;

namespace CustomilyNETTest.DataLayer
{
    public class CustomilyDbContext : DbContext
    {
        public CustomilyDbContext()
            : base("CustomilyContext")
        {}

        public DbSet<Page> Pages { get; set; }
    }
}