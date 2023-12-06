namespace FormSheetSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new ModalNavigationPage(new FormSheetPage()));
	}
}


