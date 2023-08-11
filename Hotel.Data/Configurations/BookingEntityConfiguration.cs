namespace Hotel.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class BookingEntityConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder
                .Property(h => h.CreatedOn)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
