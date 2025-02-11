namespace StudentDb.Models
{
    public class CourseLecturer
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }
    }
}
