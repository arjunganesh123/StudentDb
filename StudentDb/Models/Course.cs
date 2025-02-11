using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDb.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        [Column("CourseName")]
        public string Name { get; set; }

        #region Relationships

            #region 1-M
                public virtual ICollection<Subject> Subjects { get; set; }
            #endregion

            #region M-M
                public virtual ICollection<StudentCourse> StudentCourse { get; set; }
                public virtual ICollection<CourseLecturer> CourseLecturer { get; set; }
            #endregion
        #endregion
    }
}
