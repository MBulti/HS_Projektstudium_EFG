using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

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
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

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
        #endregion
        #region Views
        builder.Services.AddTransient<MainView>();
        builder.Services.AddTransient<TripView>();
        builder.Services.AddTransient<SettingsView>();
        #endregion
        #region ViewModels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<TripViewModel>();
        builder.Services.AddTransient<SettingsViewModel>();
        #endregion

        return builder.Build();
	}
}
