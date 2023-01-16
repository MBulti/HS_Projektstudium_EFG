using App_Signature.Resources.Languages;
using Newtonsoft.Json;
using System.Globalization;

namespace App_Signature.ViewModels
{
    public partial class SettingsViewModel : BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        string selectedLanguage;
        #endregion

        #region Public
        public SettingsViewModel()
        {
        }
        #endregion

        #region Commands
        [RelayCommand]
        void ChangeLanguageDE()
        {
            SetCulture(new CultureInfo("de-DE"));
        }
        [RelayCommand]
        void ChangeLanguageEN()
        {
            SetCulture(new CultureInfo("en-US"));
        }
        #endregion

        #region Private
        private void SetCulture(CultureInfo culture)
        {
            Resources.SetCulture(culture);
            string value = JsonConvert.SerializeObject(culture);
            Preferences.Set(nameof(GlobalSettings.CultureInfo), value);
        }
        #endregion
    }
}
