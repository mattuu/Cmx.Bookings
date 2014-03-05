using System.Data.Entity;
using Cmx.Bookings.DataAccess.Mappings;
using Cmx.Bookings.Entities;

namespace Cmx.Bookings.DataAccess
{
    public class BookingsContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}