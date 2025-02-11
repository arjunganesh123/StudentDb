namespace StudentDb.Models
{
    public class CourseLecturer
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}
