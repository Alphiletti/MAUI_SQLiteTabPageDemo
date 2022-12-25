using SQLiteTabPageDemo.Abstract;
using SQLiteTabPageDemo.Models;

namespace SQLiteTabPageDemo;

public partial class App : Application
{

	public static BaseRepository<StudentModel> studentRepo { get; set; }
	public static BaseRepository<CourseModel> courseRepo { get; set; }
	public static BaseRepository<EnrollModel> enrollRepo { get; set; }
	public App(BaseRepository<StudentModel> student, BaseRepository<CourseModel> course, BaseRepository<EnrollModel> enroll)
	{
		InitializeComponent();
		studentRepo = student;
		courseRepo = course;
		enrollRepo = enroll;
		MainPage = new AppShell();
	}
}
