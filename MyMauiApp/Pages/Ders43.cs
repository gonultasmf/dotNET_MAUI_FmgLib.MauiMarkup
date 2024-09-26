using System.Diagnostics;

namespace MyMauiApp.Pages;

public class Ders43 : ContentPage, IFmgLibHotReload
{
    public Ders43()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders43")
        .Content(
            new WebView()
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
        );
    }
}