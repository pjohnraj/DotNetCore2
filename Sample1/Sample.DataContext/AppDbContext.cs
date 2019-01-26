using Microsoft.EntityFrameworkCore;

namespace Sample.DataContext
{
    using DataModel;

    public class AppDbContext: DbContext
    {
        const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=ClientDb;Trusted_Connection=True;";

        public AppDbContext() : base() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Pie> Pies { get; set; }
    }
}
