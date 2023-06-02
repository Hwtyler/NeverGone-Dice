namespace NevergoneDice;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Views.SessionsNotes), typeof(Views.SessionsNotes));

    }
}
