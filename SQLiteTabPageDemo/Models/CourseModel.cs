using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteTabPageDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTabPageDemo.Models
{
    public class CourseModel : TableData
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        [ManyToMany(typeof(StudentModel)), AutoIncrement]
        public int studentId { get; set; }
    }
}
