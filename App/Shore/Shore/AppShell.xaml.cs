namespace Shore;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        // Register routes if necessary
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(Calendar), typeof(Calendar));
    }
}
