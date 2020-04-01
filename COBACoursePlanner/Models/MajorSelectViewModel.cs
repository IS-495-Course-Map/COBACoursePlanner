using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COBACoursePlanner.Models
{
    public class MajorSelectViewModel
    {
        public List<Class> ClassesForMajors { get; set; }
        public SelectList Majors { get; set; }
        public string Major { get; set; }
        public string SearchString { get; set; }
    }
}
