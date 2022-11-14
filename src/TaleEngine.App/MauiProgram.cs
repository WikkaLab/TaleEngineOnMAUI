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

		// Services and APIs
		builder.Services.AddSingleton(Connectivity.Current);

		// View models
		builder.Services.AddSingleton<TalkViewModel>();
		builder.Services.AddSingleton<TalkDetailViewModel>();
		builder.Services.AddSingleton<SpeakerViewModel>();
		builder.Services.AddSingleton<RoomViewModel>();
		builder.Services.AddSingleton<OtherViewModel>();

		// Views
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<TalkDetailPage>();
		builder.Services.AddSingleton<SpeakersPage>();
		builder.Services.AddSingleton<RoomsPage>();
		builder.Services.AddSingleton<OthersPage>();

		return builder.Build();
	}
}
