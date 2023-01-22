namespace App_Signature.Views;

public partial class SignatureView : ContentPage
{
	public SignatureView(SignatureViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        ((BaseViewModel)BindingContext).OnLoaded();
    }
}