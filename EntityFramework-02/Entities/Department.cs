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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }

        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        [InverseProperty("Department")]
        public ICollection<Instructor> Instructor { get; set; } = new HashSet<Instructor>();



        #endregion


    }
}
