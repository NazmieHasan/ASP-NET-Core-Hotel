namespace Hotel.Services.Data.Interfaces
{
    using Models.Booking;
    using Hotel.Web.ViewModels.Booking;

    public interface IBookingService
    {
        Task Create(string userId, CreateBookingFormModel model);

        Task<AllBookinsFilteredAndPagedServiceModel> AllAsync(AllBookingsQueryModel queryModel);

        Task<IEnumerable<BookingAllViewModel>> AllByUserIdAsync(string userId);

        Task<bool> ExistsByIdAsync(string bookingId);

        Task<BookingDetailsViewModel> GetDetailsByIdAsync(string bookingId);

        Task<CreateBookingFormModel> GetBookingForEditByIdAsync(string bookingId);
    }
}