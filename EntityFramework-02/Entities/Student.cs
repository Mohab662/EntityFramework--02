using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    [Table("Students",Schema ="dbo")]
    internal class Student
    {
        #region By Convention 
        //public int Id { get; set; }
        //public string FName { get; set; }
        //public string LName { get; set; }
        //public string Address { get; set; }
        //public int? Age { get; set; }
        //public int DepId { get; set; }

        #endregion

        #region By Data Annotation And FluentApis

        public int StudentID { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(10,MinimumLength =3)]
        public string FName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string LName { get; set; }

        [Required]
        public string Address { get; set; }

        [Range(21,90)]
        public int? Age { get; set; }


        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public ICollection<Stud_Course> StudentCourses { get; set; }




        #endregion


    }

}
