using Microsoft.EntityFrameworkCore;
using WebCoreNG.Dal.Entities;

namespace WebCoreNG.Dal
{
    public class ApplicationDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./my-database.db");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<SubmissionAccountLookup> SubmissionAccountLookups { get; set; }
    }
}
