namespace App_Signature.Views;

public partial class TripView : ContentPage
{
	public TripView(TripViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}