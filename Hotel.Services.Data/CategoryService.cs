namespace Hotel.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using Hotel.Data;
    using Hotel.Data.Models;
    using Interfaces;
    using Web.ViewModels.Home;
    using Web.ViewModels.Category;

    public class CategoryService : ICategoryService
    {
        private readonly HotelDbContext dbContext;

        public CategoryService(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(CategoryFormModel formModel)
        {
            Category newCategory = new Category
            {
                Name = formModel.Name,
                Description = formModel.Description,
                Beds = formModel.Beds,
                Price = formModel.Price,
                ImageUrl = formModel.ImageUrl
            };

            await this.dbContext.Categories.AddAsync(newCategory);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<IndexViewModel>> AllAsync()
        {
            IEnumerable<IndexViewModel> all = await this.dbContext
                .Categories
                .Where(c => c.IsActive)
                .Select(c => new IndexViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl
                })
                .ToArrayAsync();

            return all;
        }

        public async Task<IEnumerable<RoomSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<RoomSelectCategoryFormModel> allCategories = await this.dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new RoomSelectCategoryFormModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();

            return allCategories;
        }

        public async Task<bool> ExistsByIdAsync(int id)
        {
            bool result = await this.dbContext
                .Categories
                .AnyAsync(c => c.Id == id);

            return result;
        }
    }
}
