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


        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        #endregion

    }

}
