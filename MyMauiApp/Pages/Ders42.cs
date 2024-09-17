using System.Net;

using FmgLib.MauiMarkup;

namespace MyMauiApp.Pages;

public class Ders42 : ContentPage, IFmgLibHotReload
{
    public Ders42()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders42")
        .MenuBarItems(
            new MenuBarItem()
            {
                new MenuFlyoutItem()
                .Text("Test 1")
                .IconImageSource("dotnet_bot.png"),

                new MenuFlyoutItem()
                .Text("Test 2")
                .IconImageSource("dotnet_bot.png")
            }
            .Text("Test"),

            new MenuBarItem()
            {
                new MenuFlyoutItem()
                .Text("Rest 1")
                .IconImageSource("dotnet_bot.png"),

                new MenuFlyoutItem()
                .Text("Rest 2")
                .IconImageSource("dotnet_bot.png")
            }
            .Text("Rest1")
        )
        .Content(
            new WebView()
            .Assign(out WebView webView)
            .Source("https://learn.microsoft.com/dotnet/maui")
            .ContextFlyout(
                new MenuFlyout()
                {
                    new MenuFlyoutItem()
                    .Text("Deneme 1")
                    .CommandParameter("docs")
                    .IconImageSource("dotnet_bot.png")
                    .OnClicked((sender, e) =>
                    {
                        MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
                        string repo = menuItem.CommandParameter as string;
                        string url = repo == "docs" ? "docs-maui" : "maui";
                        webView.Source = new UrlWebViewSource { Url = $"https://github.com/dotnet/{url}" };
                    }),

                    new MenuFlyoutItem()
                    .Text("Deneme 2")
                    .CommandParameter("eng")
                    .OnClicked((sender, e) =>
                    {
                        MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
                        string repo = menuItem.CommandParameter as string;
                        string url = repo == "docs" ? "docs-maui" : "maui";
                        webView.Source = new UrlWebViewSource { Url = $"https://github.com/dotnet/{url}" };
                    })
                }
            )
        );
    }
}