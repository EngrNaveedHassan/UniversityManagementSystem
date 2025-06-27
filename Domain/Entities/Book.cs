using System.ComponentModel.DataAnnotations;


namespace Domain.Entities
{
    public class Book
    {
        [Key]
        public required string ISBN { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int PublicationYear { get; set; }
    }
}
