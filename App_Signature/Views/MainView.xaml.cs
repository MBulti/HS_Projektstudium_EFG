namespace App_Signature.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}