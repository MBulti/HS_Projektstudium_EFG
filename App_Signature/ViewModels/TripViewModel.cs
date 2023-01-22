namespace App_Signature.ViewModels
{
    public partial class TripViewModel : BaseViewModel
    {
        #region Declarations
        private IDataService dataService;
        #endregion

        #region Properties
        [ObservableProperty]
        List<TripModel> lsTrips;
        #endregion

        #region Public
        public TripViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public override async void OnLoaded()
        {
            base.OnLoaded();
            await RefreshTrips();
        }
        #endregion

        #region Commands
        [RelayCommand]
        async void OpenSettings()
        {
            await Shell.Current.GoToAsync($"{nameof(SettingsView)}");
        }
        [RelayCommand]
        async Task RefreshTrips()
        {
            IsBusy = true;
            var data = await dataService.GetTripData();
            if (data != null)
            {
                LsTrips = data;
                IsBusy = false;
            }
        }
        [RelayCommand]
        async void TripItemTapped(TripModel trip)
        {
            await Shell.Current.GoToAsync($"{nameof(TripEventView)}", true, new Dictionary<string, object>
            {
                { ParameterKeys.TRIPMODEL, trip }
            });
        }
        #endregion
    }
}
