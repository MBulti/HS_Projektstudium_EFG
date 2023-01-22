using Microsoft.Maui.Platform;
using Newtonsoft.Json;
using System.Globalization;

namespace App_Signature.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        #region Public
        public MainViewModel()
        {
        }
        public override async void OnLoaded()
        {
            base.OnLoaded();
            await Init();
        }
        #endregion

        #region Private
        private async Task Init()
        {
            Application.Current.UserAppTheme = AppTheme.Light;
            #region Setup locale
            var cultureInfo = CultureInfo.CurrentCulture;
            var currentCulture = Preferences.Get(nameof(GlobalSettings.CultureInfo), string.Empty);
            if (!string.IsNullOrWhiteSpace(currentCulture))
                cultureInfo = JsonConvert.DeserializeObject<CultureInfo>(currentCulture);

            Resources.SetCulture(cultureInfo);
            #endregion
            await Task.Delay(500);
            await Shell.Current.GoToAsync($"//{nameof(TripView)}");
        }
        #endregion
    }
}
