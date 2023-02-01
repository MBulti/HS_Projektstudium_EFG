using App_Signature.PopUps;
using CommunityToolkit.Maui.Views;

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

    // currently the popups are only supported in MVC style ...
    private async void Sign_Clicked(object sender, EventArgs e)
    {
        var result = await this.ShowPopupAsync(new SignaturePopUp()) as SignatureModel;
        if (result != null) 
        {
            var tripEventViewModel = BindingContext as TripEventViewModel;
            if (tripEventViewModel == null)
                return;

            tripEventViewModel.SignCommand.Execute(result);
        }
    }
}