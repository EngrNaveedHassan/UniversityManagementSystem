using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Course
    {
        [Key]
        public required string CourseCode { get; set; }
        public required string CourseName { get; set; }
        public required Subject AssociatedSubject { get; set; }
        public required Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; } = new List<Student>();
        public List<Book> RequiredBooks { get; } = new List<Book>();
    }
}
