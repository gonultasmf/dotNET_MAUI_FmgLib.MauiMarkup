﻿namespace MyMauiApp.Pages;

public partial class Ders7 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new ActivityIndicator()
                .IsRunning(true)
                .Color(Red)
                .SizeRequest(100)
                .OnLoaded(async (sender, e) =>
                {
                    var ai = sender as ActivityIndicator;
                    await Task.Delay(4000);
                    ai.IsRunning = false;
                })
            )
        );
    }
}