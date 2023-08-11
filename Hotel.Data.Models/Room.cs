namespace Hotel.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Room
    {
        public Room()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public int Number { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}