namespace Cmx.Bookings.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}