namespace App_Signature.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
		((BaseViewModel)BindingContext).OnLoaded();
    }
}