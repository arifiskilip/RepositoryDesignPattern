
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;
using WebUI.Core.Entities;

namespace WebUI.Entities.Context
{
    public class MiniTransferContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public MiniTransferContext(DbContextOptions<MiniTransferContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly(),
                     t => t.GetInterfaces().Any(i =>
                     i.IsGenericType &&
                     i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))

 );
        }
    }
}
