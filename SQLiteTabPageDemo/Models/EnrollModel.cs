using SQLiteNetExtensions.Attributes;
using SQLiteTabPageDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTabPageDemo.Models
{
    public class EnrollModel : TableData
    {
        public string StudentName { get; set; }
        public string StudentDept { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
    }
}
