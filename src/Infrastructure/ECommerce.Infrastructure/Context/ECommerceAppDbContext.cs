using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Context
{
    public class ECommerceAppDbContext : DbContext
    {
        public ECommerceAppDbContext(DbContextOptions<ECommerceAppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig())
                .ApplyConfiguration(new MallConfig());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Mall> Malls { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
