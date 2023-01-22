using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using Size = Microsoft.Maui.Graphics.Size;

namespace App_Signature.ViewModels
{
    public partial class SignatureViewModel : BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        string title;
        [ObservableProperty]
        ObservableCollection<IDrawingLine> lines = new();
        #endregion

        #region Public
        public override void OnLoaded()
        {
            base.OnLoaded();
            Title = string.Format(AppResources.tripeventview_title, 1234);
        }
        #endregion

        #region Commands
        [RelayCommand]
        void ClearSignature()
        {
            Lines.Clear();
        }
        [RelayCommand]
        async void SaveSignature()
        {
            if (!Lines.Any())
                return;
            var image = await DrawingView.GetImageStream(Lines, new Size(500, 200), Colors.White);
        }
        #endregion
    }
}
