using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COBACoursePlanner.Models
{
    public class ClassForMajor
    {
        [Key]
        public int MajorClassID { get; set; }

        [Display(Name = "Major ID")]
        public string MajorID { get; set; }

        [Display(Name = "Class ID")]
        public string ClassID { get; set; }
    }
}
