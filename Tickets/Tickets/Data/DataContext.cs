using Microsoft.EntityFrameworkCore;
using Tickets.Data.Entities;

namespace Tickets.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)  
        {
        }

        public DbSet<Entrance> entrances { get; set; }
        public DbSet <ticket>  tickets{ get; set; }

    }
}
