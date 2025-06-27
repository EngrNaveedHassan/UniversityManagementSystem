
namespace Domain.Entities
{
    public class Teacher : Person
    {
        public List<Subject> SubjectsTaught = new List<Subject>();
        public List<Course> AssignedCourses = new List<Course>();
    }
}
