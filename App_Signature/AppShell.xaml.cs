namespace App_Signature;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SettingsView), typeof(SettingsView));
	}
}
