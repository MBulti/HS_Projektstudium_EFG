using App_Signature.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Signature.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        string userName;
        #endregion

        #region Public
        public MainViewModel()
        {
        }
        #endregion

        #region Commands
        [RelayCommand]
        async void Test()
        {
            await Task.CompletedTask;
        }
        #endregion
    }
}
