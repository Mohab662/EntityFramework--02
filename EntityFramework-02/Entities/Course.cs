using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    [Table("Courses", Schema = "dbo")]
    internal class Course
    {
        #region By Convention 
        //public int Id { get; set; }
        //public double Duration { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public int TopId { get; set; }
        #endregion

        #region By Data Annotation 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public double Duration { get; set; }

        [StringLength(100,MinimumLength =20)]
        public string Description { get; set; }

        #endregion


    }
}
