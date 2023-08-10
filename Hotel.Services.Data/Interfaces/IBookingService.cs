namespace Hotel.Services.Data.Interfaces
{
    using Hotel.Web.ViewModels.Booking;
    public interface IBookingService
    {
        Task Create(string userId, CreateBookingFormModel model);
    }
}