using SQLiteTabPageDemo.Models;

namespace SQLiteTabPageDemo;

public partial class StudentPage : ContentPage
{
	public StudentPage()
	{
		InitializeComponent();
        studentListView.ItemsSource = App.studentRepo.GetAll();
	}

    private void AddStudent_Clicked(object sender, EventArgs e)
    {
        App.studentRepo.AddItem(new Models.StudentModel
        {
            StudentName = studentNameEntry.Text,
            StudentDepartment = studentDeptEntry.Text
        });
    }

    private void ShowStudent_Clicked(object sender, EventArgs e)
    {
        studentListView.ItemsSource = null;
        studentListView.ItemsSource = App.studentRepo.GetAll();
    }

    private void DeleteStudent_Clicked(object sender, EventArgs e)
    {
        var delButton = (Button)sender;
        StudentModel holderTest = (StudentModel)delButton.BindingContext;
        App.studentRepo.DeleteItem(holderTest);
        studentListView.ItemsSource = App.studentRepo.GetAll();
    }
}