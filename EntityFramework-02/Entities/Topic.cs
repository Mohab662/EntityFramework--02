using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Entities
{
    [Table("Topics", Schema = "dbo")]
    internal class Topic
    {
        #region By Convention 

        //public int Id { get; set; }
        //public string Name { get; set; }

        #endregion

        #region By Data Annotation 

        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

        #endregion

    }

}
