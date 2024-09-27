using System.Diagnostics;

using FmgLib.MauiMarkup;

namespace MyMauiApp.Pages;

public class Ders43 : ContentPage, IFmgLibHotReload
{
    public Ders43()
    {
        this.InitializeHotReload();
    }
    WebView webView;
    public void Build()
    {
        this
        .Title("Ders43")
        .Content(
            new WebView()
                .Assign(out webView)
                .Source("https://learn.microsoft.com/dotnet/maui")
                .OnNavigated((sender, e) =>
                {
                    Debug.WriteLine(e.Result.ToString());
                })
                .OnNavigating((sender, e) =>
                {
                    Debug.WriteLine(e.Url.ToString());
                    if (e.Url == "https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-8.0")
                    {
                        e.Cancel = true;
                    }
                })
                .ContextFlyout(new MenuFlyout()
                {
                    new MenuFlyoutItem()
                    .Text("Go to docs repo")
                    .CommandParameter("docs")
                    .OnClicked(OnWebViewGoToRepoClicked),

                    new MenuFlyoutItem()
                    .Text("Go to engineering repo")
                    .CommandParameter("eng")
                    .OnClicked(OnWebViewGoToRepoClicked)
                })
        );
    }
    void OnWebViewGoToRepoClicked(object sender, EventArgs e)
    {
        MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
        string repo = menuItem.CommandParameter as string;
        string url = repo == "docs" ? "docs-maui" : "maui";
        webView.Source = new UrlWebViewSource { Url = $"https://github.com/dotnet/{url}" };
    }
}