namespace App_Signature.ViewModels
{
    public partial class TripViewModel : BaseViewModel
    {
        #region Declarations
        private IDataService dataService;
        private List<TripModel> lsAllTrips = new();
        #endregion

        #region Properties
        [ObservableProperty]
        List<TripModel> lsTrips;

        [ObservableProperty]
        string filter;
        #endregion

        #region Public
        public TripViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
        // we already reload the data in the "OnAppearing"
        //public override async void OnLoaded()
        //{
        //    base.OnLoaded();
        //    await RefreshTrips();
        //}
        public override async void OnAppearing()
        {
            IsBusy = false;
            await RefreshTrips();
            base.OnAppearing();
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
                lsAllTrips = data;
                IsBusy = false;
            }
            FilterChanged();
        }
        [RelayCommand]
        async void TripItemTapped(TripModel trip)
        {
            IsBusy = true;
            await Shell.Current.GoToAsync($"{nameof(TripEventView)}", true, new Dictionary<string, object>
            {
                { ParameterKeys.TRIPMODEL, trip }
            });
        }
        [RelayCommand]
        void FilterChanged()
        {
            if (!string.IsNullOrWhiteSpace(filter))
                LsTrips = lsAllTrips.Where(bu => bu.TourNo.ToString().StartsWith(filter)).ToList();
            else
                LsTrips = lsAllTrips;
        }
        #endregion
    }
}
