namespace Hotel.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Infrastructure.Extensions;
    using Services.Data.Interfaces;
    using ViewModels.Room;
    using Hotel.Web.Infrastructure.Extentions;

    [Authorize]

    public class RoomController : Controller
    {

        private readonly ICategoryService categoryService;

        public RoomController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public  async Task<IActionResult> All()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            RoomFormModel formModel = new RoomFormModel()
            {
                Categories = await this.categoryService.AllCategoriesAsync()
            };

            return View(formModel);
        }
    }
}
