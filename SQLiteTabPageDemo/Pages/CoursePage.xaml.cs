using SQLiteTabPageDemo.Models;

namespace SQLiteTabPageDemo;

public partial class CoursePage : ContentPage
{
	public CoursePage()
	{
		InitializeComponent();
        courseListView.ItemsSource = App.courseRepo.GetAll();
	}

    private void AddCourse_Clicked(object sender, EventArgs e)
    {
        App.courseRepo.AddItem(new Models.CourseModel
        {
            CourseCode = courseCodeEntry.Text,
            CourseName = courseNameEntry.Text
        });
    }

    private void ShowCourse_Clicked(object sender, EventArgs e)
    {
        courseListView.ItemsSource = null;
        courseListView.ItemsSource = App.courseRepo.GetAll();
    }

    private void DeleteCourse_Clicked(object sender, EventArgs e)
    {
        var delButton = (Button)sender;
        CourseModel holder = (CourseModel)delButton.BindingContext;
        App.courseRepo.DeleteItem(holder);
        courseListView.ItemsSource = App.courseRepo.GetAll();
    }
}