namespace net8_mauiApp_loginPage.mvvm.views;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs e)
	{
		if(await IsAuthenticated())
		{
            Shell.Current.GoToAsync("//home");
        }
        else
		{
			Shell.Current.GoToAsync("//login");
		}
		base.OnNavigatedTo(e);
	}

	private async Task<bool> IsAuthenticated()
	{
		await Task.Delay(200);
		var haAuth = await SecureStorage.Default.GetAsync("hasAuth");
		//return haAuth != null;
		return true;

	}


}