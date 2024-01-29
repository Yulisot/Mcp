using API.Customer;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> Clients {get; set;}
    }
}