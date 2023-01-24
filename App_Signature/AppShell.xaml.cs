namespace App_Signature;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// general
		Routing.RegisterRoute(nameof(SettingsView), typeof(SettingsView));

		// trip
		Routing.RegisterRoute(nameof(TripEventView), typeof(TripEventView));
    }
}
