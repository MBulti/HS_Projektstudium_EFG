namespace App_Signature.ViewModels
{
    [QueryProperty(nameof(TripModel), ParameterKeys.TRIPMODEL)]
    public partial class TripEventViewModel : BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        TripModel tripModel;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        ImageSource imageStream;
        #endregion

        #region Public
        public override void OnLoaded()
        {
            base.OnLoaded();
            Title = string.Format(AppResources.tripeventview_title, TripModel.TourNo);
        }
        #endregion

        #region Commands
        [RelayCommand]
        async void Sign(SignatureModel signatureModel)
        {
            if (signatureModel != null)
                ImageStream = ImageSource.FromStream(() => signatureModel.Signature);
        }
        #endregion
    }
}
