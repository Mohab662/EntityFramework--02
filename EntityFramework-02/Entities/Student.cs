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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

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


        [InverseProperty("Students")]
        public Department Department { get; set; }

        //[InverseProperty("Students")]
        //public ICollection<Stud_Course> Stud_Course { get; set; } = new HashSet<Stud_Course>();


        #endregion


    }

}
