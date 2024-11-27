using Microsoft.Extensions.Logging;

namespace MauiPlanets
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Lora-Italic-VariableFont_wght.ttf", "LoraItalic");
                    fonts.AddFont("Lora-VariableFont_wght.ttf", "LoraRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
