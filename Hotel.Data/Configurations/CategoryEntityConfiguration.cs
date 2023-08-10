namespace Hotel.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Double Room",
                Description = "Modern and stylish design for you",
                Beds = 2,
                Price = 200.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2020/01/15/18/02/room-4768552_1280.jpg"

            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Triple Room",
                Description = "Convenience for all the family",
                Beds = 3,
                Price = 250.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/10/18/12/06/double-bed-994230_1280.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Apartment",
                Description = "Modern design, comfort and convenience",
                Beds = 4,
                Price = 500.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2014/04/26/00/41/dining-room-332207_1280.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Double Room L",
                Description = "Luxury, elegance and comfort",
                Beds = 2,
                Price = 300.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2015/04/11/23/25/bed-718311_1280.jpg"

            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Apartment L",
                Description = "Luxury, elegance and comfort",
                Beds = 4,
                Price = 700.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2014/04/26/00/41/interior-design-332212_1280.jpg"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 6,
                Name = "Apartment Super L",
                Description = "Super luxury, elegance and comfort",
                Beds = 4,
                Price = 1000.00M,
                ImageUrl = "https://cdn.pixabay.com/photo/2016/01/23/23/52/dining-room-1158266_1280.jpg"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}