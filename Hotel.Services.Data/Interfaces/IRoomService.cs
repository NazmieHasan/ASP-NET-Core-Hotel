namespace Hotel.Services.Data.Interfaces
{
    using Web.ViewModels.Room;

    public interface IRoomService
    {
        Task CreateAsync(RoomFormModel formModel);       
    }
}
