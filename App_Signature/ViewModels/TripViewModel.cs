namespace App_Signature.ViewModels
{
    public partial class TripViewModel : BaseViewModel
    {
        #region Declarations
        private IDataService dataService;
        #endregion

        #region Properties
        [ObservableProperty]
        string userName;
        #endregion

        #region Public
        public TripViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }

        #endregion

        #region Commands
        [RelayCommand]
        async void Test()
        {
            await Shell.Current.GoToAsync($"{nameof(SettingsView)}");


            //var transValue = AppResources.settingsview_title;
            //var data = await dataService.GetTripData();
            //if (data != null)
            //{

            //}
        }
        #endregion
    }
}
