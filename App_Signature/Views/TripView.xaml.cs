namespace App_Signature.Views;

public partial class TripView : ContentPage
{
	public TripView(TripViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        ((BaseViewModel)BindingContext).OnLoaded();
    }
}