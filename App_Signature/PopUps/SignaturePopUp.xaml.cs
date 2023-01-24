using CommunityToolkit.Maui.Core.Views;
using CommunityToolkit.Maui.Views;

namespace App_Signature.PopUps;

public partial class SignaturePopUp : Popup
{
	public SignaturePopUp()
	{
		InitializeComponent();
    }

    #region Events
    private void Popup_Opened(object sender, CommunityToolkit.Maui.Core.PopupOpenedEventArgs e)
    {
        SignatureView.Clear();
        SignatureView.DrawAction = (canvas, rect) =>
        {
            canvas.DrawLine(20, (int)SignatureView.Height - 25, (int)SignatureView.Width - 20, (int)SignatureView.Height - 25);
            canvas.FontSize = 12;
            canvas.DrawString(AppResources.signaturepopup_sign, 0, 0, (int)SignatureView.Width, (int)SignatureView.Height - 10, HorizontalAlignment.Center, VerticalAlignment.Bottom);
        };
    }
    private void CancelSignature_Clicked(object sender, EventArgs e)
    {
        SignatureView.Clear();
        Close(null);
    }
    private void ClearSignature_Clicked(object sender, EventArgs e)
    {
        SignatureView.Clear();
    }
    private async void SaveSignature_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(SignatureEntry.Text) || !SignatureView.Lines.Any())
        {
            EmptySignature.IsVisible = true;
            return;
        }

        EmptySignature.IsVisible = false;
        // fix the scaling
        SignatureView.Lines.Add(new DrawingLine()
        {
            LineWidth = 0,
            LineColor = Color.FromArgb("#ffffff"),
            Points = new System.Collections.ObjectModel.ObservableCollection<PointF>
                {
                    new PointF(0, 0),
                    new PointF((int)SignatureView.Width, 0),
                    new PointF((int)SignatureView.Width, (int)SignatureView.Height),
                    new PointF(0, (int)SignatureView.Height),
                    new PointF(0, 0)
                }
        });
        SignatureModel resultModel = new SignatureModel()
        {
            Name = SignatureEntry.Text.Trim(),
            Signature = await DrawingView.GetImageStream(SignatureView.Lines, new Size(SignatureView.Width, SignatureView.Height), Brush.White)
        };
        Close(resultModel);
    }
    private void Entry_Completed(object sender, EventArgs e)
    {
        SignatureEntry.Unfocus();
        SignatureEntry.IsEnabled = false;
        SignatureEntry.IsEnabled = true;
    }
    #endregion


}