using System.Data.Entity.ModelConfiguration;
using Cmx.Bookings.Entities;

namespace Cmx.Bookings.DataAccess.Mappings
{
    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            HasKey(b => b.Id);

            HasRequired(b => b.Customer)
                .WithMany()
                .HasForeignKey(b => b.CustomerId);
        }
    }
}