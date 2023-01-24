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

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        TripFilter.IsEnabled = false;
        TripFilter.IsEnabled = true;
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        ((BaseViewModel)BindingContext).OnAppearing();
    }
}