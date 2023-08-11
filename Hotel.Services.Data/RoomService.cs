namespace Hotel.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using Hotel.Data;
    using Hotel.Data.Models;
    using Interfaces;
    using Web.ViewModels.Room;

    public class RoomService : IRoomService
    {
        private readonly HotelDbContext dbContext;

        public RoomService(HotelDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(RoomFormModel formModel)
        {
            Room newRoom = new Room
            {
                Number = formModel.Number,
                CategoryId = formModel.CategoryId
            };

            await this.dbContext.Rooms.AddAsync(newRoom);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
