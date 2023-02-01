namespace App_Signature.ViewModels
{
    [QueryProperty(nameof(TripModel), ParameterKeys.TRIPMODEL)]
    public partial class TripEventViewModel : BaseViewModel
    {
        private IDataService dataService;

        #region Properties
        [ObservableProperty]
        TripModel tripModel;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        bool isSignatureEnabled;
        #endregion

        #region Public
        public TripEventViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public override void OnLoaded()
        {
            base.OnLoaded();
            IsSignatureEnabled = true;
            Title = string.Format(AppResources.tripeventview_title, TripModel.TourNo);
        }
        #endregion

        #region Commands
        [RelayCommand]
        async void Sign(SignatureModel signatureModel)
        {
            IsSignatureEnabled = IsBusy = true;
            try
            {
                var isSuccess = await dataService.ExportSignature(tripModel, signatureModel);
                IsBusy = false;
                if (isSuccess)
                    await Shell.Current.GoToAsync($"..");
            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
}
