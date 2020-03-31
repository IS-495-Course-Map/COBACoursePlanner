using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COBACoursePlanner.Models
{
    public class Major
    {
        [Key]
        public string MajorID { get; set; }

        public string MajorDesc { get; set; }
    }
}
