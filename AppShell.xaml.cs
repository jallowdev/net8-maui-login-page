using net8_mauiApp_loginPage.mvvm.views;

namespace net8_mauiApp_loginPage;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("login", typeof(LoginPage));
		Routing.RegisterRoute("main", typeof(MainPage));
		Routing.RegisterRoute("home", typeof(HomePage));
		Routing.RegisterRoute("settings", typeof(SettingsPage));
	}
}
