namespace Hotel.Web.ViewModels.Room
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Room;

    using Category;

    public class RoomFormModel
    {
        public RoomFormModel()
        {
            this.Categories = new HashSet<RoomSelectCategoryFormModel>();
        }

        [Required]
        [Range(NumberMinValue, NumberMaxValue)]
        [Phone]
        [Display(Name = "Number")]
        public int Number { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<RoomSelectCategoryFormModel> Categories { get; set; }
    }
}
