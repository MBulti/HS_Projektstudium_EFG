namespace App_Signature.ViewModels.Base
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool isBusy;

        protected LocalizationResourceManager Resources => LocalizationResourceManager.Instance;
        public BaseViewModel()
        {

        }
        public async virtual void OnLoaded()
        {
        }
        public async virtual void OnAppearing()
        {

        }
    }
}
