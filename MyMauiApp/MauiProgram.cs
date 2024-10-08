using System.Globalization;

using Microsoft.Extensions.Logging;

namespace MyMauiApp;

[MauiMarkup(typeof(CardView), typeof(MyView), typeof(NumericValidationStyleBehavior))]
[MauiMarkupAttachedProp(typeof(AttachedNumericValidationBehavior), "AttachBehaviorProperty", typeof(bool), typeof(BindableObject))]
[MauiMarkupAttachedProp(typeof(NumericValidationStyleBehavior), "AttachBehaviorProperty", typeof(bool), typeof(BindableObject))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        if (!Preferences.Default.ContainsKey("defaultLang"))
            Preferences.Default.Set("defaultLang", CultureInfo.CurrentCulture.Name == "tr-TR" ? "tr-TR" : "en-US");
        //Preferences.Default.Remove("first_name");


        builder
            .UseMauiApp<App>()
            .UseMauiMarkupLocalization(Preferences.Default.Get("defaultLang", string.Empty), "Deneme.json","Localization.json")
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Sevillana-Regular.ttf", "Sevillana");
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>();

        return builder.Build();
    }
}
