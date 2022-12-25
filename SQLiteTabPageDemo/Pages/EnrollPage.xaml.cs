using SQLiteTabPageDemo.Models;

namespace SQLiteTabPageDemo;

public partial class EnrollPage : ContentPage
{
    List<EnrollModel> enrollList = new List<EnrollModel>();
    StudentModel stModel;
    CourseModel csModel;

	public EnrollPage()
	{
		InitializeComponent();
        studentListView.ItemsSource = App.studentRepo.GetAll();
        courseListView.ItemsSource = App.courseRepo.GetAll();
        enrollListView.ItemsSource = enrollList;
    }

    private void Enroll_Clicked(object sender, EventArgs e)
    {
        if (stModel != null || csModel != null)
        {
            App.enrollRepo.AddItem(new EnrollModel()
            {
                StudentName = stModel.StudentName,
                StudentDept = stModel.StudentDepartment,
                CourseCode = csModel.CourseCode,
                CourseName = csModel.CourseName
            });
        }
        else DisplayAlert("Error", "Please select a row from list(s)","OK");
        enrollListView.ItemsSource = App.enrollRepo.GetAll();
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        studentListView.ItemsSource = App.studentRepo.GetAll();
        courseListView.ItemsSource = App.courseRepo.GetAll();
        enrollListView.ItemsSource = App.enrollRepo.GetAll();
    }

    private void courseListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        csModel = (CourseModel)e.Item;
    }

    private void studentListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        stModel = (StudentModel)e.Item;
    }
}