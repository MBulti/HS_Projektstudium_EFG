using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using PdfSharpCore.Fonts;

namespace App_Signature;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Montserrat-Regular.ttf", "MontserratRegular");
			});
        GlobalFontSettings.FontResolver = new CustomFontResolver();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        #region Services
        if (App.GlobalSettings.IsMock)
        {
            builder.Services.AddSingleton<IDataService, MockDataService>();
        }
        else
        {
            builder.Services.AddSingleton<IDataService, DataService>();
        }
        builder.Services.AddSingleton<IPDFService, PDFService>();
        #endregion
        #region Views
        builder.Services.AddTransient<MainView>();
        builder.Services.AddTransient<SettingsView>();
        builder.Services.AddTransient<TripView>();
        builder.Services.AddTransient<TripEventView>();
        #endregion
        #region ViewModels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<SettingsViewModel>();
        builder.Services.AddTransient<TripViewModel>();
        builder.Services.AddTransient<TripEventViewModel>();
        #endregion

        return builder.Build();
	}
}
