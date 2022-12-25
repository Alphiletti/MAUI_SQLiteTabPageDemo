using SQLite;
using SQLiteTabPageDemo.Abstract;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTabPageDemo.Models
{
    public class StudentModel : TableData
    {
        public string StudentName { get; set; }
        public string StudentDepartment { get; set; }
        [ManyToMany(typeof(CourseModel)), AutoIncrement]
        public int courseId { get; set; }
    }
}
