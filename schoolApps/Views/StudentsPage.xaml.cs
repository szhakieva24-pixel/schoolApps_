using schoolApps.Models;
using schoolApps.ViewModels;

namespace schoolApps.Views;

public partial class StudentsPage : ContentPage
{
    private readonly StudentsViewModel _vm;

    public StudentsPage()
    {
        InitializeComponent();
        _vm = new StudentsViewModel();
        BindingContext = _vm;
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        _vm.AddStudent();
        NewNameEntry.Text = "";
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Student student) return;
        await DisplayAlert("Student", student.Name, "OK");
        StudentsList.SelectedItem = null;
    }
}