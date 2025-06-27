
namespace Domain.Entities
{
    public class Student : Person
    {
        public List<Course> enrolledCourses = new List<Course>();
        public Dictionary<Course, string> grades = new Dictionary<Course, string>();
    }
}
