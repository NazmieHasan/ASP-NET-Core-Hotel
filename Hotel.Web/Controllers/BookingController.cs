namespace Hotel.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using Services.Data.Models.Booking;
    using ViewModels.Booking;
    using Hotel.Web.Infrastructure.Extentions;

    [Authorize]
    public class BookingController : Controller
    {
        private readonly IBookingService bookingService;
        private readonly IUserService userService;

        public BookingController(IBookingService bookingService,
            IUserService userService)
        {
            this.bookingService = bookingService;
            this.userService = userService;
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

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            bool bookingExists = await this.bookingService
               .ExistsByIdAsync(id);

            if (!bookingExists)
            {
                return this.RedirectToAction("Index", "Home");
            }

            BookingDetailsViewModel viewModel = await this.bookingService
                .GetDetailsByIdAsync(id);
            viewModel.User.FullName =
                   await this.userService.GetFullNameByEmailAsync(this.User.Identity?.Name!);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllBookingsQueryModel queryModel)
        {
            AllBookinsFilteredAndPagedServiceModel serviceModel =
                await this.bookingService.AllAsync(queryModel);

            queryModel.Bookings = serviceModel.Bookings;
            queryModel.TotalBookings = serviceModel.TotalBookingsCount;

            return this.View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            List<BookingAllViewModel> myBookings =
                new List<BookingAllViewModel>();

            string userId = this.User.GetId()!;
            myBookings.AddRange(await this.bookingService.AllByUserIdAsync(userId));
            
            return this.View(myBookings);
        }

    }
}
