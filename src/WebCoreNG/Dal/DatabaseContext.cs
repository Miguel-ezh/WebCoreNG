using Microsoft.EntityFrameworkCore;
using WebCoreNG.Dal.Entities;

namespace WebCoreNG.Dal
{
    public class BloggingContext : DbContext
    {
        
        public DbSet<TestTable> TestTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./my-database.db");
        }
    }
}
