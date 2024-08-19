using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    internal class Stud_Course
    {
        #region By Convention 
        //public int Id { get; set; }
        //public int StudentId { get; set; }
        //public int CourseId { get; set; }
        //public double Grade { get; set; }

        #endregion

        #region By Data Annotation And FluentApis


        [Required]
        public double Grade { get; set; }

        //[InverseProperty("Stud_Course")]
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        //[InverseProperty("Stud_Course")]
        //public ICollection<Course> Course { get; set; } = new HashSet<Course>();

        #endregion

    }

}
