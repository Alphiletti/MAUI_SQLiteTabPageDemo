using Microsoft.Extensions.Logging;
using SQLiteTabPageDemo.Abstract;
using SQLiteTabPageDemo.Models;

namespace SQLiteTabPageDemo;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<BaseRepository<StudentModel>>();
		builder.Services.AddSingleton<BaseRepository<CourseModel>>();
		builder.Services.AddSingleton<BaseRepository<EnrollModel>>();
		return builder.Build();
	}
}
