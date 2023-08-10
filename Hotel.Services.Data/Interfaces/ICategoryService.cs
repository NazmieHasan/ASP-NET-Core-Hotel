namespace Hotel.Services.Data.Interfaces
{
    using Web.ViewModels.Home;

    public interface ICategoryService
    {
        Task<IEnumerable<IndexViewModel>> AllAsync();
    }
}