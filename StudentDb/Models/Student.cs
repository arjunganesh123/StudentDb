﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDb.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("StudentName")]
        public string Name { get; set; }
        [MaxLength(2)]
        public int age { get; set; }
        public DateTime DOB { get; set; }
        public string Hobby { get; set; }
        public virtual Address Address { get; set; }

        #region Relationships

            #region 1-M
                public virtual ICollection<Lecturer> Lecturers { get; set; }
            #endregion

            #region M-M
                public virtual ICollection<StudentCourse> StudentCourse { get; set; }
            #endregion
        #endregion
    }
}
