namespace Hotel.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using ViewModels.Booking;
    using Hotel.Web.Infrastructure.Extentions;

    [Authorize]
    public class BookingController : Controller
    {
        private readonly IBookingService bookingService;

        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
              return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateBookingFormModel model)
        {
            string? userId = this.User.GetId();

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.bookingService.Create(userId, model);
            }
            catch (Exception)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.RedirectToAction("Index", "Home");
        }

    }
}
