using System.Data.Entity.ModelConfiguration;
using Cmx.Bookings.Entities;

namespace Cmx.Bookings.DataAccess.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(c => c.Id);
        }
    }
}