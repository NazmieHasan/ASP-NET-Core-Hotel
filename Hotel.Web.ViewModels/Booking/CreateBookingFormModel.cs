namespace Hotel.Web.ViewModels.Booking
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Booking;

    public class CreateBookingFormModel
    {
        [Required]
        [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
        [Phone]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; } = null!;
    }
}
