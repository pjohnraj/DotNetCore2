using Microsoft.EntityFrameworkCore;
using Sample.DataModel;

namespace Sample.EntityContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option)
            :base(option)
        {

        }

        public DbSet<Pie> Pies { get; set; }
    }
}
