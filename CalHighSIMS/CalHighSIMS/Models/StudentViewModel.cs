using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalHighSIMS.Models
{
    public class StudentViewModel
    {
        public int id { get; set; }
        public int lrn { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string lname { get; set; }
        public string status { get; set; }
        public string grade_level { get; set; }
    }
}