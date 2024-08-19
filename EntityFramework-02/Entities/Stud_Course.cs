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

        #region By Data Annotation 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        [Required]
        public double Grade { get; set; }


        #endregion

    }

}
