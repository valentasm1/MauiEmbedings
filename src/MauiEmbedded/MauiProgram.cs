using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Embedding;

namespace MauiEmbedded;

public static class MauiProgram
{
    // Create a MauiApp using the default application.
    public static MauiApp CreateMauiApp(Action<MauiAppBuilder>? additional = null) =>
        CreateMauiApp<App>(additional);

    // Create a MauiApp using the specified application.
    public static MauiApp CreateMauiApp<TApp>(Action<MauiAppBuilder>? additional = null) where TApp : App
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiEmbeddedApp<TApp>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        additional?.Invoke(builder);

        return builder.Build();
    }
}
