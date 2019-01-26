using Microsoft.EntityFrameworkCore;

namespace Sample.DataContext
{
    using DataModel;

    public class AppDbContext: DbContext
    {
        const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BethenyDemo;Trusted_Connection=True;MultipleActiveResultSets=true";

        public AppDbContext() : base() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}
