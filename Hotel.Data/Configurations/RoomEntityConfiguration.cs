namespace Hotel.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class RoomEntityConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder
                .HasOne(r => r.Category)
                .WithMany(c => c.Rooms)
                .HasForeignKey(r => r.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateRooms());

        }

        private Room[] GenerateRooms()
        {
            ICollection<Room> rooms = new HashSet<Room>();

            Room room;

            room = new Room()
            {
                Number = 201,
                CategoryId = 1
               
            };
            rooms.Add(room);

            room = new Room()
            {
                Number = 202,
                CategoryId = 1

            };
            rooms.Add(room);

            room = new Room()
            {
                Number = 203,
                CategoryId = 1

            };
            rooms.Add(room);

            room = new Room()
            {
                Number = 204,
                CategoryId = 1

            };
            rooms.Add(room);

            room = new Room()
            {
                Number = 205,
                CategoryId = 1

            };
            rooms.Add(room);

            return rooms.ToArray();
        }
    }
}
