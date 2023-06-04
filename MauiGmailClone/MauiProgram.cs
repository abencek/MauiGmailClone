using MauiGmailClone.Services;
using MauiGmailClone.ViewModels;
using MauiGmailClone.Views;
using Microsoft.Extensions.Logging;

#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

namespace MauiGmailClone;

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
                fonts.AddFont("MaterialIconsOutlined-Regular.otf", "MIOutlined");
                fonts.AddFont("MaterialIconsSharp-Regular.otf", "MIFilled");
            });

        builder.Services.AddSingleton<EmailService>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<TODOViewModel>();
        builder.Services.AddSingleton<DetailsViewModel>();
        builder.Services.AddTransient<NewViewModel>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<TODOPage>();
        builder.Services.AddSingleton<DetailsPage>();
        builder.Services.AddTransient<NewPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        //MAPPERS
        //Mapper for Button control - this will change button text alignment to left
        Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping("ContentAlignmentToLeft", (h, v) =>
        {
#if ANDROID
			h.PlatformView.TextAlignment = Android.Views.TextAlignment.TextStart;
#elif WINDOWS
            h.PlatformView.HorizontalContentAlignment = Microsoft.UI.Xaml.HorizontalAlignment.Left;
#endif
        });

        //Mapper for Entry control - this will remove default control borders
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderLine", (h, v) =>
        {
#if ANDROID
            h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif WINDOWS
            h.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
#endif
        });

        //Mapper for Editor control - this will remove default control borders
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("NoUnderLine", (h, v) =>
        {
#if ANDROID
            h.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif WINDOWS
            h.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0);
#endif
        });


		return builder.Build();

	}
}
