﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    [Table("Instructors", Schema = "dbo")]
    internal class Instructor
    {
        #region By Convention 
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Bouns { get; set; }
        //public double Salary { get; set; }
        //public string Adress { get; set; }
        //public double HourRate { get; set; }
        //public int DeptId { get; set; }

        #endregion

        #region By Data Annotation 

        public int InstructorID { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Bouns { get; set; }

        [Column(TypeName ="Money")]
        public double Salary { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]
        public double HourRate { get; set; }

        public int? DepartmentID { get; set; }
        public Department Department { get; set; }

        public ICollection<Course_Inst> CourseInstructors { get; set; }

        #endregion
    }
}
