using schoolApps.Views;

namespace schoolApps;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(StudentsPage), typeof(StudentsPage));
    }
}