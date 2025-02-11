using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDb.Models
{
    public class Lecturer
    {
        [Key]
        public int LecturerId { get; set; }
        [Required]
        [StringLength(50)]
        [Column("LecturerName")]
        public string Name { get; set; }

        #region Relationships

            #region 1-1
                public virtual Subject Subjects { get; set; }
            #endregion

            #region 1-M
                public int StudentId { get; set; }
                public virtual Student Student { get; set; }
            #endregion

            #region M-M
                public virtual ICollection<CourseLecturer> CourseLecturer { get; set; }
            #endregion
        #endregion
    }
}
