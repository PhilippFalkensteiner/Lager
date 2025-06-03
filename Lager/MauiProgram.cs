using CommunityToolkit.Maui;
using Lager.Services;
using Lager.ViewModels;
using Lager.Views;
using Microsoft.Extensions.Logging;

namespace Lager;

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
		builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<AddProducts>();
        builder.Services.AddTransient<AddProductViewModel>();
		// Del. Fun.
        builder.Services.AddTransient<DeleteProducts>();
        builder.Services.AddTransient<DeleteProductsViewModel>();
		// Search Fun.
        builder.Services.AddTransient<SearchProducts>();
        builder.Services.AddTransient<SearchProductViewModel>();
		// SQLite
        builder.Services.AddTransient<DbManagerSQLite>(); 
        return builder.Build();
	}
}
