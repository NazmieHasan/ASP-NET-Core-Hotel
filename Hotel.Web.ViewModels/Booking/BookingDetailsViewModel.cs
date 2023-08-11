namespace Hotel.Web.ViewModels.Booking
{
    using System.ComponentModel.DataAnnotations;

    using User;

    public class BookingDetailsViewModel : BookingAllViewModel
    {
        public UserInfoOnBookingViewModel User { get; set; } = null!;
    }
}
