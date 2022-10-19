using TaleEngine.App.ViewModels;
using TaleEngine.App.Views;

namespace TaleEngine.App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        // View models
        builder.Services.AddSingleton<TalkViewModel>();

        // Views
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}
