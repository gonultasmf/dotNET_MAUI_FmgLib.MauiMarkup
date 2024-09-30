﻿using Microsoft.Extensions.Logging;

namespace MyMauiApp;

[MauiMarkup(typeof(CardView), typeof(MyView), typeof(NumericValidationStyleBehavior))]
[MauiMarkupAttachedProp(typeof(AttachedNumericValidationBehavior), "AttachBehaviorProperty", typeof(bool), typeof(BindableObject))]
[MauiMarkupAttachedProp(typeof(NumericValidationStyleBehavior), "AttachBehaviorProperty", typeof(bool), typeof(BindableObject))]
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
                fonts.AddFont("Sevillana-Regular.ttf", "Sevillana");
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>();

        return builder.Build();
    }
}
