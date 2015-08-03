using Dresses4Heaven.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dresses4Heaven.DAL
{
    public class DressesContext : DbContext
    {

        public DressesContext()
            : base("DressesContext")
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}