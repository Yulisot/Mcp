using API.Customer;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<UserLogin> UserLogins {get; set;}
        public DbSet<Emp> Emps { get; set;}
        public DbSet<Paycheck> Paychecks { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Companies)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.Client)
                .WithMany(client => client.Companies)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Company)
                .WithMany(co => co.Users)
                .HasForeignKey(u => u.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserLogin>()
                .HasOne(ul => ul.User)
                .WithMany(u => u.Logins)
                .HasForeignKey(ul => ul.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Emp>()
                .HasOne(e => e.User)
                .WithMany(u => u.Emps)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Paycheck>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Paychecks)
                .HasForeignKey(p => p.EmpId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
