using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebScolariteEsprimApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public int xxxx { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "fffff")]
        [Display(Name = "prenom")]
        [Column("dxfdfdfd")]
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}