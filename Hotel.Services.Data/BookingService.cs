namespace Hotel.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using Hotel.Data;
    using Hotel.Data.Models;
    using Interfaces;
    using Web.ViewModels.Booking;

    public class BookingService : IBookingService
    {
        private readonly HotelDbContext dbContext;

        public BookingService(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task Create(string userId, CreateBookingFormModel model)
        {
            Booking newBooking = new Booking()
            {
                PhoneNumber = model.PhoneNumber,
                UserId = Guid.Parse(userId)
            };

            await this.dbContext.Bookings.AddAsync(newBooking);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
