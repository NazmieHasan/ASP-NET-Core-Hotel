namespace Hotel.Services.Data.Interfaces
{
    using Web.ViewModels.Home;
    using Web.ViewModels.Category;

    public interface ICategoryService
    {
        Task Create(CategoryFormModel formModel);

        Task<IEnumerable<IndexViewModel>> AllAsync();

        Task<IEnumerable<RoomSelectCategoryFormModel>> AllCategoriesAsync();

        Task<bool> ExistsByIdAsync(int id);
    }
}