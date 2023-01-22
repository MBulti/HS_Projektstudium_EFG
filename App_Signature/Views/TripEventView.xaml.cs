namespace App_Signature.Views;

public partial class TripEventView : ContentPage
{
	public TripEventView(TripEventViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        ((BaseViewModel)BindingContext).OnLoaded();
    }
}