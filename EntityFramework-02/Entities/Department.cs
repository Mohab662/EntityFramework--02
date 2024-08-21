using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    [Table("Department", Schema = "dbo")]
    internal class Department
    {
        #region By Convention 
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public DateTime HiringDate { get; set; }
        //public int InsId { get; set; }

        #endregion

        #region By Data Annotation And FluentApis

  
        public int DepartmentID { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }

        public int? InstructorID { get; set; }
        public Instructor Instructor { get; set; }

        public ICollection<Student> Students { get; set; }




        #endregion


    }
}
