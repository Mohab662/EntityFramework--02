using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    internal class Course_Inst
    {
        #region By Convention 
        //public int Id { get; set; }
        //public int CourseId { get; set; }
        //public int InstructorId { get; set; }
        //public string Evaluate { get; set; }

        #endregion

        #region By Data Annotation 

        [Required]
        public string Evaluate { get; set; }
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        //[InverseProperty("course_Inst")]
        //public ICollection<Instructor> instructor { get; set; } = new HashSet<Instructor>();



        #endregion
    }
}
