using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDb.Models
{
    public class Subject
    {
        [Key]
        public int SubjectrId { get; set; }
        [Required]
        [StringLength(50)]
        [Column("SubjectName")]
        public string Name { get; set; }

        #region Relationships

            #region 1-1
                public int LecturerId { get; set; }
                public virtual Lecturer Lecturers { get; set; }
            #endregion

            #region 1-M
                public int CourseId { get; set; }
                public virtual Course Course { get; set; }
            #endregion
        #endregion
    }
}
