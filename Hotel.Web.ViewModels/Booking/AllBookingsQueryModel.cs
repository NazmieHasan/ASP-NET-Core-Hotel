namespace Hotel.Web.ViewModels.Booking
{
    using System.ComponentModel.DataAnnotations;

    using Enums;

    using static Common.GeneralApplicationConstants;

    public class AllBookingsQueryModel
    {
        public AllBookingsQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.BookingsPerPage = EntitiesPerPage;
        }

        [Display(Name = "Search By User Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Sort Bookings By")]
        public BookingSort BookingSort { get; set; }

        public int CurrentPage { get; set; }

        [Display(Name = "Show Bookings On Page")]
        public int BookingsPerPage { get; set; }

        public int TotalBookings { get; set; }

        public IEnumerable<BookingAllViewModel> Bookings { get; set; }

    }
}
