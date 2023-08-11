namespace Hotel.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using Hotel.Data;
    using Hotel.Data.Models;
    using Interfaces;
    using Models.Booking;
    using Web.ViewModels.Booking;
    using Web.ViewModels.Booking.Enums;
    using Web.ViewModels.User;

    public class BookingService : IBookingService
    {
        private readonly HotelDbContext dbContext;

        public BookingService(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllBookinsFilteredAndPagedServiceModel> AllAsync(AllBookingsQueryModel queryModel)
        {
            IQueryable<Booking> bookingsQuery = this.dbContext
                            .Bookings
                            .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.PhoneNumber))
            {
                string wildCard = $"%{queryModel.PhoneNumber}%";

                bookingsQuery = bookingsQuery
                    .Where(b => EF.Functions.Like(b.PhoneNumber, wildCard));
            }

            bookingsQuery = queryModel.BookingSort switch
            {
                BookingSort.Newest => bookingsQuery
                    .OrderByDescending(b => b.CreatedOn),
                BookingSort.Oldest => bookingsQuery
                    .OrderBy(b => b.CreatedOn),
                _ => bookingsQuery
                    .OrderBy(b => b.Id)
                    .ThenByDescending(b => b.CreatedOn)
            };

            IEnumerable<BookingAllViewModel> allBookings = await bookingsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.BookingsPerPage)
                .Take(queryModel.BookingsPerPage)
                .Select(b => new BookingAllViewModel
                {
                    Id = b.Id.ToString(),
                    PhoneNumber = b.PhoneNumber
                })
                .ToArrayAsync();

            int totalBookings = bookingsQuery.Count();

            return new AllBookinsFilteredAndPagedServiceModel()
            {
                TotalBookingsCount = totalBookings,
                Bookings = allBookings
            };

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

        public async Task<IEnumerable<BookingAllViewModel>> AllByUserIdAsync(string userId)
        {
            IEnumerable<BookingAllViewModel> allUserBookings = await this.dbContext
                .Bookings
                .Where(b => b.UserId.ToString() == userId)
                .Select(b => new BookingAllViewModel
                {
                    Id = b.Id.ToString(),
                    PhoneNumber = b.PhoneNumber
                })
                .ToArrayAsync();

            return allUserBookings;
        }

        public async Task<bool> ExistsByIdAsync(string bookingId)
        {
            bool result = await this.dbContext
                .Bookings
                .AnyAsync(b => b.Id.ToString() == bookingId);

            return result;
        }

        public async Task<BookingDetailsViewModel> GetDetailsByIdAsync(string bookingId)
        {
            Booking booking = await this.dbContext
                .Bookings
                .Include(u => u.User)
                .FirstAsync(b => b.Id.ToString() == bookingId);

            return new BookingDetailsViewModel
            {
                Id = booking.Id.ToString(),
                PhoneNumber = booking.PhoneNumber,
                User = new UserInfoOnBookingViewModel()
                {
                    Email = booking.User.Email
                }
            };
        }

        public async Task<CreateBookingFormModel> GetBookingForEditByIdAsync(string bookingId)
        {
            Booking booking = await this.dbContext
                .Bookings
                .FirstAsync(b => b.Id.ToString() == bookingId);

            return new CreateBookingFormModel
            {
                PhoneNumber = booking.PhoneNumber
            };
        }

    }
}
