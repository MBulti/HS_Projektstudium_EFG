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
        async void Sign()
        {
            await Shell.Current.GoToAsync($"{nameof(SignatureView)}");
        }
        #endregion
    }
}
