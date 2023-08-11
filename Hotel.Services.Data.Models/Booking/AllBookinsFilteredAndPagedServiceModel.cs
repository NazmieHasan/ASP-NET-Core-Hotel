namespace Hotel.Services.Data.Models.Booking
{
    using Web.ViewModels.Booking;

    public class AllBookinsFilteredAndPagedServiceModel
    {
        public AllBookinsFilteredAndPagedServiceModel()
        {
            this.Bookings = new HashSet<BookingAllViewModel>();
        }

        public int TotalBookingsCount { get; set; }

        public IEnumerable<BookingAllViewModel> Bookings { get; set; }
    }
}
