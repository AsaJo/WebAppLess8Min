namespace WebAppLess8Min.Models
{
    public class Student
    {
        public  int Id { get; set; }

        public string? Description { get; set; }
        public string? StudentId { get; set; }
        public string? StudentName { get; set;}
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
