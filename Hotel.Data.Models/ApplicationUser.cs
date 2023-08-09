namespace Hotel.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.AllBookings = new HashSet<Booking>();
        }

        public virtual ICollection<Booking> AllBookings { get; set; }
    }
}