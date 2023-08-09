namespace Hotel.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Configurations;
    using Models;

    public class HotelDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Room> Rooms { get; set; } = null!;

        public DbSet<Booking> Bookings { get; set; } = null!;

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //}

    }
}