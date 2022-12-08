namespace WebAppLess8Min.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }        
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public List<Student> Students { get; set; }=new List<Student>();    


    }
}
