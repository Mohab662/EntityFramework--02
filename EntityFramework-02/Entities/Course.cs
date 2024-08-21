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

        #region By Data Annotation And FluentApis

        public int CourseID { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public double Duration { get; set; }

        [StringLength(100,MinimumLength =20)]
        public string Description { get; set; }

        //[InverseProperty("Course")]
        //public ICollection<Stud_Course> Stud_Course { get; set; } = new HashSet<Stud_Course>();


        //public Topic Topic { get; set; }


        //[NotMapped]
        //public int? Top_ID { get; set; }


        public int TopicID { get; set; }
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> StudentCourses { get; set; }
        public ICollection<Course_Inst> CourseInstructors { get; set; }

        #endregion


    }
}
