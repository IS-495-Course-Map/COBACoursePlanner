using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COBACoursePlanner.Models
{
    public class Class
    {
        [Key]
        public string ClassID { get; set; }
        public string ClassDesc { get; set; }
        public string ReqFilled { get; set; }
        public string SecReqFilled { get; set; }
        public string TertReqFilled { get; set; }
    }
}
