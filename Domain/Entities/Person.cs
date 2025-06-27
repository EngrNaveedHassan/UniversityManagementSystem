using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Person
    {
        [Key]
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string ContactInfo { get; set; }

    }
}
